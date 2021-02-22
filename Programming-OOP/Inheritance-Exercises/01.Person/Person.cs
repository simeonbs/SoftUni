using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    public class Person
    {
        private string name;
        private int age; //fields

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        } //ctor

        public string Name 
        {
            get 
            {
                return this.name;
            }
            set 
            {
                if (value.Length > 3)
                {
                    this.name = value;
                }
            } 
        } //prop name

        public virtual int Age 
        {
            get
            {
                return this.age;
            }
            protected set 
            {
                if (value > 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Invalid age");
                }
            }
        } // prop age

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                                 this.Name,
                                 this.Age));

            return stringBuilder.ToString();
        }

    }
}
