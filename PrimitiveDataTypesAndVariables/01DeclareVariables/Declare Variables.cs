using System;
// Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, 
// ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.

class DeclareVariables
{
    static void Main()
    {
        ushort ushortVar = 52130;
        sbyte sbyteVar = -115;
        uint uintVar = 4825932;
        byte byteVar = 97;
        short shortVar = -10000;

        Console.WriteLine("16-bits variable from type ushort: " + ushortVar);
        Console.WriteLine("8-bits variable from type sbyte: " + sbyteVar);
        Console.WriteLine("32-bits variable from type uint: " + uintVar);
        Console.WriteLine("8-bits variable from type byte: " + byteVar );
        Console.WriteLine("16-bits variable from type short: " + shortVar);

    }
}
