// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
void PrintIn(string message)
{
    Console.WriteLine(message);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void EmptyMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i,j]=0;
            }
        
    }
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {for (int j = 0; j < arr.GetLength(1); j++)
    {
        if(arr[i,j]==0) Console.Write($"\t ");
        else Console.Write($"\t {arr[i,j]}");
    }
        Console.WriteLine();
    }
}

int hight=ReadInt("Введите высоту треугольника Паскаля");
int length=hight*2+1;
int[,] matrix=new int[hight,length];
EmptyMatrix(matrix);

matrix[0,hight+1]=1;
for (int i = 1; i < hight; i++)
    {for (int j = 1; j < length-1; j++)
    { if((matrix[i-1,j-1]!=0)||(matrix[i-1,j+1]!=0))
        matrix[i,j]=matrix[i-1,j-1]+matrix[i-1,j+1];
    }
        
    }
PrintMatrix(matrix);
PrintIn(" ");