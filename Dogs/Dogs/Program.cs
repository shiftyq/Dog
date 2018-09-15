using System;

namespace Dogs
{
    public class Dog


    {
        public string name;
        public string owner;
        public int age;
        enum Gender
        {
            Male,
            Female
        }
        public int Bark(int times)
        {

            Console.WriteLine("Woof");
            return 0;
        }
        public bool GetTag()
        {
            Console.WriteLine("If lost, call [owner]. ['Her'|'His'] name is [name] and ['she'|'he'] is [age] ['year'|'years'] old.");
            return true;
        }

        class MainClass
    {
        public static void Main(string[] args)
        {
            Dog puppy = Dog("Onion", "Bill", 1, Gender.Male);
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag());
        }
    }
    
            
        
        }   


        }

    

