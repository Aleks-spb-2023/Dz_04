/* напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int PowNunder(int a, int b)
{
    int result = 1;
    for(int i = 0; i != b; i++)
    {
        result = result * a;
    
    }
    return result;
    
}
Console.WriteLine("Введите число А ");
int User_A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int User_B = Convert.ToInt32(Console.ReadLine());
int Quadro = PowNunder(User_A, User_B);
Console.WriteLine(Quadro);



