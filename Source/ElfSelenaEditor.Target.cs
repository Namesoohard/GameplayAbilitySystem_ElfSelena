// Copyright YangZhikang

using UnrealBuildTool;
using System.Collections.Generic;

public class ElfSelenaEditorTarget : TargetRules
{
	public ElfSelenaEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;

		ExtraModuleNames.AddRange( new string[] { "ElfSelena" } );
	}
}
