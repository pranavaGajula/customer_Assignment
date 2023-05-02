using customer_assignment;
using System.Net.Mail;
using System.Runtime.CompilerServices;

namespace customer_assignment
{
    class customer
    {
        public int Id { get; set; }
        public string F_Name { get; set; }
        public string L_Name { get; set; }

        public string Mail { get; set; }

        public int Age { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }

    }
    class Management
    {
        List<customer> customers;
        public int id = 1;
        public Management()
        {  
        
            customers = new List<customer>()
            {
            new customer{Id=id++,F_Name="John",L_Name="Roy",Mail="jr@hmail.com",Age=20,Phone="1234567890",City="kerala" },
            new customer { Id = id ++, F_Name = "John", L_Name = "Roy", Mail = "jr@hmail.com", Age = 20, Phone = "1234567890", City = "Banglore" },
            };

        }



        public void Addcustomer()
        {
            Console.WriteLine("Enter customer details:");
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Mail: ");
            string mail = Console.ReadLine();
            Console.Write("Age : ");
            int age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Phone number: ");
            string phone = Console.ReadLine();
            Console.Write("City: ");
            string city = Console.ReadLine();
            int id1 = id++;
            customers.Add(new customer()
            {
                Id = id1,
                F_Name = firstName,
                L_Name = lastName,
                Mail = mail,
                Age = age,
                Phone = phone,
                City = city,
            });
            if (phone.Length != 10 || phone.StartsWith("0"))
            {
                Console.WriteLine("Invalid phone number. Please enter a 10-digit number ");
                phone = Console.ReadLine();
            }
        }
        public customer GetCustomer(int id)
        {
            foreach (customer customer in customers)
            {
                if (customer.Id == id)
                    return customer;
            }
            return null;

        }

        public List<customer> GetCustomers()
        {
            return customers;
        }
        public bool DeleteCustomer(int id)
        {
            foreach (customer c in customers)
            {
                if (c.Id == id)
                {
                    customers.Remove(c);
                    return true;
                }
            }
            return false;
        }
        public void updatecustomeer(int id1)
        {
            foreach(customer c in customers)
            {
                if (c.Id == id1)
                {
                    Console.WriteLine("enter updated customer first name");
                    c.L_Name = Console.ReadLine();
                    Console.Write("Enter updated customer Last name: ");
                    c.L_Name  = Console.ReadLine();
                    Console.Write("Enter updated Mail: ");
                    c.Mail = Console.ReadLine();
                    Console.Write("Enter updated Age : ");
                    c. Age = Convert.ToInt16(Console.ReadLine());
                    Console.Write("Enter updated Phone number: ");
                    c.Phone = Console.ReadLine();
                    Console.Write("Enter updated City: ");
                    c.City = Console.ReadLine();
                }
            }
        }

    }
}

    internal class Program
    {
        static void Main(string[] args)
        {
        Management obj = new Management();
        string ans = "";
        do
        {
            Console.WriteLine("Welcome to Customer Management App");
            Console.WriteLine("1. Add Customer");
            Console.WriteLine("2. Get Customer By Id");
            Console.WriteLine("3. Get All Customers");
            Console.WriteLine("4. Delete Customer  By Id");
            Console.WriteLine("5. Update Customer  By Id");
            Console.WriteLine("Select any one option");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        obj.Addcustomer();
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Customer Id");
                        int id = Convert.ToInt16(Console.ReadLine());
                        customer c = obj.GetCustomer(id);
                        if (c == null)
                        {
                            Console.WriteLine("Product with specified id does not exists");
                        }
                        else
                        {
                            Console.WriteLine($"{c.Id} {c.F_Name} {c.L_Name} {c.Mail} {c.Age}{c.Phone}{c.City}");
                        }
                        break;
                    }
                case 3:
                    {
                        foreach (var c in obj.GetCustomers())
                        {
                            Console.WriteLine($"Id:{c.Id}\tFirst Name: {c.F_Name}\t Last Name: {c.L_Name}\t Mail: {c.Mail}\t Age: {c.Age}\t Phone: {c.Phone}\t City: {c.City}");
                        }
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter Customer Id");
                        int id = Convert.ToInt16(Console.ReadLine());
                        if (obj.DeleteCustomer(id))
                        {
                            Console.WriteLine("Customer Deleted Successfully");
                        }
                        else
                        {
                            Console.WriteLine("Customer with specified id does not exist");
                        }
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Enter customer Id");
                        int id1 = Convert.ToInt16(Console.ReadLine());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;
                    }
             
            }

            Console.WriteLine("Do you wish to continue? [y/n] ");
            ans = Console.ReadLine();
        } while (ans.ToLower() == "y");


    }
        
    
}
