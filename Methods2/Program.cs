
int n1 = 5;
int n2 = 6;

Swap(ref n1, ref n2);

Console.WriteLine("Now the 1st number is: " + n1 + " , and the 2nd number is: " + n2); 
static void Swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}

