using System;

namespace Rust.Ai.HTN.Murderer
{
	public enum Facts : byte
	{
		HasEnemyTarget,
		CanSeeEnemy,
		CanHearEnemy,
		EnemyRange,
		CanNavigateToEnemy,
		IsNavigating,
		AmmoState,
		HealthState,
		HasWaypoints,
		PathStatus,
		FirearmOrder,
		FireTactic,
		IsReloading,
		AtLocationWaypoint,
		AtLocationPreferredFightingRange,
		AtLocationCover,
		AtLocationLastKnownLocationOfPrimaryEnemyPlayer,
		IsSearching,
		IsIdle,
		IsLookingAround,
		Vulnerability,
		IsDucking,
		IsWaiting,
		HeldItemType,
		HasNearbyCover,
		CoverTactic,
		MaintainCover,
		IsApplyingMedical,
		CoverState,
		Frustration,
		IsReturningHome,
		AtLocationHome,
		NearbyExplosives,
		IsAvoidingExplosive,
		NearbyAnimal,
		IsAvoidingAnimal,
		IsStandingUp,
		Alertness,
		IsThrowingWeapon,
		IsRoaming
	}
}