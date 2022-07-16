﻿#pragma checksum "..\..\..\DialogWIndows\EstablishStateDialog.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3111333A6AD39F29F7470608583760E7D31A41BCC262A4E9224BD1E8085FDFC6"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LandConquest.DialogWIndows;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using WPFLocalizeExtension.Deprecated.Engine;
using WPFLocalizeExtension.Deprecated.Extensions;
using WPFLocalizeExtension.Deprecated.Providers;
using WPFLocalizeExtension.Engine;
using WPFLocalizeExtension.Extensions;
using WPFLocalizeExtension.Providers;
using WPFLocalizeExtension.TypeConverters;
using WPFLocalizeExtension.ValueConverters;


namespace LandConquest.DialogWIndows {
    
    
    /// <summary>
    /// EstablishStateDialog
    /// </summary>
    public partial class EstablishStateDialog : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 18 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal MaterialDesignThemes.Wpf.ColorPicker StateColor;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button EstablishState;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 29 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock landDescriptionTextBlock;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Ellipse selectedPersonEllipse;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock selectedPersonNameText;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid personGrid;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox countryNameTextBox;
        
        #line default
        #line hidden
        
        
        #line 58 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock rulerDescriptionTextBlock;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/dialogwindows/establishstatedialog.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
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
            
            #line 15 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
            ((LandConquest.DialogWIndows.EstablishStateDialog)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.StateColor = ((MaterialDesignThemes.Wpf.ColorPicker)(target));
            return;
            case 3:
            this.EstablishState = ((System.Windows.Controls.Button)(target));
            
            #line 21 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
            this.EstablishState.Click += new System.Windows.RoutedEventHandler(this.EstablishState_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.landDescriptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.selectedPersonEllipse = ((System.Windows.Shapes.Ellipse)(target));
            return;
            case 7:
            this.selectedPersonNameText = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.personGrid = ((System.Windows.Controls.Primitives.UniformGrid)(target));
            return;
            case 9:
            this.countryNameTextBox = ((System.Windows.Controls.TextBox)(target));
            
            #line 55 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
            this.countryNameTextBox.PreviewKeyDown += new System.Windows.Input.KeyEventHandler(this.Space_PreviewKeyDown);
            
            #line default
            #line hidden
            
            #line 55 "..\..\..\DialogWIndows\EstablishStateDialog.xaml"
            this.countryNameTextBox.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.countryName_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 10:
            this.rulerDescriptionTextBlock = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

