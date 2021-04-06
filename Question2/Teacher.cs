using System;
namespace Question2
{
    public class Teacher : Person
    {
        public Teacher(string name) :base(name)
        {
            
        }
        public string Explain ()
        {
            return $"Teacher {Name} is explaining";
        }
    }
}