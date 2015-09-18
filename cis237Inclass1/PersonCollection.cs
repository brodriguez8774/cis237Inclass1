using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    /// <summary>
    /// Creates Collection to hold multiple Person Objects.
    /// </summary>
    class PersonCollection
    {
        #region Variables

        Person[] personArray;
        int lengthOfArrayInt;

        #endregion



        #region Constructor

        /// <summary>
        /// Base Constructor. Creates initial array.
        /// </summary>
        public PersonCollection()
        {
            personArray = new Person[4000];
            lengthOfArrayInt = 0;
        }

        #endregion



        #region Properties

        #endregion



        #region Methods

        /// <summary>
        /// Adds new Person Object to Collection.
        /// </summary>
        /// <param name="person">The Person Object to add.</param>
        public void AddPerson(Person person)
        {
            personArray[lengthOfArrayInt] = person;
            lengthOfArrayInt++;
        }

        /// <summary>
        /// Displays contents of array in a string.
        /// </summary>
        /// <returns>String of array contents.</returns>
        public string GetPersonCollectionToString()
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
