// Найти произведение двух матриц 
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
                arr[i,j]=new Random().Next(0,10);
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


int lenght1=ReadInt("Введите ширину первой матрицы");
int hight1=ReadInt("Введите высоту первой матрицы");
int lenght2=ReadInt("Введите ширину второй матрицы");
int hight2=ReadInt("Введите высоту второй матрицы");
int[,] matrix1=new int[hight1,lenght1];
int[,] matrix2=new int[hight2,lenght2];
if(lenght1==hight2) 
{   int[,] multiMatrix=new int[hight1,lenght2];
    FillMatrix(matrix1);
    PrintMatrix(matrix1);
    PrintIn("");
    FillMatrix(matrix2);
    PrintMatrix(matrix2);
    Console.WriteLine();
    for (int i = 0; i < hight1; i++)
        { for (int j = 0; j < lenght2; j++)
            {multiMatrix[i,j]=0;
             for (int k = 1; k < lenght1; k++)
                   multiMatrix[i,j] =  multiMatrix[i,j]+ matrix1[i,k] * matrix2[k,j];
                      
            
                        }
            
        }
    PrintMatrix(multiMatrix);
    }
else  PrintIn("Умножение матриц не возможно");