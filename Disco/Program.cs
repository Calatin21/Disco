namespace Disco {
    internal class Program {
        static void Main(string[] args) {
            Person p1 = new Person("Person 1");
            Person p2 = new Person("Perosn 2");
            Person p3 = new Person("Person 3");
            Disco disco = new Disco();
            disco.NimmAuf(p1);
            disco.NimmAuf(p2);
            disco.NimmAuf(p3);
            disco.GetFirstItem().Tanzen();
            disco.GetFirstItem().Laecheln();
            Console.WriteLine(disco.GehRaus().GetName() + " hat Disco verlassen.");
            disco.GetFirstItem().Tanzen();
            disco.GetFirstItem().Laecheln();
            Console.WriteLine(disco.GehRaus().GetName() + " hat Disco verlassen.");
            disco.GetFirstItem().Tanzen();
            disco.GetFirstItem().Laecheln();
            Console.WriteLine(disco.GehRaus().GetName()+" hat Disco verlassen.");
        }
    }
}