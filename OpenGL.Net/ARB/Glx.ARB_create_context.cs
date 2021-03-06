
// Copyright (C) 2015 Luca Piccioni
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
using System.Text;

namespace OpenGL
{
	public partial class Glx
	{
		/// <summary>
		/// Value of GLX_CONTEXT_DEBUG_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GLX_ARB_create_context")]
		[Log(BitmaskName = "GLXContextFlags")]
		public const uint CONTEXT_DEBUG_BIT_ARB = 0x00000001;

		/// <summary>
		/// Value of GLX_CONTEXT_FORWARD_COMPATIBLE_BIT_ARB symbol.
		/// </summary>
		[RequiredByFeature("GLX_ARB_create_context")]
		[Log(BitmaskName = "GLXContextFlags")]
		public const uint CONTEXT_FORWARD_COMPATIBLE_BIT_ARB = 0x00000002;

		/// <summary>
		/// Value of GLX_CONTEXT_MAJOR_VERSION_ARB symbol.
		/// </summary>
		[RequiredByFeature("GLX_ARB_create_context")]
		public const int CONTEXT_MAJOR_VERSION_ARB = 0x2091;

		/// <summary>
		/// Value of GLX_CONTEXT_MINOR_VERSION_ARB symbol.
		/// </summary>
		[RequiredByFeature("GLX_ARB_create_context")]
		public const int CONTEXT_MINOR_VERSION_ARB = 0x2092;

		/// <summary>
		/// Value of GLX_CONTEXT_FLAGS_ARB symbol.
		/// </summary>
		[RequiredByFeature("GLX_ARB_create_context")]
		public const int CONTEXT_FLAGS_ARB = 0x2094;

		/// <summary>
		/// Binding for glXCreateContextAttribsARB.
		/// </summary>
		/// <param name="dpy">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="config">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="share_context">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		/// <param name="direct">
		/// A <see cref="T:bool"/>.
		/// </param>
		/// <param name="attrib_list">
		/// A <see cref="T:int[]"/>.
		/// </param>
		[RequiredByFeature("GLX_ARB_create_context")]
		public static IntPtr CreateContextAttribsARB(IntPtr dpy, IntPtr config, IntPtr share_context, bool direct, int[] attrib_list)
		{
			IntPtr retValue;

			unsafe {
				fixed (int* p_attrib_list = attrib_list)
				{
					Debug.Assert(Delegates.pglXCreateContextAttribsARB != null, "pglXCreateContextAttribsARB not implemented");
					retValue = Delegates.pglXCreateContextAttribsARB(dpy, config, share_context, direct, p_attrib_list);
					LogFunction("glXCreateContextAttribsARB(0x{0}, 0x{1}, 0x{2}, {3}, {4}) = {5}", dpy.ToString("X8"), config.ToString("X8"), share_context.ToString("X8"), direct, LogValue(attrib_list), retValue.ToString("X8"));
				}
			}

			return (retValue);
		}

	}

}
