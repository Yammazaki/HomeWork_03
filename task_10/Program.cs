/* int N = 0;
int.TryParse(Console.ReadLine(), out N);

string PrintNumbers(int start, int end)
{
    if (start == end)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}

Console.Write(PrintNumbers(1, N));  

// поменяли с м до н
int N = 0;
int M = 0;
int.TryParse(Console.ReadLine(), out N);
int.TryParse(Console.ReadLine(), out M);

string PrintNumbers(int start, int end)
{   
     if (start == end)
        return start.ToString();
    return (start + " " + PrintNumbers(start + 1, end));
}


Console.Write(PrintNumbers(N, M)); */

