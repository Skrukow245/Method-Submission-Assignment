using System;




class Program
{
    static void Main(string[] args)
    {
        var addition = new Operator();                    //instantiate method
        Console.WriteLine("Input 1 number");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter another number (optional)");
        int input2;
        int result;
        if (int.TryParse(Console.ReadLine(), out input2))              //if console read is empty assign it to input2
        {
            result = addition.Add(input1, input2);
        }
        else                                                           //else if user input add with input 1
        {
            result = addition.Add(input1);
        }
        Console.WriteLine(result);
        Console.ReadLine();
    }
}

