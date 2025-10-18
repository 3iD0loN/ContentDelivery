using UnityEngine;

#if UNITY_6_6_0_OR_NEWER
using UnityEngine.Loading;
#endif

using System.Runtime.InteropServices;
using UnityEngine.Scripting;

[assembly : AlwaysLinkAssembly]
public class LoadContent
{
    [DllImport("VirtualFileSystem")]
    private static extern void VirtualFileSystemRead(string database);

#if UNITY_6_6_0_OR_NEWER
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        X();
        
        ContentLoadManager.RegisterContentDirectory("outputPath");
    }
    
    private void X()
    {
        VirtualFileSystemRead("mytest_database.db");
    }
#endif
}
