using ExeciseOop.Dal;
using ExeciseOop.ExtentionMethod;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

DalProduct pro = new();
pro.ChangColor(ConsoleColor.Black, ConsoleColor.Yellow);
pro.AddProduct();
