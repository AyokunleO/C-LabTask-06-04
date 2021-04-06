namespace Question2
{
    public class Student : Person
    {
        public Student(string name) :base(name)
        {
            
        }

        public string Study ()
        {
            return $"Student {Name} is studying";
        }
    }
}