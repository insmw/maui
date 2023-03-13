using Microsoft.Maui.Graphics;
using System.Threading.Tasks;
using Microsoft.Maui.Media;
using System.IO;
#if (NETSTANDARD || !PLATFORM) || (NET6_0_OR_GREATER && !IOS && !ANDROID && !TIZEN)
using IPlatformViewHandler = Microsoft.Maui.IViewHandler;
#endif
#if IOS || MACCATALYST
using PlatformView = UIKit.UIView;
using ParentView = UIKit.UIView;
#elif ANDROID
using PlatformView = Android.Views.View;
using ParentView = Android.Views.IViewParent;
#elif WINDOWS
using PlatformView = Microsoft.UI.Xaml.FrameworkElement;
using ParentView = Microsoft.UI.Xaml.DependencyObject;
#elif TIZEN
using PlatformView = Tizen.NUI.BaseComponents.View;
using ParentView = Tizen.NUI.BaseComponents.View;
#else
using PlatformView = System.Object;
using ParentView = System.Object;
using System;
#endif

namespace Microsoft.Maui
{
	public static partial class ViewExtensions
	{
		public static FlowDirection GetEffectiveFlowDirection(this IView view)
		{
			if (view.FlowDirection != FlowDirection.MatchParent)
			{
				return view.FlowDirection;
			}

			// If the FlowDirection is MatchParent, then ask the Parent, if available
			if (view.Parent is IView parentView)
			{
				return parentView.GetEffectiveFlowDirection();
			}

			// If there's no parent, try asking the App; failing that, fall back to LTR
			return view.Handler?.MauiContext?.GetFlowDirection() ?? FlowDirection.LeftToRight;
		}

		public static Task<IScreenshotResult?> CaptureAsync(this IView view)
		{
#if PLATFORM
			if (view?.ToPlatform() is not PlatformView platformView)
				return Task.FromResult<IScreenshotResult?>(null);

			if (!Screenshot.Default.IsCaptureSupported)
				return Task.FromResult<IScreenshotResult?>(null);

			return CaptureAsync(platformView);
#else
			return Task.FromResult<IScreenshotResult?>(null);
#endif
		}


#if PLATFORM
		async static Task<IScreenshotResult?> CaptureAsync(PlatformView window) =>
			await Screenshot.Default.CaptureAsync(window);
#endif

#if !TIZEN
		internal static bool NeedsContainer(this IView? view)
		{
			if (view?.Clip != null || view?.Shadow != null)
				return true;

#if ANDROID
			if (view?.InputTransparent == true)
				return true;
#endif

#if ANDROID || IOS
			if (view is IBorder border && border.Border != null)
				return true;
#elif WINDOWS
			if (view is IBorderView border)
				return border?.Shape != null || border?.Stroke != null;
#endif
			return false;
		}
#endif

	}
}
