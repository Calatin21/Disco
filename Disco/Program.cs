namespace Disco {
    internal class Program {
        static void Main(string[] args) {
            Person p1 = new ();
            Person p2 = new ();
            Person p3 = new ();
            Disco disco = new Disco();
            disco.NimmAuf(p1);
            disco.NimmAuf(p2);
            disco.NimmAuf(p3);
            disco.GetFirstItem().Tanzen();
            disco.GetFirstItem().Laecheln();
            Console.WriteLine(disco.GehRaus().GetHashCode() + " hat Disco verlassen.");
            disco.GetFirstItem().Tanzen();
            disco.GetFirstItem().Laecheln();
            Console.WriteLine(disco.GehRaus().GetHashCode() + " hat Disco verlassen.");
            disco.GetFirstItem().Tanzen();
            disco.GetFirstItem().Laecheln();
            Console.WriteLine(disco.GehRaus().GetHashCode()+" hat Disco verlassen.");
        }
    }
}