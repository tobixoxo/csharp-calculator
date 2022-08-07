// See https://aka.ms/new-console-template for more information
Console.WriteLine("--- Welcome to the Calculator! ---");

string firstNumber = "0";
string secondNumber = "0";
int a, b;

Console.Write("Enter first number : ");
firstNumber =  Console.ReadLine();
a = Int32.Parse(firstNumber);
Console.Write("Enter Second number : ");
secondNumber = Console.ReadLine();
b = Int32.Parse(secondNumber);

Console.WriteLine($"the 2 numbers are {a} & {b}");
Console.WriteLine($"Following are the operations available");
Console.WriteLine("1)ADD\n2)SUBTRACT\n3)MULTIPLY\n4)DIVIDE\n\n5) --QUIT--");


int operation = 0;

while(operation != 5){
    Console.WriteLine("Enter the num. corresponding to operation u want to perform : ");
    operation = Int32.Parse(Console.ReadLine());
    switch(operation){
        case 1:
            Console.WriteLine($"The sum is : {a + b}");
            break;
        case 2:
            Console.WriteLine($"The difference is : {a - b}");
            break;
        case 3:
            Console.WriteLine($"The product is {a * b}");
            break;
        case 4:
            Console.WriteLine($"the quotient is : {a / b}");
            break;
        case 5:
            break;
        default:
            Console.WriteLine("Please enter valid operation!");
            break;
    }
}

Console.WriteLine("--- Thank you for using Calculator ---");
