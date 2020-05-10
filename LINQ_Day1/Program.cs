using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ_Day1
{
    class Employee
    {
        public int Salary { get; set; }
        public int Id { get; set; }
    }
    class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    class Order
    {
        public int ID { get; set; }
        public string Product { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Linq18();

            Console.Read();
        }
        static public void Linq1()
        {
            int[] array = { 1, 2, 3, 6, 7, 8 };
            // Query expression.
            var elements = from element in array
                           orderby element descending
                           where element > 2
                           select element;
            // Enumerate.
            foreach (var element in elements)
            {
                Console.Write(element);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
        static public void Linq2()
        {
            int[] array = { 2, 3, 5, 7 };
            Console.WriteLine(array.Average());
        }
        static void Linq3()
        {
            Employee[] array = new Employee[]
	            {
	                new Employee(){Salary = 40000, Id = 4},
	                new Employee(){Salary = 40000, Id = 0},
	                new Employee(){Salary = 60000, Id = 7},
	                new Employee(){Salary = 60000, Id = 9}
	            };

            // Highest salaries first.    // Lowest IDs first.
            var result = from em in array
                         orderby em.Salary descending, em.Id ascending
                         select em;

            foreach (var em in result)
                Console.WriteLine("{0}, {1}", em.Salary, em.Id);

        }
        static void Linq4()
        {
            // Input array.
            int[] array = { 2, 5, 3 };
            // Use orderby, orderby ascending, and orderby descending.
            var result0 = from element in array
                          orderby element
                          select element;

            var result1 = from element in array
                          orderby element ascending
                          select element;

            var result2 = from element in array
                          orderby element descending
                          select element;
            // Print results.
            Console.WriteLine("result0");
            foreach (var element in result0)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("result1");
            foreach (var element in result1)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("result2");
            foreach (var element in result2)
            {
                Console.WriteLine(element);
            }
        }
        static bool IsEven(int value)
        {
            return value % 2 == 0;
        }
        static void Linq5()
        {
            // Input array.
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Group elements by IsEven.
            var result = from element in array
                         orderby element
                         group element by IsEven(element);

            // Loop over groups.
            foreach (var group in result)
            {
                // Display key and its values.
                Console.WriteLine(group.Key);
                foreach (var value in group)
                {
                    Console.WriteLine(value);
                }
            }
        }
        static void Linq6()
        {
            int[] array = { 1, 3, 5, 7, 9 };
            //
            // Select the elements in a descending order with query clauses.
            //
            var result = from element in array
                         orderby element descending
                         select element;
            //
            // Evaluate the query and display the results.
            //
            foreach (var element in result)
            {
                Console.WriteLine(element);
            }
        }
        static void Linq7()
        {
            // Example customers.
            var customers = new Customer[]
	            {
	                new Customer{ID = 5, Name = "Sam"},
	                new Customer{ID = 6, Name = "Dave"},
	                new Customer{ID = 7, Name = "Julia"},
	                new Customer{ID = 8, Name = "Sue"}
	            };

            // Example orders.
            var orders = new Order[]
	            {
	                new Order{ID = 5, Product = "Book"},
	                new Order{ID = 6, Product = "Game"},
	                new Order{ID = 7, Product = "Computer"},
	                new Order{ID = 8, Product = "Shirt"}
	            };

            // Join on the ID properties.
            var query = from c in customers
                        join o in orders on c.ID equals o.ID
                        select new { c.Name, o.Product };

            // Display joined groups.
            foreach (var group in query)
            {
                Console.WriteLine("{0} bought {1}", group.Name, group.Product);
            }

        }
        static void Linq8()
        {
            int[] array = { 1, 3, 5, 7, 9 };

            var result = from element in array
                         let v = element * 100
                         where v >= 500
                         select v;

            foreach (var element in result)
                Console.WriteLine(element);
        }
        static void Linq10()
        {
            //
            // An example array.
            //
            int[] array1 = { 5, 4, 1, 2, 3 };
            //
            // Use query expression on array.
            //
            var query = from element in array1
                        orderby element
                        select element;
            //
            // Convert expression to array variable.
            //
            int[] array2 = query.ToArray();
            //
            // Display array.
            //
            foreach (int value in array2)
            {
                Console.WriteLine(value);
            }
        }
        static void Linq11()
        {
            //
            // Use this input string[] array.
            // ... Convert it to a List with the ToList extension.
            //
            string[] array = new string[]
	        {
	            "A",
	            "B",
	            "C",
	            "D"
	        };
            List<string> list = array.ToList();
            //
            // Display the list.
            //
            Console.WriteLine(list.Count);
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
        }
        static void Linq12()
        {
            // Create an array.
            int[] array = { 1, 2, 4 };
            // Call reverse extension method on the array.
            var reverse = array.Reverse();
            // Write contents of array to screen.
            foreach (int value in reverse)
            {
                Console.WriteLine(value);
            }
        }
        static void Linq13()
        {
            // An input data array.
            string[] array = { "cat", "dog", "mouse" };

            // Apply a transformation lambda expression to each element.
            // ... The Select method changes each element in the result.
            var result = array.Select(element => element.ToUpper());

            // Display the result.
            foreach (string value in result)
            {
                Console.WriteLine(value);
            }
        }
        static void Linq21()
        {
            // Declare an array with some duplicated elements in it.
            int[] array1 = { 1, 2, 2, 3, 4, 4 };
            // Invoke Distinct extension method.
            var result = array1.Distinct();
            // Display results.
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
        }
        static void Linq14()
        {
            int[] array1 = { 1, 3, 5 };
            int[] array2 = { 0, 2, 4 };

            // Concat array1 and array2.
            var result1 = array1.Concat(array2);
            foreach (int value in result1)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            // Concat array2 and then array1.
            var result2 = array2.Concat(array1);
            foreach (int value in result2)
            {
                Console.WriteLine(value);
            }

        }
        static void Linq15()
        {
            //
            // Example array that contains unwanted null and empty strings.
            //
            string[] array = { "dot", "", "net", null, null, "perls", null };
            //
            // Use Where method to remove null strings.
            //
            var result1 = array.Where(item => item != null);
            foreach (string value in result1)
            {
                Console.WriteLine(value);
            }
            //
            // Use Where method to remove null and empty strings.
            //
            var result2 = array.Where(item => !string.IsNullOrEmpty(item));
            foreach (string value in result2)
            {
                Console.WriteLine(value);
            }
        }
        static void Linq16()
        {
            // Create two example arrays.
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 2, 3, 4 };
            // Union the two arrays.
            var result = array1.Union(array2);
            // Enumerate the union.
            foreach (int value in result)
            {
                Console.WriteLine(value);
            }
        }
        static void Linq17()
        {
            // Input array.
            string[] array = { "Dot", "Net", "Perls" };

            // Test ElementAt for 0, 1, 2.
            string a = array.ElementAt(0);
            Console.WriteLine(a);
            string b = array.ElementAt(1);
            Console.WriteLine(b);
            string c = array.ElementAt(2);
            Console.WriteLine(c);

            // This is out of range.
            string d = array.ElementAt(3);
        }
        static void Linq18()
        {
            // Input array.
            string[] array = { "the", "glass", "bead", "game","Ali" ,"Bilal", "Camera"};

            // Order alphabetically by reversed strings.
            var result = array.OrderBy(a => new string(a.ToCharArray().Reverse().ToArray()));

            // Display results.
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
        static void Linq19()
        {
            var list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // Use extension method.
            bool a = list.Contains<int>(7);
            // Use instance method.
            bool b = list.Contains(7);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void Linq20()
        {
            B[] values = new B[3];
            values[0] = new B();
            values[1] = new B();
            values[2] = new B();

            // Cast all objects to a base type.
            var result = values.Cast<A>();
            foreach (A value in result)
            {
                value.Y();
            }
        }
    }
    class A
    {
        public void Y()
        {
            Console.WriteLine("A.Y");
        }
    }

    class B : A
    {
    }

}
