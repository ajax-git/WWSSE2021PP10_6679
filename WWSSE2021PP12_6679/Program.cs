/*
    Napisz program wypisujący w kolejnych wierszach wartości kolejnych liczb ciągu Fibonacciego mniejszych od zadanej wartości.
*/

int fib(int n)
{
	if (n < 3)
		return 1;

	return fib(n - 2) + fib(n - 1);
}

Console.Write("Podaj n= ");
int number = int.Parse(Console.ReadLine()) - 1;

for (int i = 1; i <= number; i++)
{
	Console.WriteLine("{0}", fib(i));
}