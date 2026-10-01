Решетникова Полина ЛА-1 Лабораторная №1
# Задание 1
## Задача 1
### Текст задачи
Дробная часть.
Дана сигнатура метода: public double fraction (double x);
Необходимо реализовать метод таким образом, чтобы он возвращал только
дробную часть числа х. Подсказка: вещественное число может быть
преобразовано к целому путем отбрасывания дробной части.

### Алгоритм решения
Получить вещественное число x. Преобразовать его к целому типу — при этом дробная часть отбрасывается. Вычесть из исходного числа x полученное целое. Разность и есть дробная часть числа x. Вернуть результат.

### Тестирование
![](https://sun9-58.vkuserphoto.ru/s/v1/ig2/An8bWftuyWhWTukDLX-hcVPz2b3CdrOqyjLtWjfXTJQgW8sPfAx8CjqWql8pD5UhlaA4f9UDEpuicSH6Osj06Tsz.jpg?quality=95&as=32x6,48x9,72x14,108x20,160x30,240x45,360x68,439x83&from=bu&u=654PzuUZF_iZlbwqy9hOrUbiHwQfRn56RX6wipbTato&cs=439x0)

## Задача 3
### Текст задачи
Букву в число. 
Дана сигнатура метода: public int charToNum (char x);
Метод принимает символ х, который представляет собой один из “0 1 2 3 4 5 6 7 8 9”. Необходимо реализовать метод таким образом, чтобы он преобразовывал символ в соответствующее число. Подсказка: код символа ‘0’ — это число 48.

### Алгоритм решения
Получить символ x. Вычислить разность между кодом символа x и кодом символа '0'. Присвоить полученное значение переменной result. Вернуть result.

### Тестирование
![](https://sun9-5.vkuserphoto.ru/s/v1/ig2/Z_H36fIzaK3ghJJDvhE4BL1v5E1pX1jlrGtUWUUSRzeXQujc1YIxwxflriPu4jpku8WxGQnUbswLdPI8YVWMC81r.jpg?quality=95&as=32x3,48x5,72x8,108x11,160x17,240x25,360x38,480x50,540x56,575x60&from=bu&u=DB7yIp23eApTyIzCwd7Y5X_wuhncr42OBRHm7pn59g8&cs=575x0)
![](https://sun9-34.vkuserphoto.ru/s/v1/ig2/EMbmf2fUTU7MMYkybroUK9vFStt-d-Lf3NmVh7UpgFjo7z5HIZPS2FjXCkHt0mI4uCtPsRCKHv9QDjYadqQ7hGiY.jpg?quality=95&as=32x7,48x10,72x15,108x23,160x33,240x50,360x75,480x100,540x113,580x121&from=bu&u=5VZQGrTXIf0vtKBLGYEzui3Zyb5qCUn8gXUOs_ZIiSQ&cs=580x0)

## Задача 5
### Текст задачи
Двузначное.
Дана сигнатура метода: public bool is2Digits (int x);
Необходимо реализовать метод таким образом, чтобы он принимал число x и возвращал true, если оно двузначное.

### Алгоритм решения
Получить целое число x. Проверить два условия одновременно: число больше 9 и число меньше 100. Если оба условия выполняются — вернуть true, иначе вернуть false.

### Тестирование
![](https://sun9-3.vkuserphoto.ru/s/v1/ig2/nQVJjO1du0GqRQtfkYQXZX7RiSVhQvLIkAr9GA_S6pOiLUy9FZR5tT9FxcUnxWacEf1Gs-F2PsxauvyEvMyqibkL.jpg?quality=95&as=32x3,48x5,72x7,108x11,160x16,240x24,360x36,480x48,529x53&from=bu&u=Fvpyzwws6QlRRzQ2DTWmwre1p6fp0OlINWNhbYX5Jn8&cs=529x0)
![](https://sun9-79.vkuserphoto.ru/s/v1/ig2/KO0W7ld1tXSuF_OR3qOHr_SK7XTqkYPhxzyhkmjqmL4DIIuAs6WYj6HIRGQQf13qBcujZmSXsgG9WYToMwRVadqN.jpg?quality=95&as=32x3,48x5,72x7,108x10,160x15,240x23,360x35,480x46,540x52,581x56&from=bu&u=MOQoQaNPV7SRuq6OKjMzcPbbZVNGFnqwRoViKQyCjUY&cs=581x0)

## Задача 7
### Текст задачи
Диапазон.
Дана сигнатура метода: public bool isInRange (int a, int b, int num);
Метод принимает левую и правую границу (a и b) некоторого числового диапазона. Необходимо реализовать метод таким образом, чтобы он возвращал true, если num входит в указанный диапазон (включая границы). Обратите внимание, что отношение a и b заранее неизвестно (неясно кто из них больше, а кто меньше).

### Алгоритм решения
Получить два числа — границы диапазона. Получить третье число, которое нужно проверить. Сравнить между собой две границы. Определить, какая из них меньше, а какая больше. Проверить, что проверяемое число не меньше меньшей границы и не больше большей границы. Если оба условия выполняются, вернуть истину. Иначе вернуть ложь.

### Тестирование
![](https://sun9-35.vkuserphoto.ru/s/v1/ig2/JktgpLgh7r06M8gH-bYywyrAHIduaYdwqDkfso-fF4JsgiTL6PSTeeTFGsOtAxUhO4TaT_KMQYVs88YFpcdW2IwW.jpg?quality=95&as=32x14,48x21,72x31,108x47,160x69,240x104,360x156,373x162&from=bu&u=xVS1LeVJqBNw4vypGJH97rKAZtfqysAvGEq2Lfga8Zk&cs=373x0)
![](https://sun9-82.vkuserphoto.ru/s/v1/ig2/ajhAtzJtwwPdMr5JWQIKyHbvTxJxr0_hMlY4nMvnpuYGrTYhre6uZ80rwwzOsNodD7gi8UaClTWVG716G5BN6lbz.jpg?quality=95&as=32x9,48x13,72x20,108x29,160x44,240x66,355x97&from=bu&u=-TZr3Vus1zE9g_mbrRJv9FjiRxZ0M4tkJdPuc1IaXY4&cs=355x0)

## Задача 9
### Текст задачи
Равенство.
Дана сигнатура метода: public bool isEqual(int a, int b, int c);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если
все три полученных методом числа равны

### Алгоритм решения
Получить три целых числа a, b, c. Сравнить первое число со вторым, а третье — с первым. Если оба сравнения истинны — все три числа равны, вернуть true. Иначе вернуть false.

### Тестирование
![](https://sun9-11.vkuserphoto.ru/s/v1/ig2/Tv7GUG5FqkaFARsvLyE6PLeFeyiJsN1fSxwG_YSuj7ETQldXV0Lzq4Xkr-PBOlwRqCiZpdK6ijZm4Th5gOhkb_zC.jpg?quality=95&as=32x8,48x11,72x17,108x25,160x38,240x56,360x85,480x113,485x114&from=bu&u=-OlFQuxCuQ75b4qhWNiP4d-YsNiqHmPS5ZCZqJwOQaY&cs=485x0)
![](https://sun9-2.vkuserphoto.ru/s/v1/ig2/yF90HHpzrtaGW-ewRuZDD4EvNjvH1Jy1AxxaLXDw1fTAI_Ax_GJtkU4W087Bl3WpIh4S82YR616jkeYSAuGgvcf3.jpg?quality=95&as=32x8,48x12,72x18,108x27,160x40,240x60,360x90,480x120,481x120&from=bu&u=k0pWrgmwP3R5VIRNfnCCkyHiOOLLEL6T6_nkAsV6Nyc&cs=481x0)
![](https://sun9-67.vkuserphoto.ru/s/v1/ig2/eLYWgDVUQsWo38YGh078Pg6O6JOkctIxN7ZfpnZjzwZSHJwLHjjaNpowYbfDX2Jrm-fifAmRzux-ty0WVqCKc5MZ.jpg?quality=95&as=32x9,48x14,72x20,108x30,160x45,240x68,360x101,480x135,497x140&from=bu&u=T4nozF73xsTARFJ-26zzpO4Mm6zvHUP2lmxCOqj_xo8&cs=497x0)

# Задание 2

## Задача 1
### Текст задачи
Модуль числа.
Дана сигнатура метода: public int abs (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал модуль
числа х (если оно было положительным, то таким и остается, если он было
отрицательным – то необходимо вернуть его без знака минус).

### Алгоритм решения
Получить целое число x. Проверить: если x меньше нуля, вернуть его с противоположным знаком (-x). Иначе вернуть x без изменений.

### Тестирование
![](https://sun9-49.vkuserphoto.ru/s/v1/ig2/KWQxmB7P1m_20mDAxnBYMunfgNSplrhOidVyjGtKJThlj0wE5xHk-179karXs-M5Rs_UynZmyb57VPuqwV-oojTX.jpg?quality=95&as=32x4,48x6,72x10,108x14,160x21,240x32,360x48,410x55&from=bu&u=6B5DZ316grFVRqTQkiPqOtU5tMXrGFwVw0FcKgfBhPQ&cs=410x0)
![](https://sun9-74.vkuserphoto.ru/s/v1/ig2/s7cKtKcsI-9TV1NlkCvvKluFJ8Wqdi5BCC9rlns8J6ecLgzNdOjbiXUMiBTMLT8bA5fTTyGFHe7knIAE3djU4yqb.jpg?quality=95&as=32x6,48x9,72x13,108x20,160x29,240x44,360x65,435x79&from=bu&cs=435x0)

## Задача 3
### Текст задачи
Тридцать пять.
Дана сигнатура метода: public bool is35 (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал true, если
число x делится нацело на 3 или 5. При этом, если оно делится и на 3, и на 5, то
вернуть надо false. Подсказка: оператор % позволяет получить остаток от
деления.

### Алгоритм решения
Получить целое число x. Проверить: делится ли x на 3 без остатка и при этом не делится на 5 — тогда вернуть true. Иначе проверить обратное: не делится на 3, но делится на 5 — тоже вернуть true. Во всех остальных случаях вернуть false.

### Тестирование
![](https://sun9-11.vkuserphoto.ru/s/v1/ig2/9hpxVvnCQc-lV88xJNoNlaIDCHtfAVOE8kzD339D_wjxMA_UuG8A9c61n_WbLF4oq_FDRA7LKm9vvZSK2ovKCVFw.jpg?quality=95&as=32x7,48x10,72x15,108x22,160x33,240x50,276x57&from=bu&u=eGP2VwOcZUX6Sb5MO4wGJq5bZ5g-v04uue95vk-Vjf4&cs=276x0)
![](https://sun9-25.vkuserphoto.ru/s/v1/ig2/8997yHq18PpqLhiaeg7TYcsZ6j2krrp7K2uydsg87Pvms71fnvZlDa9bm6mmsVWKg6IYVOBsugi7Lnk_57TxpjWZ.jpg?quality=95&as=32x7,48x11,72x17,108x25,160x37,240x55,283x65&from=bu&cs=283x0)
![](https://sun9-60.vkuserphoto.ru/s/v1/ig2/ejjNs23dY005khclpgUD_Gl2n6BUxTwcqFW3bHWJDziT4ld-od8GqCFYTttG0Nc17aoAgDr22VRa57Qo4tiKCHQw.jpg?quality=95&as=32x7,48x10,72x15,108x22,160x33,240x50,280x58&from=bu&cs=280x0)
![](https://sun9-6.vkuserphoto.ru/s/v1/ig2/kLEYN_aYEl7b-y8IV5sReNr-26YelVX5px474GveaGM7e1Iw7H2zOj--yHwiK_PcYX5ZcJaW2DEQpCfo6y3NHGRO.jpg?quality=95&as=32x6,48x8,72x13,108x19,160x28,240x42,359x63&from=bu&u=PAQg-a-nc6W5AlGNX5izkrrL0j3eMyTL6o-K3LJ_U1g&cs=359x0)

## Задача 5
### Текст задачи
Тройной максимум.
Дана сигнатура метода: public int max3 (int x, int y, int z);
Необходимо реализовать метод таким образом, чтобы он возвращал
максимальное из трех полученных методом чисел. Подсказка: идеальное
решение включает всего две инструкции if и не содержит вложенных if.

### Алгоритм решения
Получить три целых числа x, y, z. Сравнить y с x: если y больше, заменить x значением y. Затем сравнить z с x: если z больше, заменить x значением z. В итоге в x окажется максимум. Вернуть x.

### Тестирование
![](https://sun9-68.vkuserphoto.ru/s/v1/ig2/npzVNwqT_VbjIPClYxyBJUu1Wc7CWlt68wcKjqRgRpJRPvVvBraHkIhgLA8VDJDuCwNEp6n57KsdrzXoNaWCTDiI.jpg?quality=95&as=32x12,48x18,72x27,108x40,160x60,240x89,360x134,480x179,499x186&from=bu&u=UDU0gtKW2z-J6WHKFIgzJ2i3AwDgEJDG8J4VS3U3GyM&cs=499x0)
![](https://sun9-38.vkuserphoto.ru/s/v1/ig2/8RtnwU1QZRrlTywDiKE8SKtwPc8MTX4sjANydBinKVCzbIFXqjOKFXGNtoFMB6CNjk2DN-quAoL53YQGRThkDMe0.jpg?quality=95&as=32x7,48x10,72x16,108x23,160x35,240x52,360x78,480x104,512x111&from=bu&cs=512x0)

## Задача 7
### Текст задачи
Двойная сумма.
Дана сигнатура метода: public int sum2 (int x, int y);
Необходимо реализовать метод таким образом, чтобы он возвращал сумму
чисел x и y. Однако, если сумма попадает в диапазон от 10 до 19, то надо вернуть
число 20.

### Алгоритм решения
Получить два целых числа x, y. Вычислить их сумму. Проверить: если сумма больше 9 и меньше 20 — вернуть число 20. Иначе вернуть саму сумму.

### Тестирование
![](https://sun9-16.vkuserphoto.ru/s/v1/ig2/z7VdlSIRVzO0z-hBUiA7cD6mquqbXYN2DpyB9iy88wbfyYGo0vy_QXKs-SZB_9FH7sT0y9A7qw_OZdyBEnR74T3s.jpg?quality=95&as=32x8,48x12,72x18,108x27,160x40,240x60,360x90,417x104&from=bu&u=_LPa7eHdPqrgZLEGZsFjb46m-ulEMd2HNAd8QewHLZs&cs=417x0)
![](https://sun9-39.vkuserphoto.ru/s/v1/ig2/rnu7d_51hs9Y4A8Bv3cDOQVLCMo23cXHPrjw8JZPDfnheD2ddHu8GT4ILBZmwm2lzjqiC9ihwmTu9KwVvPtbBaBA.jpg?quality=95&as=32x10,48x15,72x22,108x33,160x48,240x73,360x109,443x134&from=bu&cs=443x0)

## Задача 9
### Текст задачи
День недели.
Дана сигнатура метода: public String day (int x);
Метод принимает число x, обозначающее день недели. Необходимо реализовать
метод таким образом, чтобы он возвращал строку, которая будет обозначать
текущий день недели, где 1- это понедельник, а 7 – воскресенье. Если число не
от 1 до 7 то верните текст “это не день недели”. Вместо if в данной задаче
используйте switch. 

### Алгоритм решения
Получить целое число x — номер дня недели. С помощью конструкции switch проверить значение: 1 → «понедельник», 2 → «вторник», …, 7 → «воскресенье». Если число не входит в 1..7 — вернуть «это не день недели».

### Тестирование
![](https://sun9-38.vkuserphoto.ru/s/v1/ig2/kJJaex6diiFU9n9p6PuJsJ0h0tJl-nOjHw62tayZbf_UlhyGsj2K_OAjWz24E5GV6MGCleMHHsmOLCuJfiyLZk_A.jpg?quality=95&as=32x6,48x9,72x14,108x21,160x31,240x46,256x49&from=bu&u=5ri8dcd_SYElidt6Sv9eMrepCIaWZS4oZBw4S63-RI0&cs=256x0)
![](https://sun9-68.vkuserphoto.ru/s/v1/ig2/guunXa8nC-Lk8u6HT8WGaM6ugo07qvHceIXoC5kUwvrZvI1wfNe82QD5oIVEK4YSFfEv7cGNAtsAK3NlxOzCnYob.jpg?quality=95&as=32x7,48x10,72x15,108x23,160x34,240x51,300x64&from=bu&cs=300x0)

# Задание 3

## Задача 1
### Текст задачи
Числа подряд.
Дана сигнатура метода: public String listNums (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в
которой будут записаны все числа от 0 до x (включительно).


### Алгоритм решения
Получить целое число x. Создать массив строк размером x. Счётчиком j пройти с 0 до x-1, а счётчиком i — от x вниз до 1. На каждой итерации записать в nums[j] число i и увеличить j. Объединить элементы массива через пробел с помощью string.Join и вернуть строку.
### Тестирование
![](https://sun9-52.vkuserphoto.ru/s/v1/ig2/wYa6fOivXnk6b8aAzDOWUXkOYoNIEmY5DkuhdAsomdSaNsJTRJ2kISnCs0ZFZBIS9UXFxHG5iFfn6pajaActd5MG.jpg?quality=95&as=32x3,48x5,72x8,108x12,160x17,240x26,360x39,456x49&from=bu&u=0CpWkYpEYu19gmeyzG4g-EF45ZWCl3BcKcK51EugwJs&cs=456x0)

## Задача 3
### Текст задачи
Четные числа.
Дана сигнатура метода: public String chet (int x);
Необходимо реализовать метод таким образом, чтобы он возвращал строку, в
которой будут записаны все четные числа от 0 до x (включительно). Подсказа
для обеспечения качества кода: инструкцию if использовать не следует.

### Алгоритм решения
Получить целое число x. Создать пустую строку результата. В цикле от 0 до x с шагом 2 добавлять текущее значение и пробел в строку. Вернуть строку.

### Тестирование
![](https://sun9-83.vkuserphoto.ru/s/v1/ig2/TqpR3Htl4mQEycJks2hOm972cpUL5CE8io-DS3KNTavtU8lXs2n8bZ1c5OEnV2mBbyxHZQ30w7G6Xfqm-FqY2K9T.jpg?quality=95&as=32x6,48x10,72x14,108x22,160x32,240x48,360x73,417x84&from=bu&u=Gk1hFQJsvYkivVbTB9szpftbKw2-TZysg9taf9o7G0w&cs=417x0)

## Задача 5
### Текст задачи
Длина числа.
Дана сигнатура метода: public int numLen (long x);
Необходимо реализовать метод таким образом, чтобы он возвращал количество
знаков в числе x. 

### Алгоритм решения
Получить целое число x типа long. Преобразовать его в строку с помощью ToString(). Вернуть длину этой строки.

### Тестирование
![](https://sun9-43.vkuserphoto.ru/s/v1/ig2/Kx1GSwyF7T3MLO1hLq7_pqy7Ak1T1m5MbOvTP0WZxDyqfmpGYwgV6rx0JLoKRtPFl6hnINqxFCj5KwURVIRu_fOE.jpg?quality=95&as=32x5,48x7,72x10,108x16,160x23,240x35,360x52,480x70,504x73&from=bu&u=kCFgGQ5f62LYS2WVHMKLRGZ5XN83ZjHUhcB9a3Hc9Ms&cs=504x0)

## Задача 7
### Текст задачи
Квадрат.
Дана сигнатура метода: public void square (int x);
Необходимо реализовать метод таким образом, чтобы он выводил на экран
квадрат из символов ‘*’ размером х, у которого х символов в ряд и х символов в
высоту. 

### Алгоритм решения
Получить целое число x — сторону квадрата. Собрать строку из x символов '*'. Вывести эту строку x раз с помощью цикла — получится квадрат.

### Тестирование
![](https://sun9-27.vkuserphoto.ru/s/v1/ig2/yCa73TMM3gxOxOgg3KHJeaiMhJzc1XvhwZx1LzA5YlfK9X-bF3yXxr7n0f8vL2ZeRaQWlQkMP1r1I6-9t9QH1Y-Y.jpg?quality=95&as=32x11,48x16,72x24,108x36,160x53,240x79,360x118,480x158,517x170&from=bu&u=9CGVEc6Ez_oyVDGk9V1tZn0V7r3tH-zAdYouAkVFLhk&cs=517x0)

## Задача 9
### Текст задачи
Правый треугольник.
Дана сигнатура метода: public void rightTriangle (int x);
Необходимо реализовать метод таким образом, чтобы он выводил на экран
треугольник из символов ‘*’ у которого х символов в высоту, а количество
символов в ряду совпадает с номером строки, при этом треугольник выровнен
по правому краю. Подсказка: перед символами ‘*’ следует выводить
необходимое количество пробелов.

### Алгоритм решения
Получить целое число x — высоту треугольника. В цикле от 1 до x построить строку: сначала (x - i) пробелов, затем i звёздочек. Вывести каждую строку — получится прямоугольный треугольник.
### Тестирование
![](https://sun9-71.vkuserphoto.ru/s/v1/ig2/4A4acOohRujb52OlRNbtbiE4mSeWKTJJKqoRWRO-nitNkewu74_Wkad7FvSDl4KXiO5gpm23p4varKLypcjvN81l.jpg?quality=95&as=32x12,48x18,72x28,108x41,160x61,240x92,360x138,480x184,486x186&from=bu&u=8CTkikIQRJIY-j9BI4cS-NLD-08Ag6hY_C7b4T4FPVM&cs=486x0)

# Задание 4

## Задача 1
### Текст задачи
Поиск первого значения.
Дана сигнатура метода: public int findFirst (int[] arr, int x);
Необходимо реализовать метод таким образом, чтобы он возвращал индекс
первого вхождения числа x в массив arr. Если число не входит в массив –
возвращается -1.
### Алгоритм решения
Получить массив целых чисел и искомое число x. Пройти по массиву слева направо. Если текущий элемент равен x — вернуть его индекс. Если цикл завершился и совпадений не было — вернуть -1.

### Тестирование
![](https://sun9-4.vkuserphoto.ru/s/v1/ig2/Qnug8_9otNXHdfL-1OGcioXOuWLln36CTSexTUs_7s91AIRPcwnl4phqPR0DAZJoSuVW_MWB60q6lsRhC8kvutgo.jpg?quality=95&as=32x17,48x26,72x39,108x59,160x87,240x131,360x197,430x235&from=bu&u=qt3nWA-i7Xa-nFIcbNLyIibMFA7w5-Dr5F9EDY2X5M8&cs=430x0)

## Задача 3
### Текст задачи
Поиск максимального.
Дана сигнатура метода: public int maxAbs (int[] arr);
Необходимо реализовать метод таким образом, чтобы он возвращал
наибольшее по модулю (то есть без учета знака) значение массива arr.

### Алгоритм решения
Получить массив целых чисел. Завести переменную max_num = -1. Пройти по массиву: для каждого элемента взять его модуль, сравнить с текущим max_num и записать большее. Вернуть max_num.

### Тестирование
![](https://sun9-29.vkuserphoto.ru/s/v1/ig2/IUkWF_aZMDtuSy6q9y_IXlkY75uewyMV6hrFPLftDwmFJQXwM0DOKj03Y4VqKaHwzMF4ayQsMhiZoQt-8sFHvfhu.jpg?quality=95&as=32x16,48x24,72x37,108x55,160x81,240x122,360x183,467x237&from=bu&u=4WP1sGYdhzo8iKE4sW5YE7Tj8iledQm0yok_MtskVxU&cs=467x0)

## Задача 5
### Текст задачи
Добавление массива в массив.
Дана сигнатура метода: public int[] add (int[] arr, int[] ins, int pos);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, который будет содержать все элементы массива arr, однако в позицию
pos будут вставлены значения массива ins.

### Алгоритм решения
Получить два массива arr и ins, а также позицию pos. Если pos меньше 0 — сделать его 0. Если pos больше длины arr — сделать его длиной arr. Создать новый массив длиной arr.Length + ins.Length. Скопировать элементы arr до pos, затем вставить все элементы ins, затем скопировать оставшиеся элементы arr. Вернуть новый массив.

### Тестирование
![](https://sun9-1.vkuserphoto.ru/s/v1/ig2/gj-IZWvNVabLXEl2qZSXdFbg0M-jKcm_DCYEV9l9-ZQPle4Nxt_ApX6SSgihiyiTQ9hEZK6iCs3fLDVhAehWLIlt.jpg?quality=95&as=32x15,48x22,72x33,108x49,160x73,240x109,360x164,480x218,540x246,578x263&from=bu&u=ff6Qt1K7rQjAUWeaG6KqHoBueAFa1DPmJEss24vSv4s&cs=578x0)

## Задача 7
### Текст задачи
Возвратный реверс.
Дана сигнатура метода: public int[] reverseBack (int[] arr);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, в котором значения массива arr записаны задом наперед.

### Алгоритм решения
Получить массив. Пройти циклом до середины массива (arr.Length / 2). На каждой итерации поменять местами элемент i и элемент (arr.Length - 1 - i). Вернуть изменённый массив.

### Тестирование
![](https://sun9-18.vkuserphoto.ru/s/v1/ig2/kRAiGtKpjDZduYV1wP1TsSBS7r2kTLBULKMyGzrrfPR-ox6qZWvMIljVjqCYWhid_jT4D7Uqbi0QPcr_UtFPGs7X.jpg?quality=95&as=32x14,48x20,72x30,108x46,160x68,240x102,360x152,430x182&from=bu&u=0GkW6pU8owSZCHYssCrTmUQb47PkDB_B-5w_-6dOtwA&cs=430x0)
## Задача 9
### Текст задачи
Все вхождения.
Дана сигнатура метода: public int[] findAll (int[] arr, int x);
Необходимо реализовать метод таким образом, чтобы он возвращал новый
массив, в котором записаны индексы всех вхождений числа x в массив arr.

### Алгоритм решения
Получить массив и число x. Первым проходом посчитать, сколько раз x встречается в массиве. Создать массив индексов нужного размера. Вторым проходом записать в него индексы всех вхождений x. Вернуть массив индексов.

### Тестирование
![](https://sun9-35.vkuserphoto.ru/s/v1/ig2/Nr5iYt6C6Sv3bwILQrQTUSu3BH1l4-lqEbLzl8QgW16g4KILskdftsU3IR2YcQz4i6Ks_KoJaeRUfVXTgWLsgYwu.jpg?quality=95&as=32x12,48x17,72x26,108x39,160x58,240x87,360x130,480x173,540x195,598x216&from=bu&u=d4F7dQENuw2XN6pdzimrSvd3ZaNvON0TRk6egXkjDmU&cs=598x0)
