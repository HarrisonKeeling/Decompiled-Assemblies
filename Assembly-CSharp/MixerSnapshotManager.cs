using System;
using UnityEngine;
using UnityEngine.Audio;

public class MixerSnapshotManager : MonoBehaviour
{
	public AudioMixerSnapshot defaultSnapshot;

	public AudioMixerSnapshot underwaterSnapshot;

	public AudioMixerSnapshot loadingSnapshot;

	public AudioMixerSnapshot woundedSnapshot;

	public SoundDefinition underwaterInSound;

	public SoundDefinition underwaterOutSound;

	public SoundDefinition woundedLoop;

	private Sound woundedLoopSound;

	public MixerSnapshotManager()
	{
	}
}