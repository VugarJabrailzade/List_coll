using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace TaskList
{
    
    class Person 
    {
        public string Name { get; set; }
        public string  Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "Vugar",
                Surname = "Jabrailzade",
                Age = 25
            };
            var person2 = new Person()
            {
                Name = "Azad",
                Surname = "Ibrahimlli",
                Age = 31
            };
            var person3 = new Person()
            {
                Name = "Ruslan",
                Surname = "Aliyev",
                Age = 20
            };
            var person4 = new Person()
            {
                Name = "Huseyn",
                Surname = "Farzali",
                Age = 19
            };
            var person5 = new Person()
            {
                Name = "Murad",
                Surname = "Aliyev",
                Age = 16
            };
            var person6 = new Person()
            {
                Name = "Narmin",
                Surname = "Akbarova",
                Age = 20
            };
            var person7 = new Person()
            {
                Name = "Asgar",
                Surname = "Madadli",
                Age = 16
            };
            var person8 = new Person()
            {
                Name = "Firangiz",
                Surname = "Rustamli",
                Age = 20
            };
            var person9 = new Person()
            {
                Name = "Ali",
                Surname = "Salmanov",
                Age = 20
            };
            var person10 = new Person()
            {
                Name = "Fatima",
                Surname = "Gadirova",
                Age = 20
            };

            var list = new List<Person>();
            list.Add(person);
            list.Add(person2);
            list.Add(person3);
            list.Add(person4);
            list.Add(person5);
            list.Add(person6);
            list.Add(person7);
            list.Add(person8);
            list.Add(person9);
            list.Add(person10);

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}


            Console.WriteLine("\nPlease add Name for search:");
            string input = Console.ReadLine();
            var result = list.Find(x => x.Name == input);

            if (result == null )
            {
                Console.WriteLine("Not Found");
            }
            else
            {
                Console.WriteLine("Found");
            }

            

        }
    }


}