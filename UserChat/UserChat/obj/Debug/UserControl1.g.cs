﻿#pragma checksum "..\..\UserControl1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "050EAE60F58C9FA5F2EC018748C5784C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.34209
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


namespace WpfControlLibrary2 {
    
    
    /// <summary>
    /// UserControl1
    /// </summary>
    public partial class UserControl1 : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 8 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image Avatar;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Nick;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Mail;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PART_call;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button PART_message;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Chat;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label Message;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SEND_message;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\UserControl1.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SMILE_message;
        
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
            System.Uri resourceLocater = new System.Uri("/UserChat;component/usercontrol1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\UserControl1.xaml"
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
            this.Avatar = ((System.Windows.Controls.Image)(target));
            
            #line 8 "..\..\UserControl1.xaml"
            this.Avatar.MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.ClickAvatar);
            
            #line default
            #line hidden
            return;
            case 2:
            this.Nick = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.Mail = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.PART_call = ((System.Windows.Controls.Button)(target));
            
            #line 12 "..\..\UserControl1.xaml"
            this.PART_call.Click += new System.Windows.RoutedEventHandler(this.PART_call_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.PART_message = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\UserControl1.xaml"
            this.PART_message.Click += new System.Windows.RoutedEventHandler(this.PART_message_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.Chat = ((System.Windows.Controls.Label)(target));
            return;
            case 7:
            this.Message = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.SEND_message = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\UserControl1.xaml"
            this.SEND_message.Click += new System.Windows.RoutedEventHandler(this.ClikSend);
            
            #line default
            #line hidden
            return;
            case 9:
            this.SMILE_message = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\UserControl1.xaml"
            this.SMILE_message.Click += new System.Windows.RoutedEventHandler(this.ClickSmile);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

