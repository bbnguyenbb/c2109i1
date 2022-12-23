using System.Transactions;
using GenericClass;

ClassOne<int> one = new ClassOne<int>();
one.Field = 10;
one.Show(); 

ClassTwo<string, int> tow = new();
tow.Field1 ="nguyen";
tow.Field2 = 10;
tow.Show();


ClassTwo<int, double> t = new();
t.Field1= 10;
t.Field2 = 10.5;
t.Show();