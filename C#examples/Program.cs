// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;

/*namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, C# World!");
          
        }
    }

}*/

//struct
/*namespace StructSample
{
    public struct Book
    {
        public string Title;
        public string Author;
        public decimal Price;
        public short Year;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Struct Sample!");
            Book myBook = new Book();
            myBook.Title = "Simplified C#";
            myBook.Author = "Mahesh Chand";
            myBook.Price = 45.95M;
            myBook.Year = 2017;

            Console.WriteLine($"Book {myBook.Title} was written by {myBook.Author}" +
               $" in {myBook.Year}. Price is {myBook.Price}");

            Console.ReadKey();
        }
    }
}*/

//class
/*class Person
{
    private string name;
    private int age;
    private string sex;

    public Person()
    {
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }
    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public string Sex
    {
        get { return this.sex; }
        set { this.sex = value; }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person p = new Person();
        p.Name = "Mahesh Chand";
        p.Age = 40;
        p.Sex = "Male";

        Console.WriteLine("Person 1 {0} is {1} years old {2}.", p.Name, p.Age, p.Sex);

        Console.ReadKey();
    }
}*/


//method
/*class Person
{
    private string name;
    private int age;
    private string sex;
    private string profession;
    private bool retired = false;

    public Person(string personName, int personAge, string personSex)
    {
        this.name = personName;
        this.age = personAge;
        this.sex = personSex;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
    public string Sex
    {
        get { return this.sex; }
        set { this.sex = value; }
    }

    public void SayHello()
    {
        if (this.name.Length > 0)
            Console.WriteLine("Hello {0} from the Person class", this.name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Mahesh Chand", 40, "male");
        person.SayHello();
        Console.ReadKey();
    }
}*/

//method overloading
/*public class Rate
{
    private decimal total;
    public decimal CalculateCost(decimal price, decimal rate)
    {
        total = price * rate;
        return total;
    }

    public void CalCost(decimal price, decimal rate, out decimal total)
    {
        total = price * rate;
    }

    public void CalCost(decimal price, decimal rate, out decimal total, out decimal min, out decimal max)
    {
        min = rate * 0.5m;
        max = rate * 2;
        total = price * rate;
    }
}

class Program
{
    static void Main(string[] args)
    {
        RateCalculator calculator = new RateCalculator();
        decimal total = calculator.CalCost(12.5m, 6.8m);
        calculator.CalcCost(12.5m, 6.8m, out decimal cost);
        calculator.CalCost(12.5m, 6.8m, out decimal totalcost, out decimal minrate, out decimal maxrate);
        Console.WriteLine("Total cost {0}", totalcost);

        Console.ReadKey();
    }
}*/

//foreach
/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("foreach loop Sample!");
        int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
        foreach (int num in oddArray)
        {
            Console.WriteLine(num);
        }

        Console.ReadKey();
    }
}*/

//do-while Statement
/*class Program
{
    static void Main(string[] args)
    {
        int counter = 0;
        do
        {
            Console.WriteLine(counter);
            counter++;
        } while (counter < 2);

        Console.ReadKey();
    }
}*/

//while 
/*class Program Statement
{
    static void Main(string[] args)
    {
        int counter = 0;
        while (counter < 10)
        {
            Console.WriteLine(counter);
            counter++;
        }
        Console.ReadKey();
    }
}*/


//go to Statement
/*class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");

        Console.WriteLine("What is your name? ");
        string name = Console.ReadLine();
        switch (name)
        {
            case "Anusha":
                Console.WriteLine("My name is Anusha.");
                goto case "MS";
            case "MS":
                Console.WriteLine(@"MS is my last name.");
                break;
            case "Neel":
                Console.WriteLine("My name is Neel. ");
                break;
            default:
                break;
        }
        Console.ReadKey();
    }
}*/


//break Statement
/*class Program
{
    static void Main(string[] args)
    {
        int[] oddArray = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21};
        foreach (int num in oddArray)
        {
            Console.WriteLine(num);
            if (num == 15) 
                break;
        }
    }
}*/

//continue Statement and return Statement
/*class Program
{
    static void Main(string[] args)
    {
        for (int counter = 0; counter <= 10; counter++)
        {
            if (counter == 5)
                continue;
            Console.WriteLine(counter);
        }
    }
}*/

//return Statement
/*class Program
{
    static void Main(string[] args)
    {
        for (int counter = 0; counter <= 10; counter++)
        {
            if (counter == 7)
                return;
            Console.WriteLine(counter);
        }
    }
}*/


