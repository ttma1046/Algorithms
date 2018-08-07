using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Csharp.hashtable
{
    class Hashtable
    {
        LinkedList<LinkedListItem>[] data;

        
        bool put(String key, Person value)
        {
            int hashcode = getHashCode(key);
            int index = convertToIndex(hashCode);
            LinkedList<LinkedListItem> list = data[index];
            list.AddLast(new LinkedListItem { Key = key, Person = value});
            return true;
        }
        
    }

    class LinkedListItem
    {
        public string Key { get; set; }

        public Person Person { get; set; }
    }

    class Person
    {
        public string Name { get; set; }
    }
}
