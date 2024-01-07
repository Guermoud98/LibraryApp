﻿#pragma checksum "..\..\..\..\GUI\BooksWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "BB9944376A85A4AB22F792E65085ECABFB5FDE55"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Library.GUI;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Library.GUI {
    
    
    /// <summary>
    /// BooksWindow
    /// </summary>
    public partial class BooksWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid Grid;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxTitre;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxAuteur;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxCategorie;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button BrowseBtn;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxBrowse;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxDisponible;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AfficherLivresBtn;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\..\..\GUI\BooksWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid dataGridBooks;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Library;component/gui/bookswindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\GUI\BooksWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.Grid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.TextBoxTitre = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxAuteur = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.TextBoxCategorie = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            
            #line 25 "..\..\..\..\GUI\BooksWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreerCompte);
            
            #line default
            #line hidden
            return;
            case 6:
            this.BrowseBtn = ((System.Windows.Controls.Button)(target));
            
            #line 26 "..\..\..\..\GUI\BooksWindow.xaml"
            this.BrowseBtn.Click += new System.Windows.RoutedEventHandler(this.BrowseButton_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.TextBoxBrowse = ((System.Windows.Controls.TextBox)(target));
            return;
            case 8:
            this.TextBoxDisponible = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            this.AfficherLivresBtn = ((System.Windows.Controls.Button)(target));
            
            #line 33 "..\..\..\..\GUI\BooksWindow.xaml"
            this.AfficherLivresBtn.Click += new System.Windows.RoutedEventHandler(this.AfficherLivresBtn_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.dataGridBooks = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

