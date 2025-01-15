namespace Assignment04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Q1.Write a class named Calculator that contains a method named Add. Overload the Add method to: 
            ///● Accept two integers and return their sum.
            ///● Accept three integers and return their sum.
            ///● Accept two doubles and return their sum.

            //Calculator calculator = new Calculator();

            //// Testing the Add methods
            //Console.WriteLine("Sum of two integers (5, 10): " + calculator.Add(5, 10)); // Output: 15
            //Console.WriteLine("Sum of three integers (5, 10, 15): " + calculator.Add(5, 10, 15)); // Output: 30
            //Console.WriteLine("Sum of two doubles (5.5, 10.5): " + calculator.Add(5.5, 10.5)); // Output: 15.5

            #endregion

            #region Q2.Create a class named Rectangle with the following constructors:
            ///● A parameterless constructor that sets the width and height to 0. 
            ///● A constructor that accepts width and height as integers. 
            ///● A constructor that accepts a single integer and sets both width and height to that value.

            //// Creating rectangles using different constructors
            //Rectangle rect1 = new Rectangle();
            //Rectangle rect2 = new Rectangle(10, 20);
            //Rectangle rect3 = new Rectangle(15);

            //// Displaying the dimensions of each rectangle
            //rect1.DisplayRectangle(); // Output: Width: 0, Height: 0
            //rect2.DisplayRectangle(); // Output: Width: 10, Height: 20
            //rect3.DisplayRectangle(); // Output: Width: 15, Height: 15

            #endregion

            #region Q3.Define a class Complex Number that represents a complex number with real and imaginary parts.
            ///* Note: Overload the +, - operator to add and subtract two complex numbers.

            //// Creating two complex numbers by directly setting properties
            //ComplexNumber c1 = new ComplexNumber { Real = 5, Imaginary = 3 };
            //ComplexNumber c2 = new ComplexNumber { Real = 2, Imaginary = 4 };

            //// Adding the two complex numbers
            //ComplexNumber sum = c1 + c2;
            //Console.WriteLine($"Sum: {sum}"); // Output: Sum: 7 + 7i

            //// Subtracting the two complex numbers
            //ComplexNumber subtraction = c1 - c2;
            //Console.WriteLine($"Subtraction: {subtraction}"); // Output: Difference: 3 - 1i

            #endregion

            #region Question4
            ///a) Create a base class named Employee with method That Work as it prints "Employee is  working".
            ///b) Create a derived class named Manager that overrides the Work method to print "Manager is managing".
            /*
             *Ensure that the Manager class also calls the Work method of the Employee class within its
              Overridden method.
            */

            //// Creating an Employee object and calling the Work method
            //Employee employee = new Employee();
            //employee.Work(); // Output: Employee is working

            //// Creating a Manager object and calling the Work method
            //Manager manager = new Manager();
            //manager.Work(); // Output: Employee is working
            //                //         Manager is managing
            #endregion

            #region Question5
            ///a) Create a base class BaseClass with a virtual method DisplayMessage that prints  "Message from BaseClass".
            ///b) Create a derived class DerivedClass1 that overrides the DisplayMessage method using the override keyword.
            ///C) Create another derived class DerivedClass2 that hides the DisplayMessage method using the new keyword.

            ///Then explain the difference between using override and new (using binding behavior)

            //// Creating objects of BaseClass, DerivedClass1, and DerivedClass2
            //BaseClass baseObj = new BaseClass();
            //BaseClass derivedObj1 = new DerivedClass1();
            //BaseClass derivedObj2 = new DerivedClass2();

            //// Calling DisplayMessage on each object
            //baseObj.DisplayMessage();       // Output: Message from BaseClass
            //derivedObj1.DisplayMessage();   // Output: Message from DerivedClass1
            //derivedObj2.DisplayMessage();   // Output: Message from BaseClass (not DerivedClass2 due to hiding)

            //// Creating objects of DerivedClass2 and calling DisplayMessage on it directly
            //DerivedClass2 directDerived2 = new DerivedClass2();
            //directDerived2.DisplayMessage(); // Output: Message from DerivedClass2

            #region Explanation:
            /*
             * Key Differences Between override and new:
              Override: 
               When you use the override keyword, the method in the derived class completely replaces the 
               base class method, even when the method is called on a base class reference that points to a 
               derived class object. This is called method overriding and supports polymorphism.

              New: 
               When you use the new keyword, it hides the method in the base class, but does not replace it.
               If you call the method on a base class reference that points to a derived class object, the 
               base class method is called, not the hidden method in the derived class. This is known as 
               method hiding and does not support polymorphism.
             */
            #endregion

            #endregion

            #endregion

            #region Part 02

            #region Q1.Define Class Duration To include Three Attributes Hours, Minutes and Seconds.
            //// Creating a Duration object with specific hours, minutes, and seconds
            //Duration duration = new Duration(2, 45, 30);

            //// Displaying the duration
            //duration.DisplayDuration();  // Output: 02:45:30
            #endregion

            #region Q2.Override All System. Object Members [To String(), Equals(),GetHashCode()].

            //// Creating two Duration objects with specific hours, minutes, and seconds
            //Duration duration1 = new Duration(2, 45, 30);
            //Duration duration2 = new Duration(2, 45, 30);
            //Duration duration3 = new Duration(3, 10, 45);

            //// Displaying the durations
            //Console.WriteLine("Displaying the durations:");
            //Console.WriteLine("==========================");
            //duration1.DisplayDuration();  // Output: 02:45:30
            //duration2.DisplayDuration();  // Output: 02:45:30
            //duration3.DisplayDuration();  // Output: 03:10:45

            //// Comparing two Duration objects using Equals()
            //Console.WriteLine("Comparing two Duration objects using Equals():");
            //Console.WriteLine("===============================================");
            //Console.WriteLine(duration1.Equals(duration2));  // Output: True
            //Console.WriteLine(duration1.Equals(duration3));  // Output: False

            //// Displaying the hash codes of the Duration objects
            //Console.WriteLine("Displaying the hash codes of the Duration objects:");
            //Console.WriteLine("===================================================");
            //Console.Write("Displaying the Hash Code of the Duration 1");
            //Console.WriteLine(duration1.GetHashCode()); 
            //Console.Write("Displaying the Hash Code of the Duration 2");
            //Console.WriteLine(duration2.GetHashCode()); 

            #endregion

            #region Q3.Define All Required Constructors to Produce this output: 
            ///Duration D1 =new Duration (1,10,15);
            ///D1.ToString();
            ///Output: Hours: 1, Minutes :10, Seconds :15 

            //Console.WriteLine("The Duration is ....");
            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());  // Output: Hours: 1, Minutes: 10, Seconds: 15

            ///Duration D1 =new Duration (3600); 
            ///D1.ToString();
            ///Output: Hours: 1, Minutes: 0, Seconds: 0

            //Console.WriteLine("The Duration of the total is ....");
            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());  // Output: Hours: 1, Minutes: 0, Seconds: 0

            ///Duration D2 = new Duration(7800);
            ///D2.ToString();
            ///Output: Hours: 2, Minutes: 10, Seconds: 0

            //Console.WriteLine("The Duration of the total is ....");
            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());  // Output: Hours: 2, Minutes: 10, Seconds: 0

            ///Duration D3 =new Duration (666); 
            ///D3.ToString();
            ///Output: Minutes: 11, Seconds: 6

            //Console.WriteLine("The Total Duration of the total is ....");
            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());  // Output: Minutes: 11, Seconds: 6

            #endregion

            #region Q4.Implement All required Operators overloading to enable this Code: 
            ///● D3 = D1 + D2
            ///● D3 = D1 + 7800
            ///● D3 = 666 + D3
            ///● D3 = ++D1(Increase One Minute)
            ///● D3 = --D2(Decrease One Minute)
            ///● D1 = D1 - D2
            ///● If(D1 > D2)
            ///● If(D1 <= D2)
            ///● If(D1)
            ///● DateTime Obj = (DateTime)D1

            //// Creating Duration objects
            //Duration D1 = new Duration(1, 10, 15);
            //Duration D2 = new Duration(3600); // 3600 seconds = 1 hour
            //Duration D3 = new Duration(7800); // 7800 seconds = 2 hours 10 minutes

            //// Add two Duration objects
            //D3 = D1 + D2;
            //Console.WriteLine("D3 = D1 + D2.....");
            //Console.WriteLine(D3.ToString());  // Output: Hours: 2, Minutes: 10, Seconds: 15

            //// Add Duration and total seconds
            //D3 = D1 + 7800;
            //Console.WriteLine("D3 = D1 + 7800.....");
            //Console.WriteLine(D3.ToString());  // Output: Hours: 3, Minutes: 10, Seconds: 15

            //// Add total seconds and Duration
            //D3 = 666 + D3;
            //Console.WriteLine("D3 = 666 + D3.....");
            //Console.WriteLine(D3.ToString());  // Output: Hours: 3, Minutes: 16, Seconds: 21

            //// Pre-increment (increase one minute)
            //D3 = ++D1;
            //Console.WriteLine("D3 = ++D1.....");
            //Console.WriteLine(D3.ToString());  // Output: Hours: 1, Minutes: 11, Seconds: 15

            //// Pre-decrement (decrease one minute)
            //D3 = --D2;
            //Console.WriteLine("D3 = --D2.....");
            //Console.WriteLine(D3.ToString());  // Output: Hours: 0, Minutes: 59, Seconds: 0

            //// Subtraction (D1 - D2)
            //D3 = D1 - D2;
            //Console.WriteLine("D3 = D1 - D2.....");
            //Console.WriteLine(D3.ToString());  // Output: Hours: 1, Minutes: 10, Seconds: 15

            //// Comparison (D1 > D2)
            //Console.WriteLine("If(D1 > D2).....");
            //Console.WriteLine(D1 > D2);  // Output: True

            //// Comparison (D1 <= D2)
            //Console.WriteLine("If(D1 <= D2).....");
            //Console.WriteLine(D1 <= D2);  // Output: False

            //// Duration to DateTime
            //DateTime dateTime = (DateTime)D1;
            //Console.WriteLine("DateTime dateTime = (DateTime)D1");
            //Console.WriteLine(dateTime);  // Output: 1/1/0001 1:10:15 AM

            //// Check if Duration is valid (non-zero)
            //Console.WriteLine("If(D1).....");
            //if (D1)
            //{
            //    Console.WriteLine("D1 is valid (non-zero duration).");
            //}

            #endregion

            #endregion
        }
    }
}
