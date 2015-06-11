// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Offsets that change at least once per build, and are platform specific.
	public enum BaseOffsets
	{
		ViewMatrix = 0x4a0d164,
		EntityList = 0x4a17bd4,
		EnginePtr = 0x5ce294,
		LocalPlayer = 0xa75ccc
	}
}