using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Maui.Patched.ApplicationModel;

namespace Microsoft.Maui.Patched.Media
{
	partial class TextToSpeechImplementation : ITextToSpeech
	{
		Task PlatformSpeakAsync(string text, SpeechOptions options, CancellationToken cancelToken) =>
			throw ExceptionUtils.NotSupportedOrImplementedException;

		Task<IEnumerable<Locale>> PlatformGetLocalesAsync() =>
			throw ExceptionUtils.NotSupportedOrImplementedException;
	}
}
