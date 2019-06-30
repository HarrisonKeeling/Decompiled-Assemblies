using System;
using System.Text;
using TMPro;
using UnityEngine;

public class SystemInfoGeneralText : MonoBehaviour
{
	public TextMeshProUGUI text;

	public static string currentInfo
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("System");
			stringBuilder.AppendLine();
			stringBuilder.Append("\tName: ");
			stringBuilder.Append(SystemInfo.deviceName);
			stringBuilder.AppendLine();
			stringBuilder.Append("\tOS:   ");
			stringBuilder.Append(SystemInfo.operatingSystem);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.Append("CPU");
			stringBuilder.AppendLine();
			stringBuilder.Append("\tModel:  ");
			stringBuilder.Append(SystemInfo.processorType);
			stringBuilder.AppendLine();
			stringBuilder.Append("\tCores:  ");
			stringBuilder.Append(SystemInfo.processorCount);
			stringBuilder.AppendLine();
			stringBuilder.Append("\tMemory: ");
			stringBuilder.Append(SystemInfo.systemMemorySize);
			stringBuilder.Append(" MB");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.Append("GPU");
			stringBuilder.AppendLine();
			stringBuilder.Append("\tModel:  ");
			stringBuilder.Append(SystemInfo.graphicsDeviceName);
			stringBuilder.AppendLine();
			stringBuilder.Append("\tAPI:    ");
			stringBuilder.Append(SystemInfo.graphicsDeviceVersion);
			stringBuilder.AppendLine();
			stringBuilder.Append("\tMemory: ");
			stringBuilder.Append(SystemInfo.graphicsMemorySize);
			stringBuilder.Append(" MB");
			stringBuilder.AppendLine();
			stringBuilder.Append("\tSM:     ");
			stringBuilder.Append(SystemInfo.graphicsShaderLevel);
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.Append("Process");
			stringBuilder.AppendLine();
			stringBuilder.Append("\tMemory:   ");
			stringBuilder.Append(SystemInfoEx.systemMemoryUsed);
			stringBuilder.Append(" MB");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			stringBuilder.Append("Mono");
			stringBuilder.AppendLine();
			stringBuilder.Append("\tCollects: ");
			stringBuilder.Append(GC.CollectionCount(0));
			stringBuilder.AppendLine();
			stringBuilder.Append("\tMemory:   ");
			stringBuilder.Append(SystemInfoGeneralText.MB(GC.GetTotalMemory(false)));
			stringBuilder.Append(" MB");
			stringBuilder.AppendLine();
			stringBuilder.AppendLine();
			if (World.Seed > 0 && World.Size > 0)
			{
				stringBuilder.Append("World");
				stringBuilder.AppendLine();
				stringBuilder.Append("\tSeed:        ");
				stringBuilder.Append(World.Seed);
				stringBuilder.AppendLine();
				stringBuilder.Append("\tSize:        ");
				stringBuilder.Append(SystemInfoGeneralText.KM2((float)((float)World.Size)));
				stringBuilder.Append(" km²");
				stringBuilder.AppendLine();
				stringBuilder.Append("\tHeightmap:   ");
				stringBuilder.Append(SystemInfoGeneralText.MB((TerrainMeta.HeightMap ? TerrainMeta.HeightMap.GetMemoryUsage() : (long)0)));
				stringBuilder.Append(" MB");
				stringBuilder.AppendLine();
				stringBuilder.Append("\tWatermap:    ");
				stringBuilder.Append(SystemInfoGeneralText.MB((TerrainMeta.WaterMap ? TerrainMeta.WaterMap.GetMemoryUsage() : (long)0)));
				stringBuilder.Append(" MB");
				stringBuilder.AppendLine();
				stringBuilder.Append("\tSplatmap:    ");
				stringBuilder.Append(SystemInfoGeneralText.MB((TerrainMeta.SplatMap ? TerrainMeta.SplatMap.GetMemoryUsage() : (long)0)));
				stringBuilder.Append(" MB");
				stringBuilder.AppendLine();
				stringBuilder.Append("\tBiomemap:    ");
				stringBuilder.Append(SystemInfoGeneralText.MB((TerrainMeta.BiomeMap ? TerrainMeta.BiomeMap.GetMemoryUsage() : (long)0)));
				stringBuilder.Append(" MB");
				stringBuilder.AppendLine();
				stringBuilder.Append("\tTopologymap: ");
				stringBuilder.Append(SystemInfoGeneralText.MB((TerrainMeta.TopologyMap ? TerrainMeta.TopologyMap.GetMemoryUsage() : (long)0)));
				stringBuilder.Append(" MB");
				stringBuilder.AppendLine();
				stringBuilder.Append("\tAlphamap:    ");
				stringBuilder.Append(SystemInfoGeneralText.MB((TerrainMeta.AlphaMap ? TerrainMeta.AlphaMap.GetMemoryUsage() : (long)0)));
				stringBuilder.Append(" MB");
				stringBuilder.AppendLine();
			}
			stringBuilder.AppendLine();
			if (!string.IsNullOrEmpty(World.Checksum))
			{
				stringBuilder.AppendLine("Checksum");
				stringBuilder.Append('\t');
				stringBuilder.AppendLine(World.Checksum);
			}
			return stringBuilder.ToString();
		}
	}

	public SystemInfoGeneralText()
	{
	}

	private static int KM2(float meters)
	{
		return Mathf.RoundToInt(meters * meters * 1E-06f);
	}

	private static long MB(long bytes)
	{
		return bytes / (long)1048576;
	}

	private static long MB(ulong bytes)
	{
		return SystemInfoGeneralText.MB((long)bytes);
	}

	protected void Update()
	{
		this.text.text = SystemInfoGeneralText.currentInfo;
	}
}