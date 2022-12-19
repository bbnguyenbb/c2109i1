using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal interface IBinaryFile
{
    //có kiểu trả về và tên phương thức nhưng ko có bổ từ
    void WriteBinaryFile();
    void ReadFile();

    //phương thức mặc định của interface
    void ShowInfo() => Console.WriteLine("this is binary file");
}
