﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Documents;

namespace Questify.Builder.UI.Wpf.Presentation.Watermark
{
    public static class WatermarkService
    {
        public static readonly DependencyProperty WatermarkProperty = DependencyProperty.RegisterAttached(
   "Watermark",
   typeof(object),
   typeof(WatermarkService),
   new FrameworkPropertyMetadata((object)null, new PropertyChangedCallback(OnWatermarkChanged)));


        private static readonly Dictionary<object, ItemsControl> itemsControls = new Dictionary<object, ItemsControl>();


        public static object GetWatermark(DependencyObject d)
        {
            return (object)d.GetValue(WatermarkProperty);
        }

        public static void SetWatermark(DependencyObject d, object value)
        {
            d.SetValue(WatermarkProperty, value);
        }

        private static void OnWatermarkChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            Control control = (Control)d;
            control.Loaded += Control_Loaded;

            if (d is ComboBox || d is TextBox)
            {
                control.GotKeyboardFocus += Control_GotKeyboardFocus;
                control.LostKeyboardFocus += Control_Loaded;
            }

            if (d is ItemsControl && !(d is ComboBox))
            {
                ItemsControl i = (ItemsControl)d;

                i.ItemContainerGenerator.ItemsChanged += ItemsChanged;
                itemsControls.Add(i.ItemContainerGenerator, i);

                DependencyPropertyDescriptor prop = DependencyPropertyDescriptor.FromProperty(ItemsControl.ItemsSourceProperty, i.GetType());
                prop.AddValueChanged(i, ItemsSourceChanged);
            }
        }


        private static void Control_GotKeyboardFocus(object sender, RoutedEventArgs e)
        {
            Control c = (Control)sender;
            if (ShouldShowWatermark(c))
            {
                RemoveWatermark(c);
            }
        }

        private static void Control_Loaded(object sender, RoutedEventArgs e)
        {
            Control control = (Control)sender;
            if (ShouldShowWatermark(control))
            {
                ShowWatermark(control);
            }
        }

        private static void ItemsSourceChanged(object sender, EventArgs e)
        {
            ItemsControl c = (ItemsControl)sender;
            if (c.ItemsSource != null)
            {
                if (ShouldShowWatermark(c))
                {
                    ShowWatermark(c);
                }
                else
                {
                    RemoveWatermark(c);
                }
            }
            else
            {
                ShowWatermark(c);
            }
        }

        private static void ItemsChanged(object sender, ItemsChangedEventArgs e)
        {
            ItemsControl control;
            if (itemsControls.TryGetValue(sender, out control))
            {
                if (ShouldShowWatermark(control))
                {
                    ShowWatermark(control);
                }
                else
                {
                    RemoveWatermark(control);
                }
            }
        }



        private static void RemoveWatermark(UIElement control)
        {
            AdornerLayer layer = AdornerLayer.GetAdornerLayer(control);

            if (layer != null)
            {
                Adorner[] adorners = layer.GetAdorners(control);
                if (adorners == null)
                {
                    return;
                }

                foreach (Adorner adorner in adorners)
                {
                    if (adorner is WatermarkAdorner)
                    {
                        adorner.Visibility = Visibility.Hidden;
                        layer.Remove(adorner);
                    }
                }
            }
        }

        private static void ShowWatermark(Control control)
        {
            AdornerLayer layer = AdornerLayer.GetAdornerLayer(control);

            if (layer != null)
            {
                layer.Add(new WatermarkAdorner(control, GetWatermark(control)));
            }
        }

        private static bool ShouldShowWatermark(Control c)
        {
            if (c is ComboBox)
            {
                return (c as ComboBox).Text == string.Empty;
            }
            else if (c is TextBoxBase)
            {
                return (c as TextBox).Text == string.Empty;
            }
            else if (c is ItemsControl)
            {
                return (c as ItemsControl).Items.Count == 0;
            }
            else
            {
                return false;
            }
        }

    }
}