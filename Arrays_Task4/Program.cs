// Динамический массив

class Program
{
    static void Main()
    {
        bool isWorking = true;

        Console.WriteLine("Введите числа: ");

        int[] array = new int[] { int.Parse(Console.ReadLine()) };
        int[] tempArray = new int[2];
        int numberOfNewArray = 1;

        for (int i = 0; isWorking; i++)
        {
            int[] newArray = new int[2 + i];
            newArray[0] = array[0];

            if (newArray.Length > 2)
            {
                for (int k = 1; k < tempArray.Length; k++)
                {
                    newArray[k] = tempArray[k];
                }
            }

            if (newArray.Length > array.Length)
            {
                for (; numberOfNewArray + 1 == newArray.Length;)
                {
                    newArray[numberOfNewArray] = int.Parse(Console.ReadLine());
                    numberOfNewArray++;
                }
            }

            tempArray = newArray;
        }
    }
}