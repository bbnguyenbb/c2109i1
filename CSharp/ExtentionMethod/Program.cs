using System.Text;
using ExtentionMethod;

Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

Console.WriteLine("vui lòng nhập 1 số: ");
int i = int.TryParse(Console.ReadLine(), out var result)?result:0;

//làm kiểm tra xem biến i có lớn hơn 100 không?
CheckNumber.Check(i, 100);
i.IsGreaterThan(100);

int abc = 500;
abc.IsGreaterThan(200);

//extention method
//không thông qua đối tượng của class đang chứa
//mà thông qua cái muốn sử dụng


Program pro = new();
pro.Hi();