using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    class PersonCollection
    {
        #region Variables

        Person[] personArray;
        int lengthOfArrayInt;

        #endregion


        #region Constructor

        public PersonCollection()
        {
            personArray = new Person[4000];
            lengthOfArrayInt = 0;
        }

        #endregion



        #region Properties

        #endregion



        #region Methods

        public void addPerson(Person person)
        {
            personArray[lengthOfArrayInt] = person;
            lengthOfArrayInt++;
        }

        public string getPersonCollectionToString()
        {
            string outputString = "";

            foreach (Person person in personArray)
            {
                if (person != null)
                {
                    outputString += person.ToString() + Environment.NewLine;
                }
            }

            return outputString;
        }

        #endregion
    }
}
