using System;

class Program
{
    static void Main(string[] args)
    {
        MyHomeWork01();
        MyHomeWork02();
    }

    // 第五題-MyHomeWork01
    static void MyHomeWork01() {
        // 第一題：宣告陣列
        int[] ints = new int[10];
        float[] floats = new float[8];
        double[] doubles = new double[4];
        string[] strings = new string[5];

        // 第二題
        Console.WriteLine("請輸入 10 個整數：");
        int intSum = 0; // 儲存總和
        for (int i = 0; i < ints.Length; i++)
        {
            Console.Write($"整數第 {i + 1} 個：");
            ints[i] = int.Parse(Console.ReadLine());
            intSum += ints[i];
        }
        Console.WriteLine("整數陣列內容：" + string.Join(", ", ints));
        Console.WriteLine($"整數陣列平均值：{(double)intSum / ints.Length}\n");

        Console.WriteLine("請輸入 8 個浮點數：");
        float floatSum = 0; // 儲存總和
        for (int i = 0; i < floats.Length; i++)
        {
            Console.Write($"浮點數第 {i + 1} 個：");
            floats[i] = float.Parse(Console.ReadLine());
            floatSum += floats[i];
        }
        Console.WriteLine("浮點數陣列內容：" + string.Join(", ", floats));
        Console.WriteLine($"浮點數陣列平均值：{floatSum / floats.Length}\n");

        Console.WriteLine("請輸入 4 個倍精確度數：");
        double doubleSum = 0; // 儲存總和
        for (int i = 0; i < doubles.Length; i++)
        {
            Console.Write($"倍精確度數第 {i + 1} 個：");
            doubles[i] = double.Parse(Console.ReadLine());
            doubleSum += doubles[i];
        }
        Console.WriteLine("倍精確度陣列內容：" + string.Join(", ", doubles));
        Console.WriteLine($"倍精確度陣列平均值：{doubleSum / doubles.Length}\n");

        Console.WriteLine("請輸入 5 個字串：");
        for (int i = 0; i < strings.Length; i++)
        {
            Console.Write($"字串第 {i + 1} 個：");
            strings[i] = Console.ReadLine();
        }
        Console.WriteLine("字串陣列內容：" + string.Join(", ", strings));
    }

    // 第五題-MyHomeWork02
    static void MyHomeWork02() {
        // 第三題
        int[] ints1 = { 1, 2, 3, 4, 5 };
        float[] floats1 = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };
        double[] doubles1 = { 1.22, 2.33, 3.44, 4.55, 5.66 };
        string[] strings1 = { "王小明", "陳大明", "李小英", "張小美", "陳不良" };

        // 第四題
        Console.WriteLine("整數陣列內容：");
        int intSum = 0; // 儲存總和
        foreach (int value in ints1)
        {
            Console.WriteLine(value);
            intSum += value;
        }
        Console.WriteLine($"整數陣列平均值：{(double)intSum / ints1.Length}\n");

        Console.WriteLine("浮點數陣列內容：");
        float floatSum = 0; // 儲存總和
        foreach (float value in floats1)
        {
            Console.WriteLine(value);
            floatSum += value;
        }
        Console.WriteLine($"浮點數陣列平均值：{floatSum / floats1.Length}\n");

        Console.WriteLine("倍精確度陣列內容：");
        double doubleSum = 0; // 儲存總和
        foreach (double value in doubles1)
        {
            Console.WriteLine(value);
            doubleSum += value;
        }
        Console.WriteLine($"倍精確度陣列平均值：{doubleSum / doubles1.Length}\n");

        Console.WriteLine("字串陣列內容：");
        foreach (string value in strings1)
        {
            Console.WriteLine(value);
        }
    }
}
