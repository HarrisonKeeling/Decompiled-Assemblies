using System;
using UnityEngine;

public class MovementSounds : MonoBehaviour
{
	public SoundDefinition waterMovementDef;

	public float waterMovementFadeInSpeed = 1f;

	public float waterMovementFadeOutSpeed = 1f;

	private Sound waterMovement;

	private SoundModulation.Modulator waterGainMod;

	private Vector3 lastPos;

	public bool mute;

	public MovementSounds()
	{
	}
}