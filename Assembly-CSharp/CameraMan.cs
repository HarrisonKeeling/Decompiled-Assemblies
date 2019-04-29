using System;

public class CameraMan : SingletonComponent<CameraMan>
{
	public bool OnlyControlWhenCursorHidden = true;

	public bool NeedBothMouseButtonsToZoom;

	public float LookSensitivity = 1f;

	public float MoveSpeed = 1f;

	public CameraMan()
	{
	}
}