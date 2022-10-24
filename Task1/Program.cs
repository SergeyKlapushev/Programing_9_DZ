/* Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. Разделить ввод данных, от расчета данных (Одна функция вводит данные, другая функция подсчитывает количество положительных)

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Messager("Введите количество чисел которые вы хотите ввести (не больше 8 и не меньше 0): ");

//Получаем сообщение что надо ввести кол-во цифр
void Messager(string message)
{
    Console.Write(message);
    InputCountNumbers();
}

//Вводим кол-во цифр 
void InputCountNumbers()
{
    int len = Convert.ToInt32(Console.ReadLine());

    if (len > 8 || len <=0)
    {
        Messager("Число не может быть больше 8, меньше 0 и равно 0! Введите ещё раз: ");
    }
    else {InputNumbers(len);}
}

//Вводим числа
void InputNumbers (int len)
{
    double [] array = new double[len];

    for (int i = 0; i < len; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    CountingPositiveIntegers(array);
}

//Считаем кол-во чисел больше 0 
void CountingPositiveIntegers(double[] array)
{  
    int positive_numbers = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]>0)
        {
            positive_numbers++;
        }
    }
    Result(array, positive_numbers);
}

//Получаем ответ
void Result(double[] array, int positive_numbers)
{
     for (int i = 0; i < array.Length; i++)
     {
        Console.Write($"[{array[i]}] ");
     }
     Console.Write($"-> {positive_numbers} ");
}