﻿using EmojiKing.View;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace EmojiKing
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            MainFrame.Navigate(typeof(EmotionPage));
        }

        private void MainListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            switch ((e.AddedItems[0] as ListViewItem).Tag.ToString())
            {
                case "EmotionPage": { MainFrame.Navigate(typeof(EmotionPage)); break; }
                case "FaceStickersPage": { MainFrame.Navigate(typeof(FaceStickersPage)); break; }
                default:
                    break;
            }
        }

        private void HumburgerButton_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            if (MainFrame.CanGoBack)
            {
                MainFrame.GoBack();
            }
            else
            {

            }
        }

        public void ShowNotify(string message)
        {
            NotifyPopup.IsOpen = true;
        }

        private void SubListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var item = e.ClickedItem as FrameworkElement;
            switch(item.Tag.ToString())
            {
                case "Settings":
                        MainFrame.Navigate(typeof(SettingsPage));
                        break;
                case "About":
                        MainFrame.Navigate(typeof(AboutPage));
                        break;
            }
        }
    }
}