//implicit type conversion
/*
class Program
{
    static void Main(string[] args)
    {
        int numInt = 1500;
        Type numIntType = numInt.GetType();
        double numDouble = numInt;
        Type numDoubleType = numDouble.GetType();
        Console.WriteLine($"numInt value: {numInt}" );
        Console.WriteLine($"numInt Type: {numIntType}");
        Console.WriteLine($"Int Size: {sizeof(int)} Bytes");
        Console.WriteLine($"numDouble value: {numDouble}");
        Console.WriteLine($"numDouble Type: {numDoubleType}");
        Console.WriteLine($"double Size: {sizeof(double)} Bytes");

        Console.ReadKey();
    }
}
*/

//Explicit Type Casting
/*class Program
{
    static void Main(string[] args)
    {
        double numDouble = 1.23;
        int numInt = (int)numDouble;
        Console.WriteLine("Original double Value: " + numDouble);
        Console.WriteLine("Converted int Value: " + numInt);
        Console.ReadKey();
    }
}*/

//Operators
/*class Program
{
    static void Main(string[] args)
    {
        int Result;
        int Num1 = 20, Num2 = 10;
        Result = (Num1 + Num2);
        Console.WriteLine($"Addition Operator: {Result}" );
        Result = (Num1 - Num2);
        Console.WriteLine($"Subtraction Operator: {Result}");
        Result = (Num1 * Num2);
        Console.WriteLine($"Multiplication Operator: {Result}");
        Result = (Num1 / Num2);
        Console.WriteLine($"Division Operator: {Result}");
        Result = (Num1 % Num2);
        Console.WriteLine($"Modulo Operator: {Result}");
        Console.ReadKey();
    }
}*/

//Assignment Operators
/*nt a=10;
int b=5;
a += b; //a=a+b;
Console.WriteLine($"Addition Operator: {a}");
a -= b; //a=a-b;
Console.WriteLine($"Sub Operator: {a}");
a *= b; //a=a*b;
Console.WriteLine($"Mul Operator: {a}");
a %= b; //a=a%b;
Console.WriteLine($"Div Operator: {a}");*/

//Relational Operators
/*bool Result;
int Num1 = 5, Num2 = 10;
// Equal to Operator
Result = (Num1 == Num2);
Console.WriteLine("Equal (=) to Operator: " + Result);
// Greater than Operator
Result = (Num1 > Num2);
Console.WriteLine("Greater than Operator: " + Result);
// Less than Operator
Result = (Num1 < Num2);
Console.WriteLine("Less than Operator: " + Result);
// Greater than Equal to Operator
Result = (Num1 >= Num2);
Console.WriteLine("Greater than or Equal to Operator: " + Result);
// Less than Equal to Operator
Result = (Num1 <= Num2);
Console.WriteLine("Lesser than or Equal to Operator: " + Result);
// Not Equal To Operator
Result = (Num1 != Num2);
Console.WriteLine("Not Equal to Operator: " + Result);*/

//Logical Operators
/*bool x = true, y = false, z;
//Logical AND operator
z = x && y;
Console.WriteLine("Logical AND Operator: " + z);
//Logical OR operator
z = x || y;
Console.WriteLine("Logical OR Operator: " + z);
//Logical NOT operator
z = !x;
Console.WriteLine("Logical NOT Operator: " + z);*/

//Bitwise Operators 
/*int a = 12, b = 25, Result;
// Bitwise AND Operator
Result = a & b;
Console.WriteLine($"Bitwise AND: {Result}");
// Bitwise OR Operator
Result = a | b;
Console.WriteLine($"Bitwise OR: {Result}");
// Bitwise XOR Operator
Result = a ^ b;
Console.WriteLine($"Bitwise XOR: {Result}");*/

//Unary Operators
// Post-Increment
/*int x = 10;
Console.WriteLine("x is {0}", x);
int Result = x++;
Console.WriteLine("Result is {0}",Result);//10
Console.WriteLine(x);//11
int Result1 = x++;
Console.WriteLine("Result1 is {0}",Result1);//11
// Pre-Increment 
int y = 10;
Console.WriteLine("y is {0}", y);
int Result2 = ++y;
Console.WriteLine("Result2 is {0}",Result2);
Console.WriteLine("y is {0}", y);
int Result3 = ++y;
Console.WriteLine("Result3 is {0}",Result3);
*/

//Decrement 
//post-Decrement 
/*int x = 10;
int Result1 = x--;
Console.WriteLine("x is {0} and Result1 is {1}", x, Result1);
// Pre-Decrement 
int y = 10;
int Result2 = --y;
Console.WriteLine("y is {0} and Result2 is {1}", y, Result2);*/


