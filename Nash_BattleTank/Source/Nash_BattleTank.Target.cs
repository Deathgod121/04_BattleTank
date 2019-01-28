// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class Nash_BattleTankTarget : TargetRules
{
	public Nash_BattleTankTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "Nash_BattleTank" } );
	}
}
