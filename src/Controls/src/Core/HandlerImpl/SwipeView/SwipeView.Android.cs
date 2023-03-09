namespace Microsoft.Maui.Controls
{
	public partial class SwipeView
	{
		MauiSwipeView? _mauiSwipeView;

		private protected override void OnHandlerChangedCore()
		{
			base.OnHandlerChangedCore();

			if (Handler is not null)
			{
				if (Handler is SwipeViewHandler swipeViewHandler && swipeViewHandler.PlatformView is MauiSwipeView mauiSwipeView)
				{
					_mauiSwipeView = mauiSwipeView;
					_mauiSwipeView.SwipeItemsAdded += OnSwipeItemsAdded;
					_mauiSwipeView.SwipeItemsRemoved += OnSwipeItemsRemoved;
				}
			}
			else if (_mauiSwipeView is not null)
			{
				_mauiSwipeView.SwipeItemsAdded -= OnSwipeItemsAdded;
				_mauiSwipeView.SwipeItemsRemoved -= OnSwipeItemsRemoved;
				_mauiSwipeView = null;
			}
		}

		void OnSwipeItemsAdded(object? sender, SwipeItemsAddedEventArgs e)
		{
			foreach (var swipeItem in e.AddedSwipeItems)
			{
				if (swipeItem is Element element)
				{
					AddLogicalChild(element);
				}
			}
		}

		void OnSwipeItemsRemoved(object? sender, System.EventArgs e)
		{
			ClearLogicalChildren();
		}
	}
}