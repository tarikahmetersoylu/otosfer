﻿#pragma checksum "..\..\ChooseDateForMountCalculate.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "C8A075DA5B4FEF2A8D292955A5F41E24BDB19F0140FC48A4C3DF32120828C36C"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using OTOSFER;
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


namespace OTOSFER {
    
    
    /// <summary>
    /// ChooseDateForMountCalculate
    /// </summary>
    public partial class ChooseDateForMountCalculate : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\ChooseDateForMountCalculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MountCalculatetbtn;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\ChooseDateForMountCalculate.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button MountCalculateCancelbtn;
        
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
            System.Uri resourceLocater = new System.Uri("/OTOSFER;component/choosedateformountcalculate.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ChooseDateForMountCalculate.xaml"
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
            this.MountCalculatetbtn = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\ChooseDateForMountCalculate.xaml"
            this.MountCalculatetbtn.Click += new System.Windows.RoutedEventHandler(this.MountCalculatetbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.MountCalculateCancelbtn = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\ChooseDateForMountCalculate.xaml"
            this.MountCalculateCancelbtn.Click += new System.Windows.RoutedEventHandler(this.MountCalculateCancelbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
