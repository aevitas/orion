// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Offsets that change at least once per build, and are platform specific.
	public enum BaseOffsets
	{
		ViewMatrix = 0x4A35404,
		EntityList = 0x4A43844,
		EnginePtr = 0x5D3234,
		LocalPlayer = 0xA9D44C
	}
}
