using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Planets
{
    public partial class ImageSizeDialog: Form
    {
        public Size ImageSize { get; set; }

        public ImageSizeDialog()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            nudWidth.Value = ImageSize.Width;
            nudHeight.Value = ImageSize.Height;
            base.OnShown(e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ImageSize = new Size((int)nudWidth.Value, (int)nudHeight.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
