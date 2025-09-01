//Сортировка чисел

class Program
{
    public static void Main()
    {
        var array = new int[20];
        var random = new Random();
        int temp;

        Console.WriteLine("Array before sorting: ");
        for (var k = 0; k < array.Length; k++)
        {
            array[k] = random.Next(10);
            Console.Write(array[k] + " ");
        }
        
        for (var i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length-i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j+1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                }
            }
        }
        
        Console.WriteLine("\nArray after sorting: ");
        foreach (var t in array)
            Console.Write(t + " ");
    }
}