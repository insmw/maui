﻿using System;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using Xunit;

namespace Microsoft.Maui.UnitTests.Views
{
	[Category(TestCategory.Core, TestCategory.View)]
	public class BorderTests
	{
		[Fact]
		public void TestDefaultBorderStrokeShape()
		{
			Border border = new Border();

			Assert.NotNull(border);
			Assert.NotNull(border.StrokeShape);
		}

		[Fact]
		public void TestBorderPropagateBindingContext()
		{
			Border border = new Border();

			var bindingContext = new object();
			border.BindingContext = bindingContext;

			var content = new ContentView();
			border.Content = content;

			Assert.True(border.BindingContext == bindingContext);
		}

		[Fact]
		public void TestStrokeShapeBindingContext()
		{
			var context = new object();

			var parent = new Border
			{
				BindingContext = context
			};

			var strokeShape = new Rectangle();

			parent.StrokeShape = strokeShape;

			Assert.Same(context, ((Rectangle)parent.StrokeShape).BindingContext);
		}

		[Fact]
		public void BorderStrokeShapeSubscribed()
		{
			var strokeShape = new RoundRectangle { CornerRadius = new CornerRadius(12) };
			var border = new Border { StrokeShape = strokeShape };

			bool fired = false;
			border.PropertyChanged += (sender, e) =>
			{
				if (e.PropertyName == nameof(Border.StrokeShape))
					fired = true;
			};

			strokeShape.CornerRadius = new CornerRadius(24);
			Assert.True(fired, "PropertyChanged did not fire!");
		}

		[Fact]
		public void BorderStrokeSubscribed()
		{
			var stroke = new SolidColorBrush(Colors.Red);
			var border = new Border { Stroke = stroke };

			bool fired = false;
			border.PropertyChanged += (sender, e) =>
			{
				if (e.PropertyName == nameof(Border.Stroke))
					fired = true;
			};

			stroke.Color = Colors.Green;
			Assert.True(fired, "PropertyChanged did not fire!");
		}

		[Theory]
		[InlineData(typeof(Rectangle))]
		[InlineData(typeof(RoundRectangle))]
		[InlineData(typeof(Ellipse))]
		public async Task BorderStrokeShapeDoesNotLeak(Type type)
		{
			var strokeShape = (Shape)Activator.CreateInstance(type);
			var reference = new WeakReference(new Border { StrokeShape = strokeShape });

			strokeShape = null;

			await Task.Yield();
			GC.Collect();
			GC.WaitForPendingFinalizers();

			Assert.False(reference.IsAlive, "Border should not be alive!");
		}

		[Fact]
		public void TestSetChild()
		{
			Frame frame = new Frame();

			var child1 = new Label();

			bool added = false;

			frame.ChildAdded += (sender, e) => added = true;

			frame.Content = child1;

			Assert.True(added);
			Assert.Equal(child1, frame.Content);

			added = false;
			frame.Content = child1;

			Assert.False(added);
		}

		[Fact]
		public void TestReplaceChild()
		{
			Frame frame = new Frame();

			var child1 = new Label();
			var child2 = new Label();

			frame.Content = child1;

			bool removed = false;
			bool added = false;

			frame.ChildRemoved += (sender, e) => removed = true;
			frame.ChildAdded += (sender, e) => added = true;

			frame.Content = child2;

			Assert.True(removed);
			Assert.True(added);
			Assert.Equal(child2, frame.Content);
		}
	}
}