// Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

int ReadInt(string message)
{
    Console.WriteLine(message);
    return int.Parse(Console.ReadLine()!);
}

void FillMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
            {for (int k = 0; k < arr.GetLength(2); k++)
                {bool count=false;
                int random=new Random().Next(10,100);
                        {for (int l = 0; l < i; l++)
                            {for (int m = 0; m < j; m++)
                                {for (int n = 0; n < k; n++)
                                    {if (arr[l,m,n]==random)
                                    {
                                        count=true;
                                        break;
                                    } 
                                        
                                        
                                        
                                    }
                                    
                                }
                                
                            }
                        }
                if(!count)
                {arr[i,j,k]=random;
                
                }
                }
                
            }

        }
}

void PrintMatrix(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
        {for (int j = 0; j < arr.GetLength(1); j++)
            {for (int k = 0; k < arr.GetLength(2); k++)
                    {Console.Write($"\t {arr[i,j,k]}");
                        
                    }
            Console.WriteLine();
            }
        Console.WriteLine();
        }
}

int level=ReadInt("Введите уровень матрицы");
int height=ReadInt("Введите высоту матрицы");
int length=ReadInt("Введите длину матрицы");
Console.WriteLine();

int[,,] matrix=new int[level,height,length];

FillMatrix(matrix);
PrintMatrix(matrix);

  
