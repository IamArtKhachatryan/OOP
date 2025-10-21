void ChangeNumber(ref int number)
{
    number += 10;
}

void DivideNumbers(int a, int b, out double result)
{
    result = (double)a / b;
}

int x = 5;
ChangeNumber(ref x);
Console.WriteLine("After ref: " + x);

double divResult;
DivideNumbers(20, 4, out divResult);
Console.WriteLine("Division result: " + divResult);
