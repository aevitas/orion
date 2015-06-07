// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

using System;
using System.Linq;
using System.Numerics;
using Orion.GlobalOffensive.Patchables;

namespace Orion.GlobalOffensive.Objects
{
	/// <summary>
	///     Represents the local player - i.e. the guy who's eyes we're borrowing.
	/// </summary>
	public class LocalPlayer : BaseEntity
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="LocalPlayer" /> class.
		/// </summary>
		/// <param name="baseAddress">The base address.</param>
		internal LocalPlayer(IntPtr baseAddress) : base(baseAddress)
		{
		}

		/// <summary>
		///     Gets the view matrix of the local player.
		/// </summary>
		/// <value>
		///     The view matrix.
		/// </value>
		public Matrix4x4 ViewMatrix
		{
			get { return ReadField<Matrix4x4>(BaseOffsets.ViewMatrix); }
		}

		/// <summary>
		/// Gets the player ID for the player currently under the player's crosshair, and 0 if none.
		/// </summary>
		public int CrosshairId
		{
			get { return ReadField<int>(StaticOffsets.CrosshairId); }
		}

		/// <summary>
		/// Gets the target the local player is currently aiming at, or null if none.
		/// </summary>
		public BaseEntity Target
		{
			get
			{
				// Store this in a local variable - the crosshair ID will get updated *very* frequently, 
				// to the point where we can't be sure that by the time we make a call to FirstOrDefault, it'll
				// still be "valid" according to the check before it. (Value can change on a per-frame basis)
				// This way, at least we'll be sure that for the execution of this function, we maintain the same value.
				int id = CrosshairId;

				if (CrosshairId <= 0)
					return null;

				return Orion.Objects.Players.FirstOrDefault(p => p.Id == id - 1);
			}
		}
	}
}