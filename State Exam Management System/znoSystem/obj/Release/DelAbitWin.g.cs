﻿#pragma checksum "..\..\DelAbitWin.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EDB42593D5335EC55F8315844C5E87F6A075242D2865672A04E807CA603EB5AA"
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
using znoSystem;


namespace znoSystem {
    
    
    /// <summary>
    /// DelAbitWin
    /// </summary>
    public partial class DelAbitWin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 10 "..\..\DelAbitWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelAbitBtn;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\DelAbitWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AbitIDTB;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\DelAbitWin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelBackBtn_Copy;
        
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
            System.Uri resourceLocater = new System.Uri("/znoSystem;component/delabitwin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DelAbitWin.xaml"
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
            this.DelAbitBtn = ((System.Windows.Controls.Button)(target));
            
            #line 10 "..\..\DelAbitWin.xaml"
            this.DelAbitBtn.Click += new System.Windows.RoutedEventHandler(this.DelAbitBtn_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.AbitIDTB = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.DelBackBtn_Copy = ((System.Windows.Controls.Button)(target));
            
            #line 13 "..\..\DelAbitWin.xaml"
            this.DelBackBtn_Copy.Click += new System.Windows.RoutedEventHandler(this.DelBackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
