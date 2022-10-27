int a = 10;
int b = 12;
int c = 11;
if (a>b && c>b)
{
    Console.WriteLine(b);
}
else if ( a>c && b>c)
{
    Console.WriteLine(c);
}
else if ( b>a && c>a)
{
    Console.WriteLine(a);
}

