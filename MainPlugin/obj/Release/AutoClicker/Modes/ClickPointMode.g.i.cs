﻿#pragma checksum "..\..\..\..\AutoClicker\Modes\ClickPointMode.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EF1527B1E6606B81341D55FF4677DF0DC1DF0842238C4792E59935FFD4BE998D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MainPlugin.AutoClicker.Modes;
using MyFunctions.ControlsWPF;
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


namespace MainPlugin.AutoClicker.Modes {
    
    
    /// <summary>
    /// ClickPointMode
    /// </summary>
    public partial class ClickPointMode : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\..\..\AutoClicker\Modes\ClickPointMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MyFunctions.ControlsWPF.NumericUpDown NUD_Repeats;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\AutoClicker\Modes\ClickPointMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MyFunctions.ControlsWPF.NumericUpDown NUD_Interval;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\AutoClicker\Modes\ClickPointMode.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_SelectPoint;
        
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
            System.Uri resourceLocater = new System.Uri("/MainPlugin;component/autoclicker/modes/clickpointmode.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\AutoClicker\Modes\ClickPointMode.xaml"
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
            this.NUD_Repeats = ((MyFunctions.ControlsWPF.NumericUpDown)(target));
            return;
            case 2:
            this.NUD_Interval = ((MyFunctions.ControlsWPF.NumericUpDown)(target));
            return;
            case 3:
            this.BT_SelectPoint = ((System.Windows.Controls.Button)(target));
            
            #line 19 "..\..\..\..\AutoClicker\Modes\ClickPointMode.xaml"
            this.BT_SelectPoint.Click += new System.Windows.RoutedEventHandler(this.BT_SelectPoint_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

