/*

*/
#region source
using fmt = System.Console;
using cmplx = go.math.cmplx_package;
using uint64 = System.UInt64;
using complex128 = System.Numerics.Complex;

static class main_package
{
    static bool ToBe = false;

    static uint64 MaxInt = /* 1 << 64 - 1 */ 18446744073709551615UL;

    static complex128 z = cmplx.Sqrt(-5 + new complex128(12.0D, 0.0D));

    static void Main() {
        fmt.WriteLine("Type: {0} Value: {1}\n", ToBe.GetType(), ToBe);
        fmt.WriteLine("Type: {0} Value: {1}\n", MaxInt.GetType(), MaxInt);
        fmt.WriteLine("Type: {0} Value: ({1}+{2}i)\n", z.GetType(), z.Real, z.Imaginary);
    }
}
#endregion
