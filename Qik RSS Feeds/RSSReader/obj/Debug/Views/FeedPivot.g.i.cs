﻿#pragma checksum "C:\Users\karanthaker\Desktop\prod\Qik RSS Feeds\RSSReader\Views\FeedPivot.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "07C83C78F0928ECDE12E8BC7E137CC2A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace RSSReader.Views {
    
    
    public partial class FeedPivot : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Microsoft.Phone.Controls.Pivot RSSItemsPivot;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton appbar_refresh;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton appbar_search;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/RSSReader;component/Views/FeedPivot.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.RSSItemsPivot = ((Microsoft.Phone.Controls.Pivot)(this.FindName("RSSItemsPivot")));
            this.appbar_refresh = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("appbar_refresh")));
            this.appbar_search = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("appbar_search")));
        }
    }
}

