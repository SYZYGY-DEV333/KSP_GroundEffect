# KSP Ground Effect
Now ekranoplans would work as intended, hopefully.
Authored by Capital-Asterisk; edited by LinuxGuruGamer and SYZYGY-DEV333. Licensed under MIT.
The SimpleJSON library was written by Markus Göbel (Bunny83), and is licensed under MIT.

See [Releases](https://github.com/SYZYGY-DEV333/KSP_GroundEffect/releases) or the [Forum Post](https://forum.kerbalspaceprogram.com/index.php?/topic/178169-wip-ground-effect/).

## ModuleManager part exemption
If you don't want a part to have Ground Effect calculations performed on it, use a modulemanager patch like this:

```
@PART[something]
{
	%MODULE
	{
		name = IgnoreGroundEffect
	}
}
```

## Unofficial build instructions that worked for me:
1. Open in VS or MonoDevelop and try to build.
2. If that works, great. If not, check the refrences. Make sure to reference the following from KSP_Data:
    - Assembly-CSharp.dll
    - System.Core.dll
    - System.Configuration.dll
    - System.dll
    - UnityEngine.CoreModule.dll
    - UnityEngine.dll
    - UnityEngine.PhysicsModule.dll
   
   Reference also SimpleJSON.cs which is packaged with this.
   If This still doesn't work, try the below, though be warned that the resulting compiled plugin has somewhat more limited functionality.

## Build instructions for if all else fails:
1. Move all of the following files from KSP_Data to the same directory as the files in this repository:
    - Assembly-CSharp.dll
    - System.Core.dll
    - System.Configuration.dll
    - System.dll
    - UnityEngine.CoreModule.dll
    - UnityEngine.dll
    - UnityEngine.PhysicsModule.dll
   
   Also, move SimpleJSON.cs into your working directory.
2. Run the following command:
    `csc /t:library /out:KSP_GroundEffect.dll VesselGroundEffect.cs /r:Assembly-CSharp.dll /r:System.Core.dll /r:System.dll /r:UnityEngine.CoreModule.dll /r:UnityEngine.dll /r:UnityEngine.PhysicsModule.dll /r:System.Configuration.dll /r:SimpleJSON.cs`
3. ???
4. Profit

