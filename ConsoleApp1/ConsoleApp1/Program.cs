// See https://aka.ms/new-console-template for more information

using System;

static int CalculateMax(int[] values)
{
    if (values == null || values.Length == 0)
        throw new ArgumentException("Array is empty");

    int max = values[0];

    foreach (int v in values)
    {
        if (v > max)
            max = v;
    }

    return max;
}