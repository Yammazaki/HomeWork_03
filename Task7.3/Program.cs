// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int m = 3;
int n = 4;
double sum1 = 0;
double sum2 = 0;
double sum3 = 0;
double sum4 = 0;
double[,] array = new double[m,n];

for(int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        array[i, j] = new Random().Next(0, 10);
        Console.Write($"{array[i, j]} ");
        if(j == 0) sum1 = sum1 + array[i, j];
        if(j == 1) sum2 = sum2 + array[i, j];
        if(j == 2) sum3 = sum3 + array[i, j];
        if(j == 3) sum4 = sum4 + array[i, j];
    }
    Console.Write($"\n");
}

string result1 = string.Format("{0:f1}", sum1/m);
string result2 = string.Format("{0:f1}", sum2/m);
string result3 = string.Format("{0:f1}", sum3/m);
string result4 = string.Format("{0:f1}", sum4/m);
Console.WriteLine($"Среднее арифметическое каждого столбца: {result1} {result2} {result3} {result4}");
