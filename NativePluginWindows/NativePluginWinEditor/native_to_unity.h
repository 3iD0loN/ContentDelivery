#ifndef NATIVE_TO_UNITY_NOTIFIERS_HPP
#define NATIVE_TO_UNITY_NOTIFIERS_HPP

#if _MSC_VER // this is defined when compiling with Visual Studio
#define EXPORT_API __declspec(dllexport) // Visual Studio needs annotating exported functions with this
#else
#define EXPORT_API // XCode does not need annotating exported functions, so define is empty
#endif

// Prevents the functions defined in this block from being name-mangled by C++ compiler.
// This makes them easy to locate by name, which is needed in order to bind them to C# scripts.
#ifdef __cplusplus
extern "C"
{
#endif

	EXPORT_API void* VirtualFileSystemWrite(const char* database);

	EXPORT_API void VirtualFileSystemClose(void*);

#ifdef __cplusplus
}
#endif

#endif
