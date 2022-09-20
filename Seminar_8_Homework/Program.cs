int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
    int[,] array = new int[rows,cols];
    for(int i = 0; i<rows; i++)
        for(int j = 0; j<cols; j++)
            array[i,j] = new Random().Next(min, max+1);
    return array;
}

void Show2dArray(int[,] array){
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            if(array[i,j] < 10) Console.Write(array[i,j]+ "   ");
            else Console.Write(array[i,j]+ "  ");
        }
        Console.WriteLine();
    }
}

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] SortArray(int[,] array){
    int temp;
    for(int i = 0; i < array.GetLength(0); i++){        //перебор строк матрицы
       for(int j = 0; j < array.GetLength(1) - 1; j++){     //проходы по строке
            for(int k = 0; k < array.GetLength(1) - 1 - j; k++){       //сравнения, выполняемые при одном проходе по строке
                if(array[i,k] < array[i,k+1]){
                    temp = array[i,k];
                    array[i,k] = array[i,k+1];
                    array[i,k+1] = temp;
                }
            }
        } 
    }
    return array;
}

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int MinSumRow(int[,] array){
    int[] sumArray = new int[array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0); i++){
        for(int j = 0; j<array.GetLength(1); j++){
            sumArray[i] += array[i,j];
        }
    }
    int minSumIndex = 0;
    for(int i = 1; i<sumArray.GetLength(0); i++){
        if(sumArray[i] < sumArray[minSumIndex]) minSumIndex = i;
    }
    minSumIndex += 1; 
    return minSumIndex;
}

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
int[,] CreateSpiralArray(){
    int rows = 4;    //по условию задачи
    int cols = 4;    //по условию задачи
    int[,] array = new int[rows,cols];
    int number = 1;
    for(int k = 0; k < 2; k++){
        //Движемся вправо
        for(int i = k; i<cols - k; i++){
            array[k,i] = number;
            number++;
        }
        //Движемся вниз
        for(int i = k + 1; i<rows-k; i++){
            array[i,cols-k-1] = number;
            number++;
        }
        //Движемся влево
        for(int i = cols - k - 2; i>=k; i--){
            array[rows - k - 1,i] = number;
            number++;
        }
        //Движемся вверх
        for(int i = rows - k - 2; i>=k + 1; i--){
            array[i,k] = number;
            number++;
        }  
    }
    return array;
}

// Задача 54, Задача 56
Console.Write("Введите кол-во строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

// Задача 54
int[,] array = CreateRandom2dArray(rows, cols, min, max);
Show2dArray(array);
Console.WriteLine();
int[,] array2 = SortArray(array);
Show2dArray(array2);


// // Задача 56
// int[,] array = CreateRandom2dArray(rows, cols, min, max);
// Show2dArray(array);
// int minSumIndex = MinSumRow(array);
// Console.WriteLine($"Строка с наименьшей суммой элементов под номером {minSumIndex}");


// //Задача 62
// int[,]array3 = CreateSpiralArray();
// Show2dArray(array3);


