using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237Inclass1
{
    /// <summary>
    /// Creates and controls new Person object.
    /// </summary>
    class Person
    {
        #region Variables

        string firstNameString;
        string lastNameString;
        int ageInt;

        #endregion



        #region Constructor

        /// <summary>
        /// Base Constructor.
        /// </summary>
        public Person()
        {

        }
        
        /// <summary>
        /// Load Person Constructor.
        /// </summary>
        /// <param name="firstName">First Name</param>
        /// <param name="lastName">Last Name</param>
        /// <param name="age">Current Age</param>
        public Person(string firstName, string lastName, int age)
        {
            this.firstNameString = firstName;
            this.lastNameString = lastName;
            this.ageInt = age;
        }

        #endregion



        #region Properties

        public string FirstName
        {
            get
            {
                return this.firstNameString;
            }

            set
            {
                this.FirstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastNameString;
            }

            set
            {
                this.lastNameString = value;
            }
        }

        public int Age
        {
            get
            {
                return this.ageInt;
            }

            set
            {
                this.Age = value;
            }
        }

        #endregion



        #region Methods

        /// <summary>
        /// Method to print person's full name.
        /// </summary>
        public void PrintFullName()
        {
            Console.WriteLine(this.firstNameString + " " + this.lastNameString);
        }

        public override string ToString()
        {
            return this.firstNameString + " " + this.lastNameString;
        }

        #endregion

    }
}
