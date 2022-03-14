int[] array = { 5, 10, 12, 6, 3, 7 };

int counter = 0;

for (int i = 0; i < array.Length-1; i++)
{
    for (int j = i+1; j < array.Length; j++)
    {
        if(array[i] + array[j] < 10)
        {
            counter++;
        }
    }
}

Console.WriteLine(counter);