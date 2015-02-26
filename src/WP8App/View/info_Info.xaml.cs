// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   PageCS.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Entities=WPAppStudio.Entities;
using Ioc=WPAppStudio.Ioc;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using MyToolkit.Paging;
using Repositories=WPAppStudio.Repositories;
using WPAppStudio;

namespace WPAppStudio.View
{
    /// <summary>
    /// Phone application page for info_Info.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class info_Info : PhoneApplicationPage
    {       
        /// <summary>
        /// Initializes the phone application page for info_Info and all its components.
        /// </summary>
        public info_Info()
        {
            InitializeComponent();        
			if (Resources.Contains("Panoramainfo_Info0AppBar"))
				PhonePage.SetApplicationBar(this, Resources["Panoramainfo_Info0AppBar"] as BindableApplicationBar);                            
		}
		
        private void panoramainfo_Info_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {		
			InitializeAppBarpanoramainfo_Info(Panoramainfo_Info.SelectedItem as PanoramaItem);
        }
		
		private void InitializeAppBarpanoramainfo_Info(PanoramaItem panoramaItem)        
        {
			if (Resources.Contains(panoramaItem.Name + "AppBar"))
			{
				PhonePage.SetApplicationBar(this, Resources[panoramaItem.Name + "AppBar"] as BindableApplicationBar);            
				ApplicationBar.IsVisible = true;
            }
		    else if(ApplicationBar != null)
		        ApplicationBar.IsVisible = false;
        }
 
        /// <summary>
        /// Called when the page becomes the active page.
        /// </summary>
        /// <param name="e">Contains information about the navigation done.</param>
        protected override  void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
		
            Monuments_ListListControl.SelectedItem = null;
		
            SpecialPlaces_ListListControl.SelectedItem = null;
		}
    }
}
