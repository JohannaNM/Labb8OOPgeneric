using System.IO;

namespace Labb8OOPgeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating employees
            Employee E1 = new Employee()
            {
                ID = 101,
                Name = "Johanna",
                Gender = "Female",
                Salary = 20000
            };
            Employee E2 = new Employee()
            {
                ID = 102,
                Name = "Andreas",
                Gender = "Male",
                Salary = 25000
            };
            Employee E3 = new Employee()
            {
                ID = 103,
                Name = "Leon",
                Gender = "Male",
                Salary = 40000
            };
            Employee E4 = new Employee()
            {
                ID = 104,
                Name = "Nadine",
                Gender = "Female",
                Salary = 30000
            };
            Employee E5 = new Employee()
            {
                ID = 105,
                Name = "Axel",
                Gender = "Male",
                Salary = 0
            };
            //Adding empoyees to stack
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            Console.WriteLine("*********Stack Elements*********");
            Console.WriteLine("");
            //print all employees in stack to console
            foreach (Employee emp in stack)
            {
                Console.WriteLine($"{emp.ID} - {emp.Name} - {emp.Gender} - {emp.Salary}");
                Console.WriteLine($"Number of Elements in Stack: " + stack.Count);
            }
            
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("*******Retrive Using POP()*******");
            // retriving stack elements, (deletes from stack when retrived)
            Employee stackEmp = stack.Pop();
            Console.WriteLine($"{stackEmp.ID} - {stackEmp.Name} - {stackEmp.Gender} - {stackEmp.Salary}");
            Console.WriteLine($"Number of Elements left in Stack: " + stack.Count);

            Employee stackEmp2 = stack.Pop();
            Console.WriteLine($"{stackEmp2.ID} - {stackEmp2.Name} - {stackEmp2.Gender} - {stackEmp2.Salary}");
            Console.WriteLine($"Number of Elements left in Stack: " + stack.Count);

            Employee stackEmp3 = stack.Pop();
            Console.WriteLine($"{stackEmp3.ID} - {stackEmp3.Name} - {stackEmp3.Gender} - {stackEmp3.Salary}");
            Console.WriteLine($"Number of Elements left in Stack: " + stack.Count);

            Employee stackEmp4 = stack.Pop();
            Console.WriteLine($"{stackEmp4.ID} - {stackEmp4.Name} - {stackEmp4.Gender} - {stackEmp4.Salary}");
            Console.WriteLine($"Number of Elements left in Stack: " + stack.Count);

            Employee stackEmp5 = stack.Pop();
            Console.WriteLine($"{stackEmp5.ID} - {stackEmp5.Name} - {stackEmp5.Gender} - {stackEmp5.Salary}");
            Console.WriteLine($"Number of Elements left in Stack: " + stack.Count);
            // Readding employees to stack
            stack.Push(E1);
            stack.Push(E2);
            stack.Push(E3);
            stack.Push(E4);
            stack.Push(E5);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("*******Retrive Using Peek()*******");
            Console.WriteLine($"Number of Elements in Stack: " + stack.Count);
            // Peek at stack elements (element remains in stack)
            Employee e1 = stack.Peek();
            Console.WriteLine($"{e1.ID} - {e1.Name} - {e1.Gender} - {e1.Salary}");
            Console.WriteLine($"Number of Elements left in Stack: " + stack.Count);

            Employee e2 = stack.Peek();
            Console.WriteLine($"{e2.ID} - {e2.Name} - {e2.Gender} - {e2.Salary}");
            Console.WriteLine($"Number of Elements left in Stack: " + stack.Count);
            Console.WriteLine("-------------------------------------");
            // Checking if stack contains a specific object
            if (stack.Contains(E3))
            {
                Console.WriteLine("E3 is in stack");
            }
            else
            {
                Console.WriteLine("E3 is not in stack");
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(" \n ");

            Console.WriteLine("************List Objects*************");
            Console.WriteLine("");
            //Creating list of employees
            List<Employee> employees = new List<Employee>();
            //Adding employees to list
            employees.Add(E1);
            employees.Add(E2);
            employees.Add(E3);
            employees.Add(E4);
            employees.Add(E5);

            Console.WriteLine("**********Using Contains()***********");
            // Checking if list contains a specific object
            if (employees.Contains(E1))
            {
                Console.WriteLine("E1 object exists in the list");
            }
            else
            {
                Console.WriteLine("E2 object does not exsist in the list");
            }
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("************Using Find()*************");
            // Returns first matching employee with Gender = male 
            Employee? emp1 = employees.Find(employee => employee.Gender == "Male");
            Console.WriteLine($"ID = {emp1?.ID}, Name = {emp1?.Name}, Gender = {emp1?.Gender}, Salary = {emp1?.Salary}" );
            Console.WriteLine("-------------------------------------");
           
            Console.WriteLine("**********Using FindAll()************");
            //Retrives all male employees from list and creates a new list containing the male employees
            List<Employee> maleEmployees = employees.FindAll(employee => employee.Gender == "Male");
            foreach (Employee memp in maleEmployees)
            {
                Console.WriteLine($"ID = {memp.ID}, Name = {memp.Name}, Gender = {memp.Gender}, Salary = {memp.Salary}");
            }
            Console.WriteLine("-------------------------------------");

        }
    }
}