using System;

namespace SplittingTuples
{
    class Program
    {
        /*static void Main()
       {
            var EmployeeDetails = GetEmployeeDetails(1001);
             var Name = EmployeeDetails.Item1;
             var Salary = EmployeeDetails.Item2;
             var Gender = EmployeeDetails.Item3;
             var Dept = EmployeeDetails.Item4;
             // Do something with the data.
             //here we are just printing the data in the console
             Console.WriteLine("Employee Details :");
             Console.WriteLine($"Name: {Name},  Gender: {Gender}, Department: {Dept}, Salary:{Salary}");
             Console.WriteLine("Press any key to exit.");
             Console.ReadKey();
         }
         private static (string, double, string, string) GetEmployeeDetails(long EmployeeID)
         {
             //based on the EmployyeID get the data from a database
             //here we are hardcoded the value
             string EmployeeName = "Pranaya";
             double Salary = 2000;
             string Gender = "Male";
             string Department = "IT";
             return (EmployeeName, Salary, Gender, Department);
         }

       }*/
        //Different ways to deconstruct a tuple or Splitting Tuples in C#
        //way 1
        /* static void Main()
         {
             (string Name, double Salary, string Gender, string Dept) = GetEmployeeDetails(1001);
             // Do something with the data.
             //here we are just printing the data in the console
             Console.WriteLine("Employee Details :");
             Console.WriteLine($"Name: {Name},  Gender: {Gender}, Department: {Dept}, Salary:{Salary}");
             Console.WriteLine("Press any key to exit.");
             Console.ReadKey();
         }
         private static (string, double, string, string) GetEmployeeDetails(long EmployeeID)
         {
             //based on the EmployyeID get the data from a database
             //here we are hardcoded the value
             string EmployeeName = "Pranaya";
             double Salary = 2000;
             string Gender = "Male";
             string Department = "IT";
             return (EmployeeName, Salary, Gender, Department);
         }

     }*/

     //way2
        
    static void Main()
        {
            // var (Name, Salary, Gender, Dept) = GetEmployeeDetails(1001);
            (var Name, var Salary, string Gender, var Dept) = GetEmployeeDetails(1001);// not recommended.

            // Do something with the data.
            //here we are just printing the data in the console
            Console.WriteLine("Employee Details :");
            Console.WriteLine($"Name: {Name},  Gender: {Gender}, Department: {Dept}, Salary:{Salary}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        private static (string, double, string, string) GetEmployeeDetails(long EmployeeID)
        {
            //based on the EmployyeID get the data from a database
            //here we are hardcoded the value
            string EmployeeName = "Pranaya";
            double Salary = 2000;
            string Gender = "Male";
            string Department = "IT";
            return (EmployeeName, Salary, Gender, Department);
        }


    }
}
