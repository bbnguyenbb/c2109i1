namespace OopEncapsulationProperty;

internal class HumanBeing
{
    //fields các field phải là private
    private string fullname;

    //thuộc tính address theo c# mới
    public string Address { private get; set; }
    public int    Age     { get; set; }

    //property theo c# cũ (viết theo dạng mobile)
    public string FullName
    {
        set => fullname = value; 
        //get => fullname;
    }

    public void ShowProper()
    {
        Console.WriteLine($"{nameof(Address)}={Address}");
        Console.WriteLine($"{nameof(fullname)}={fullname}");
    }
}
