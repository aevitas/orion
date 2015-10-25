// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Offsets that change at least once per build, and are platform specific.
	public enum BaseOffsets
	{
		ViewMatrix = 0x4a30f84,
		EntityList = 0x4a3ba44,
		EnginePtr = 0x5d3224,
		LocalPlayer = 0xa9947c
	}
}
