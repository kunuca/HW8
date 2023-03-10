// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
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
int min=matrix[0,0];
int minhight=0;
int minLenght=0;
for (int i = 0; i < hight; i++)
    { for (int j = 0; j < length; j++)
        { if (min>matrix[i,j])
            {min=matrix[i,j];
             minhight=i;
             minLenght=j;
            }
            
        }  
        
    }
PrintIn($"i={minhight}, j={minLenght}, min={min}");

for (int i = 0; i < minhight; i++)
    { for (int j = 0; j < minLenght; j++)
        {
            newmatrix[i,j]=matrix[i,j];
        }
    }

for (int i = 0; i < minhight; i++)
    { for (int j = minLenght; j < length-1; j++)
        {
            newmatrix[i,j]=matrix[i,j+1];
        }
    }

for (int i = minhight; i < hight-1; i++)
    { for (int j = 0; j < minLenght; j++)
        {
            newmatrix[i,j]=matrix[i+1,j];
        }
    }

for (int i = minhight; i < hight-1; i++)
    { for (int j = minLenght; j < length-1; j++)
        {
            newmatrix[i,j]=matrix[i+1,j+1];
        }
    }
PrintMatrix(newmatrix);