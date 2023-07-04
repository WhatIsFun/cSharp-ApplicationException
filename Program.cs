namespace cSharp_ApplicationException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Example
            //Student[] students =
            //{
            //    new Student("Adhary","1233", 19),
            //    new Student("Mohd", "1234", 24),
            //    new Student("Ahmed","1233", 50)

            //};
            //Console.WriteLine(Student.validateStudents(students));

            // Task 1: 
            //BankAccount balance = new BankAccount(100);
            //try
            //{
            //    balance.Withdraw(200);
            //}
            //catch (InsufficientFundsException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Task 2: Write a program that contains multiple methods.
            //In one method, throw an exception.
            //Call that method from another method and catch the exception.
            //Display a message indicating that the exception was caught and handled

            try
            {
                Method1();
            }
            catch (Exception e)
            {
                Console.WriteLine("The exception caught and handled " + e.Message);
            }


            //Task 3:
            
            Console.WriteLine("Enter file path>> ");
            string filePath = Console.ReadLine();
            try
            {
                using (StreamReader sR = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sR.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("File not found in this path. " + e.Message);
            }
            finally
            {
                Console.WriteLine("File read completed. ");
            }

        }
        public static void Method1()
        {
            throw new Exception("Exception Method1");
        }


        
    }
}