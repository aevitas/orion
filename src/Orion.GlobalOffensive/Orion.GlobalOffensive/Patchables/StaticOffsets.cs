// Copyright (C) 2015-2020 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive.Patchables
{
	// Contains offsets that hardly ever, if ever at all, change.
	public enum StaticOffsets
	{
		// Entity
		Position = 0x134,
		Team = 0xF0,
		Armor = 0xA8A4,
		Health = 0xFC,
		Dormant = 0xE9,
		Index = 0x64,
		Flags = 0x100,
		LifeState = 0x25B,
		CrosshairId = 0xC550,

		// GameClient
		LocalPlayerIndex = 0x178,
		GameState = 0x100,

		// EntityList/ObjectManager
		EntitySize = 0x10
	}
}