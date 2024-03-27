namespace BuilderPattern
{

    internal class Program
    {
        // out param: out parameter where actual value gets changed and " the time of declaration intialization is not required but before leaving scope
        // value should get initialized 
        static void Main(string[] args)
        {
            string DataType = "XXX";
            var test = DataType switch
            {
                "JsOn" => "VILASJSON",
                "xml" => "VILASXMl",
                _ => "Nothing"
            };

            // remove duplicate values from array
            int[] numbers = [1, 2, 1, 4, 5];

            // Using lambda operator to print array numbers
            Array.ForEach(numbers.Distinct().ToArray(), num => Console.WriteLine($"Distinct Numbers are =>{num} "));


            List<Employee> lstEmp1 = [new Employee { Id = 1, Name = "vilas" }, new Employee { Id = 2, Name = "Suhas" }];
            List<Employee> lstEmp2 = [new Employee { Id = 1, Name = "Advait" }, new Employee { Id = 3, Name = "Swanand" }];

            //var result = from emp1 in lstEmp1 join emp2 in lstEmp2 on emp1.Id equals emp2.Id select emp1 ;

            var result = from emp1 in lstEmp1
                         join emp2 in lstEmp2 on emp1.Id equals emp2.Id
                         select emp1;


            foreach (Employee emp in result)
            {
                Console.WriteLine(emp.Name);
            }


            // Combine the two lists using LINQ Concat method
            List<Employee> combinedList = lstEmp1.Concat(lstEmp2).ToList();

            // Print the combined list
            Console.WriteLine("Combined List:");
            foreach (Employee emp in combinedList)
            {
                Console.WriteLine(emp.Name);
            }
            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }


}
