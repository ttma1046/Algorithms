using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Csharp.hashtable
{
    class Hashtable
    {
        LinkedList<Item>[] data = new LinkedList<Item>[100];

        public static void Main(string[] args)
        {
            var hash = new Hashtable();
            hash.put("tom", new Person() { Name = "tom", Age = 14, Address = "Rockdale" });
            hash.put("tom", new Person() { Name = "tom", Age = 15, Address = "Test" });
            hash.put("omt", new Person() { Name = "omt", Age = 16, Address = "Test" });
            hash.put("mot", new Person() { Name = "mot", Age = 17, Address = "Test" });
            hash.put("tmo", new Person() { Name = "tmo", Age = 18, Address = "Test" });
            hash.put("chandler", new Person() { Name = "Chandler", Age = 15, Address = "Test" });

            var person = hash.get("tom");
            Console.WriteLine($"{person.Name}, {person.Age}, {person.Address}");
            person = hash.get("omt");
            Console.WriteLine($"{person.Name}, {person.Age}, {person.Address}");
            person = hash.get("mot");
            Console.WriteLine($"{person.Name}, {person.Age}, {person.Address}");

            person = hash.get("tmo");
            Console.WriteLine($"{person.Name}, {person.Age}, {person.Address}");

            person = hash.get("bdb");
            if (person == null)
            {
                Console.WriteLine("nothing");
            }
            else
            {
                Console.WriteLine($"{person.Name}, {person.Age}, {person.Address}");
            }

            person = hash.get("chandler");
            Console.WriteLine($"{person.Name}, {person.Age}, {person.Address}");
        }

        public bool put(string key, Person person)
        {
            long hashcode = getHashCode(key);
            int index = convertToIndex(hashcode);
            LinkedList<Item> list = data[index];

            if (list == null)
            {
                list = new LinkedList<Item>();
                data[index] = list;
            } else {
                LinkedListNode<Item> item = list.First;

                while (item != null)
                {
                    if (item.Value.Key == key)
                    {
                        item.Value.Person = person;
                        return true;
                    }

                    item = item.Next;
                }
            }

            list.AddLast(new Item { Key = key, Person = person});
            return true;
        }

        public Person get(string key)
        {
            long hashcode = getHashCode(key);
            int index = convertToIndex(hashcode);
            LinkedList<Item> list = data[index];

            if (list != null)
            {
                LinkedListNode<Item> item = list.First;

                while (item != null)
                {
                    if (item.Value.Key == key)
                    {
                        return item.Value.Person;
                    }

                    item = item.Next;
                }
            }

            return null;
        }

        private int convertToIndex(long hashCode)
        {
            return (int)hashCode % data.Length;
        }

        private long getHashCode(string key)
        {
            long hashCode = 0;
            for (int i = 0;i < key.Length; i++)
            {
                char c = key[i];
                int offset = 'a';
                int code = c - offset;
                hashCode += code;
            }

            return hashCode;
        }
    }

    class Item
    {
        public string Key { get; set; }

        public Person Person { get; set; }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set; }
    }
}

