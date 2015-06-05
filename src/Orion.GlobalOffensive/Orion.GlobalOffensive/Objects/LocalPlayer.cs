// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

using System;
using System.Numerics;
using Orion.GlobalOffensive.Patchables;

namespace Orion.GlobalOffensive.Objects
{
	/// <summary>
	/// Represents the local player - i.e. the guy who's eyes we're borrowing.
	/// </summary>
	public class LocalPlayer : BaseEntity
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LocalPlayer"/> class.
		/// </summary>
		/// <param name="baseAddress">The base address.</param>
		protected LocalPlayer(IntPtr baseAddress) : base(baseAddress)
		{
		}

		/// <summary>
		/// Gets the view matrix of the local player.
		/// </summary>
		/// <value>
		/// The view matrix.
		/// </value>
		public Matrix4x4 ViewMatrix
		{
			get { return ReadField<Matrix4x4>(BaseOffsets.ViewMatrix); }
		}
	}
}
