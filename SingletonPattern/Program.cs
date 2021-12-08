// See https://aka.ms/new-console-template for more information
using SingletonPattern;

Console.WriteLine("Hello, World!");

Parallel.Invoke(
    () => PrintCustomerDetails(),
    () => PrintStudentDetails()
    );

//Person.Employee employee = new Person.Employee();
//employee.PrintDetails("Hello, I'm an employee");


static void PrintCustomerDetails()
{
    Person customer = Person.GetInstance();
    customer.PrintDetails("Hello, I'm a customer");
}

static void PrintStudentDetails()
{
    Person student = Person.GetInstance();
    student.PrintDetails("Hello, I'm a student");

}