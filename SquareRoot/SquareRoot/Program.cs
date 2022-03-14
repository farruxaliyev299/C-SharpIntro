//Verilmis ededin en yaxin asagi kokalti deyerini tapan alqoritm
//(imisalcun eded 20-dirse 4 qaytarmalidi, 25-dise 5 qaytarmalidi, 16-drisa 4 ve s.)

int number = 83;

int count=0;

for(int i = 1; i < number; i++)
{
    if (i * i <= number)
    {
        count++;
    }

}
Console.WriteLine(count);