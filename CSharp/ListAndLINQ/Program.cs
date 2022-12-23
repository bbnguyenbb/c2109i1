


Console.OutputEncoding = Encoding.Unicode;
Console.InputEncoding = Encoding.Unicode;

List<Student> list = new()
{
    new Student() {RollNumber = 1, FullName = "khắc nguyên", Section = "dãy số 1", HostelNumber = 1},
    new Student() {RollNumber = 2, FullName = "nghĩa", Section = "dãy số 1", HostelNumber = 2},
    new Student() {RollNumber = 3, FullName = "phú", Section = "dãy số 1", HostelNumber = 3},
    new Student() {RollNumber = 4, FullName = "khánh", Section = "dãy số 2", HostelNumber = 4},
    new Student() {RollNumber = 5, FullName = "lợi", Section = "dãy số 2", HostelNumber = 5},
    new Student() {RollNumber = 6, FullName = "hùng", Section = "dãy số 2", HostelNumber = 6},
    new Student() {RollNumber = 7, FullName = "vinh", Section = "dãy số 3", HostelNumber = 1},
    new Student() {RollNumber = 8, FullName = "thảo", Section = "dãy số 3", HostelNumber = 2},
    new Student() {RollNumber = 9, FullName = "tín", Section = "dãy số 3", HostelNumber = 3},
    new Student() {RollNumber = 10, FullName = "quân", Section = "dãy số 4", HostelNumber = 4}
};

//Stopwatch sw = new Stopwatch();
//sw.Restart();
//foreach (var stu in list)
//{
//    Console.WriteLine(stu);
//}

//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

//tất cả các dạng của collection đều có mẫu để duyệt qua dữ liệu
//mà không dùng for hay foreach => ienumarator
//IEnumerator enu = list.GetEnumerator();
//while (enu.MoveNext())
//{
//    Console.WriteLine(enu.Current);
//}
//Console.WriteLine($"foreach time: {sw.ElapsedMilliseconds}");
//sw.Restart();

//linq => language Intergrated query

//linq to object
//linq to sql
//linq to xml, json
//parallel linq => plinq


//linq to object có 2 dạng
// style 1) theo trường phái sql   => query syntax, dễ học, dễ hiểu
// style 2) theo trường phái lamda => method syntax, khó học, rất khó hiểu

//liệt kê tất cả sinh viên với mã sinh viên phải lớn hơn 2
//foreach (var stu in list)
//{
//    if (stu.RollNumber > 2)
//    {
//        Console.WriteLine(stu);
//    }
//}

//Console.WriteLine("=====================");
//linq to object style 1
//var liststu = from t in list
//    where t.RollNumber > 2
//    select t;

//foreach (var st in liststu)
//{
//    Console.WriteLine(st);
//}

//linq to object style 1 rút gọn
//foreach (var st in from t in list 
//         where t.RollNumber > 2
//         select t)
//{
//    Console.WriteLine(st);
//}

//linq to object style 2
//var listst = list.Select(stu=>stu).Where(stu=>stu.RollNumber >2);
//var liststu = list.Where(stu=>stu.RollNumber>2);
//foreach (var st in liststu)
//{
//    Console.WriteLine(st);
//}

//linq to object style 2 rút gọn
//foreach (var st in list.Where(stu => stu.RollNumber > 2))
//{
//    Console.WriteLine(st);
//}

//các phương thức có sẵn trong list
//list.ForEach(Console.WriteLine);
//list.ForEach(stu => Console.WriteLine(stu));

//list.ForEach(
//        stu =>
//        {
//            if (stu.RollNumber > 2)
//            {
//                Console.WriteLine(stu);
//            }
//        }
//);
//kết hợp lambda với phương thức có sẵn của list
//list.Where(stu => stu.RollNumber > 2)
//    .ToList()
//    .ForEach(Console.WriteLine);


//var r = from stu in list
//        where stu.RollNumber>2
//        select new //anonymous type 
//        {
//            stu.RollNumber, 
//            stu.FullName
//        };

//r.ToList().ForEach(Console.WriteLine);

//var r = from stu in list
//        where stu.RollNumber > 2
//        select new //anonymous type 
//        {
//            StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
//            StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
//        };

//r.ToList().ForEach(Console.WriteLine);

//list.Select(stu => new
//{
//    StudentDetail = $"{stu.RollNumber} : {stu.FullName}",
//    StudentRoom = $"{stu.Section} = {stu.HostelNumber}"
//}).ToList().ForEach(Console.WriteLine);


//foreach (var stu in list)
//{
//    Console.WriteLine(stu);
//}


//IEnumerator enu = list.GetEnumerator();
//while (enu.MoveNext())
//{

//}

//từ khi có linq

//var t = from stu in list
//        select stu;
//lần đầu tiên thực thi trên server và trả về bộ nhớ.

//select * from list where rollnumber >2
//IEnumerable<Student> i = from stu in list
//                        where stu.RollNumber>2
//                         select stu;

//là vào bộ nhó loại bỏ chỉ lấy 2 dòng đầu tiên
//i = i.Take(2);
//=======================
//lần đầu tiên thực thi trên server và trả về bộ nhớ.
//select * from list where rollnumber >2
//IQueryable<Student> u = from stu in list.AsQueryable()
//                        where stu.RollNumber >2
//                        select stu;
//select top(2) * from list where rollnumber >2
//sẽ chạy lên server lần nữa
//u = u.Take(2);
//=====================
//var k = from stu in list
//    where stu.RollNumber > 2
//    select stu;

//k.ToList().ForEach(Console.WriteLine);

//sắp xếp


var obj1 = from stu in list
            where stu.RollNumber > 5
           orderby stu.Section descending, stu.HostelNumber ascending 
           select stu;

//var obj2 = list.OrderByDescending(stu=>stu.Section)
//            .OrderBy(stu=>stu.HostelNumber);

var obj3 = list.Where(stu=>stu.RollNumber >5)
                .OrderByDescending(stu=>stu.Section)
                .ThenBy(stu=>stu.HostelNumber);