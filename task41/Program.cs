// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Сколько чисел вы хотите ввести : ");
int num = Convert.ToInt32(Console.ReadLine());
int [] array = new int[num];
int[] amountNumbers = AmountNumbers(array);
PrintArray(amountNumbers);
int countNumbersMorezero = CountNumbersMorezero(amountNumbers);
Console.WriteLine($"количество значений больше 0 = {countNumbersMorezero}");
int [] AmountNumbers(int[] number)
{
    for (int i = 0; i < num; i++)
    {
    Console.Write("Введите число : ");
    int  number1 = Convert.ToInt32(Console.ReadLine());
    array[i] = number1;
    }
    return array;
}
int CountNumbersMorezero(int[] number1)
{
    int count = 0;
    for (int i = 0; i < num; i++)
    {
        if (number1[i] > 0)
        {
            count++;
        } 
    }
    return count;
}
void PrintArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}



