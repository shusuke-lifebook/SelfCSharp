using System;

namespace SelfCSharp.Chap02;

public class CastBad
{
    public static void Main(string[] args)
    {
        int i = 128;
        sbyte b = (sbyte)i;
        Console.WriteLine(b);
    }
}
