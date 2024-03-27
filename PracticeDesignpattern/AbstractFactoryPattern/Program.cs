namespace AbstractFactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    #region ProductA

    public interface IProductA
    {
        void Operation();
    }
    public class ConcreteProductA1 : IProductA
    {
        public void Operation()
        {
            Console.WriteLine("Operation A1 implementation");
        }
    }

    public class ConcreteProductA2 : IProductA
    {
        public void Operation()
        {
            Console.WriteLine("Operation A2 implementation");
        }
    }
    #endregion A

    #region Product B
    public interface IProductB
    {
        void Operation();
    }
    public class ConcreteProductB1 : IProductB
    {
        public void Operation()
        {
            Console.WriteLine("Operation B1 implementation");
        }
    }

    public class ConcreteProductB2 : IProductB
    {
        public void Operation()
        {
            Console.WriteLine("Operation B2 implementation");
        }
    }

    #endregion B

    #region AbstractFactory Interface and Classes

    public interface IAbstractFactory
    {
        public IProductA CreateProductA();
        public IProductB CreateProductB();
    }

    public class ConcreteFactoryA : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            throw new NotImplementedException();
        }

        public IProductB CreateProductB()
        {
            throw new NotImplementedException();
        }
    }


    #endregion


}
