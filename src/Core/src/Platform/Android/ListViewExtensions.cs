using Android.Widget;
using ALayoutDirection = Android.Views.LayoutDirection;
using ATextDirection = Android.Views.TextDirection;

namespace Microsoft.Maui
{
	public static class ListViewExtensions
	{
		public static void UpdateFlowDirection(this ListView platformView, IView view)
		{
			switch (view.GetEffectiveFlowDirection())
			{
				case FlowDirection.MatchParent:
					platformView.LayoutDirection = ALayoutDirection.Inherit;
					platformView.TextDirection = ATextDirection.Inherit;
					break;
				case FlowDirection.RightToLeft:
					platformView.LayoutDirection = ALayoutDirection.Rtl;
					platformView.TextDirection = ATextDirection.Rtl;
					break;
				case FlowDirection.LeftToRight:
					platformView.LayoutDirection = ALayoutDirection.Ltr;
					platformView.TextDirection = ATextDirection.Ltr;
					break;
			}
		}
	}
}
