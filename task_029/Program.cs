Console.WriteLine("Введите размер массива");
int size = Convert.ToInt16(Console.ReadLine());
int [] numbers = new int [size];
Console.Write("[");
for(int i = 0; i < numbers.Length - 1 ; i++)
{
    numbers[i] = new Random().Next(10,100);
    Console.Write(numbers[i] + " ,");
    
}
 Console.Write(numbers[numbers.Length -1]);
 Console.WriteLine("]"); 

 
