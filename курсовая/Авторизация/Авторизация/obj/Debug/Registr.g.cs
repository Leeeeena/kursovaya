﻿#pragma checksum "..\..\Registr.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E18F0B4351F6A4D70C2CB0112EAB85A4335D546A985561ED4A03645CD146CF25"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Авторизация;


namespace Авторизация {
    
    
    /// <summary>
    /// Registr
    /// </summary>
    public partial class Registr : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 34 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox login;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pass;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pass2;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox familia;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox imya;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox otchestvo;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button gotovo;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Comback;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\Registr.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cleaner;
        
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
            System.Uri resourceLocater = new System.Uri("/Авторизация;component/registr.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Registr.xaml"
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
            this.login = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.pass = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 3:
            this.pass2 = ((System.Windows.Controls.PasswordBox)(target));
            return;
            case 4:
            this.familia = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.imya = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.otchestvo = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.gotovo = ((System.Windows.Controls.Button)(target));
            
            #line 40 "..\..\Registr.xaml"
            this.gotovo.Click += new System.Windows.RoutedEventHandler(this.gotovo_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Comback = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Registr.xaml"
            this.Comback.Click += new System.Windows.RoutedEventHandler(this.Comback_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.cleaner = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\Registr.xaml"
            this.cleaner.Click += new System.Windows.RoutedEventHandler(this.cleaner_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

