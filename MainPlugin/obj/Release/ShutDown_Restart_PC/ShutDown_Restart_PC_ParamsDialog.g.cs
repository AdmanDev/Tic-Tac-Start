﻿#pragma checksum "..\..\..\ShutDown_Restart_PC\ShutDown_Restart_PC_ParamsDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5F1EAB8D03E5D21783620BE411E71CC58CA828F764C32D14777235ED2257A8BB"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using MainPlugin.ShutDown_Restart_PC;
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


namespace MainPlugin.ShutDown_Restart_PC {
    
    
    /// <summary>
    /// ShutDown_Restart_PC_ParamsDialog
    /// </summary>
    public partial class ShutDown_Restart_PC_ParamsDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 19 "..\..\..\ShutDown_Restart_PC\ShutDown_Restart_PC_ParamsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RB_ShutDown;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\ShutDown_Restart_PC\ShutDown_Restart_PC_ParamsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton RB_Restart;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\ShutDown_Restart_PC\ShutDown_Restart_PC_ParamsDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BT_OK;
        
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
            System.Uri resourceLocater = new System.Uri("/MainPlugin;component/shutdown_restart_pc/shutdown_restart_pc_paramsdialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ShutDown_Restart_PC\ShutDown_Restart_PC_ParamsDialog.xaml"
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
            this.RB_ShutDown = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 2:
            this.RB_Restart = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 3:
            this.BT_OK = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\ShutDown_Restart_PC\ShutDown_Restart_PC_ParamsDialog.xaml"
            this.BT_OK.Click += new System.Windows.RoutedEventHandler(this.BT_OK_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

