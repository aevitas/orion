// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Contains offsets that hardly ever, if ever at all, change.
	public enum StaticOffsets
	{
		// Entity
		Position = 0x134,
		Team = 0xF0,
		Armor = 0x23B0,
		Health = 0xFC,
		Dormant = 0xE9,
		Index = 0x64,
		Flags = 0x100,
		LifeState = 0x25B,
		CrosshairId = 0x2410,

		// GameClient
		LocalPlayerIndex = 0x160,
		GameState = 0xE8,

		// EntityList/ObjectManager
		EntitySize = 0x10
	}
}
