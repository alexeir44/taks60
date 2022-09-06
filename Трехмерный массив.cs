int CorrectInput()
{
    string? UserNumber;
    int number = 0;
    bool check = false;
    while (check == false)
    {
        UserNumber = Console.ReadLine();
        if (int.TryParse(UserNumber, out number))
        {
            check = true;
        }
        else
        {
            Console.Write("Ошибка ввода.\n Повторите ввод:");
        }
    }
    return number;
}

// создание трехмерного массива
/*int[,,]*/
void CreateArray()
{
    Console.WriteLine("Введите размеры массива:");
    Console.Write("Введите количество элементов по оси x: ");
    int x = CorrectInput();
    Console.Write("Введите количество элементов по оси y: ");
    int y = CorrectInput();
    Console.Write("Введите количество элементов по оси z: ");
    int z = CorrectInput();
    int box;
    bool check = false;
    int[,,] matrix = new int[x, y, z];
    if (x*y*z <= 0 || x*y*z>90)
        {
            Console.WriteLine("Недопустимые входные данные.");
            //return matrix;
        }
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                while (check == false)
                {
                    box = new Random().Next(10,100);
                    if (CheckElementMatrix(matrix, box, i))
                    {
                        matrix[i,j,k] = box;
                        check = true;            
                    }                    
                }
                check = false;
            }
        }
    }
    PrintMatrix(matrix);
    //return matrix;
}

// Вывод трехмерного массива
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i<matrix.GetLength(0); i++)
    {
        for (int j = 0; j<matrix.GetLength(1); j++)
        {
            for (int k = 0; k<matrix.GetLength(2); k++)
                Console.Write($"{matrix[i,j,k]} ({i},{j},{k}) ");                        
        Console.WriteLine();
        }
    }
}

// Проверка на повтор
bool CheckElementMatrix(int[,,] matrix, int rndnum, int x)
{
    for (int i = 0; i < x+1; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (matrix[i,j,k]==rndnum)
                {
                    return false;
                }
            }       
        }
    }
    return true;
}

//Код программы
/*int[,,] matrix =*/ 
CreateArray();