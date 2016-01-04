// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Offsets that change at least once per build, and are platform specific.
	public enum BaseOffsets : uint
	{
		ViewMatrix = 0x4a4c4a4,
		EntityList = 0x4a5a8e4,
		// In most dumpers, this is called ClientState
		EnginePtr = 0x6062b4,
		LocalPlayer = 0xa6c49c
	}
}