// Copyright YangZhikang

using UnrealBuildTool;
using System.Collections.Generic;

public class ElfSelenaTarget : TargetRules
{
	public ElfSelenaTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "ElfSelena" } );
	}
}
