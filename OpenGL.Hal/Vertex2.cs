﻿
// Copyright (C) 2009-2016 Luca Piccioni
// 
// This library is free software; you can redistribute it and/or
// modify it under the terms of the GNU Lesser General Public
// License as published by the Free Software Foundation; either
// version 2.1 of the License, or (at your option) any later version.
// 
// This library is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
// Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public
// License along with this library; if not, write to the Free Software
// Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301
// USA

using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace OpenGL
{
	/// <summary>
	/// Vertex value type (byte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UByte, 2)]
	[DebuggerDisplay("Vertex2ub: X={x} Y={y}")]
	public struct Vertex2ub : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte"/> that specify the value of every component.
		/// </param>
		public Vertex2ub(byte v) : this(v, v) { }

		/// <summary>
		/// Vertex2ub constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="byte[]"/> that specify the value of every component.
		/// </param>
		public Vertex2ub(byte[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2ub constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="byte"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="byte"/> that specify the Y coordinate.
		/// </param>
		public Vertex2ub(byte x, byte y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2ub constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2ub"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2ub(Vertex2ub other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public byte x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public byte y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2ub operator +(Vertex2ub v1, Vertex2ub v2)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x + v2.x);
			v.y = (byte)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ub"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2ub operator -(Vertex2ub v1, Vertex2ub v2)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x - v2.x);
			v.y = (byte)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator *(Vertex2ub v1, float scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator *(Vertex2ub v1, double scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator /(Vertex2ub v1, float scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator /(Vertex2ub v1, double scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ub"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2ub v1, Vertex2ub v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator *(Vertex2ub v1, byte scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x * scalar);
			v.y = (byte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ub"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="byte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ub"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ub operator /(Vertex2ub v1, byte scalar)
		{
			Vertex2ub v;

			v.x = (byte)(v1.x / scalar);
			v.y = (byte)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2ub v1, Vertex2ub v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2ub v1, Vertex2ub v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to byte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="byte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator byte[](Vertex2ub a)
		{
			byte[] v = new byte[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2ub v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2ub v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2ub v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2ub v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2ub v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ub"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2ub v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2ub Zero = new Vertex2ub(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2ub One = new Vertex2ub(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2ub UnitX = new Vertex2ub(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2ub UnitY = new Vertex2ub(0, 1);

		#endregion

		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (byte)(value * (float)byte.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)byte.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (byte)(value * (float)byte.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2ub.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2ub.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (sbyte coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Byte, 2)]
	[DebuggerDisplay("Vertex2b: X={x} Y={y}")]
	public struct Vertex2b : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte"/> that specify the value of every component.
		/// </param>
		public Vertex2b(sbyte v) : this(v, v) { }

		/// <summary>
		/// Vertex2b constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="sbyte[]"/> that specify the value of every component.
		/// </param>
		public Vertex2b(sbyte[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2b constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="sbyte"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="sbyte"/> that specify the Y coordinate.
		/// </param>
		public Vertex2b(sbyte x, sbyte y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2b constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2b"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2b(Vertex2b other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public sbyte x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public sbyte y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2b to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2b operator -(Vertex2b v)
		{
			return (new Vertex2b((sbyte)(-v.x), (sbyte)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2b operator +(Vertex2b v1, Vertex2b v2)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x + v2.x);
			v.y = (sbyte)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2b"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2b operator -(Vertex2b v1, Vertex2b v2)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x - v2.x);
			v.y = (sbyte)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator *(Vertex2b v1, float scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator *(Vertex2b v1, double scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator /(Vertex2b v1, float scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator /(Vertex2b v1, double scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2b"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2b v1, Vertex2b v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator *(Vertex2b v1, sbyte scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x * scalar);
			v.y = (sbyte)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2b"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="sbyte"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2b"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2b operator /(Vertex2b v1, sbyte scalar)
		{
			Vertex2b v;

			v.x = (sbyte)(v1.x / scalar);
			v.y = (sbyte)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2b v1, Vertex2b v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2b v1, Vertex2b v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2b v1, Vertex2b v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2b v1, Vertex2b v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2b v1, Vertex2b v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2b v1, Vertex2b v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to sbyte[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="sbyte[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator sbyte[](Vertex2b a)
		{
			sbyte[] v = new sbyte[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2b v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2b v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2b v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2b v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2b v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2b"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2b v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2b Zero = new Vertex2b(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2b One = new Vertex2b(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2b UnitX = new Vertex2b(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2b UnitY = new Vertex2b(0, 1);

		#endregion

		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - sbyte.MinValue) / ((long)sbyte.MaxValue - (long)sbyte.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (sbyte)((value * 0.5f + 0.5f) * ((long)sbyte.MaxValue - (long)sbyte.MinValue) + sbyte.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2b.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2b.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (ushort coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UShort, 2)]
	[DebuggerDisplay("Vertex2us: X={x} Y={y}")]
	public struct Vertex2us : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort"/> that specify the value of every component.
		/// </param>
		public Vertex2us(ushort v) : this(v, v) { }

		/// <summary>
		/// Vertex2us constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="ushort[]"/> that specify the value of every component.
		/// </param>
		public Vertex2us(ushort[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2us constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="ushort"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="ushort"/> that specify the Y coordinate.
		/// </param>
		public Vertex2us(ushort x, ushort y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2us constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2us"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2us(Vertex2us other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public ushort x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public ushort y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2us operator +(Vertex2us v1, Vertex2us v2)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x + v2.x);
			v.y = (ushort)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2us"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2us operator -(Vertex2us v1, Vertex2us v2)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x - v2.x);
			v.y = (ushort)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator *(Vertex2us v1, float scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator *(Vertex2us v1, double scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator /(Vertex2us v1, float scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator /(Vertex2us v1, double scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2us"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2us v1, Vertex2us v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator *(Vertex2us v1, ushort scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x * scalar);
			v.y = (ushort)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2us"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="ushort"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2us"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2us operator /(Vertex2us v1, ushort scalar)
		{
			Vertex2us v;

			v.x = (ushort)(v1.x / scalar);
			v.y = (ushort)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2us v1, Vertex2us v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2us v1, Vertex2us v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2us v1, Vertex2us v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2us v1, Vertex2us v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2us v1, Vertex2us v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2us v1, Vertex2us v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to ushort[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="ushort[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator ushort[](Vertex2us a)
		{
			ushort[] v = new ushort[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2us v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2us v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2us v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2us v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2us v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2us"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2us v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2us Zero = new Vertex2us(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2us One = new Vertex2us(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2us UnitX = new Vertex2us(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2us UnitY = new Vertex2us(0, 1);

		#endregion

		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)ushort.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (ushort)(value * (float)ushort.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2us.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2us.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (short coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Short, 2)]
	[DebuggerDisplay("Vertex2s: X={x} Y={y}")]
	public struct Vertex2s : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short"/> that specify the value of every component.
		/// </param>
		public Vertex2s(short v) : this(v, v) { }

		/// <summary>
		/// Vertex2s constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="short[]"/> that specify the value of every component.
		/// </param>
		public Vertex2s(short[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2s constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="short"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="short"/> that specify the Y coordinate.
		/// </param>
		public Vertex2s(short x, short y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2s constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2s"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2s(Vertex2s other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public short x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public short y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2s to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2s operator -(Vertex2s v)
		{
			return (new Vertex2s((short)(-v.x), (short)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2s operator +(Vertex2s v1, Vertex2s v2)
		{
			Vertex2s v;

			v.x = (short)(v1.x + v2.x);
			v.y = (short)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2s"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2s operator -(Vertex2s v1, Vertex2s v2)
		{
			Vertex2s v;

			v.x = (short)(v1.x - v2.x);
			v.y = (short)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator *(Vertex2s v1, float scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator *(Vertex2s v1, double scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator /(Vertex2s v1, float scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator /(Vertex2s v1, double scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2s"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2s v1, Vertex2s v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator *(Vertex2s v1, short scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x * scalar);
			v.y = (short)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2s"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="short"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2s"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2s operator /(Vertex2s v1, short scalar)
		{
			Vertex2s v;

			v.x = (short)(v1.x / scalar);
			v.y = (short)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2s v1, Vertex2s v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2s v1, Vertex2s v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2s v1, Vertex2s v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2s v1, Vertex2s v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2s v1, Vertex2s v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2s v1, Vertex2s v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to short[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="short[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator short[](Vertex2s a)
		{
			short[] v = new short[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2s v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2s v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2s v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2s v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2s v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2s"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2s v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2s Zero = new Vertex2s(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2s One = new Vertex2s(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2s UnitX = new Vertex2s(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2s UnitY = new Vertex2s(0, 1);

		#endregion

		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - short.MinValue) / ((long)short.MaxValue - (long)short.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (short)((value * 0.5f + 0.5f) * ((long)short.MaxValue - (long)short.MinValue) + short.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2s.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2s.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (uint coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.UInt, 2)]
	[DebuggerDisplay("Vertex2ui: X={x} Y={y}")]
	public struct Vertex2ui : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint"/> that specify the value of every component.
		/// </param>
		public Vertex2ui(uint v) : this(v, v) { }

		/// <summary>
		/// Vertex2ui constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="uint[]"/> that specify the value of every component.
		/// </param>
		public Vertex2ui(uint[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2ui constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="uint"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="uint"/> that specify the Y coordinate.
		/// </param>
		public Vertex2ui(uint x, uint y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2ui constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2ui"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2ui(Vertex2ui other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public uint x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public uint y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2ui operator +(Vertex2ui v1, Vertex2ui v2)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x + v2.x);
			v.y = (uint)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ui"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2ui operator -(Vertex2ui v1, Vertex2ui v2)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x - v2.x);
			v.y = (uint)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator *(Vertex2ui v1, float scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator *(Vertex2ui v1, double scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator /(Vertex2ui v1, float scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator /(Vertex2ui v1, double scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2ui"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2ui v1, Vertex2ui v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator *(Vertex2ui v1, uint scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x * scalar);
			v.y = (uint)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2ui"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="uint"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2ui"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2ui operator /(Vertex2ui v1, uint scalar)
		{
			Vertex2ui v;

			v.x = (uint)(v1.x / scalar);
			v.y = (uint)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2ui v1, Vertex2ui v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2ui v1, Vertex2ui v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to uint[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="uint[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator uint[](Vertex2ui a)
		{
			uint[] v = new uint[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex2ui v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2ui v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static explicit operator Vertex3f(Vertex2ui v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2ui v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static explicit operator Vertex4f(Vertex2ui v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2ui"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2ui v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2ui Zero = new Vertex2ui(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2ui One = new Vertex2ui(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2ui UnitX = new Vertex2ui(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2ui UnitY = new Vertex2ui(0, 1);

		#endregion

		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [0.0, 1.0].
		/// </summary>
		public float X
		{
			get { return ((float)x / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				x = (uint)(value * (float)uint.MaxValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [0.0, 1.0].
		/// </summary>
		public float Y
		{
			get { return ((float)y / (float)uint.MaxValue); }
			set
			{
				if (value < 0.0f || value > 1.0)
					throw new InvalidOperationException("value out of range");
				y = (uint)(value * (float)uint.MaxValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2ui.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2ui.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (int coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Int, 2)]
	[DebuggerDisplay("Vertex2i: X={x} Y={y}")]
	public struct Vertex2i : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int"/> that specify the value of every component.
		/// </param>
		public Vertex2i(int v) : this(v, v) { }

		/// <summary>
		/// Vertex2i constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="int[]"/> that specify the value of every component.
		/// </param>
		public Vertex2i(int[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2i constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="int"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="int"/> that specify the Y coordinate.
		/// </param>
		public Vertex2i(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2i constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2i"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2i(Vertex2i other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public int x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public int y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2i to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2i operator -(Vertex2i v)
		{
			return (new Vertex2i((int)(-v.x), (int)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2i operator +(Vertex2i v1, Vertex2i v2)
		{
			Vertex2i v;

			v.x = (int)(v1.x + v2.x);
			v.y = (int)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2i"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2i operator -(Vertex2i v1, Vertex2i v2)
		{
			Vertex2i v;

			v.x = (int)(v1.x - v2.x);
			v.y = (int)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator *(Vertex2i v1, float scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator *(Vertex2i v1, double scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator /(Vertex2i v1, float scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator /(Vertex2i v1, double scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2i"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2i v1, Vertex2i v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator *(Vertex2i v1, int scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x * scalar);
			v.y = (int)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2i"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="int"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2i"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2i operator /(Vertex2i v1, int scalar)
		{
			Vertex2i v;

			v.x = (int)(v1.x / scalar);
			v.y = (int)(v1.y / scalar);

			return (v);
		}

		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2i v1, Vertex2i v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2i v1, Vertex2i v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2i v1, Vertex2i v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2i v1, Vertex2i v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2i v1, Vertex2i v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2i v1, Vertex2i v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to int[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="int[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator int[](Vertex2i a)
		{
			int[] v = new int[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex2i v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2i v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static explicit operator Vertex3f(Vertex2i v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2i v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static explicit operator Vertex4f(Vertex2i v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2i"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2i v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2i Zero = new Vertex2i(0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2i One = new Vertex2i(1);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2i UnitX = new Vertex2i(1, 0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2i UnitY = new Vertex2i(0, 1);

		#endregion

		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, normalized in range [-1.0, +1.0].
		/// </summary>
		public float X
		{
			get { return ((float)(x - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				x = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		/// <summary>
		/// Vertex coordinate Y, normalized in range [-1.0, +1.0]..
		/// </summary>
		public float Y
		{
			get { return ((float)(y - int.MinValue) / ((long)int.MaxValue - (long)int.MinValue)) * 2.0f - 1.0f; }
			set
			{
				if (value < -1.0f || value > +1.0)
					throw new InvalidOperationException("value out of range");
				y = (int)((value * 0.5f + 0.5f) * ((long)int.MaxValue - (long)int.MinValue) + int.MinValue);
			}
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2i.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2i.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0}, {1}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (float coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Float, 2)]
	[DebuggerDisplay("Vertex2f: X={x} Y={y}")]
	public struct Vertex2f : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float"/> that specify the value of every component.
		/// </param>
		public Vertex2f(float v) : this(v, v) { }

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="float[]"/> that specify the value of every component.
		/// </param>
		public Vertex2f(float[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="float"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="float"/> that specify the Y coordinate.
		/// </param>
		public Vertex2f(float x, float y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2f constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2f"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2f(Vertex2f other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public float x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public float y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2f to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2f operator -(Vertex2f v)
		{
			return (new Vertex2f((float)(-v.x), (float)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2f operator +(Vertex2f v1, Vertex2f v2)
		{
			Vertex2f v;

			v.x = (float)(v1.x + v2.x);
			v.y = (float)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2f"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2f operator -(Vertex2f v1, Vertex2f v2)
		{
			Vertex2f v;

			v.x = (float)(v1.x - v2.x);
			v.y = (float)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2f operator *(Vertex2f v1, float scalar)
		{
			Vertex2f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2f operator *(Vertex2f v1, double scalar)
		{
			Vertex2f v;

			v.x = (float)(v1.x * scalar);
			v.y = (float)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2f operator /(Vertex2f v1, float scalar)
		{
			Vertex2f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2f operator /(Vertex2f v1, double scalar)
		{
			Vertex2f v;

			v.x = (float)(v1.x / scalar);
			v.y = (float)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2f"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2f"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2f v1, Vertex2f v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2f v1, Vertex2f v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2f v1, Vertex2f v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2f v1, Vertex2f v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2f v1, Vertex2f v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2f v1, Vertex2f v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2f v1, Vertex2f v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to float[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="float[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator float[](Vertex2f a)
		{
			float[] v = new float[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2f v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2f v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2f v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2f v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2f"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2f v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2f Zero = new Vertex2f(0.0f);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2f One = new Vertex2f(1.0f);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2f UnitX = new Vertex2f(1.0f, 0.0f);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2f UnitY = new Vertex2f(0.0f, 1.0f);

		#endregion

		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (float)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (float)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2f.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2f.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (double coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Double, 2)]
	[DebuggerDisplay("Vertex2d: X={x} Y={y}")]
	public struct Vertex2d : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double"/> that specify the value of every component.
		/// </param>
		public Vertex2d(double v) : this(v, v) { }

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="double[]"/> that specify the value of every component.
		/// </param>
		public Vertex2d(double[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="double"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="double"/> that specify the Y coordinate.
		/// </param>
		public Vertex2d(double x, double y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2d constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2d"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2d(Vertex2d other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public double x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public double y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2d to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2d operator -(Vertex2d v)
		{
			return (new Vertex2d((double)(-v.x), (double)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2d operator +(Vertex2d v1, Vertex2d v2)
		{
			Vertex2d v;

			v.x = (double)(v1.x + v2.x);
			v.y = (double)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2d operator -(Vertex2d v1, Vertex2d v2)
		{
			Vertex2d v;

			v.x = (double)(v1.x - v2.x);
			v.y = (double)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2d operator *(Vertex2d v1, float scalar)
		{
			Vertex2d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2d operator *(Vertex2d v1, double scalar)
		{
			Vertex2d v;

			v.x = (double)(v1.x * scalar);
			v.y = (double)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2d operator /(Vertex2d v1, float scalar)
		{
			Vertex2d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2d operator /(Vertex2d v1, double scalar)
		{
			Vertex2d v;

			v.x = (double)(v1.x / scalar);
			v.y = (double)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2d"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2d"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2d v1, Vertex2d v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2d v1, Vertex2d v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2d v1, Vertex2d v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2d v1, Vertex2d v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2d v1, Vertex2d v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2d v1, Vertex2d v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2d v1, Vertex2d v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to double[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="double[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator double[](Vertex2d a)
		{
			double[] v = new double[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static explicit operator Vertex2f(Vertex2d v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static explicit operator Vertex3f(Vertex2d v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2d v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static explicit operator Vertex4f(Vertex2d v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2d"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2d v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion

		#region Notable Vertex

		/// <summary>
		/// Origin vertex.
		/// </summary>
		public static readonly Vertex2d Zero = new Vertex2d(0.0);

		/// <summary>
		/// Unit vertex along all axes.
		/// </summary>
		public static readonly Vertex2d One = new Vertex2d(1.0);

		/// <summary>
		/// Unit vertex along X axis.
		/// </summary>
		public static readonly Vertex2d UnitX = new Vertex2d(1.0, 0.0);

		/// <summary>
		/// Unit vertex along Y axis.
		/// </summary>
		public static readonly Vertex2d UnitY = new Vertex2d(0.0, 1.0);

		#endregion

		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (double)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (double)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2d.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2d.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}|", x, y));
		}

		#endregion
	}

	/// <summary>
	/// Vertex value type (HalfFloat coordinates).
	/// </summary>
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[ArrayBufferItem(VertexBaseType.Half, 2)]
	[DebuggerDisplay("Vertex2hf: X={x} Y={y}")]
	public struct Vertex2hf : IVertex2, IEquatable<IVertex2>
	{
		#region Constructors

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat"/> that specify the value of every component.
		/// </param>
		public Vertex2hf(HalfFloat v) : this(v, v) { }

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="v">
		/// A <see cref="HalfFloat[]"/> that specify the value of every component.
		/// </param>
		public Vertex2hf(HalfFloat[] v) : this(v[0], v[1]) { }

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="x">
		/// A <see cref="HalfFloat"/> that specify the X coordinate.
		/// </param>
		/// <param name="y">
		/// A <see cref="HalfFloat"/> that specify the Y coordinate.
		/// </param>
		public Vertex2hf(HalfFloat x, HalfFloat y)
		{
			this.x = x;
			this.y = y;
		}

		/// <summary>
		/// Vertex2hf constructor.
		/// </summary>
		/// <param name="other">
		/// A <see cref="Vertex2hf"/> that specify the vertex to be copied.
		/// </param>
		public Vertex2hf(Vertex2hf other) : this(other.x, other.y) { }

		#endregion

		#region Structure

		/// <summary>
		/// X coordinate for bidimensional vertex.
		/// </summary>
		public HalfFloat x;

		/// <summary>
		/// Y coordinate for bidimensional vertex.
		/// </summary>
		public HalfFloat y;

		#endregion

		#region Arithmetic Operators

		/// <summary>
		/// Negate operator.
		/// </summary>
		/// <param name="v">
		/// The Vertex2hf to negate.
		/// </param>
		/// <returns>
		/// It returns the negate of <paramref name="v"/>.
		/// </returns>
		public static Vertex2hf operator -(Vertex2hf v)
		{
			return (new Vertex2hf((HalfFloat)(-v.x), (HalfFloat)(-v.y)));
		}

		/// <summary>
		/// Add operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the addition of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2hf operator +(Vertex2hf v1, Vertex2hf v2)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x + v2.x);
			v.y = (HalfFloat)(v1.y + v2.y);

			return (v);
		}

		/// <summary>
		/// Subtract operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2hf"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the subtraction of <paramref name="v1"/> and <paramref name="v2"/>.
		/// </returns>
		public static Vertex2hf operator -(Vertex2hf v1, Vertex2hf v2)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x - v2.x);
			v.y = (HalfFloat)(v1.y - v2.y);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2hf operator *(Vertex2hf v1, float scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar multiply operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the multiplication of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2hf operator *(Vertex2hf v1, double scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x * scalar);
			v.y = (HalfFloat)(v1.y * scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Single"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2hf operator /(Vertex2hf v1, float scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Scalar divide operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> that specify the left operand.
		/// </param>
		/// <param name="scalar">
		/// A <see cref="Double"/> that specify the right operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> that equals to the division of <paramref name="v1"/> with <paramref name="scalar"/>.
		/// </returns>
		public static Vertex2hf operator /(Vertex2hf v1, double scalar)
		{
			Vertex2hf v;

			v.x = (HalfFloat)(v1.x / scalar);
			v.y = (HalfFloat)(v1.y / scalar);

			return (v);
		}

		/// <summary>
		/// Dot product operator.
		/// </summary>
		/// <param name="v1">
		/// A <see cref="Vertex2hf"/> representing the left dot product operand.
		/// </param>
		/// <param name="v2">
		/// A <see cref="Vertex2hf"/> representing the right dot product operand.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2hf"/> representing the dot product between <paramref name="v1"/> and
		/// <paramref name="v2"/>.
		/// </returns>
		public static float operator *(Vertex2hf v1, Vertex2hf v2)
		{
			return (float)(v1.x * v2.x + v1.y * v2.y);
		}


		#endregion

		#region Equality Operators

		/// <summary>
		/// Equality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator ==(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.Equals(v2));
		}

		/// <summary>
		/// Inequality operator.
		/// </summary>
		/// <param name="v1"></param>
		/// <param name="v2"></param>
		/// <returns></returns>
		public static bool operator !=(Vertex2hf v1, Vertex2hf v2)
		{
			return (!v1.Equals(v2));
		}

		#endregion

		#region Relational Operators

		/// <summary>
		/// Less than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator <(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.x < v2.x && v1.y < v2.y);
		}

		/// <summary>
		/// Greater than operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than <paramref name="v2"/>.
		/// </returns>
		public static bool operator >(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.x > v2.x && v1.y > v2.y);
		}

		/// <summary>
		/// Less than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator <=(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.x <= v2.x && v1.y <= v2.y);
		}

		/// <summary>
		/// Greater than or equal to operator.
		/// </summary>
		/// <param name="v1">The left operand.</param>
		/// <param name="v2">The right operand</param>
		/// <returns>
		/// It returns true if <paramref name="v1"/> is less than or equal to <paramref name="v2"/>.
		/// </returns>
		public static bool operator >=(Vertex2hf v1, Vertex2hf v2)
		{
			return (v1.x >= v2.x && v1.y >= v2.y);
		}

		#endregion

		#region Cast Operators

		/// <summary>
		/// Cast to HalfFloat[] operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="HalfFloat[]"/> initialized with the vector components.
		/// </returns>
		public static explicit operator HalfFloat[](Vertex2hf a)
		{
			HalfFloat[] v = new HalfFloat[2];

			v[0] = a.x;
			v[1] = a.y;

			return (v);
		}

		/// <summary>
		/// Cast to Vertex2f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2f"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2f(Vertex2hf v)
		{
			return (new Vertex2f(v.X, v.Y));
		}

		/// <summary>
		/// Cast to Vertex2d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex2d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex2d(Vertex2hf v)
		{
			return (new Vertex2d(v.X, v.Y));
		}
		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3f"/> initialized with the vector components, and Z component is implictly zero.
		/// </returns>
		public static implicit operator Vertex3f(Vertex2hf v)
		{
			return (new Vertex3f(v.X, v.Y, 0.0f));
		}

		/// <summary>
		/// Cast to Vertex3d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex3d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex3d(Vertex2hf v)
		{
			return (new Vertex3d(v.X, v.Y, 0.0));
		}

		/// <summary>
		/// Cast to Vertex3f operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4f"/> initialized with the vector components, and Z and W components are implictly zero.
		/// </returns>
		public static implicit operator Vertex4f(Vertex2hf v)
		{
			return (new Vertex4f(v.X, v.Y, 0.0f, 1.0f));
		}

		/// <summary>
		/// Cast to Vertex4d operator.
		/// </summary>
		/// <param name="a">
		/// A <see cref="Vertex2hf"/> to be casted.
		/// </param>
		/// <returns>
		/// A <see cref="Vertex4d"/> initialized with the vector components.
		/// </returns>
		public static implicit operator Vertex4d(Vertex2hf v)
		{
			return (new Vertex4d(v.X, v.Y, 0.0, 1.0));
		}

		#endregion
		#region IVertex2 Implementation

		/// <summary>
		/// Vertex coordinate X, unclamped range.
		/// </summary>
		public float X
		{
			get { return ((float)x); }
			set { x = (HalfFloat)value; }
		}

		/// <summary>
		/// Vertex coordinate Y, unclamped range.
		/// </summary>
		public float Y
		{
			get { return ((float)y); }
			set { y = (HalfFloat)value; }
		}

		#endregion

		#region IVertex Implementation

		/// <summary>
		/// Vertex components indexer.
		/// </summary>
		/// <param name="idx">
		/// A <see cref="UInt32"/> that specify the component index using for accessing to this IVertex component.
		/// </param>
		/// <remarks>
		/// <para>
		/// This indexer returns a single-precision floating-point representation of the vertex component value.
		/// </para>
		/// </remarks>
		/// <exception cref="ArgumentOutOfRangeException">
		/// Exception thrown if <paramref name="idx"/> exceeds the maximum allowed component index.
		/// </exception>
		/// <exception cref="InvalidOperationException">
		/// Exception thrown if the set value is outside the representable range of the underlying type.
		/// </exception>s
		public float this[uint idx]
		{
			get
			{
				switch (idx) {
					case 0: return (X);
					case 1: return (Y);
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
			set
			{
				switch (idx) {
					case 0: X = value; break;
					case 1: Y = value; break;
					default:
						throw new ArgumentOutOfRangeException("idx");
				}
			}
		}

		#endregion

		#region IEquatable<IVertex2> Implementation

		/// <summary>
		/// Indicates whether the this IVertex3 is equal to another IVertex3.
		/// </summary>
		/// <param name="other">
		/// An IVertex3 to compare with this object.
		/// </param>
		/// <returns>
		/// It returns true if the this IVertex3 is equal to <paramref name="other"/>; otherwise, false.
		/// </returns>
		public bool Equals(IVertex2 other)
		{
			const float Epsilon = 1e-6f;

			if (ReferenceEquals(null, other))
				return false;

			if (Math.Abs(X - other.X) >= Epsilon)
				return (false);
			if (Math.Abs(Y - other.Y) >= Epsilon)
				return (false);

			return (true);
		}

		/// <summary>
		/// Determines whether the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>.
		/// </summary>
		/// <param name="obj">
		/// The <see cref="T:System.Object"/> to compare with the current <see cref="T:System.Object"/>.
		/// </param>
		/// <returns>
		/// It returns true if the specified <see cref="T:System.Object"/> is equal to the current <see cref="T:System.Object"/>; otherwise, false.
		/// </returns>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj))
				return (false);
			if (obj.GetType().GetInterface("IVertex2") == null)
				return (false);

			return (Equals((IVertex2)obj));
		}

		/// <summary>
		/// Serves as a hash function for a particular type. <see cref="M:System.Object.GetHashCode"/> is suitable for
		/// use in hashing algorithms and data structures like a hash table.
		/// </summary>
		/// <returns>
		/// A hash code for the current <see cref="T:System.Object"/>.
		/// </returns>
		public override int GetHashCode()
		{
			unchecked {
				int result = x.GetHashCode();
				result = (result * 397) ^ y.GetHashCode();

				return result;
			}
		}

		#endregion

		#region Object Overrides

		/// <summary>
		/// Stringify this Vertex2hf.
		/// </summary>
		/// <returns>
		/// Returns a <see cref="String"/> that represents this Vertex2hf.
		/// </returns>
		public override string ToString()
		{
			return (String.Format("|{0:F4}, {1:F4}|", x, y));
		}

		#endregion
	}

}