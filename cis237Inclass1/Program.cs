using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Aa", "Aaa", 20);
            Person personB = new Person("Bb", "Bbb", 300);
            Person personC = new Person("Cc", "Ccc", 5);

            person.PrintFullName();
            personB.PrintFullName();
            personC.PrintFullName();

            PersonCollection personCollection = new PersonCollection();

            personCollection.addPerson(person);
            personCollection.addPerson(new Person("Not", "Declared First", 34));

            Console.WriteLine(personCollection.getPersonCollectionToString());
        }
    }
}
