// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ServiceLocator.tt
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using IIoc=WPAppStudio.Ioc.Interfaces;
using Ioc=WPAppStudio.Ioc;
using IViewModels=WPAppStudio.ViewModel.Interfaces;

namespace WPAppStudio.Services
{
    /// <summary>
    /// Implementation of the ViewModel locator service based on IoC.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class ViewModelLocatorService
    {
        // IoC container
        private readonly IIoc.IContainer _container;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewModelLocatorService" /> class.
        /// </summary>
        public ViewModelLocatorService()
        {
            _container = new Ioc.Container();
        }
		
		/// <summary>
        /// Resolve a service of type T
        /// </summary>
        /// <typeparam name="T">Type of the service.</typeparam>
        /// <returns></returns>
        public T ResolveService<T>()
        {
            return _container.Resolve<T>();
        }

        /// <summary>
        /// Gets the reference to a info_InfoViewModel.
        /// </summary>
		public IViewModels.Iinfo_InfoViewModel info_InfoViewModel
        {
            get { return _container.Resolve<IViewModels.Iinfo_InfoViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a SpecialPlaces_DetailViewModel.
        /// </summary>
		public IViewModels.ISpecialPlaces_DetailViewModel SpecialPlaces_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.ISpecialPlaces_DetailViewModel>(); }
        }

        /// <summary>
        /// Gets the reference to a monuments_DetailViewModel.
        /// </summary>
		public IViewModels.Imonuments_DetailViewModel monuments_DetailViewModel
        {
            get { return _container.Resolve<IViewModels.Imonuments_DetailViewModel>(); }
        }
		/// <summary>
        /// Gets the reference to a AboutViewModel.
        /// </summary>
		public IViewModels.IAboutViewModel AboutViewModel
        {
            get { return _container.Resolve<IViewModels.IAboutViewModel>(); }
        }
		
		/// <summary>
        /// Gets the reference to a LicenseViewModel.
        /// </summary>
		public IViewModels.ILicenseViewModel LicenseViewModel
        {
            get { return _container.Resolve<IViewModels.ILicenseViewModel>(); }
        }
    }
}