bool end = false;
while (end != true)
{
        Console.WriteLine("Give the first number");
        if (int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Give the second number");
            if (int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Now choose operation");
                Console.WriteLine("1| +");
                Console.WriteLine("2| -");
                Console.WriteLine("3| /");
                Console.WriteLine("4| *");
                Console.WriteLine("5| Exit");
                int.TryParse(Console.ReadLine(), out int choice);
                if (choice == 1)
                {
                    int result = a + b;
                    Console.WriteLine(result);
                }
                else if (choice == 2)
                {
                    int result = a - b;
                    Console.WriteLine(result);
                }
                else if (choice == 3)
                {
                if (b != 0)
                {
                    float result = (float)a / b;
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine("You can't divide by zero");
                }
                }
                else if (choice == 4)
                {
                    int result = a * b;
                    Console.WriteLine(result);
                }
                else if (choice == 5)
                {
                    end = true;
                Console.Clear();
                }
                else
                {
                    Console.WriteLine("Incorrect second number");
                }
            }
        }
    else
    {
        Console.WriteLine("Incorrect");
    }
}