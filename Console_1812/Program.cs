using System;

public class SolutionShort
{
    public bool SquareIsWhite(string coordinates)
    {
        // 將兩個字元的 ASCII 值相加，總和是否為奇數。
        // 總和是奇數，代表是白色 (true)。
        return (coordinates[0] + coordinates[1]) % 2 != 0;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        SolutionShort sol = new SolutionShort();

        //1: a1 是黑色
        string coord1 = "a1";
        Console.WriteLine($"座標 '{coord1}' 是白色嗎? -> {sol.SquareIsWhite(coord1)}"); // 預期: False

        //2: h3 是白色
        string coord2 = "h3";
        Console.WriteLine($"座標 '{coord2}' 是白色嗎? -> {sol.SquareIsWhite(coord2)}"); // 預期: True
    }
}