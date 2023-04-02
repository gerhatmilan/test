namespace Test
{
    internal class Program
    {
        internal class Human
        {
            private String _name;
            private Int32 _age;

            public Human(String name, Int32 age)
            {
                _name = name;
                _age = age;
            }

            public void PrintHuman()
            {
                Console.WriteLine($"Name: {0}\nAge: {1}", _name, _age);
            }

            public void IncreaseAge()
            {
                _age++;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}