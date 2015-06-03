// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Offsets that change at least once per build, and are platform specific.
	public enum RelativeOffsets
	{
		ViewMatrix = 0x04a0a0e4,
		EntityList = 0x04a14b54,
	}
}
