using RefOut;
using System.Text;

Console.InputEncoding  = Encoding.Unicode;
Console.OutputEncoding = Encoding.Unicode;

int a;
int b;
UseRefOut.ChangeNumber(out a, out b);
Console.WriteLine($"Program : {nameof(a)}={a}, {nameof(b)}={b}");
