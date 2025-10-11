using UnityEditor;
using UnityEditor.Build.Reporting;

using System.Runtime.InteropServices;
using UnityEngine.Scripting;

[assembly : AlwaysLinkAssembly]
public class BuildContent : EditorWindow
{
    [DllImport("VirtualFileSystem.Editor")]
    private static extern System.IntPtr  VirtualFileSystemOpen(string filePath);
    
    [DllImport("VirtualFileSystem.Editor")]
    private static extern System.IntPtr  VirtualFileSystemClose(System.IntPtr database);
    
    [MenuItem("Tests/Create Database")]
    private static void X()
    {
        // Creates at project root.
        System.IntPtr databaseHandle = VirtualFileSystemOpen("mytest_database.db");

        VirtualFileSystemClose(databaseHandle);
    }
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Y()
    {
        var buildOptions = new BuildContentDirectoryParameters()
        {
            outputPath = "outputPath",
            rootAssetPaths = new string[0],
            options = BuildContentOptions.None,
            compression = UnityEngine.BuildCompression.UncompressedRuntime,
            targetPlatform = BuildTarget.StandaloneWindows,
            subtarget = 0,
            extraScriptingDefines = new string[0],
        };
        
        BuildReport result = BuildPipeline.BuildContentDirectory(buildOptions);
    }
}