//Ternary Operator
/*int a = 20, b = 90, res;
res = ((a > b) ?a : b);
Console.WriteLine("Result = " + res);*/

//Control Flow Statements
/*if(10 > 5)
{
    Console.WriteLine("Executing Statment1");
    Console.WriteLine("Executing Statment2");
}
else
{
    Console.WriteLine("Executing Statment3");
    Console.WriteLine("Executing Statment4");
}
Console.WriteLine("Executing Statment5");

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Welcome to C#.NET");
}
            
Console.WriteLine("Executing Statment1");
goto statement4;   
Console.WriteLine("Executing Statment2");
Console.WriteLine("Executing Statment3");
statement4:  
Console.WriteLine("Executing Statment4");
Console.WriteLine("Executing Statment5");*/


/*string str = "Java";
switch (str)
{
    case "C#":      
    case "Java":
    case "C":
        Console.WriteLine("It’s a Programming Langauge");
        break;
    case "MSSQL":
    case "MySQL":
    case "Oracle":
        Console.WriteLine("It’s a Database");
        break;
    case "MVC":
    case "WEB API":
        Console.WriteLine("It’s a Framework");
        break;
    default:
        Console.WriteLine("Invalid Input");
        break;
}*/


//call by value
/*int a=15;
int b=a;
b=40;
Console.WriteLine(a);
Console.WriteLine(b);*/

//call by value with reference

/*public class employee
{
    public int id;
    public string name;
}

namespace Myprj
{
    class Program
    {
        static void Main(string[] args)
        {
            employee ep = new employee();
            ep.id = 2;
            ep.name = "anu";
            Console.WriteLine($"employee id is {ep.id}");
            Console.WriteLine($"employee id is {ep.name}");
        }

    }
}*/

//call by reference
/*namespace Myprj
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=15;
            Console.WriteLine(a);
            update(ref a);
            Console.WriteLine(a);
        }

        static void update(ref int b)
        {
            b=30;
        }

    }
}*/


//Recursion
/*namespace RecursionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Method Started");
            fun1(4);
            Console.WriteLine("Main Method Started");
            Console.ReadKey();
        }
        static void fun1(int n)
        {
            Console.WriteLine("Fun1 Started");
            fun2(3);
            Console.WriteLine("Fun1 Ended");
        }
        static void fun2(int n)
        {
            Console.WriteLine("Fun2 Started");
            fun3(2);
            Console.WriteLine("Fun2 Ended");
        }
        static void fun3(int n)
        {
            Console.WriteLine("Fun3 Started");
            fun4(1);
            Console.WriteLine("Fun3 Ended");
        }
        static void fun4(int n)
        {
            Console.WriteLine("Fun4 Started");
            Console.WriteLine("Fun4 Ended");
        }
    }
}*/

//
/*Console.WriteLine("Prints on ");
Console.WriteLine("New line");
Console.Write("Prints on ");
Console.Write("Same line");

int number1 = 15, number2 = 20, sum;
sum = number1 + number2;
Console.WriteLine("{0} + {1} = {2}", number1, number2, sum);
Console.WriteLine($"{number1} + {number2} = {sum}");*/

//User Input
/*string str;
Console.Write("Enter a string - ");
str = Console.ReadLine();
Console.WriteLine($"You entered {str}");*/


//static class
/*namespace StaticConstructorsDemo
{
    static class MyCollege
    {
        //static fields
        public static string CollegeName;
        public static string Address;

        //static constructor
        static MyCollege()
        {
            CollegeName = "ABC College of Technology";
            Address = "Hyderabad";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyCollege.CollegeName);
            Console.WriteLine(MyCollege.Address);
            Console.Read();
        }
    }
}*/

//properties
/*namespace PropertyDemo
{
    public class Calculator
    {
        int _Number1, _Number2, _Result;
        public int SetNumber1
        {
            set
            {
                _Number1 = value;
            }
        }
        public int SetNumber2
        {
            set
            {
                _Number2 = value;
            }
        }
        public int GetResult
        {
            get
            {
                return _Result;
            }
        }
        public void Add()
        {
            _Result = _Number1 + _Number2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter two Numbers:");
            calculator.SetNumber1 = int.Parse(Console.ReadLine());
            calculator.SetNumber2 = int.Parse(Console.ReadLine());
            calculator.Add();
            Console.WriteLine($"The Sum is: {calculator.GetResult}");
        }
    }
}*/


