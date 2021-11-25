using System;

public class Program
{
    public static void Main()
    {
        string inputLine;
        string[] inputArray;
        int
            w,
            h,
            n;

        // Размер холста
        inputLine = Console.ReadLine();
        inputArray = inputLine.Split(" ");
        w = Convert.ToInt32(inputArray[0]);
        h = Convert.ToInt32(inputArray[1]);

        // Кол-во блоков
        n = Convert.ToInt32(Console.ReadLine());

        // Подготовка массива с холстом
        bool[,] canvasArray = new bool[w, h];
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                canvasArray[i, j] = false;
            }
        }

        // Рассчёт площади
        for (int k = 0; k < n; k++)
        {
            inputLine = Console.ReadLine();
            inputArray = inputLine.Split(" ");

            int x1 = Convert.ToInt32(inputArray[0]);
            int y1 = Convert.ToInt32(inputArray[1]);
            int x2 = Convert.ToInt32(inputArray[2]);
            int y2 = Convert.ToInt32(inputArray[3]);

            for (int xi = x1; xi < x2; xi++)
            {
                for (int yi = y1; yi < y2; yi++)
                {
                    canvasArray[xi, yi] = true;
                    Console.WriteLine("(" + xi + ":" + yi + ")");
                }
            }
        }

        int result = 0;

        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < h; j++)
            {
                if (!canvasArray[i, j])
                {
                    result++;
                }
            }
        }

        Console.WriteLine (result);
    }
}
