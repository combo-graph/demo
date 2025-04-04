// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class ComboGraph_DemoEditorTarget : TargetRules
{
	public ComboGraph_DemoEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		ExtraModuleNames.AddRange( new string[] { "ComboGraph_Demo" } );
		
		bUseUnityBuild = false;  
		bUseSharedPCHs = false;  
		bUsePCHFiles = false;
	}
}
