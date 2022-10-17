/*
двумерный массив
*/

//string[,] table = new string[2,5]; --> где 2 это кол-во строк, 5 это кол-во столбцов.
                                        // [,] - это двухмерный массив
// String.Empty
//table [0,0] table [0,1] table [0,2] table [0,3] table [0,4]
//table [1,0] table [2,0] table [3,0] table [4,0] table [5,0]


/*table[1,2] = "слово"; 
for (int rows = 0; rows < 2; rows++)
{
   for (int colums = 0; colums < 5; colums++)
   {
    Console.WriteLine($"-{table[rows, colums]}-");
}
}
*/

int[,] matrix = new int[3,4];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i, j]} ");
    }
    Console.WriteLine();
}