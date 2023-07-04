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
            BankAccount balance = new BankAccount(100);
            try
            {
                balance.Withdraw(200);
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }

        }

    }
}