﻿#pragma checksum "..\..\TicketHomePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2D47D5798192AB5F7DFE43AE2BA2F952BB4C8515F1BA8604DFF670DD9F140DF6"
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
    /// TicketHomePage
    /// </summary>
    public partial class TicketHomePage : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 41 "..\..\TicketHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button availablevoyagelistbtn;
        
        #line default
        #line hidden
        
        
        #line 71 "..\..\TicketHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border ticketsagust;
        
        #line default
        #line hidden
        
        
        #line 74 "..\..\TicketHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button TicketClose;
        
        #line default
        #line hidden
        
        
        #line 77 "..\..\TicketHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Border golge;
        
        #line default
        #line hidden
        
        
        #line 87 "..\..\TicketHomePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Ticketicerik;
        
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
            System.Uri resourceLocater = new System.Uri("/OTOSFER;component/tickethomepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TicketHomePage.xaml"
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
            this.availablevoyagelistbtn = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\TicketHomePage.xaml"
            this.availablevoyagelistbtn.Click += new System.Windows.RoutedEventHandler(this.availablevoyagelistbtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ticketsagust = ((System.Windows.Controls.Border)(target));
            
            #line 71 "..\..\TicketHomePage.xaml"
            this.ticketsagust.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ticketsagust_MouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TicketClose = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\TicketHomePage.xaml"
            this.TicketClose.Click += new System.Windows.RoutedEventHandler(this.TicketClose_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.golge = ((System.Windows.Controls.Border)(target));
            return;
            case 5:
            this.Ticketicerik = ((System.Windows.Controls.Grid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

