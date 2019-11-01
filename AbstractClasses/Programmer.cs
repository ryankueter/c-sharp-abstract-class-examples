/*
 * Author: Ryan Kueter
 * Copyright 2019 Ryan Kueter.
 */

namespace AbstractClasses
{
    public class Programmer : Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public Programmer() : base() { }

        public Programmer(string firstName, string lastName, int age) : base()
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public override string GetAge()
        {
            return age.ToString();
        }
    }
}
