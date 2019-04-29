using System;
using UnityEngine;

[CreateAssetMenu(menuName="Rust/Plant Properties")]
public class PlantProperties : ScriptableObject
{
	[ArrayIndexIsEnum(enumType=typeof(PlantProperties.State))]
	public PlantProperties.Stage[] stages = new PlantProperties.Stage[6];

	[Header("Metabolism")]
	public AnimationCurve timeOfDayHappiness = new AnimationCurve(new Keyframe[] { new Keyframe(0f, 0f), new Keyframe(12f, 1f), new Keyframe(24f, 0f) });

	public AnimationCurve temperatureHappiness = new AnimationCurve(new Keyframe[] { new Keyframe(-10f, -1f), new Keyframe(1f, 0f), new Keyframe(30f, 1f), new Keyframe(50f, 0f), new Keyframe(80f, -1f) });

	public AnimationCurve fruitCurve = new AnimationCurve(new Keyframe[] { new Keyframe(0f, 0f), new Keyframe(0.75f, 1f), new Keyframe(1f, 0f) });

	public int maxSeasons = 1;

	public int maxHeldWater = 1000;

	public int lifetimeWaterConsumption = 5000;

	public float waterConsumptionLifetime = 60f;

	public int waterYieldBonus = 1;

	[Header("Harvesting")]
	public BaseEntity.Menu.Option pickOption;

	public ItemDefinition pickupItem;

	public int pickupAmount = 1;

	public GameObjectRef pickEffect;

	public int maxHarvests = 1;

	public bool disappearAfterHarvest;

	[Header("Cloning")]
	public BaseEntity.Menu.Option cloneOption;

	public ItemDefinition cloneItem;

	public int maxClones = 1;

	public PlantProperties()
	{
	}

	[Serializable]
	public struct Stage
	{
		public PlantProperties.State nextState;

		public float lifeLength;

		public float health;

		public float resources;

		public GameObjectRef skinObject;
	}

	public enum State
	{
		Seed,
		Seedling,
		Sapling,
		Mature,
		Fruiting,
		Dying
	}
}