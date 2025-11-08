using System.Runtime.CompilerServices;

string[] names = ["Sophia", "Andrew", "Emma", "Logan"];
float[] score = [92.2f, 89.6f, 85.6f, 91.2f];

int i;
float item;

Console.WriteLine("Student\t\tGrade\n");

for (i = 0; i < score.Length; i++)
{
    item = score[i];

    //Print into Console the Name, Score and name
    Console.Write(names[i]+ ":" + "\t\t" + score[i] + "\t");

    //Calculate if the score match the Grade
    if (item < 60)
    {
        Console.WriteLine("F");
    }
    else if (item < 63)
    {
        Console.WriteLine("D-");
    }
    else if (item < 67)
    {
        Console.WriteLine("D");
    }
    else if (item < 70)
    {
        Console.WriteLine("D+");
    }
    else if (item < 73)
    {
        Console.WriteLine("C-");
    }
    else if (item < 77)
    {
        Console.WriteLine("C");
    }
    else if (item < 80)
    {
        Console.WriteLine("C+");
    }
    else if (item < 84)
    {
        Console.WriteLine("B-");
    }
    else if (item < 87)
    {
        Console.WriteLine("B");
    }
    else if (item < 90)
    {
        Console.WriteLine("B+");
    }
    else if (item < 93)
    {
        Console.WriteLine("A-");
    }
    else if (item < 97)
    {
        Console.WriteLine("A");
    }
    else if (item < 100)
    {
        Console.WriteLine("A+");
    }

}