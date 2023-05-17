namespace DependencyInject
{
    public class NumGenerator
    {
        public int GetNumber()
        {
            return new Random().Next(100);
        }
    }
}
