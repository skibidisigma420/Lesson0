using Lesson0.validators;
using System;

namespace Lesson0
{
    /// <summary>
    /// class Person contains information about a person (height, weight, date of birth, etc)
    /// </summary>
    class Person
    {
        public Person(
            int height, 
            int weight, 
            DateTime birthday, 
            string firstname, 
            string lastname)
        {
            if (!intValidator.Validate(Height))
                throw new ArgumentOutOfRangeException("");
            if (!intValidator.Validate(Weight))
                throw new ArgumentOutOfRangeException("");
            if (!stringValidator.Validate(FirstName))
                throw new ArgumentException("");
            if (!stringValidator.Validate(LastName))
                throw new ArgumentException("");
            Height = height;
            Weight = weight;
            BirthDay = birthday;
            FirstName = firstname;
            LastName = lastname;
        }

        public int Height { get; private set; }

        public int Weight { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public DateTime BirthDay { get; }

        public string FullName
        {
            get { return FirstName + " " + LastName }
        }

        public int Age
        {
            get
            {
                return (DateTime.Now - BirthDay).Days/365;
            }
        }

        public bool ChangeHeight (int Height)
        {
            bool flag = intValidator.Validate(Height);
            if (flag)
                this.Height = Height;
            return flag;
        }

    }
}
