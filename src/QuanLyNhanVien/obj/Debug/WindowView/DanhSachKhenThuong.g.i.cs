﻿#pragma checksum "..\..\..\WindowView\DanhSachKhenThuong.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3EF54BAD05EA460CF9FE6D99B57FFA2B59D246F14F6F0C318EFD5B64784C5B7E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using QuanLyNhanVien;
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


namespace QuanLyNhanVien.WindowView {
    
    
    /// <summary>
    /// DanhSachKhenThuong
    /// </summary>
    public partial class DanhSachKhenThuong : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock loaiFormTbk;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid danhSachDtg;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tienTbx;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox soLuongTbx;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tienSanCoTbk;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock tongTienTbk;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button truBotBtn;
        
        #line default
        #line hidden
        
        
        #line 72 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button congThemBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/QuanLyNhanVien;component/windowview/danhsachkhenthuong.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
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
            this.loaiFormTbk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.danhSachDtg = ((System.Windows.Controls.DataGrid)(target));
            
            #line 47 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
            this.danhSachDtg.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.danhSachDtg_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.tienTbx = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.soLuongTbx = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
            this.soLuongTbx.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.soLuongTbx_TextChanged);
            
            #line default
            #line hidden
            
            #line 59 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
            this.soLuongTbx.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.soLuongTbx_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 5:
            this.tienSanCoTbk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.tongTienTbk = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.truBotBtn = ((System.Windows.Controls.Button)(target));
            
            #line 69 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
            this.truBotBtn.Click += new System.Windows.RoutedEventHandler(this.truBotBtn_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.congThemBtn = ((System.Windows.Controls.Button)(target));
            
            #line 74 "..\..\..\WindowView\DanhSachKhenThuong.xaml"
            this.congThemBtn.Click += new System.Windows.RoutedEventHandler(this.congThemBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

