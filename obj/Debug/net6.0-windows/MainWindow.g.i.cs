// Updated by XamlIntelliSenseFileGenerator 5/20/2022 12:14:19 AM
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7CA330E3AE093D684BA564BE8D42E7850B180E94"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CursoNicosiored_P5;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace CursoNicosiored_P5
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox P_Bread;

#line default
#line hidden


#line 26 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox P_Meat;

#line default
#line hidden


#line 32 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox P_Tomato;

#line default
#line hidden


#line 38 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox P_Lettuce;

#line default
#line hidden


#line 44 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox P_Cheese;

#line default
#line hidden


#line 59 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock P_Burgers;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CursoNicosiored_P5;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.4.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.P_Bread = ((System.Windows.Controls.CheckBox)(target));

#line 25 "..\..\..\MainWindow.xaml"
                    this.P_Bread.Click += new System.Windows.RoutedEventHandler(this.P_Bread_Click);

#line default
#line hidden
                    return;
                case 2:
                    this.P_Meat = ((System.Windows.Controls.CheckBox)(target));

#line 31 "..\..\..\MainWindow.xaml"
                    this.P_Meat.Click += new System.Windows.RoutedEventHandler(this.P_Meat_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.P_Tomato = ((System.Windows.Controls.CheckBox)(target));

#line 37 "..\..\..\MainWindow.xaml"
                    this.P_Tomato.Click += new System.Windows.RoutedEventHandler(this.P_Tomato_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.P_Lettuce = ((System.Windows.Controls.CheckBox)(target));

#line 43 "..\..\..\MainWindow.xaml"
                    this.P_Lettuce.Click += new System.Windows.RoutedEventHandler(this.P_Lettuce_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.P_Cheese = ((System.Windows.Controls.CheckBox)(target));

#line 49 "..\..\..\MainWindow.xaml"
                    this.P_Cheese.Click += new System.Windows.RoutedEventHandler(this.P_Cheese_Click);

#line default
#line hidden
                    return;
                case 6:

#line 54 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Substract_Button_Click);

#line default
#line hidden
                    return;
                case 7:

#line 58 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Addition_Button_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.P_Burgers = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 9:
                    this.Total = ((System.Windows.Controls.TextBlock)(target));
                    return;
                case 10:

#line 77 "..\..\..\MainWindow.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Order_Button_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBlock P_Total;
    }
}

