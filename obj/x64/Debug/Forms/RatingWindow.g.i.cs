﻿#pragma checksum "..\..\..\..\Forms\RatingWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "1FDEFB63FC43EFC6F19252B4CA9D8FDF141D86166086A6F266B0BA17FB728F56"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using LandConquest.Forms;
using LandConquest.Resources;
using System;
using System.Collections;
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


namespace LandConquest.Forms {
    
    
    /// <summary>
    /// RatingWindow
    /// </summary>
    public partial class RatingWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image profileImage;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonXP;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonCoins;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonArmy;
        
        #line default
        #line hidden
        
        
        #line 36 "..\..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonTitles;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button buttonClose;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Forms\RatingWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListView rankingsList;
        
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
            System.Uri resourceLocater = new System.Uri("/LandConquest;component/forms/ratingwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Forms\RatingWindow.xaml"
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
            
            #line 12 "..\..\..\..\Forms\RatingWindow.xaml"
            ((LandConquest.Forms.RatingWindow)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Window_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.profileImage = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.buttonXP = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\..\Forms\RatingWindow.xaml"
            this.buttonXP.Click += new System.Windows.RoutedEventHandler(this.buttonXP_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.buttonCoins = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\..\Forms\RatingWindow.xaml"
            this.buttonCoins.Click += new System.Windows.RoutedEventHandler(this.buttonCoins_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.buttonArmy = ((System.Windows.Controls.Button)(target));
            
            #line 30 "..\..\..\..\Forms\RatingWindow.xaml"
            this.buttonArmy.Click += new System.Windows.RoutedEventHandler(this.buttonArmy_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.buttonTitles = ((System.Windows.Controls.Button)(target));
            return;
            case 7:
            this.buttonClose = ((System.Windows.Controls.Button)(target));
            
            #line 42 "..\..\..\..\Forms\RatingWindow.xaml"
            this.buttonClose.Click += new System.Windows.RoutedEventHandler(this.buttonClose_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.rankingsList = ((System.Windows.Controls.ListView)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

