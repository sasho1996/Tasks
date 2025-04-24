using System;

public class Program {

    private string? name = "";//Name

    private string? color = "";//color
    private string? food = "";//food
    private string? number = "";//number

    private int firstNumber = 0;//First Number

    private int secondNumber = 0;//First Number
    
    private bool checkType = false;//Check Type

    private string? firstName = "";//First Name
    private string? lastName = "";//Last Name
    private string? country = "";//Country
    private int age = 0;//Age

    private double hour=0.0;//Hour
    private double minute=0.0;//Minute

    /*
     
    Task 1
     
     */

    //Enter User Data
    public void EnterUserData() {

        Console.Clear();

        Console.Write("Enter name: ");

        name = Console.ReadLine();

        if (name == "") {

            Console.Clear();

            EnterUserData();

        }

        Console.Clear();

        Console.WriteLine($"Hello, {name}! Welcome to your first C# program.");

    }

    /*
     
    End Task 1

      */

    /*
     
    Task 2
     
     */
    //Add
    public int Add(int num_1, int num_2) {

        return num_1 + num_2;

    }

    //Subtract
    public int Subtract(int num_1, int num_2) {

        return num_1 - num_2;

    }

    //Multiply
    public int Multiply(int num_1, int num_2) {

        return num_1 * num_2;

    }
    
    //Divide
    public double Divide(int num_1, int num_2) {

        return (double)num_1 / (double)num_2;

    }

    //Calculate
    public void Calculate() {

        checkType = false;//Reset Data

        while (!checkType) {

            Console.Clear();
            
            Console.Write("Enter First Number: ");
          
            checkType = int.TryParse(Console.ReadLine(), out firstNumber);

            if (checkType && firstNumber==0) {

                checkType = false;

                Console.Clear();

                continue;

            }


            if (!checkType) {

                Console.Clear();

                Console.WriteLine("Error data Press Enter!");

                Console.ReadKey();

            }

        }

        checkType = false;//Reset data

        while (!checkType) {

            Console.Clear();

            Console.Write("Enter Second Number: ");

            checkType = int.TryParse(Console.ReadLine(), out secondNumber);

            if (checkType && secondNumber == 0) {

                checkType = false;

                Console.Clear();

                continue;

            }

            if (!checkType) {

                Console.Clear();

                Console.WriteLine("Error data Press Enter!");

                Console.ReadKey();

            }

        }

        Console.Clear();

        Console.WriteLine($"{firstNumber}+{secondNumber}={Add(firstNumber, secondNumber)}");

        Console.WriteLine($"{firstNumber}-{secondNumber}={Subtract(firstNumber, secondNumber)}");

        Console.WriteLine($"{firstNumber}*{secondNumber}={Multiply(firstNumber, secondNumber)}");

        Console.WriteLine($"{firstNumber}/{secondNumber}={Divide(firstNumber, secondNumber)}");

    }

    /*
     
    End Task 2
     
     */

    /*
      
     Task 3
     
     */

    public void EnterAnswers() {

        Console.Clear();
        
        if (color == "") {

            Console.WriteLine("What's your favorite color?");

            color = Console.ReadLine();

            if (color== "") {

                Console.WriteLine("Error Data. Press Enter!");

                Console.ReadKey();

                EnterAnswers();

            }

        }

        if (food == "") {

            Console.WriteLine("What's your favorite food?");

            food = Console.ReadLine();

            if (food == "") {

                Console.WriteLine("Error Data. Press Enter!");
                
                Console.ReadKey();
                
                EnterAnswers();

            }

        }
       
        if (number == "") {

            Console.WriteLine("What's your favorite number?");

            number = Console.ReadLine();

            if (number == "") {

                Console.WriteLine("Error Data. Press Enter!");

                Console.ReadKey();

                EnterAnswers();

            }

        }

        Console.Clear();

        Console.WriteLine($"You love {color}, {food}, and your lucky number is {number}!");

    }

    /*
     
    End Task 3

     */

    /*
     
        Task 4

     */

    //Reg User
    public void RegUser() {

        Console.Clear();
        
        checkType = false;//Reset Data

        if (firstName == "") {

            Console.Write("Enter first name: ");
            
            firstName = Console.ReadLine();

            if (firstName == "") {

                Console.WriteLine("Error data Press Enter!");

                Console.ReadKey ();

            }
            
            RegUser();

        }

        if (lastName == "") {

            Console.Write("Enter last name: ");

            lastName = Console.ReadLine();

            if (lastName == "") {

                Console.WriteLine("Error data Press Enter!");

                Console.ReadKey();

            }

            RegUser();

        }

        if (age == 0) {

            while (!checkType) {

                Console.Write("Enter age: ");

                checkType = int.TryParse(Console.ReadLine(), out age);

                if (checkType && age == 0 || age > 111) {

                    Console.WriteLine("Error data Press Enter!");
                    
                    Console.ReadKey();

                    checkType = false;

                }

            }

        }

        if (country == "") {

            Console.Write("Enter country: ");

            country = Console.ReadLine();

            if (country == "") {

                Console.WriteLine("Error data Press Enter!");

                Console.ReadKey();

            }

            RegUser();

        }

        Console.Clear();

        Console.WriteLine($"Your name is {firstName} {lastName}, you are {age} years old and you live in {country}.");

    }

    /*
     
    End Task 4
     
     */

    /*
     
        Task 5 
    
     */

    public void ConvertHourToMinute() {

        checkType = false;//Reset Data

        while (!checkType) {

            Console.Write("Enter Hour(Format 0,0): ");

            checkType = double.TryParse(Console.ReadLine(), out hour);

            if (checkType && hour ==0.0) {

                checkType = false;

                Console.WriteLine("Error data Press Enter!");

                Console.ReadKey();
                
                Console.Clear();

            }

            if (!checkType) {

                Console.WriteLine("Error data Press Enter!");

                Console.ReadKey();

                Console.Clear();

            }

        }

        minute = hour * 60.0;

        Console.Clear();

        Console.WriteLine($"That’s {minute} minutes.");

    }

    /*
      
     End Task 5 
     
     */
    private static void Main(string[] args) {

        Program program = new Program();

        program.EnterUserData();

        Console.WriteLine("Press Enter Get Next Task!");
        Console.ReadKey();
        Console.Clear();

        program.Calculate();

        Console.WriteLine("Press Enter Get Next Task!");
        Console.ReadKey();
        Console.Clear();

        program.EnterAnswers();

        Console.WriteLine("Press Enter Get Next Task!");
        Console.ReadKey();
        Console.Clear();

        program.RegUser();

        Console.WriteLine("Press Enter Get Next Task!");
        Console.ReadKey();
        Console.Clear();
        
        program.ConvertHourToMinute();

        Console.WriteLine("Press Enter!");
        Console.ReadKey();

    }

}