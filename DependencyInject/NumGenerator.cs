namespace DependencyInject
{
    public class NumGenerator : INumGenerator
    {
        public int GetNumber()
        {
            return new Random().Next(100);
        }
    }

    public interface INumGenerator
    {
        public int GetNumber();
    }

}
