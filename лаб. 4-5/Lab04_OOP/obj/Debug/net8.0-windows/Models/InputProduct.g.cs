﻿#pragma checksum "..\..\..\..\Models\InputProduct.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "995D04D8FD0964D0BF5933229E4F751FD0392D4D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Lab04_OOP.Commands;
using Lab04_OOP.Models;
using MahApps.Metro.IconPacks;
using MahApps.Metro.IconPacks.Converter;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace Lab04_OOP.Models {
    
    
    /// <summary>
    /// InputProduct
    /// </summary>
    public partial class InputProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 35 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button CloseForm_Button;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Title_TextBox;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Description_TextBox;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox Type_ComboBox;
        
        #line default
        #line hidden
        
        
        #line 73 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Price_Slider;
        
        #line default
        #line hidden
        
        
        #line 94 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddOrChangeButton;
        
        #line default
        #line hidden
        
        
        #line 112 "..\..\..\..\Models\InputProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image ProductImage;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Lab04_OOP;component/models/inputproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Models\InputProduct.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 17 "..\..\..\..\Models\InputProduct.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.ChangeProductInDataGrid);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\..\..\Models\InputProduct.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.AddProduct_Executed);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\..\..\Models\InputProduct.xaml"
            ((System.Windows.Input.CommandBinding)(target)).Executed += new System.Windows.Input.ExecutedRoutedEventHandler(this.Close);
            
            #line default
            #line hidden
            return;
            case 4:
            this.CloseForm_Button = ((System.Windows.Controls.Button)(target));
            return;
            case 5:
            this.Title_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.Description_TextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.Type_ComboBox = ((System.Windows.Controls.ComboBox)(target));
            
            #line 64 "..\..\..\..\Models\InputProduct.xaml"
            this.Type_ComboBox.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.Type_ComboBox_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.Price_Slider = ((System.Windows.Controls.TextBox)(target));
            return;
            case 9:
            
            #line 91 "..\..\..\..\Models\InputProduct.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddOrChangeButton = ((System.Windows.Controls.Button)(target));
            return;
            case 11:
            this.ProductImage = ((System.Windows.Controls.Image)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

