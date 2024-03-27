namespace BuilderPattern
{
    internal class TestOutparameter
    {
        // out param: out parameter where actual value gets changed and " the time of declaration intialization is not required but before leaving scope
        // value should get initialized 
        static void Main4(string[] args)
        {
            int x = 5, y;

            TestOutPatram(out x, out y);

            Console.WriteLine($"value of number X => {x} and Y => {y} ");
            Console.ReadLine();
        }

        private static void TestOutPatram(out int x, out int y)
        {
            x = 100;
            y = 200;
        }
    }
}
