using System;

namespace Rust.Ai.HTN.Bear
{
	public enum Facts : byte
	{
		HasEnemyTarget,
		CanSeeEnemy,
		CanHearEnemy,
		EnemyRange,
		CanNavigateToEnemy,
		IsNavigating,
		HealthState,
		PathStatus,
		AtLocationPreferredFightingRange,
		AtLocationLastKnownLocationOfPrimaryEnemyPlayer,
		IsSearching,
		IsIdle,
		IsLookingAround,
		Vulnerability,
		Frustration,
		Alertness,
		IsReturningHome,
		AtLocationHome,
		NearbyAnimal,
		IsAvoidingAnimal,
		IsStandingUp,
		IsTransitioning,
		HasPlayersInRange
	}
}