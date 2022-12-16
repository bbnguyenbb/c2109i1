
using OopEncapsulation;

namespace OopEncapsulationCont;

internal class Weed : Plant
{
    static void Main(string[] args)
    {
        Weed w = new();
        w.Protected();
        w.ProtectedInternal();
        //w.PrivateProtected();
    }
}
