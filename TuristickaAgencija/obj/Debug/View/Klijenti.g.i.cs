// Updated by XamlIntelliSenseFileGenerator 10/1/2020 12:55:00 AM
#pragma checksum "..\..\..\View\Klijenti.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "513CCDF2D6F658C32360017A7069EA8C7F5D0C3B37096A01B15CEE09AA82A6A1"
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


namespace TuristickaAgencija
{


    /// <summary>
    /// Klijenti
    /// </summary>
    public partial class Klijenti : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector
    {


#line 18 "..\..\..\View\Klijenti.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image image;

#line default
#line hidden


#line 50 "..\..\..\View\Klijenti.xaml"
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
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/TuristickaAgencija;component/view/klijenti.xaml", System.UriKind.Relative);

#line 1 "..\..\..\View\Klijenti.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.image = ((System.Windows.Controls.Image)(target));
                    return;
                case 2:
                    this.one = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 3:
                    this.two = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 4:
                    this.three = ((System.Windows.Controls.DatePicker)(target));
                    return;
                case 5:
                    this.four = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 6:
                    this.five = ((System.Windows.Controls.TextBox)(target));
                    return;
                case 7:

#line 44 "..\..\..\View\Klijenti.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.grid1 = ((System.Windows.Controls.DataGrid)(target));
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox jmbg;
        internal System.Windows.Controls.TextBox ime;
        internal System.Windows.Controls.TextBox prezime;
        internal System.Windows.Controls.TextBox adresa;
        internal System.Windows.Controls.TextBox telefon;
        internal System.Windows.Controls.TextBox email;
    }
}

