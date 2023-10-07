// Copyright 2019, Institute for Artificial Intelligence - University of Bremen
// Author: Andrei Haidu (http://haidu.eu)

using UnrealBuildTool;
using System.IO;

public class BoostUnreal : ModuleRules
{
	public BoostUnreal(ReadOnlyTargetRules Target) : base(Target)
	{
		// We are just setting up paths for pre-compiled binaries.
		// Type = ModuleType.External;
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;

		// For boost::
		bEnableUndefinedIdentifierWarnings = false;
		bUseRTTI = true;		
		
		PublicIncludePaths.AddRange(new string[] {});
		PrivateIncludePaths.AddRange(new string[] {});
		PublicDependencyModuleNames.AddRange(new string[] {"Core"});
		PrivateDependencyModuleNames.AddRange(new string[] {});
		DynamicallyLoadedModuleNames.AddRange(new string[] {});
		// PublicIncludePaths.AddRange(new string[] { });
		// PrivateIncludePaths.AddRange(new string[] { });

		// PrivateDependencyModuleNames.AddRange(new string[] { });
		// DynamicallyLoadedModuleNames.AddRange(new string[] { });
		//PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "includes"));
		// PublicSystemIncludePaths.Add(Path.Combine(ModuleDirectory, "includes"));
	}
}