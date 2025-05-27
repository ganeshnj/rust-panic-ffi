using System.Runtime.InteropServices;

namespace MyNetLibrary;

public static class RustInterop
{
    [DllImport("../../../../my-rust-lib/target/debug/libmy_rust_lib.dylib", CallingConvention = CallingConvention.Cdecl)]
    public static extern void i_panic();

    public static void IsPanicCaught()
    {
        try
        {
            // Call the Rust function that will panic
            i_panic();
        }
        catch (Exception ex)
        {
            // Handle the exception if needed
            Console.WriteLine("Caught an exception: " + ex.Message);
        }
    }
}