using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;

static long FlippingBits(long n)
{
    uint y = (uint)n;
    return ~y;
}

long originalValue = 1;
long flippedValue = FlippingBits(originalValue);
Console.WriteLine($"Original: {originalValue}, Flipped: {flippedValue}");