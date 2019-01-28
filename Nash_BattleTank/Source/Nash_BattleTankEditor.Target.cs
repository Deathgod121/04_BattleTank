// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Nash_BattleTankEditorTarget : TargetRules
{
	public Nash_BattleTankEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "Nash_BattleTank" } );
	}
}
