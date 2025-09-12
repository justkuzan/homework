//Скобочное выражение

class Program
{
    public static void Main()
    {
        int depth;
        
        Random rnd = new Random();
        char[] arr = new char[rnd.Next(4, 12)];
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (rnd.Next(2) == 0)
                arr[i] = '(';
            else
                arr[i] = ')';

            Console.Write(arr[i] + " ");
        }

        if (isCorrect(arr, out depth))
            Console.WriteLine($"\nCorrect. Max depth {depth}");
        else
            Console.WriteLine("\nIncorrect");
    }

    static bool isCorrect(char[] arr, out int depth)
    {
        int alignment = 0;
        depth = 0;

        foreach (var i in arr)
        {
            if (i == '(')
            {
                alignment++;
                if (alignment > depth)
                    depth = alignment;
            }
            else if (i == ')')
                alignment--;
            
            if (alignment < 0)
                return false;
        }
        return alignment == 0;
    }


    
}