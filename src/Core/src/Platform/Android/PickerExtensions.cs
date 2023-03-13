﻿using Android.App;
using Android.Content.Res;

namespace Microsoft.Maui.Platform
{
	public static class PickerExtensions
	{
		public static void UpdateTitle(this MauiPicker platformPicker, IPicker picker) =>
			UpdatePicker(platformPicker, picker);

		public static void UpdateTitleColor(this MauiPicker platformPicker, IPicker picker)
		{
			var titleColor = picker.TitleColor;

			if (titleColor != null)
			{
				if (PlatformInterop.CreateEditTextColorStateList(platformPicker.TextColors, titleColor.ToPlatform()) is ColorStateList c)
					platformPicker.SetHintTextColor(c);
			}
		}

		public static void UpdateTextColor(this MauiPicker platformPicker, IPicker picker, ColorStateList? defaultColor)
		{
			var textColor = picker.TextColor;

			if (textColor == null)
			{
				platformPicker.SetTextColor(defaultColor);
			}
			else
			{
				if (PlatformInterop.CreateEditTextColorStateList(platformPicker.TextColors, textColor.ToPlatform()) is ColorStateList c)
					platformPicker.SetTextColor(c);
			}
		}

		public static void UpdateSelectedIndex(this MauiPicker platformPicker, IPicker picker) =>
			UpdatePicker(platformPicker, picker);

		internal static void UpdatePicker(this MauiPicker platformPicker, IPicker picker)
		{
			platformPicker.Hint = picker.Title;

			if (picker.SelectedIndex == -1 || picker.SelectedIndex >= picker.GetCount())
				platformPicker.Text = null;
			else
				platformPicker.Text = picker.GetItem(picker.SelectedIndex);
		}

		internal static void UpdateFlowDirection(this AlertDialog alertDialog, IPicker picker)
		{
			if (alertDialog.Window?.DecorView is not null)
				alertDialog.Window.DecorView.UpdateFlowDirection(picker);

			if (alertDialog.ListView is not null)
				alertDialog.ListView.UpdateFlowDirection(picker);
		}
	}
}