namespace Adapter
{
    public class Teenager
    {
        public int Age { get; private set; }

        public Teenager(int age)
        {
            Age = age;
        }

        public bool IsAdult()
        {
            return Age >= 18; 
        }
    }
}
