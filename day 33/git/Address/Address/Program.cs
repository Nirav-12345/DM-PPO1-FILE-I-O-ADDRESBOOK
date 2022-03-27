using System;

namespace Address;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Addres Book");

        address employee = new address();

        AddressModel repo = new AddressModel();

        employee.EmpId = 1;
        employee.Address = "Gopal nagar";
        employee.empFirstName = "Nirav";
        employee.empLastName = "Raj";
        employee.city = "Asansol";
        employee.state = "Bengal";
        employee.Zip = "713340";
        employee.email = "niravpandit0002";

        repo.AddEmployee(employee);
    }
}