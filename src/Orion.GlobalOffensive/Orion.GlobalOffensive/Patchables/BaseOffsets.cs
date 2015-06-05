// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Offsets that change at least once per build, and are platform specific.
	public enum BaseOffsets
	{
		ViewMatrix = 0x4a0c164,
		EntityList = 0x4a16bd4,
		EnginePtr = 0x5ce1c4,
		LocalPlayer = 0xa74c9c,
	}
}
