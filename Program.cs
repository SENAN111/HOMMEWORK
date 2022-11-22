using homework_.Models;
using System.Security.Cryptography;

namespace homework_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Animal animal = new Animal();
            Dog dog =new Dog("ferid ","huski","erekek");
            
            

            Console.WriteLine($"Name:{dog.Name} \n Gender:{dog.Gender} \n birth year:{dog.BirthYear} \n dog breed:{dog.Breed}");
              

                
            

        }
    }
}