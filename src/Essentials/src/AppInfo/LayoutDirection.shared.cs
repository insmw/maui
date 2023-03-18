﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Maui.Patched.ApplicationModel
{
	/// <summary>
	/// Enumerates possible layout directions.
	/// </summary>
	public enum LayoutDirection
	{
		/// <summary>The requested layout direction is unknown.</summary>
		Unknown,

		/// <summary>The requested layout direction is left-to-right.</summary>
		LeftToRight,

		/// <summary>The requested layout direction is right-to-left.</summary>
		RightToLeft
	}
}
