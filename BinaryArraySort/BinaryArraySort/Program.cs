using System;

public class Program
{

    // Main Method
     public static void Main(String[] args)
    {

        int[] a = { 1, 1, 0, 1, 1, 1, 0, 1, 1, 0, 1, 1, 1 ,1 ,1, 1}; //Count od Zeros < Radical n
        int n = a.Length;
        sortBinaryArray(a, n);
        for (int i = 0; i < n; i++)
            Console.Write(a[i] + " ");

        Console.ReadKey();

    }

    public static void sortBinaryArray(int[] a, int n)
    {
        int j = -1 ,k=0;
        for (int i = 0; i < n; i++)
        {

            // if number is smaller than 1
            // then swap it with j-th number
            if (a[i] < 1)
            {
                j++;
                k++; //count Zero
                
                    // swap index x and y
                    var temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;


                if (k == Math.Ceiling( Math.Sqrt(n))-1) 
                    return;  // because  we have count of zeros < radical n
            }
        }
    }
}


