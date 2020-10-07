// Copyright (C) 2015-2020 aevitas
// See the file LICENSE for copying permission.

namespace Orion.GlobalOffensive
{
	public enum PlayerTeam
	{
		Neutral = 1,
		Terrorist = 2,
		CounterTerrorist = 3
	}

	public enum SignonState
	{
		None = 0, // Menu
		Challenge = 1,
		Connected = 2, // Server welcome message?
		New = 3, // nfi when this is used
		PreSpawn = 4, // Selecting team
		Spawn = 5, // Spawn protected
		Full = 6, // Can move, shoot, etc.
		ChangingLevel = 7
	}
}