namespace HomeWork;

public class HomeTask1 : IBaseHomeTask
{
    public void Run()
    {
        Console.Write("Input a amount of massive elements:");
        int elementCount = int.Parse(Console.ReadLine());
        int[] firstMassive = new int[elementCount];
        int result = 0;

        for (int i = 0; i < firstMassive.Length; i++)

        {
            Console.Write($"\n Input number of massive index: {i} ");
            firstMassive[i] = int.Parse(Console.ReadLine());

            if (firstMassive[i] % 2 == 0)
            {
                result = result + firstMassive[i];
            }
        }

        Console.Write("Summ of even number" + result);
    }
}