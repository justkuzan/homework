//Сдвиг значений массива

class Program
{
    public static void Main()
    {
        int[] arr = new int[10];
        Random rnd = new Random();

        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = rnd.Next(1, 10);
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine("\nHow many positions do you want to shift: ");
        int shiftNumber = int.Parse(Console.ReadLine());
        shiftNumber %= arr.Length;

        RotateLeftInPlace(arr, shiftNumber);

        Console.WriteLine($"\nResult of shifting {shiftNumber} positions to the left:");
        Console.WriteLine(string.Join(" ", arr));
    }

    static void RotateLeftInPlace(int[] arr, int shift)
    {
        int n = arr.Length;

        Reverse(arr, 0, shift - 1);
        Reverse(arr, shift, n - 1);
        Reverse(arr, 0, n - 1);
    }

    static void Reverse(int[] arr, int start, int end)
    {
        while (start < end)
        {
            int temp = arr[start];
            arr[start] = arr[end];
            arr[end] = temp;
            start++;
            end--;
        }
    }
}