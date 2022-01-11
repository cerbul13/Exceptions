using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class Dog
    {
        private string name;
        private int age;
        public string Name
        {
            get 
            {
                return this.name;
            }
            set
            {
                if (value.Length<2)
                {
                    throw new InvalidNameLengthException();
                } else
                {
                    this.name = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0)
                {
                    throw new NegativeAgeException();
                }                
                else
                {
                    if (value>100)
                    {
                        throw new AgeTooBigException();
                    } else
                    {
                        this.age = value;
                    }

                }
            }
        }
        public Dog(string name, int age)
        {
            try
            {
                this.Name = name;
            }
            catch(InvalidNameLengthException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                this.Age = age;
            }
            catch(NegativeAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(AgeTooBigException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
