using FigureAreaCalculator;
using FigureAreaCalculator.DomainServices;
using FigureCalculateDemoApp.Domains;
using FigureCalculateDemoApp.Strategies;

/// Регистрация новой стратегии, созданной клиентом.
var registry = new AreaCalculatorStrategyRegistry();
registry.Register(new SquareAreaCalculatorStrategy());

var areaCalculator = new AreaCalculatorStrategy<Square>(registry);
var circle = new Square(5);
Console.WriteLine(areaCalculator.GetArea(circle));