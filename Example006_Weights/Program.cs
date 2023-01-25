int a = new Random().Next(0, 101);
int b = new Random().Next(0, 101);
int c = new Random().Next(0, 101);
int d = new Random().Next(0, 101);
int e = new Random().Next(0, 101);
int f = new Random().Next(0, 101);
Console.Write("a = ");
Console.WriteLine(a);
Console.Write("b = ");
Console.WriteLine(b);
Console.Write("c = ");
Console.WriteLine(c);
Console.Write("d = ");
Console.WriteLine(d);
Console.Write("e = ");
Console.WriteLine(e);
Console.Write("f = ");
Console.WriteLine(f);

int max = a;
 
if(a > max ) max = a;
if(b > max ) max = b;
if(c > max ) max = c;
if(d > max ) max = d;
if(e > max ) max = e;
if(f > max ) max = f;

Console.Write("max = ");
Console.Write(max);