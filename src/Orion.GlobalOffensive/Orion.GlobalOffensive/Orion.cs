// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

using System.Diagnostics;
using BlueRain;
using Orion.GlobalOffensive.Objects;

namespace Orion.GlobalOffensive
{
	/// <summary>
	/// Main class for the Orion Global Offensive framework.
	/// </summary>
	public static class Orion
	{
		private static bool _isAttached;

		/// <summary>
		/// Gets the memory instance of the process Orion is currently attached to.
		/// </summary>
		public static ExternalProcessMemory Memory { get; private set; }

		/// <summary>
		/// Gets the local player.
		/// </summary>
		public static LocalPlayer Me { get; private set; }

		/// <summary>
		/// Initializes Orion by attaching to the specified CSGO process.
		/// </summary>
		/// <param name="process">The process.</param>
		public static void Attach(Process process)
		{
			if (_isAttached)
				return;

			Memory = new ExternalProcessMemory(process, true);

			_isAttached = true;
		}
	}
}
