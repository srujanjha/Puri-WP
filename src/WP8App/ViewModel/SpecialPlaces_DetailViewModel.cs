// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of SpecialPlaces_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class SpecialPlaces_DetailViewModel : ViewModelsBase.VMBase, IViewModels.ISpecialPlaces_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialPlaces_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public SpecialPlaces_DetailViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.specialplacesCollectionSchema _currentspecialplacesCollectionSchema;

        /// <summary>
        /// CurrentspecialplacesCollectionSchema property.
        /// </summary>		
        public Entities.specialplacesCollectionSchema CurrentspecialplacesCollectionSchema
        {
            get
            {
				return _currentspecialplacesCollectionSchema;
            }
            set
            {
                SetProperty(ref _currentspecialplacesCollectionSchema, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechSpecialPlaces_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechSpecialPlaces_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentspecialplacesCollectionSchema.Subtitle);
        }
		

        private ICommand _textToSpeechSpecialPlaces_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechSpecialPlaces_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechSpecialPlaces_DetailStaticControlCommand
        {
            get { return _textToSpeechSpecialPlaces_DetailStaticControlCommand = _textToSpeechSpecialPlaces_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechSpecialPlaces_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareSpecialPlaces_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareSpecialPlaces_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentspecialplacesCollectionSchema.Subtitle, "", "", CurrentspecialplacesCollectionSchema.Image);
        }
		

        private ICommand _shareSpecialPlaces_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareSpecialPlaces_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareSpecialPlaces_DetailStaticControlCommand
        {
            get { return _shareSpecialPlaces_DetailStaticControlCommand = _shareSpecialPlaces_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareSpecialPlaces_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartSpecialPlaces_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartSpecialPlaces_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.ISpecialPlaces_DetailViewModel), CreateTileInfoSpecialPlaces_DetailStaticControl());
        }
		

        private ICommand _pinToStartSpecialPlaces_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartSpecialPlaces_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartSpecialPlaces_DetailStaticControlCommand
        {
            get { return _pinToStartSpecialPlaces_DetailStaticControlCommand = _pinToStartSpecialPlaces_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartSpecialPlaces_DetailStaticControlCommandDelegate); }
        }
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.specialplacesCollectionSchema)) { return; }
                
                CurrentspecialplacesCollectionSchema = value as Entities.specialplacesCollectionSchema;
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the SpecialPlaces_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoSpecialPlaces_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentspecialplacesCollectionSchema.Id.ToString(),
                Title = CurrentspecialplacesCollectionSchema.Subtitle,
                BackTitle = CurrentspecialplacesCollectionSchema.Subtitle,
                BackContent = string.Empty,
                Count = 0,
                BackgroundImagePath = CurrentspecialplacesCollectionSchema.Image,
                BackBackgroundImagePath = CurrentspecialplacesCollectionSchema.Image,
                LogoPath = "Logo-aafb5c9d-c352-45d2-8a05-ca75f71cb409.png"
            };
            return tileInfo;
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the AboutThisPlace1StaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoAboutThisPlace1StaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentspecialplacesCollectionSchema.Id.ToString(),
                Title = CurrentspecialplacesCollectionSchema.Title,
                BackTitle = CurrentspecialplacesCollectionSchema.Title,
                BackContent = CurrentspecialplacesCollectionSchema.Description,
                Count = 0,
                BackgroundImagePath = string.Empty,
                BackBackgroundImagePath = string.Empty,
                LogoPath = "Logo-aafb5c9d-c352-45d2-8a05-ca75f71cb409.png"
            };
            return tileInfo;
        }
    }
}
