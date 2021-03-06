// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;

class My
{
    static int Sum(Span<int> span)
    {
        int sum = 0;
        for (int i = 0; i < span.Length; i++)
            sum += span[i];
        return sum;
    }

    static void Main()
    {
        int[] a = new int[] { 1, 2, 3 };
        Span<int> span = new Span<int>(a);
        Console.WriteLine(Sum(span).ToString());
        Span<int> slice = span.Slice(1, 2);
        Console.WriteLine(Sum(slice).ToString());
    }
}
