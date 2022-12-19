using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPolymorphismInterface;
internal class FileTwo :  IBinaryFile, ITextFile
{
    //không dùng bồ từ
    void IBinaryFile.ReadFile() => Console.WriteLine("read binary file");

    void ITextFile.ReadFile() => Console.WriteLine("read text file");

    //buộc phải dùng
    public void WriteBinaryFile() => Console.WriteLine("write binary file");

    public void WriteTextFile() => Console.WriteLine("write text file");
}
