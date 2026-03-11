// See https://aka.ms/new-console-template for more information

using System;

static int CalculateMin(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Tablica jest pusta lub null");

    int min = values[0];

    foreach (int v in values)
    {
        if (v < min)
            min = v;
    }

    return min;
}
