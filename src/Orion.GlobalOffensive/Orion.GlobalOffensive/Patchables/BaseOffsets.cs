// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Offsets that change at least once per build, and are platform specific.
	public enum BaseOffsets
	{
		ViewMatrix = 0x4a4a394,
		EntityList = 0x4a58784,
		EnginePtr = 0x6062c4,
		LocalPlayer = 0xa6a444
	}
}
