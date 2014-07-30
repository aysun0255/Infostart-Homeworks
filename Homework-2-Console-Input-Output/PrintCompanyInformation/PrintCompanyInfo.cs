using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * Problem 2. Print Company Information
 * A company has name, address, phone 
 * number, fax number, web site and 
 * manager. The manager has first name, 
 * last name, age and a phone number. 
 * Write a program that reads the information 
 * about a company and its manager and 
 * prints it back on the console
 */

class PrintCompanyInfo
{
    static void Main()
    {
        //Read the information about company and it's manager
        Console.Write("Enter Company name:");
        string companyName = Console.ReadLine();
        Console.Write("Enter Company adress:");
        string companyAdress = Console.ReadLine();
        Console.Write("Enter Company phone number:");
        string companyPhoneNumber = Console.ReadLine();
        Console.Write("Enter Company fax number:");
        string companyFaxNumber = Console.ReadLine();
        Console.Write("Enter Company website:");
        string companyWebsite = Console.ReadLine();
        Console.Write("Enter Company manager's first name:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter Company manager's last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter Company manager's age:");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Enter Company manager's phone number:");
        string managerPhoneNumber = Console.ReadLine();

        //Print the information
        Console.WriteLine("Company name:{0}",companyName);
        Console.WriteLine("Company adress:{0}", companyAdress);
        Console.WriteLine("Company phone number:{0}", companyPhoneNumber);
        Console.WriteLine("Company fax number:{0}", companyFaxNumber);
        Console.WriteLine("Company website:{0}", companyWebsite);
        Console.WriteLine("Manager :{0} {1}", managerFirstName,managerLastName);
        Console.WriteLine("Manager phone number:{0}", managerPhoneNumber);
        Console.WriteLine("Manager age:{0}", managerAge);

    }
}

