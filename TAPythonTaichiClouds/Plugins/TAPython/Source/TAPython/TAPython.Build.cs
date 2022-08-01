// Copyright Huipeng Chen. All Rights Reserved.

using UnrealBuildTool;

public class TAPython : ModuleRules
{
	public TAPython(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = ModuleRules.PCHUsageMode.UseExplicitOrSharedPCHs;
		
		PublicIncludePaths.AddRange(
			new string[] {
				// ... add public include paths required here ...
			}
			);
				
		
		PrivateIncludePaths.AddRange(
			new string[] {
                //"ContentBrowser/Private",
                "TAPython/Public/PythonInterface",
                "TAPython/Private/PythonInterface"
				// ... add other private include paths required here ...
			}
			);
			
		
		PublicDependencyModuleNames.AddRange(
			new string[]
			{
				"Core",
                "CoreUObject",
                "Engine",
                "InputCore",
                "Slate",
                "SlateCore",
                "Foliage",
                "Landscape"
				// ... add other public dependencies that you statically link with here ...
			}
			);
			
		
		PrivateDependencyModuleNames.AddRange(
			new string[]
			{
                "EditorStyle",
                "LevelEditor",

                "ContentBrowser",
				"ContentBrowserData",
				"AssetTools",
                "AssetRegistry",
                "UnrealEd",

                "PythonScriptPlugin",
                "Json",
                "Projects",
                "DesktopPlatform",
                "ApplicationCore",
				"AppFramework",
                                
                "Blutility",
                "RenderCore",
                "RawMesh",
                "MaterialEditor",
//                "ShaderCore",
                "RHI",
                
                "EditorWidgets",
                "LandscapeEditor",
                "LandscapeEditorUtilities",
				"ProceduralMeshComponent",
				"MeshDescription",
				"StaticMeshDescription"

				// ... add private dependencies that you statically link with here ...	
			}
			);

#if UE_5_0_OR_LATER

#else
		PrivateDependencyModuleNames.Add("EditorScriptingUtilities");
		PrivateDependencyModuleNames.Add("SceneOutliner");
#endif


		DynamicallyLoadedModuleNames.AddRange(
			new string[]
			{
				// ... add any modules that your module loads dynamically here ...
			}
			);
		bUsePrecompiled = true; 
	}
}
