// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   DataSchema.tt
using System;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using WPAppStudio.Entities.Base;

namespace WPAppStudio.Entities
{
    /// <summary>
    /// Implementation of the monumentsCollectionSchema Data Schema.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public class monumentsCollectionSchema : BindableBase
    {
	    /// <summary>
        /// Identifier for instances created according monumentsCollectionSchema Data Schema.
        /// </summary>
		public Guid Id { get; set; }

        private string _title;

        /// <summary>
        /// Gets/Sets value of Title column.
        /// </summary>
        public string Title
        {
            get { return _title; }
            set
            {
                SetProperty(ref _title, value);
            }
        }

        private string _subtitle;

        /// <summary>
        /// Gets/Sets value of Subtitle column.
        /// </summary>
        public string Subtitle
        {
            get { return _subtitle; }
            set
            {
                SetProperty(ref _subtitle, value);
            }
        }

        private string _image;

        /// <summary>
        /// Gets/Sets value of Image column.
        /// </summary>
        public string Image
        {
            get { return _image; }
            set
            {
                SetProperty(ref _image, value);
            }
        }

        private string _description;

        /// <summary>
        /// Gets/Sets value of Description column.
        /// </summary>
        public string Description
        {
            get { return _description; }
            set
            {
                SetProperty(ref _description, value);
            }
        }

        public override bool Equals(object obj)
        {
            var cmp = obj as monumentsCollectionSchema;
			
			if(cmp == null) return false;
			
			return Equals(Title, cmp.Title) && Equals(Subtitle, cmp.Subtitle) && Equals(Image, cmp.Image) && Equals(Description, cmp.Description);
        }
		
		public override int GetHashCode()
		{
			var hash = 13;
			
			hash = (hash * 7) + Title.GetHashCode();
			hash = (hash * 7) + Subtitle.GetHashCode();
			hash = (hash * 7) + Image.GetHashCode();
			hash = (hash * 7) + Description.GetHashCode();
		
			return hash;
		}
    }
}
