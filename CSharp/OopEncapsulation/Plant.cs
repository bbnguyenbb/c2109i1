namespace OopEncapsulation;

public class Plant
{
    //encapsulation thể hiện ở 2 chỗ
    //a) access modify b) property
    //a) access modify
    private            void Private()           => Console.WriteLine("Private");
    protected          void Protected()         => Console.WriteLine("protected");
    internal           void Internal()          => Console.WriteLine("internal");
    private protected  void PrivateProtected()  => Console.WriteLine("private protected");
    protected internal void ProtectedInternal() => Console.WriteLine("protected internal");
    public             void Public()            => Console.WriteLine("public");
}