//
/*int Number1 = 10;
int Number2 = 90;
Console.WriteLine($"Number1 == Number2: {Number1 == Number2}");
int Num1 = 10;
int Num2 = 10;
Console.WriteLine($"Number1.Equals(Number2): {Num1.Equals(Num2)}");*/

//Boxing and UnBoxing
/*int x = 10;
object y = x; //Boxing
Console.WriteLine(y);
int z = (int)y; //Unboxing
Console.WriteLine(z);*/

//Encapsulation
/*namespace EncapsulationDemo
{
    public class Bank
    {
        private int Amount;
        public int GetAmount()
        {
            return Amount;
        }
        public void SetAmount(int Amount)
        {
            if (Amount > 0)
            {
                this.Amount = Amount;
            }
            else
            {
                throw new Exception("Please Pass a Positive Value");
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            try
            {
                Bank bank = new Bank();
                bank.SetAmount(10);
                Console.WriteLine(bank.GetAmount());
                bank.SetAmount(-150);
                Console.WriteLine(bank.GetAmount());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}*/


//Single Inheritance
/*namespace Demo
{
    public class Program
    {
        static void Main()
        {
            Cuboid obj =  new Cuboid(2, 4, 6);
            Console.WriteLine($"Volume is : {obj.Volume()}");
            Console.WriteLine($"Area is : {obj.Area()}");
            Console.WriteLine($"Perimeter is : {obj.Perimeter()}");
            Console.ReadKey();
        }
    }
    //Parent class
    public class Rectangle
    {
        public int length;
        public int breadth;
        public int Area()
        {
            return length * breadth;
        }
        public int Perimeter()
        {
            return 2 * (length + breadth);
        }
    }
    
    //Child Class
    class Cuboid : Rectangle
    {
        public int height;
        public Cuboid(int l, int b, int h)
        {
            length = l;
            breadth = b;
            height = h;
        }
        public int Volume()
        {
            return length * breadth * height;
        }
    }
}*/


/*public class A
{
    public void Method1()
    {
       Console.WriteLine("hi");
    }
}

public class B : A
{ 
    public void Method2()
    {
       Console.WriteLine("hello");
    }
}

public class Example
{
    public static void Main()
    {
        B b = new ();
        b.Method1();
        b.Method2();
    }
}*/


//Interface
/*namespace Interface 
{
    interface IPolygon 
    {
        void calculateArea(int a, int b);
    }

    interface IColor 
    {
        void getColor();
    }
    
    class Rectangle : IPolygon, IColor
    {
        public void calculateArea(int a, int b) 
        {
        int area = a * b;
        Console.WriteLine("Area of Rectangle: " + area);
        }

        public void getColor() 
        {
        Console.WriteLine("Red Rectangle");        
        }
    }

    class Program 
    {
        static void Main (string [] args) 
        {

        Rectangle r1 = new Rectangle();
        r1.calculateArea(100, 200);
        r1.getColor();
        }
    }
}*/

//Abstract Class and Abstract Methods
/*namespace AbstractMethods
{
    public abstract class Plan
    {
        protected abstract  double getRate();
        public void Calculation(int units)
        {
            double rate = getRate();
            Console.WriteLine($"Bill Amount For {units} Units is: Rs. {rate * units}");
        }
    }

    class CommercialPlan : Plan
    {
        protected override double getRate()
        {
           return 5.00;
        }
    }
    class DomesticlPlan : Plan
    {
        protected override double getRate()
        {
            return 2.50;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Plan p;
            Console.WriteLine("Commercial Plan");
            p = new CommercialPlan();
            p.Calculation(250);

            Console.WriteLine("Domesticl Plan");
            p = new DomesticlPlan();
            p.Calculation(150);
            Console.ReadKey();
        }
    }
}*/


//Method Overloading
class Program
{
    static void Main(string[] args)
    {
        Program obj = new Program();
        obj.Method(); 
        obj.Method(10); 
        obj.Method("Hello"); 
        obj.Method(10, "Hello"); 
        obj.Method("Hello", 10); 
        Console.ReadKey();
    }
    public void Method()
    {
        Console.WriteLine("1st Method");
    }
    public void Method(int i)
    {
        Console.WriteLine("2nd Method");
    }
    public void Method(string s)
    {
        Console.WriteLine("3rd Method");
    }
    public void Method(int i, string s)
    {
        Console.WriteLine("4th Method");
    }
    public void Method(string s, int i)
    {
        Console.WriteLine("5th Method");
    }    
}