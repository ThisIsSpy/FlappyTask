using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Editor {
    
    public class BuildScript
    {
        [MenuItem("Build/Windows")]
        public static void BuildWindows()
        {
            BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, "Builds/Windows/NUKEGame.exe", BuildTarget.StandaloneWindows64, BuildOptions.None);
        }
    
        [MenuItem("Build/Android")]
        public static void BuildAndroid()
        {
            BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, "Builds/Android/NUKEGame.apk", BuildTarget.Android, BuildOptions.None);
        }
    
        [MenuItem("Build/WebGL")]
        public static void BuildWebGL()
        {
            BuildPipeline.BuildPlayer(EditorBuildSettings.scenes, "Builds/WebGL", BuildTarget.WebGL, BuildOptions.None);
        }
    
        [MenuItem("Build/Build All")]
        public static void BuildAll()
        {
            BuildWindows();
            BuildAndroid();
            BuildWebGL();
        }
    
    }
    
}
