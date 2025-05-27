cd my-rust-lib
cargo build
cd ..
dotnet test MyNetLibrary.Tests --filter "FullyQualifiedName=MyNetLibrary.Tests.Tests.TestIsPanicWithUnwindCaught"
dotnet test MyNetLibrary.Tests --filter "FullyQualifiedName=MyNetLibrary.Tests.Tests.TestIsPanicCaught"