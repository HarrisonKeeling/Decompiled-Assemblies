using System;

public class Achievements : SingletonComponent<Achievements>
{
	public SoundDefinition listComplete;

	public SoundDefinition itemComplete;

	public SoundDefinition popup;

	public Achievements()
	{
	}
}