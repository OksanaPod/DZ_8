﻿Console.WriteLine($"\nВведите размеры матриц.");
int m = InputNumbers("Введите число строк матриц: ");
int n = InputNumbers("Введите число столбцов матриц: ");
int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"\nПервая матрица:");
WriteArray(firstMartrix);
int[,] secomdMartrix = new int[m, n];
CreateArray(secomdMartrix);
Console.WriteLine($"\nВторая матрица:");
WriteArray(secomdMartrix);
int[,] resultMatrix = new int[m, n];
MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
Console.WriteLine($"\nПроизведение первой и второй матриц:");
WriteArray(resultMatrix);
void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
{
for (int i = 0; i < resultMatrix.GetLength(0); i++)
{
for (int j = 0; j < resultMatrix.GetLength(1); j++)
{
int sum = 0;
sum = firstMartrix[i,j] * secomdMartrix[i,j];
resultMatrix[i,j] = sum;
}}}
int InputNumbers(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
void CreateArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
array[i, j] = new Random().Next(1,10);
}}}
void WriteArray (int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
Console.Write(array[i,j] + " ");
}
Console.WriteLine();
}}