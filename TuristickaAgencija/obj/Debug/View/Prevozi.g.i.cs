﻿#pragma checksum "..\..\..\View\Prevozi.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "4BB0446C90D191F121009D6926F866A118BAE251406A94A2ECFB5A69A47B9ED3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using TuristickaAgencija;


namespace TuristickaAgencija {
    
    
    /// <summary>
    /// Prevozi
    /// </summary>
    public partial class Prevozi : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\View\Prevozi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\View\Prevozi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox destinacija;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\View\Prevozi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker datum;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\View\Prevozi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox klijent;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\View\Prevozi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.TimePicker vreme;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\View\Prevozi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox cena;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\View\Prevozi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox tip;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\View\Prevozi.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid grid1;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TuristickaAgencija;component/view/prevozi.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\View\Prevozi.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.image = ((System.Windows.Controls.Image)(target));
            return;
            case 2:
            this.destinacija = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.datum = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.klijent = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.vreme = ((MaterialDesignThemes.Wpf.TimePicker)(target));
            return;
            case 6:
            this.cena = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.tip = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            
            #line 50 "..\..\..\View\Prevozi.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.grid1 = ((System.Windows.Controls.DataGrid)(target));
            
            #line 60 "..\..\..\View\Prevozi.xaml"
            this.grid1.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.grid1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 63 "..\..\..\View\Prevozi.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Obrisi);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

