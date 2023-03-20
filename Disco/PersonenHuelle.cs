namespace Disco {
    internal class PersonenHuelle {
        Person p;
        public PersonenHuelle(Person p) {
            this.p = p;
        }
        public void Tanzen() {
            Console.WriteLine($"{p.GetName()} tanzt");
        }
        public void Laecheln() {
            Console.WriteLine($"{p.GetName()} laechelt");
        }
        public Person GetPerson() {
            return p;
        }
    }
}
