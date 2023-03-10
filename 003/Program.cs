// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
void PrintIn(string message)
{
    Console.WriteLine(message);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j]=new Random().Next(1,100);
            }
        
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"\t {arr[i,j]}");
    }
        Console.WriteLine();
    }
}

int hight=ReadInt("Введите высоту матрицы");
int length=ReadInt("Введите ширину матрицы");
int[,] matrix=new int[hight,length];
int[,] newmatrix=new int[hight-1, length-1];
FillMatrix(matrix);
PrintMatrix(matrix);
PrintIn(" ");