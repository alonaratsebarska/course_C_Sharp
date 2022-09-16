// Sobrat stroku s chislami ot a do b, a < || = b

// Iterativnyj metod
/*
string NumbersFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++) result += $"{i} ";
    return result;
}

string NumbersRec(int a, int b)
{
    if (a <= b - 1) return $"{a} " + NumbersRec(a + 1, b);
    else return $"{b}";
}

int a = 0;
int b = 10;

Console.WriteLine(NumbersFor(a, b));
Console.WriteLine(NumbersRec(a, b));


//Summa chisel ot 1 do n;

int SumFor(int n)
{
    int result = 0;
    for( int i = 1; i <= n; i++) result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec( n - 1);
}

int n = 15;
Console.WriteLine(SumFor(n));
Console.WriteLine(SumRec(n));

// Factorial chisla 

double FactorialFor(int n)
{
    double result = 1;
    for (int i = 1; i<= n; i++) result *= i;
    return result;
}

double FactorialRec(int n)
{
    if (n == 1) return 1;
    else return n * FactorialRec(n -1);
}


int n = 15;
Console.WriteLine(FactorialFor(n));
Console.WriteLine(FactorialRec(n));
*/

// Vychislit a v n stepeni

/*
int PowerFor(int a, int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++) result *= a;
    return result;
}

int PowerRec(int a, int n)
{
   return n == 0 ? 1 : PowerRec(a, n - 1) * a; 
   //if (n == 0) return 1;
   //else return PowerRec(a, n -1) * a;
}

int PowerRecMath( int a, int n)
{
    if (n == 0) return 1;
    else if (n %2 == 0) return PowerRecMath(a* a, n / 2);
    else return PowerRecMath(a, n - 1) * a;
}

int a = 5;
int n = 7;
Console.WriteLine(PowerFor(a, n));
Console.WriteLine(PowerRec(a, n));
Console.WriteLine(PowerRecMath(a, n));
*/




