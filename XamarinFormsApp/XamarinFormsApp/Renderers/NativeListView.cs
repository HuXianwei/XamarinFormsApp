﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinFormsApp.Models;

namespace XamarinFormsApp.Renderers
{
    public class NativeListView : ListView
    {
        public static readonly BindableProperty ItemsProperty =
          BindableProperty.Create("Items", typeof(IEnumerable<DataSource>), typeof(NativeListView), new List<DataSource>());

        public IEnumerable<DataSource> Items
        {
            get { return (IEnumerable<DataSource>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        public event EventHandler<SelectedItemChangedEventArgs> ItemSelected;

        public void NotifyItemSelected(object item)
        {
            if (ItemSelected != null)
            {
                ItemSelected(this, new SelectedItemChangedEventArgs(item));
            }
        }
    }
}
