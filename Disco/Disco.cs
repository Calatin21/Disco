namespace Disco {
    internal class Disco {
        List<PersonenHuelle> ph = new List<PersonenHuelle>();
        public void NimmAuf(Person p) {
            PersonenHuelle ph1 = new PersonenHuelle(p);
            ph.Add(ph1);
            Console.WriteLine($"{p.GetName()} hat Disco betreten");
        }
        public Person GehRaus() {
            Person p = ph.First().GetPerson();
            ph.Remove(ph.First());
            return p;
        }
        public PersonenHuelle GetFirstItem() {
            return ph.First();
        }
    }
}
