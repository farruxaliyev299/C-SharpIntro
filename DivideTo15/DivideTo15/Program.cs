//Verilmis n ve m arasinda 15 ebolunen ededlerin sayini tapin.

int m = 61;

int counter = 0;

for(int n = 1; n < m; n++)
{
    if (n % 15 == 0)
    {
        counter++;
    }
}
Console.WriteLine(counter);
