// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

using System;
using System.Diagnostics;
using BlueRain;
using Orion.GlobalOffensive.Objects;
using Orion.GlobalOffensive.Patchables;

namespace Orion.GlobalOffensive
{
	/// <summary>
	///     Main class for the Orion Global Offensive framework.
	/// </summary>
	public static class Orion
	{
		private static bool _isAttached;

		/// <summary>
		///     Gets the memory instance of the process Orion is currently attached to.
		/// </summary>
		public static NativeMemory Memory { get; private set; }

		/// <summary>
		///     Gets the local player.
		/// </summary>
		public static LocalPlayer Me => Objects.LocalPlayer;

		/// <summary>
		///     Gets the current object manager.
		/// </summary>
		public static ObjectManager Objects { get; private set; }

		/// <summary>
		///     Gets the current instance of the game client.
		/// </summary>
		public static GameClient Client { get; private set; }

		public static IntPtr ClientBase { get; private set; }
		public static IntPtr EngineBase { get; private set; }

		/// <summary>
		///     Initializes Orion by attaching to the specified CSGO process.
		/// </summary>
		/// <param name="process">The process.</param>
		/// <param name="isInjected">if set to <c>true</c> [is injected].</param>
		public static void Attach(Process process, bool isInjected = false)
		{
			if (_isAttached)
				return;

			// We won't require the injector for now - we're completely passive.
			if (isInjected)
				Memory = new LocalProcessMemory(process);
			else
			{
				Memory = new ExternalProcessMemory(process);
			}

			ClientBase = Memory.GetModule("client.dll").BaseAddress;
			EngineBase = Memory.GetModule("engine.dll").BaseAddress;

			Objects = new ObjectManager(ClientBase + (int) BaseOffsets.EntityList, 128);

			var enginePtr = Memory.Read<IntPtr>(EngineBase + (int) BaseOffsets.EnginePtr);

			if (enginePtr == IntPtr.Zero)
				throw new Exception("Couldn't find Engine Ptr - are you sure your offsets are up to date?");

			Client = new GameClient(enginePtr);

			_isAttached = true;
		}
	}
}
