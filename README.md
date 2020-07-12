# KSP Ground Effect
Now ekranoplans would work as intended, hopefully.
See [Releases](https://github.com/SYZYGY-DEV333/KSP_GroundEffect/releases) or the [Forum Post](https://forum.kerbalspaceprogram.com/index.php?/topic/178169-wip-ground-effect/).


Unofficial build instructions that worked for me:
1. Move all of the following files from KSP_Data to the same directory as the files in this repository:
    - Assembly-CSharp.dll
    - System.Core.dll
    - System.dll
    - UnityEngine.CoreModule.dll
    - UnityEngine.dll
    - UnityEngine.PhysicsModule.dll
2. Run the following command:
    `csc /t:library /out:KSP_GroundEffect.dll VesselGroundEffect.cs /r:Assembly-CSharp.dll /r:System.Core.dll /r:System.dll /r:UnityEngine.CoreModule.dll /r:UnityEngine.dll /r:UnityEngine.PhysicsModule.dll`
3. ???
4. Profit

