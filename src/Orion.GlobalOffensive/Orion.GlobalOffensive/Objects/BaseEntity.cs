// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

using System;
using System.Numerics;
using Orion.GlobalOffensive.Patchables;

namespace Orion.GlobalOffensive.Objects
{
	/// <summary>
	/// Base type for all entities in the game.
	/// </summary>
	public class BaseEntity : NativeObject
	{
		protected BaseEntity(IntPtr baseAddress) : base(baseAddress)
		{
		}

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>
		/// The identifier.
		/// </value>
		public int Id
		{
			get { return ReadMember<int>(StaticOffsets.Index); }
		}

		/// <summary>
		/// Gets this entity's position.
		/// </summary>
		/// <value>
		/// The position.
		/// </value>
		public Vector3 Position
		{
			get { return ReadMember<Vector3>(StaticOffsets.Position); }
		}

		/// <summary>
		/// Gets this entity's health.
		/// </summary>
		/// <value>
		/// The health.
		/// </value>
		public int Health
		{
			get { return ReadMember<int>(StaticOffsets.Health); }
		}

		/// <summary>
		/// Gets this entity's armor.
		/// </summary>
		/// <value>
		/// The armor.
		/// </value>
		public int Armor
		{
			get { return ReadMember<int>(StaticOffsets.Armor); }
		}

		/// <summary>
		/// Gets a value indicating whether this entity is dormant.
		/// </summary>
		/// <value>
		/// <c>true</c> if this instance is dormant; otherwise, <c>false</c>.
		/// </value>
		public bool IsDormant
		{
			get { return ReadMember<int>(StaticOffsets.Dormant) == 1; }
		}

		/// <summary>
		/// Gets the team this entity is on.
		/// </summary>
		/// <value>
		/// The team.
		/// </value>
		public PlayerTeam Team
		{
			get { return (PlayerTeam) ReadMember<int>(StaticOffsets.Team); }
		}

		/// <summary>
		/// Gets the squared distance to this entity, relative to the local player.
		/// </summary>
		/// <value>
		/// The distance squared.
		/// </value>
		public float DistanceSqr
		{
			get { return Vector3.DistanceSquared(Orion.Me.Position, Position); }
		}

		/// <summary>
		/// Gets the distance to this entity, relative to the local player.
		/// </summary>
		/// <value>
		/// The distance.
		/// </value>
		public float Distance
		{
			get { return Vector3.Distance(Orion.Me.Position, Position); }
		}
	}
}