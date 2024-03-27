namespace BuilderPattern
{
    internal class PassByValues
    {
        // In pass by value : Actual value never changed where in Pass by ref actual value gets changed
        static void Main2(string[] args)
        {
            int x = 5, y = 6;

            PassByValue(x, y);

            Console.WriteLine($"value of number X => {x} and Y => {y} ");
            Console.ReadLine();
        }

        private static void PassByValue(int x, int y)
        {
            x = 100;
            y = 200;
        }
    }
}
