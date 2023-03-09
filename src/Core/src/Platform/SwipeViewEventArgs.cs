using System;

namespace Microsoft.Maui.Platform
{
	internal class SwipeItemsAddedEventArgs : EventArgs
	{
		public SwipeItemsAddedEventArgs(ISwipeItems swipeItems)
		{
			AddedSwipeItems = swipeItems;
		}

		public ISwipeItems AddedSwipeItems { get; private set; }
	}
}