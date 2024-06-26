using UnrealBuildTool;

public class VRGameTarget : TargetRules
{
	public VRGameTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("VRGame");
	}
}
