//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
Console.Clear();
Console.Write("Введите количество элементов массива = ");
int m;
int n = Convert.ToInt32(Console.ReadLine());
void FillArray(string[] array) // Метод заполнения исходного массива
{
    for (int i = 0; i < n; i++)
        { 
            array[i] = Convert.ToString(Console.ReadLine());
            
        }
}
void PrintArray(string[] array)// Метод печати массивов
{
    if (array.Length==0)
        {
            Console.Write($" [] ");
        }
    else
        {   
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
                {
                    if (i<array.Length-1)
                        {
                            Console.Write($" '{array[i]}', ");
                        }
                    else
                        {Console.Write($" '{array[i]}' ");}
                }
                    Console.Write("]");
                    Console.WriteLine();
        }
}
void Count(string[] array1)// Метод подсчета количества строк в исхоном массиве с длинной <= 3 символа 
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
           count++;
        }
    }
m = count;
}    