

using ExeciseOop.ExtentionMethod;

namespace ExeciseOop.Dal;
internal class DalProduct : IProduct
{
    public List<Product> ListPro { get; set; } = new();

    public void AddProduct()
    {
        Console.WriteLine(" enter the number of product");
        var n = Validate<int>.CheckReadLine();

        for (int i = 0; i < n; i++)
        {
            //var     pro = new Product();
            Product pro = new();
            Console.WriteLine($"product[{i+1}]=> entere id product: ");
            pro.Proid = Validate<string>.CheckReadLine();

            //
            ListPro.Add(pro);
        }

    }
}
