namespace SimpleFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct objFact = SimpleFactory.CreateProduct("A");
            objFact.Operation();

            Console.ReadLine();
        }
    }

    public interface IProduct
    {
        void Operation();
    }

    public class ConcreteProductA : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation A implementation");
        }
    }

    public class ConcreteProductB : IProduct
    {
        public void Operation()
        {
            Console.WriteLine("Operation B implementation");
        }
    }

    /// <summary>
    /// Simple factory Violet OCP , because if new type come, we have to do changes in factory which is not cumbersome 
    /// </summary>
    public  class SimpleFactory
    {
        public static IProduct CreateProduct(string productType)
        {
            switch (productType)
            {
                case "A": 
                    return new ConcreteProductA();
                case "B":
                    return new ConcreteProductB();
                default:
                    throw new Exception("No Product Implemeneted");
            }
        }
    }
}
