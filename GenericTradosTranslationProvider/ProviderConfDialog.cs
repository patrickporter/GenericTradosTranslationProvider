using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericTradosTranslationProvider
{
    public partial class ProviderConfDialog : Form
    {
        #region "ProviderConfDialog"
        public ProviderConfDialog(TranslationOptions options)
        {
            Options = options;
            InitializeComponent();
            UpdateDialog();
        }

        public TranslationOptions Options
        {
            get;
            set;
        }
        #endregion


        #region "UpdateDialog"
        private void UpdateDialog()
        {
            //TODO: add code to update the dialog, if necessary, from the options read in the plugin URI string
        }
        #endregion





        #region "OK"
        private void bnt_OK_Click(object sender, EventArgs e)
        {
            //TODO: update the options when the user clicks the OK button
        }
        #endregion

        private void btn_Cancel_Click(object sender, EventArgs e)
        {

        }




    }
}
