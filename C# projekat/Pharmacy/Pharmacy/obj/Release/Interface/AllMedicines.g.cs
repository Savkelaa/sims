﻿#pragma checksum "..\..\..\Interface\AllMedicines.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "AE8B6DC75B00745EDBFE57B2CC38F20F4539FCD9C20FBC9613F03BB20738C210"
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
    /// AllMedicines
    /// </summary>
    public partial class AllMedicines : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 21 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridMedicines;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchId;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchName;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchManufacturer;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchPrice1;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchPrice2;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox searchQuantity;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox comp1;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox comp2;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\Interface\AllMedicines.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox comp3;
        
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
            System.Uri resourceLocater = new System.Uri("/Pharmacy;component/interface/allmedicines.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Interface\AllMedicines.xaml"
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
            this.gridMedicines = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.searchId = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\Interface\AllMedicines.xaml"
            this.searchId.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchId_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.searchName = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\Interface\AllMedicines.xaml"
            this.searchName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.searchManufacturer = ((System.Windows.Controls.TextBox)(target));
            
            #line 42 "..\..\..\Interface\AllMedicines.xaml"
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
            
            #line 45 "..\..\..\Interface\AllMedicines.xaml"
            this.searchQuantity.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.searchQuantity_TextChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            
            #line 52 "..\..\..\Interface\AllMedicines.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Search_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.comp1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 56 "..\..\..\Interface\AllMedicines.xaml"
            this.comp1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.comp1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 10:
            this.comp2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 57 "..\..\..\Interface\AllMedicines.xaml"
            this.comp2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.comp2_TextChanged);
            
            #line default
            #line hidden
            return;
            case 11:
            this.comp3 = ((System.Windows.Controls.TextBox)(target));
            
            #line 58 "..\..\..\Interface\AllMedicines.xaml"
            this.comp3.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.comp3_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

