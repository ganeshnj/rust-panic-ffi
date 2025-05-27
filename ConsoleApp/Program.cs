using System;
using System.Runtime.InteropServices;
using MyNetLibrary;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Call the Rust function that will panic
            RustInterop.i_panic();
        }
        catch (Exception ex)
        {
            // Handle the exception if needed
            Console.WriteLine("Caught an exception: " + ex.Message);
        }

        Console.WriteLine("Program completed.");
    }
}
