
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
		/// Binding for glXGetVideoSyncSGI.
		/// </summary>
		/// <param name="count">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGI_video_sync")]
		public static int GetVideoSyncSGI(IntPtr count)
		{
			int retValue;

			Debug.Assert(Delegates.pglXGetVideoSyncSGI != null, "pglXGetVideoSyncSGI not implemented");
			retValue = Delegates.pglXGetVideoSyncSGI(count);
			LogFunction("glXGetVideoSyncSGI(0x{0}) = {1}", count.ToString("X8"), retValue);

			return (retValue);
		}

		/// <summary>
		/// Binding for glXWaitVideoSyncSGI.
		/// </summary>
		/// <param name="divisor">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="remainder">
		/// A <see cref="T:int"/>.
		/// </param>
		/// <param name="count">
		/// A <see cref="T:IntPtr"/>.
		/// </param>
		[RequiredByFeature("GLX_SGI_video_sync")]
		public static int WaitVideoSyncSGI(int divisor, int remainder, IntPtr count)
		{
			int retValue;

			Debug.Assert(Delegates.pglXWaitVideoSyncSGI != null, "pglXWaitVideoSyncSGI not implemented");
			retValue = Delegates.pglXWaitVideoSyncSGI(divisor, remainder, count);
			LogFunction("glXWaitVideoSyncSGI({0}, {1}, 0x{2}) = {3}", divisor, remainder, count.ToString("X8"), retValue);

			return (retValue);
		}

	}

}
