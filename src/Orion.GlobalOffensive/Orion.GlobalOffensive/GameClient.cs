using System;
using Orion.GlobalOffensive.Objects;

namespace Orion.GlobalOffensive
{
	/// <summary>
	/// Manages the game client, and all stuff we require from it.
	/// </summary>
	public class GameClient : NativeObject
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="GameClient"/> class.
		/// </summary>
		/// <param name="baseAddress">The base address.</param>
		public GameClient(IntPtr baseAddress) : base(baseAddress)
		{
		}
	}
}
