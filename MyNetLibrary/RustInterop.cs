using System.Runtime.InteropServices;

namespace MyNetLibrary;

public static class RustInterop
{
    [DllImport("../../../../my-rust-lib/target/debug/libmy_rust_lib", CallingConvention = CallingConvention.Cdecl)]
    public static extern void i_panic();

    [DllImport("../../../../my-rust-lib/target/debug/libmy_rust_lib", CallingConvention = CallingConvention.Cdecl)]
    public static extern void i_panic_with_unwind();
}