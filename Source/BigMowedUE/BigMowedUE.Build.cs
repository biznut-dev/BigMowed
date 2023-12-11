// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class BigMowedUE : ModuleRules
{
	public BigMowedUE(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}
