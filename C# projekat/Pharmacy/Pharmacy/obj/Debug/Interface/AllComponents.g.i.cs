﻿#pragma checksum "..\..\..\Interface\AllComponents.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "200D1B4101843552F090C35B4A0EB5D32E8784C3288DF7007B40142EB544DFA8"
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
    /// AllComponents
    /// </summary>
    public partial class AllComponents : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Interface\AllComponents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid gridComponent;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Interface\AllComponents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbName;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\Interface\AllComponents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbDesc;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\Interface\AllComponents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMedicine1;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\Interface\AllComponents.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbMedicine2;
        
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
            System.Uri resourceLocater = new System.Uri("/Pharmacy;component/interface/allcomponents.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Interface\AllComponents.xaml"
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
            this.gridComponent = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.tbName = ((System.Windows.Controls.TextBox)(target));
            
            #line 40 "..\..\..\Interface\AllComponents.xaml"
            this.tbName.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbName_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tbDesc = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\Interface\AllComponents.xaml"
            this.tbDesc.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbDesc_TextChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.tbMedicine1 = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\Interface\AllComponents.xaml"
            this.tbMedicine1.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbMedicine1_TextChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tbMedicine2 = ((System.Windows.Controls.TextBox)(target));
            
            #line 45 "..\..\..\Interface\AllComponents.xaml"
            this.tbMedicine2.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.tbMedicine2_TextChanged);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

