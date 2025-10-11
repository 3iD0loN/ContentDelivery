using UnityEngine;
using UnityEngine.Loading;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

[assembly : AlwaysLinkAssembly]
public class LoadContent
{
    [DllImport("VirtualFileSystem")]
    private static extern void VirtualFileSystemRead(string database);
    
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
}
