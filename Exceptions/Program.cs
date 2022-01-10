using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Dog dog = new Dog("Azorel", 50);
                //Dog dog = new Dog("A", 5);
                //Dog dog = new Dog("Azorel", -1);
                //Dog dog = new Dog("Azorel", 101);
            }
            catch (InvalidNameLengthException inv)
            {
                Console.WriteLine(inv.Message);
            }
            catch (NegativeAgeException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (AgeTooBigException atb)
            {
                Console.WriteLine(atb.Message);
            }
        }
    }
}
