/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */

namespace AbstractClasses
{
    // An abstract class is a template and you cannot create an instance of an abstract class.
    // Since the abstract method does not contain an implementation,
    // it does not have a method block.
    public abstract class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        public abstract string GetAge();

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
