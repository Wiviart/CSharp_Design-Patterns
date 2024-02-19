var exp1 = new NumberExpression(2);
var exp2 = new NumberExpression(3);
var adEx = new AdditionExpression(exp1, exp2);
double i = adEx.Evaluate();
Console.WriteLine(i);
