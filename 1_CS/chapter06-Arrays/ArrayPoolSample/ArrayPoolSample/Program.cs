﻿using System.Buffers;

UseSharedPool();

static void UseSharedPool()
{
    for (int i = 0; i < 10; i++)
    {
        int arrayLength = (i + 1) << 10;
        int[] arr = ArrayPool<int>.Shared.Rent(arrayLength);
        Console.WriteLine($"requested an array of {arrayLength} and received {arr.Length}");
    }
}