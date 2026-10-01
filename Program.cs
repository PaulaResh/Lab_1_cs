using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // ЗАДАНИЕ 1
        Console.WriteLine("ЗАДАНИЕ 1");

        //1
        double rez1, x1;
        LB1 s1 = new LB1();
        Console.Write("Введите дробное число Х: ");
        while (!double.TryParse(Console.ReadLine(), out x1))
            Console.Write("Ошибка! Введите корректное дробное число: ");
        rez1 = s1.Fraction(x1);
        Console.WriteLine("Дробная часть числа Х = " + (decimal)rez1);

        //3
        char x1_3;
        Console.WriteLine("Введи символ от 0 до 9, чтобы преобразовать его в соотв. число: ");
        while (!char.TryParse(Console.ReadLine(), out x1_3))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s1_3 = new LB1();
        Console.WriteLine("Итог = " + s1_3.charToNum(x1_3));

        Console.WriteLine();
        // 5
        int x5;
        Console.Write("Введите целое число Х, чтобы узнать двузначное ли оно: ");
        while (!int.TryParse(Console.ReadLine(), out x5))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s5 = new LB1();
        bool rez5 = s5.is2Digits(x5);
        Console.WriteLine("Двузначное ли число? - " + rez5);

        Console.WriteLine();
        //7
        int a6, b6, num6;
        Console.Write("1 граница: ");
        while (!int.TryParse(Console.ReadLine(), out a6)) Console.Write("Ошибка! Введите целое число: ");

        Console.Write("2 граница: ");
        while (!int.TryParse(Console.ReadLine(), out b6)) Console.Write("Ошибка! Введите целое число: ");

        Console.Write("Сам номер: ");
        while (!int.TryParse(Console.ReadLine(), out num6)) Console.Write("Ошибка! Введите целое число: ");
        LB1 s7 = new LB1();
        Console.WriteLine("Входит ли число в рамки границ?: " + s7.isInRange(a6, b6, num6));

        Console.WriteLine();
        // 9
        int a9, b9, c9;
        LB1 s9 = new LB1();
        Console.WriteLine("Введите 3 целых числа, чтобы проверить равны ли они:");

        Console.Write("Число 1: ");
        while (!int.TryParse(Console.ReadLine(), out a9)) Console.Write("Ошибка! Введите целое число: ");

        Console.Write("Число 2: ");
        while (!int.TryParse(Console.ReadLine(), out b9)) Console.Write("Ошибка! Введите целое число: ");

        Console.Write("Число 3: ");
        while (!int.TryParse(Console.ReadLine(), out c9)) Console.Write("Ошибка! Введите целое число: ");

        Console.WriteLine(s9.isEqual(a9, b9, c9));

        Console.WriteLine();
        // ЗАДАНИЕ 2
        Console.WriteLine("ЗАДАНИЕ 2");

        //1
        int x2_1;
        Console.Write("Введите целое число, мы вернем его с +: ");
        while (!int.TryParse(Console.ReadLine(), out x2_1))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s2_1 = new LB1();
        Console.WriteLine("Итог = " + s2_1.abs(x2_1));

        Console.WriteLine();
        // 3
        int x2_3;
        Console.Write("Введите целое число(is35): ");
        while (!int.TryParse(Console.ReadLine(), out x2_3))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s2_3 = new LB1();
        Console.WriteLine(s2_3.is35(x2_3));
        
        Console.WriteLine();
        //5
        int x2_5, y2_5, z2_5;
        Console.WriteLine("Введите 3 целых числа, чтобы найти максимальное из них:");

        Console.Write("Число 1: ");
        while (!int.TryParse(Console.ReadLine(), out x2_5)) Console.Write("Ошибка! Введите целое число: ");

        Console.Write("Число 2: ");
        while (!int.TryParse(Console.ReadLine(), out y2_5)) Console.Write("Ошибка! Введите целое число: ");

        Console.Write("Число 3: ");
        while (!int.TryParse(Console.ReadLine(), out z2_5)) Console.Write("Ошибка! Введите целое число: ");
        LB1 s2_5 = new LB1();
        Console.WriteLine("Максимальное из 3-х = " + s2_5.max3(x2_5, y2_5, z2_5));

        Console.WriteLine();
        // 7
        int x2_7, y2_7;
        Console.WriteLine("Введите 2 целых числа, а мы посчитаем сумму:");
        Console.Write("Число 1: ");
        while (!int.TryParse(Console.ReadLine(), out x2_7)) Console.Write("Ошибка! Введите целое число: ");
        Console.Write("Число 2: ");
        while (!int.TryParse(Console.ReadLine(), out y2_7)) Console.Write("Ошибка! Введите целое число: ");
        LB1 s2_7 = new LB1();
        Console.WriteLine("Сумма чисел = " + s2_7.sum2(x2_7, y2_7));

        Console.WriteLine();
        //9
        int day9;
        Console.Write("Введи число дня недели:: ");
        while (!int.TryParse(Console.ReadLine(), out day9)) Console.Write("Ошибка! Введите целое число: ");
        LB1 s2_9 = new LB1();
        Console.WriteLine("День недели: " + s2_9.day(day9));

        Console.WriteLine();
        // ЗАДАНИЕ 3
        Console.WriteLine("ЗАДАНИЕ 3");
        // 1
        int x3_1;
        LB1 s3_1 = new LB1();
        Console.Write("Введите число и будет выведен массив от Х до 0: ");
        while (!int.TryParse(Console.ReadLine(), out x3_1))
            Console.Write("Ошибка! Введите корректное целое число: ");
        Console.WriteLine("Массив от Х до 0: " + (s3_1.reverseListNums(x3_1) + " 0"));

        Console.WriteLine();
        //3 
        int x3_3;
        Console.Write("До какого числа будем искать четные?: ");
        while (!int.TryParse(Console.ReadLine(), out x3_3))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s3_3 = new LB1();
        Console.WriteLine("Четные числа: " + s3_3.chet(x3_3));

        Console.WriteLine();
        // 5
        long x3_5;
        Console.Write("Введите число, чтобы посчитать кол-во знаков в нем: ");
        while (!long.TryParse(Console.ReadLine(), out x3_5))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s3_5 = new LB1();
        Console.WriteLine("Кол-во знаков в числе = " + s3_5.numLen(x3_5));

        Console.WriteLine();
        //7
        int x3_7;
        Console.Write("Введите Х = сторона квадрата. Построим квадрат из *: ");
        while (!int.TryParse(Console.ReadLine(), out x3_7))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s3_7 = new LB1();
        s3_7.square(x3_7);

        Console.WriteLine();
        // 9
        int x3_9;
        Console.Write("Введите Х = кол-ву символов в высоту треугольника: ");
        while (!int.TryParse(Console.ReadLine(), out x3_9))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s3_9 = new LB1();
        s3_9.rightTriangle(x3_9);

        Console.WriteLine();
        // ЗАДАНИЕ 4
        Console.WriteLine("ЗАДАНИЕ 4");

        Console.WriteLine();
        //1
        int nArr_1, x4_1;
        Console.Write("Поиск first вхождения. Введите длину массива: ");
        while (!int.TryParse(Console.ReadLine(), out nArr_1))
            Console.Write("Ошибка! Введите корректное целое число: ");

        int[] arr_1 = new int[nArr_1];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < nArr_1; i++)
        {
            Console.Write($"Элемент [{i}]: ");
            while (!int.TryParse(Console.ReadLine(), out arr_1[i]))
                Console.Write("Ошибка! Введите целое число: ");
        }
        Console.Write("Введите X: ");
        while (!int.TryParse(Console.ReadLine(), out x4_1))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s4_1 = new LB1();
        Console.WriteLine("Индекс первого вхождения числа Х = " + s4_1.findFirst(arr_1, x4_1));

        Console.WriteLine();
        // 3
        int nArr_3;
        Console.Write("Поиск max элемента. Введите длину массива: ");
        while (!int.TryParse(Console.ReadLine(), out nArr_3))
            Console.Write("Ошибка! Введите корректное целое число: ");

        int[] arr_3 = new int[nArr_3];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < nArr_3; i++)
        {
            Console.Write($"Элемент [{i}]: ");
            while (!int.TryParse(Console.ReadLine(), out arr_3[i]))
                Console.Write("Ошибка! Введите целое число: ");
        }
        LB1 s4_3 = new LB1();
        Console.WriteLine("Максимальный элемент массива по модулю = " + s4_3.maxAbs(arr_3));

        Console.WriteLine();
        //5
        int nArr_5, nIns_5, pos;
        Console.Write("Вставить другой массив на позицию. Введите длину массива arr: ");
        while (!int.TryParse(Console.ReadLine(), out nArr_5))
            Console.Write("Ошибка! Введите корректное целое число: ");

        int[] arr_5 = new int[nArr_5];
        Console.WriteLine("Введите элементы массива: ");
        for (int i = 0; i < nArr_5; i++)
        {
            Console.Write($"Элемент [{i}]: ");
            while (!int.TryParse(Console.ReadLine(), out arr_5[i]))
                Console.Write("Ошибка! Введите целое число: ");
        }

        Console.Write("Поиск max элемента. Введите длину массива Ins: ");
        while (!int.TryParse(Console.ReadLine(), out nIns_5))
            Console.Write("Ошибка! Введите корректное целое число: ");
        int[] Ins_5 = new int[nIns_5];
        Console.WriteLine("Введите элементы массива Ins: ");
        for (int i = 0; i < nIns_5; i++)
        {
            Console.Write($"Элемент [{i}]: ");
            while (!int.TryParse(Console.ReadLine(), out Ins_5[i]))
                Console.Write("Ошибка! Введите целое число: ");
        }

        Console.Write("Введите pos: ");
        while (!int.TryParse(Console.ReadLine(), out pos))
            Console.Write("Ошибка! Введите корректное целое число: ");

        LB1 s4_5 = new LB1();
        Console.WriteLine("Итоговый массив: " + string.Join(" ", s4_5.add(arr_5, Ins_5, pos)));


        Console.WriteLine();
        // 7
        int nArr_7;
        Console.Write("Введите длину массива: ");
        while (!int.TryParse(Console.ReadLine(), out nArr_7))
            Console.Write("Ошибка! Введите корректное целое число: ");

        int[] arr_7 = new int[nArr_7];
        Console.WriteLine("Введите элементы массива, а мы перевернем его: ");
        for (int i = 0; i < nArr_7; i++)
        {
            Console.Write($"Элемент [{i}]: ");
            while (!int.TryParse(Console.ReadLine(), out arr_7[i]))
                Console.Write("Ошибка! Введите целое число: ");
        }
        LB1 s4_7 = new LB1();
        Console.WriteLine("Перевернутый массив: " + string.Join(" ", s4_7.reverseBack(arr_7)));

        Console.WriteLine();
        //9
        int nArr_9, x4_9;
        Console.Write("Поиск всех индексов, где стоит число Х. Введите длину массива: ");
        while (!int.TryParse(Console.ReadLine(), out nArr_9))
            Console.Write("Ошибка! Введите корректное целое число: ");

        int[] arr_9 = new int[nArr_9];
        Console.WriteLine("Введите элементы массива, а мы перевернем его: ");
        for (int i = 0; i < nArr_9; i++)
        {
            Console.Write($"Элемент [{i}]: ");
            while (!int.TryParse(Console.ReadLine(), out arr_9[i]))
                Console.Write("Ошибка! Введите целое число: ");
        }

        Console.Write("Введите число. Найдем на каких местах стоит в массиве: ");
        while (!int.TryParse(Console.ReadLine(), out x4_9))
            Console.Write("Ошибка! Введите корректное целое число: ");
        LB1 s4_9 = new LB1();
        Console.WriteLine("На этих местах стоит: " + string.Join(" ", s4_9.findAll(arr_9, x4_9)));
    }
}
