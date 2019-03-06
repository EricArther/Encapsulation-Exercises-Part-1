using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int employeesNumber = 1;
            List<Employee> employees = new List<Employee> { };
            bool bTemp = false;
            Int64 iTemp = 0;

            for (int i = 0; i < employeesNumber; i++)
            {
                employees.Add(new Employee());
                Console.WriteLine($"enter the detail of employee {i + 1}");
                Console.WriteLine();

                //bTemp = false;
                //do
                //{
                    Console.Write($"{"full name: ",28}");
                employees[i].FullName = Console.ReadLine();
                //if(employees[i].FullName != "")
                //    {
                //        bTemp = true;
                //    }
                //    else
                //    {
                //        Console.WriteLine("invalid. please try again.");
                //        Console.WriteLine();
                //    }
                //} while (bTemp == false);

                bTemp = false;
                do
                {
                    Console.Write($"{"phone number: ",28}");
                    //employees[i].PhoneNumber = Console.ReadLine();
                    bool parse = Int64.TryParse(Console.ReadLine(), out iTemp);
                    if (parse)
                    {
                        employees[i].PhoneNumber = iTemp.ToString();
                        bTemp = true;
                    }
                    else
                    {
                        Console.WriteLine("invalid. please try again.");
                        Console.WriteLine();
                    }
                } while (bTemp == false);

                Console.Write($"{"email address: ",28}");
                employees[i].EmailAddress = Console.ReadLine();

                bTemp = false;
                do
                {
                    Console.Write($"{"IRD number: ",28}");
                    //employees[i].IrdNumber = Console.ReadLine();
                    bool parse = Int64.TryParse(Console.ReadLine(), out iTemp);
                    if (parse && iTemp.ToString().Length >=8 && iTemp.ToString().Length <=9)
                    {
                        employees[i].IrdNumber = iTemp.ToString();
                        bTemp = true;
                    }
                    else
                    {
                        Console.WriteLine("invalid. please try again.");
                        Console.WriteLine();
                    }
                } while (bTemp == false);

                bTemp = false;
                do
                {
                    Console.Write($"{"bank account number: ",28}");
                    //employees[i].BankAccountNumber = Console.ReadLine();
                    bool parse = Int64.TryParse(Console.ReadLine(), out iTemp);
                    if (parse && iTemp.ToString().Length == 16)
                    {
                        employees[i].BankAccountNumber = $"{ iTemp:##-####-#######-###}".ToString();
                        bTemp = true;
                    }
                    else
                    {
                        Console.WriteLine("invalid. please try again.");
                        Console.WriteLine(iTemp);
                    }
                } while (bTemp == false);

                Console.Write($"{"computer system username: ",28}");
                employees[i].ComputerSystemUsername = Console.ReadLine();

                Console.Write($"{"computer system password: ",28}");
                employees[i].ComputerSystemPassword = Console.ReadLine();

                Console.Clear();
            }

            foreach (Employee e in employees)
            {
                e.Display();
            }

            Console.ReadKey();
        }

        class Employee
        {
            string fullName;
            string phoneNumber;
            string emailAddress;
            string irdNumber;
            string bankAccountNumber;
            string computerSystemUsername;
            string computerSystemPassword;

            public string FullName { get { return fullName; } set { fullName = value; } }
            public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
            public string EmailAddress { get { return emailAddress; } set { emailAddress = value; } }
            public string IrdNumber { private get { return irdNumber; } set { irdNumber = value; } }
            public string BankAccountNumber { private get { return bankAccountNumber; } set { bankAccountNumber = value; } }
            public string ComputerSystemUsername { get { return computerSystemUsername; } set { computerSystemUsername = value; } }
            public string ComputerSystemPassword { get { return computerSystemPassword; } set { computerSystemPassword = value; } }

            public void Display()
            {
                Console.WriteLine();
                Console.WriteLine($"{"full name: ",28}{FullName}");
                Console.WriteLine($"{"phone number: ",28}{PhoneNumber}");
                Console.WriteLine($"{"email address: ",28}{EmailAddress}");
                Console.WriteLine($"{"IRD number: ",28}{IrdNumber}");
                Console.WriteLine($"{"bank account number: ",28}{BankAccountNumber}");
                Console.WriteLine($"{"computer system username: ",28}{ComputerSystemUsername}");
                Console.WriteLine($"{"computer system password: ",28}{ComputerSystemPassword}");
            }
        }
    }
}
