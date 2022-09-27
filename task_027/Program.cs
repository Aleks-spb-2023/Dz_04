 /*Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int Summ_digit(int num)
{
    int result = 0;
    while(num > 0)
    {
        int last_digit = num % 10;
        result += last_digit;
        num /= 10;
    }
    return result;
}
Console.WriteLine("Введите число ");
int user_num = Convert.ToInt32(Console.ReadLine());
int Summ = Summ_digit(user_num);
Console.WriteLine($"Сумма цифр числа {user_num} равна -> {Summ} ");
