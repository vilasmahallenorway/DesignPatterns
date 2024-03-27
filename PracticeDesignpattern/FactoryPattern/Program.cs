namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factory objFactory = new ConcreteFactoryA();
            objFactory.CreateProduct();

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

    public abstract class Factory
    {
        public abstract IProduct CreateProduct();
    }
    
    public class ConcreteFactoryA : Factory
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductA();
        }
    }
    
    public class ConcreteFactoryB : Factory
    {
        public override IProduct CreateProduct()
        {
            return new ConcreteProductB();
        }
    }
}
