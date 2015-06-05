// Copyright (C) 2015 aevitas
// See the file LICENSE for copying permission.

using System;
using Orion.GlobalOffensive.Patchables;

namespace Orion.GlobalOffensive.Objects
{
	/// <summary>
	///     A native object in the game, one whose resources we do not directly own, but do manipulate.
	/// </summary>
	public abstract class NativeObject : IEquatable<NativeObject>
	{
		/// <summary>
		///     Initializes a new instance of the <see cref="NativeObject" /> class.
		/// </summary>
		/// <param name="baseAddress">The base address.</param>
		protected NativeObject(IntPtr baseAddress)
		{
			BaseAddress = baseAddress;
		}

		/// <summary>
		///     Gets the base address of this object in the remote process.
		/// </summary>
		public IntPtr BaseAddress { get; private set; }

		/// <summary>
		///     Gets a value indicating whether this instance is valid.
		/// </summary>
		/// <value>
		///     <c>true</c> if this instance is valid; otherwise, <c>false</c>.
		/// </value>
		public bool IsValid
		{
			get { return BaseAddress != IntPtr.Zero; }
		}

		/// <summary>
		///     Returns a hash code for this instance.
		/// </summary>
		/// <returns>
		///     A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
		/// </returns>
		public override int GetHashCode()
		{
			return BaseAddress.GetHashCode();
		}

		/// <summary>
		///     Reads a member of the specified type at the specified offset.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="offset">The offset.</param>
		/// <returns></returns>
		protected T ReadField<T>(int offset) where T : struct
		{
			return Orion.Memory.Read<T>(BaseAddress + offset);
		}

		/// <summary>
		///     Reads a member of the specified type at the specified offset.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="offset">The offset.</param>
		/// <returns></returns>
		protected T ReadField<T>(StaticOffsets offset) where T : struct
		{
			return ReadField<T>((int) offset);
		}

		/// <summary>
		///     Reads a member of the specified type at the specified offset.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="offset">The offset.</param>
		/// <returns></returns>
		protected T ReadField<T>(BaseOffsets offset) where T : struct
		{
			return ReadField<T>((int) offset);
		}

		#region Implementation of IEquatable

		/// <summary>
		///     Indicates whether the current object is equal to another object of the same type.
		/// </summary>
		/// <param name="other">An object to compare with this object.</param>
		/// <returns>
		///     true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
		/// </returns>
		public bool Equals(NativeObject other)
		{
			return BaseAddress == other.BaseAddress;
		}

		/// <summary>
		///     Determines whether the specified <see cref="System.Object" />, is equal to this instance.
		/// </summary>
		/// <param name="obj">The <see cref="System.Object" /> to compare with this instance.</param>
		/// <returns>
		///     <c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			return obj.GetType() == GetType() && Equals((NativeObject) obj);
		}

		#endregion

		#region Operators

		/// <summary>
		///     Implements the operator ==.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>
		///     The result of the operator.
		/// </returns>
		public static bool operator ==(NativeObject left, NativeObject right)
		{
			return Equals(left, right);
		}

		/// <summary>
		///     Implements the operator !=.
		/// </summary>
		/// <param name="left">The left.</param>
		/// <param name="right">The right.</param>
		/// <returns>
		///     The result of the operator.
		/// </returns>
		public static bool operator !=(NativeObject left, NativeObject right)
		{
			return !Equals(left, right);
		}

		#endregion
	}
}