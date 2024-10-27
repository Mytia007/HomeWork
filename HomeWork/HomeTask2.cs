namespace HomeWork;

public class HomeTask2 : IBaseHomeTask
{
    public void Run()
    {
        
        int oddNumber = 0;
        int evenNumber = 0;
        Console.WriteLine("Input first number of the range");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Input last number of the range");
        int limit = int.Parse(Console.ReadLine());

        while (number <= limit)
        {
            if (number % 2 == 0) 
            {
                oddNumber++;
            }
            else
            {
                evenNumber++;
            }
            number++;
        }
        Console.WriteLine("Amout of odd numbers "  + oddNumber);
        Console.WriteLine("Amout of even numbers "  + evenNumber);
    }
}