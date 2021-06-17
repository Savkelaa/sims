﻿#pragma checksum "..\..\..\Interface\AcceptedMedicines.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "83480AE102042DBEBAEDB3E98E14FC6E6EB570FEF50962DB7CBC8142943E9FBD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pharmacy.Interface;
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


namespace Pharmacy.Interface {
    
    
    /// <summary>
    /// AcceptedMedicines
    /// </summary>
    public partial class AcceptedMedicines : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\Interface\AcceptedMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridAccepted;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\Interface\AcceptedMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchId;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\Interface\AcceptedMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchName;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\..\Interface\AcceptedMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchManufacturer;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\Interface\AcceptedMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchPrice1;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\Interface\AcceptedMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchPrice2;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\Interface\AcceptedMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchQuantity;
        
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
            System.Uri resourceLocater = new System.Uri("/Pharmacy;component/interface/acceptedmedicines.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Interface\AcceptedMedicines.xaml"
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
            this.gridAccepted = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.searchId = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\Interface\AcceptedMedicines.xaml"
            this.searchId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchId_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 34 "..\..\..\Interface\AcceptedMedicines.xaml"
            this.searchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchManufacturer = ((System.Windows.Controls.TextBox)(target));
            
            #line 35 "..\..\..\Interface\AcceptedMedicines.xaml"
            this.searchManufacturer.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchManufacturer_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.searchPrice1 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.searchPrice2 = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.searchQuantity = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\Interface\AcceptedMedicines.xaml"
            this.searchQuantity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchQuantity_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 45 "..\..\..\Interface\AcceptedMedicines.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

