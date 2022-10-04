Console.WriteLine("Please input your first Number: \n");
int firstNumber = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Pick one Operator: + - * /");
String operatorDecision = Console.ReadLine();


Console.WriteLine("Please input a second Number: \n");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("If you want to add a third number type: `y`. If not: `n` ");

String decision = Console.ReadLine();

if (operatorDecision == "+")
{

    if (decision == "n")
    {
        int onlyPlus = firstNumber + secondNumber;
        Console.WriteLine("The result is: " + onlyPlus);
    }
    else if (decision == "y")
    {
        Console.WriteLine("Please input a third number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your second operator?: + - * / ");
        String secondOperatorDecision = Console.ReadLine();

        if (secondOperatorDecision == "+")
        {
            int addSum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine("The result is: " + addSum);
        }
        else if (secondOperatorDecision == "-")
        {
            int subSum = firstNumber + secondNumber - thirdNumber;
            Console.WriteLine("The result is: " + subSum);
        }
        else if (secondOperatorDecision == "*")
        {
            int mulSum = firstNumber + secondNumber * thirdNumber;
            Console.WriteLine("The result is: " + mulSum);
        }
        else if (secondOperatorDecision == "/")
        {
            float divSum = firstNumber + secondNumber / thirdNumber;
            Console.WriteLine("The result is: " + divSum);
        }
    }
}

if (operatorDecision == "-")
{
    if (decision == "n")
    {
        int firstSubNumb = firstNumber - secondNumber;
        Console.WriteLine("The result is: " + firstSubNumb);
    }
    else if (decision == "y")
    {
        Console.WriteLine("Please input a third Number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your second Operator: + - * / ");
        String secondOperatorDecision = Console.ReadLine();
        if (secondOperatorDecision == "+")
        {
            int addSum = firstNumber - secondNumber + thirdNumber;
            Console.WriteLine("The result is: " + addSum);
        }
        else if (secondOperatorDecision == "-")
        {
            int subSum = firstNumber - secondNumber - thirdNumber;
            Console.WriteLine("The result is: " + subSum);
        }
        else if (secondOperatorDecision == "*")
        {
            int mulSum = firstNumber - secondNumber * thirdNumber;
            Console.WriteLine("The result is: " + mulSum);
        }
        else if (secondOperatorDecision == "/")
        {
            float divSum = firstNumber - secondNumber / thirdNumber;
            Console.WriteLine("The result is: " + divSum);
        }
    }
}

if (operatorDecision == "*")
{
    if (decision == "y")
    {
        Console.WriteLine("Please input a third Number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your Second Operator: + - * / ");
        String secondOperatorDecision = Console.ReadLine();
        if (secondOperatorDecision == "+")
        {
            int addSum = firstNumber * secondNumber + thirdNumber;
            Console.WriteLine("The result is: " + addSum);
        }
        else if (secondOperatorDecision == "-")
        {
            int subSum = firstNumber * secondNumber - thirdNumber;
            Console.WriteLine("The result is: " + subSum);
        }
        else if (secondOperatorDecision == "*")
        {
            int mulSum = firstNumber * secondNumber * thirdNumber;
            Console.WriteLine("The result is: " + mulSum);
        }
        else if (secondOperatorDecision == "/")
        {
            float divSum = firstNumber * secondNumber / thirdNumber;
            Console.WriteLine("The result is: " + divSum);
        }
        else if (decision == "n")
        {
            Console.WriteLine("The result is: " + firstNumber * secondNumber);
        }
    }
}

if (operatorDecision == "/")
{
    if (decision == "n")
    {
        Console.WriteLine("The result is: " + firstNumber / secondNumber);
    }
    else if (decision == "y")
    {
        Console.WriteLine("Please input a third Number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("What is your second Operator?: + - * / ");
        String secondOperatorDecision = Console.ReadLine();
        if (secondOperatorDecision == "+")
        {
            int addSum = firstNumber / secondNumber + thirdNumber;
            Console.WriteLine("The result is: " + addSum);
        }
        else if (secondOperatorDecision == "-")
        {
            int subSum = firstNumber / secondNumber - thirdNumber;
            Console.WriteLine("The result is: " + subSum);
        }
        else if (secondOperatorDecision == "*")
        {
            int mulSum = firstNumber / secondNumber * thirdNumber;
            Console.WriteLine("The result is: " + mulSum);
        }
        else if (secondOperatorDecision == "/")
        {
            float divSum = firstNumber / secondNumber / thirdNumber;
            Console.WriteLine("The result is: " + divSum);
        }
    }
}











