﻿#pragma checksum "..\..\KLUBView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "AC76168A14BED40D9045700EF99607F261D6BA30"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using KLUB;
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


namespace KLUB {
    
    
    /// <summary>
    /// KLUBView
    /// </summary>
    public partial class KLUBView : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\KLUBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TimeBox;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\KLUBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label M;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\KLUBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label P;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\KLUBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label FwdLabel;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\KLUBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label BwdLabel;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\KLUBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox ALSBox;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\KLUBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PathBox;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\KLUBView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox CommandString;
        
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
            System.Uri resourceLocater = new System.Uri("/KLUB;component/klubview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\KLUBView.xaml"
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
            this.TimeBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.M = ((System.Windows.Controls.Label)(target));
            return;
            case 3:
            this.P = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.FwdLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 5:
            this.BwdLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 6:
            this.ALSBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.PathBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.CommandString = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 63 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_5_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            
            #line 64 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_6_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 65 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_7_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            
            #line 66 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_8_Click);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 67 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_9_Click);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 68 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_0_Click);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 69 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_1_Click);
            
            #line default
            #line hidden
            return;
            case 16:
            
            #line 70 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_2_Click);
            
            #line default
            #line hidden
            return;
            case 17:
            
            #line 71 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_3_Click);
            
            #line default
            #line hidden
            return;
            case 18:
            
            #line 72 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_4_Click);
            
            #line default
            #line hidden
            return;
            case 19:
            
            #line 73 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_plus_Click);
            
            #line default
            #line hidden
            return;
            case 20:
            
            #line 74 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_minus_Click);
            
            #line default
            #line hidden
            return;
            case 21:
            
            #line 75 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_P_Click);
            
            #line default
            #line hidden
            return;
            case 22:
            
            #line 76 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_L_Click);
            
            #line default
            #line hidden
            return;
            case 23:
            
            #line 77 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_I_Click);
            
            #line default
            #line hidden
            return;
            case 24:
            
            #line 78 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_K_Click);
            
            #line default
            #line hidden
            return;
            case 25:
            
            #line 79 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_toZero_Click);
            
            #line default
            #line hidden
            return;
            case 26:
            
            #line 80 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_up_Click);
            
            #line default
            #line hidden
            return;
            case 27:
            
            #line 81 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_down_Click);
            
            #line default
            #line hidden
            return;
            case 28:
            
            #line 82 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_F_Click);
            
            #line default
            #line hidden
            return;
            case 29:
            
            #line 83 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_BK_Click);
            
            #line default
            #line hidden
            return;
            case 30:
            
            #line 84 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_RMP_Click);
            
            #line default
            #line hidden
            return;
            case 31:
            
            #line 85 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_podtag_Click);
            
            #line default
            #line hidden
            return;
            case 32:
            
            #line 86 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_otpr_Click);
            
            #line default
            #line hidden
            return;
            case 33:
            
            #line 87 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_OC_Click);
            
            #line default
            #line hidden
            return;
            case 34:
            
            #line 88 "..\..\KLUBView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_k20_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

