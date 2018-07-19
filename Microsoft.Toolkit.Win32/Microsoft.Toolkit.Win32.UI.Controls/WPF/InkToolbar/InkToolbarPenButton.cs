// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Windows.Interop;
using Windows.Foundation;
using Windows.UI.Xaml.Media;
using uwpControls = global::Windows.UI.Xaml.Controls;
using uwpInking = Windows.UI.Input.Inking;
using uwpXaml = global::Windows.UI.Xaml;

namespace Microsoft.Toolkit.Win32.UI.Controls.WPF
{
    /// <summary>
    /// Wpf-enabled wrapper for <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton"/>
    /// </summary>
    public class InkToolbarPenButton : WindowsXamlHost
    {
        internal global::Windows.UI.Xaml.Controls.InkToolbarPenButton UwpControl => this.XamlRoot as global::Windows.UI.Xaml.Controls.InkToolbarPenButton;

        /// <summary>
        /// Initializes a new instance of the <see cref="InkToolbarPenButton"/> class, a
        /// Wpf-enabled wrapper for <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton"/>
        /// </summary>
        public InkToolbarPenButton()
            : this(typeof(global::Windows.UI.Xaml.Controls.InkToolbarPenButton).FullName)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InkToolbarPenButton"/> class, a
        /// Wpf-enabled wrapper for <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton"/>.
        /// Intended for internal framework use only.
        /// </summary>
        public InkToolbarPenButton(string typeName)
            : base(typeName)
        {
        }

        protected override void OnInitialized(EventArgs e)
        {
            // Bind dependency properties across controls
            // properties of FrameworkElement
            Bind(nameof(Style), StyleProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.StyleProperty);
            Bind(nameof(MaxHeight), MaxHeightProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxHeightProperty);
            Bind(nameof(FlowDirection), FlowDirectionProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.FlowDirectionProperty);
            Bind(nameof(Margin), MarginProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MarginProperty);
            Bind(nameof(HorizontalAlignment), HorizontalAlignmentProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.HorizontalAlignmentProperty);
            Bind(nameof(VerticalAlignment), VerticalAlignmentProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.VerticalAlignmentProperty);
            Bind(nameof(MinHeight), MinHeightProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MinHeightProperty);
            Bind(nameof(Height), HeightProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.HeightProperty);
            Bind(nameof(MinWidth), MinWidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MinWidthProperty);
            Bind(nameof(MaxWidth), MaxWidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxWidthProperty);
            Bind(nameof(UseLayoutRounding), UseLayoutRoundingProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.UseLayoutRoundingProperty);
            Bind(nameof(Name), NameProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.NameProperty);
            Bind(nameof(Tag), TagProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.TagProperty);
            Bind(nameof(DataContext), DataContextProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.DataContextProperty);
            Bind(nameof(Width), WidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.WidthProperty);

            // InkToolbarPenButton specific properties
            Bind(nameof(SelectedStrokeWidth), SelectedStrokeWidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedStrokeWidthProperty);
            Bind(nameof(SelectedBrushIndex), SelectedBrushIndexProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushIndexProperty);
            Bind(nameof(Palette), PaletteProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.PaletteProperty);
            Bind(nameof(MinStrokeWidth), MinStrokeWidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MinStrokeWidthProperty);
            Bind(nameof(MaxStrokeWidth), MaxStrokeWidthProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxStrokeWidthProperty);
            Bind(nameof(SelectedBrush), SelectedBrushProperty, global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushProperty, new WindowsXamlHostWrapperConverter());

            base.OnInitialized(e);
        }

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxStrokeWidthProperty"/>
        /// </summary>
        public static DependencyProperty MaxStrokeWidthProperty { get; } = DependencyProperty.Register(nameof(MaxStrokeWidth), typeof(double), typeof(InkToolbarPenButton));

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MinStrokeWidthProperty"/>
        /// </summary>
        public static DependencyProperty MinStrokeWidthProperty { get; } = DependencyProperty.Register(nameof(MinStrokeWidth), typeof(double), typeof(InkToolbarPenButton));

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.PaletteProperty"/>
        /// </summary>
        public static DependencyProperty PaletteProperty { get; } = DependencyProperty.Register(nameof(Palette), typeof(System.Collections.Generic.IList<Microsoft.Toolkit.Win32.UI.Controls.WPF.Brush>), typeof(InkToolbarPenButton));

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushIndexProperty"/>
        /// </summary>
        public static DependencyProperty SelectedBrushIndexProperty { get; } = DependencyProperty.Register(nameof(SelectedBrushIndex), typeof(int), typeof(InkToolbarPenButton));

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushProperty"/>
        /// </summary>
        public static DependencyProperty SelectedBrushProperty { get; } = DependencyProperty.Register(nameof(SelectedBrush), typeof(Microsoft.Toolkit.Win32.UI.Controls.WPF.Brush), typeof(InkToolbarPenButton));

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedStrokeWidthProperty"/>
        /// </summary>
        public static DependencyProperty SelectedStrokeWidthProperty { get; } = DependencyProperty.Register(nameof(SelectedStrokeWidth), typeof(double), typeof(InkToolbarPenButton));

        /// <summary>
        /// Gets or sets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedStrokeWidth"/>
        /// </summary>
        public double SelectedStrokeWidth
        {
            get => (double)GetValue(SelectedStrokeWidthProperty);
            set => SetValue(SelectedStrokeWidthProperty, value);
        }

        /// <summary>
        /// Gets or sets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrushIndex"/>
        /// </summary>
        public int SelectedBrushIndex
        {
            get => (int)GetValue(SelectedBrushIndexProperty);
            set => SetValue(SelectedBrushIndexProperty, value);
        }

        /// <summary>
        /// Gets or sets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.Palette"/>
        /// </summary>
        public System.Collections.Generic.IList<Microsoft.Toolkit.Win32.UI.Controls.WPF.Brush> Palette
        {
            get => (System.Collections.Generic.IList<Microsoft.Toolkit.Win32.UI.Controls.WPF.Brush>)GetValue(PaletteProperty);
            set => SetValue(PaletteProperty, value);
        }

        /// <summary>
        /// Gets or sets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MinStrokeWidth"/>
        /// </summary>
        public double MinStrokeWidth
        {
            get => (double)GetValue(MinStrokeWidthProperty);
            set => SetValue(MinStrokeWidthProperty, value);
        }

        /// <summary>
        /// Gets or sets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.MaxStrokeWidth"/>
        /// </summary>
        public double MaxStrokeWidth
        {
            get => (double)GetValue(MaxStrokeWidthProperty);
            set => SetValue(MaxStrokeWidthProperty, value);
        }

        /// <summary>
        /// Gets <see cref="global::Windows.UI.Xaml.Controls.InkToolbarPenButton.SelectedBrush"/>
        /// </summary>
        public Microsoft.Toolkit.Win32.UI.Controls.WPF.Brush SelectedBrush
        {
            get => (Microsoft.Toolkit.Win32.UI.Controls.WPF.Brush)GetValue(SelectedBrushProperty);
        }
    }
}