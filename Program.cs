using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypesAndValueTypesExercise2
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
                               // number is equal to 1, because the variable has been sent
                               // to Increment() method
                               // 
                               // number variable from scope of method Main() and Increment()
                               // occupy different places in memory
                               //
                               //when the Increment() method is called a new location is created
                               //called 'number', it's value incremented by 10 and then it's
                               //immediately destroyed

            Console.WriteLine(number);


            var person = new Person() { Age = 20 };
            // both person from Main() and MakeOld() points to the same object on the
            // heap
            MakeOld(person);
            Console.WriteLine(person.Age);
            
        }
        public static void Increment(int number) 
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
