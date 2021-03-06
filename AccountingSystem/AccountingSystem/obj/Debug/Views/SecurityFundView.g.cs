﻿#pragma checksum "..\..\..\Views\SecurityFundView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "DED4F9ABFE13A3C0EAFBE7FF36DF96FC"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using AccountingSystem.Views;
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


namespace AccountingSystem.Views {
    
    
    /// <summary>
    /// SecurityFundView
    /// </summary>
    public partial class SecurityFundView : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid securityFund;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn tableDate;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn tableDetails;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn tableDeposit;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn tableExpenses;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn tableRemains;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Details;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Deposit;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\Views\SecurityFundView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Expenses;
        
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
            System.Uri resourceLocater = new System.Uri("/AccountingSystem;component/views/securityfundview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\SecurityFundView.xaml"
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
            this.securityFund = ((System.Windows.Controls.DataGrid)(target));
            
            #line 20 "..\..\..\Views\SecurityFundView.xaml"
            this.securityFund.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.dg1_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.tableDate = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 3:
            this.tableDetails = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 4:
            this.tableDeposit = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 5:
            this.tableExpenses = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 6:
            this.tableRemains = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            case 7:
            this.Details = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.Deposit = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.Expenses = ((System.Windows.Controls.TextBox)(target));
            return;
            case 10:
            
            #line 73 "..\..\..\Views\SecurityFundView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Save_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

