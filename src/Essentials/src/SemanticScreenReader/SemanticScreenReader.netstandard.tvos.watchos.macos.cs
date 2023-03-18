using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Accessibility
{
	partial class SemanticScreenReaderImplementation : ISemanticScreenReader
	{
		public void Announce(string text) =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
