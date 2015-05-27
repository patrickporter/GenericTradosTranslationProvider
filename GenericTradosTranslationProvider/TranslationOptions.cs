using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sdl.LanguagePlatform.TranslationMemoryApi;
using System.Windows.Forms;

namespace GenericTradosTranslationProvider
{
    /// <summary>
    /// This class is used to hold the provider plug-in settings. 
    /// All settings are automatically stored in a URI.
    /// </summary>
    public class TranslationOptions
    {
        #region "TranslationMethod"
        //TODO: set the translation method here for the type of translation provider
        public static readonly TranslationMethod ProviderTranslationMethod = TranslationMethod.Other;
        #endregion

        #region "TranslationProviderUriBuilder"
        TranslationProviderUriBuilder _uriBuilder;

        public TranslationOptions()
        {
            _uriBuilder = new TranslationProviderUriBuilder(TranslationProvider.TranslationProviderScheme);
        }

        public TranslationOptions(Uri uri)
        {
            _uriBuilder = new TranslationProviderUriBuilder(uri);
        }
        #endregion

        /// <summary>
        /// Use this to set/get provider options.
        /// </summary>
        #region "StringOption1"
        public string StringOption1
        {
            get { return GetStringParameter("stringoption1"); }
            set { SetStringParameter("stringoption1", value); }
        }
        #endregion

        /// <summary>
        /// Use this to set/get provider options.
        /// </summary>
        #region "StringOption2"
        public string StringOption2
        {
            get { return GetStringParameter("stringoption2"); }
            set { SetStringParameter("stringoption2", value); }
        }
        #endregion

        #region "SetStringParameter"
        private void SetStringParameter(string p, string value)
        {
            _uriBuilder[p] = value;
        }
        #endregion

        #region "GetStringParameter"
        private string GetStringParameter(string p)
        {
            string paramString = _uriBuilder[p];
            return paramString;
        }
        #endregion


        #region "Uri"
        public Uri Uri
        {
            get
            {
                return _uriBuilder.Uri;
            }
        }
        #endregion
    }
}
