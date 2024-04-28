using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planets
{
    public partial class FrmMain : Form
    {
        private PlanetManager manager;
        private ImageSizeDialog imageSizeDialog;

        public FrmMain(string[] args)
        {
            InitializeComponent();
            manager = new PlanetManager();
            imageSizeDialog = new ImageSizeDialog();
            progressBar1.Visible = false;

            nudTime.DataBindings.Add("Value", manager, "Time", false, DataSourceUpdateMode.OnPropertyChanged);
            nudStep.DataBindings.Add("Value", manager, "Step", false, DataSourceUpdateMode.OnPropertyChanged);
            nudZoom.DataBindings.Add("Value", manager, "Zoom", false, DataSourceUpdateMode.OnPropertyChanged);
            nudDrawNthPoint.DataBindings.Add("Value", manager, "DrawNthPoint", false, DataSourceUpdateMode.OnPropertyChanged);
            cbxViewFrom.DataSource = manager.Planets;

            ofdLoad.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "saves");
            sfdSave.InitialDirectory = Path.Combine(Directory.GetCurrentDirectory(), "saves");
            sfdExport.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            manager.PlanetAdded += PlanetAdded;
            manager.PlanetsCleared += PlanetsCleared;
            manager.PropertyChanged += Manager_PropertyChanged;

            string defaultSave = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"saves\default.planets");

            if (args != null && args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    LoadPlanets(args[0]);
                }
            }
            else if (File.Exists(defaultSave))
            {
                LoadPlanets(defaultSave);
            }
            else
            {
                manager.Time = (float)nudTime.Value;
                manager.Step = (float)nudStep.Value;
                manager.Zoom = (float)nudZoom.Value;
                manager.DrawNthPoint = (int)nudDrawNthPoint.Value;
            }
        }

        public FrmMain() : this(null) { }

        private void Manager_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ViewFrom")
            {
                if (manager.ViewFrom != null)
                {
                    cbxViewFrom.SelectedItem = manager.ViewFrom;
                }
            }
        }

        private void PlanetsCleared(object sender, EventArgs e)
        {
            pnlPlanets.Controls.Clear();
        }

        private void PlanetAdded(object sender, PlanetEventArgs e)
        {
            PlanetControl control = new PlanetControl(e.planet, manager);
            AddPlanetControl(control);
        }

        private void AddPlanetControl(PlanetControl control)
        {
            control.PlanetRemoved += RemovePlanet;
            PlanetRemoved += control.RemoveUpdate;
            control.Dock = DockStyle.Top;

            pnlPlanets.SuspendLayout();
            pnlPlanets.Controls.Add(control);
            control.BringToFront();
            pnlPlanets.ResumeLayout();
            
            pnlPlanetsContainer.VerticalScroll.Value = pnlPlanetsContainer.VerticalScroll.Maximum;
        }

        void RemovePlanet(object sender, PlanetEventArgs e)
        {
            manager.RemovePlanet(e.planet);

            if (manager.Planets.Count > 0 && manager.ViewFrom == e.planet)
            {
                manager.ViewFrom = manager.Planets[0];
            }

            OnPlanetRemoved(e.planet);
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (pbxResult.Width > 0 && pbxResult.Height > 0)
            {
                btnDraw.Enabled = false;
                progressBar1.Visible = true;
                Bitmap newImage = new Bitmap(pbxResult.Width, pbxResult.Height);
                bgwDrawImage.RunWorkerAsync(newImage);
            }
        }

        private void btnAddPlanet_Click(object sender, EventArgs e)
        {
            manager.AddPlanet(new DrawablePlanet(0, 0, 0, null, "Untitled", Color.Black, true));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (sfdSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                manager.Save(sfdSave.FileName);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (ofdLoad.ShowDialog() == DialogResult.OK)
            {
                LoadPlanets(ofdLoad.FileName);
            }
        }

        private void LoadPlanets(string path)
        {
            try
            {
                manager.Load(path);
                foreach (PlanetControl p in pnlPlanets.Controls)
                {
                    p.UpdateParentsList();
                }

                string fileName = Path.GetFileName(path);
                if (fileName.Length > 0)
                {
                    fileName = " - " + fileName;
                }
                this.Text = "Planets" + fileName;

                pnlPlanetsContainer.PerformLayout();
                pnlPlanetsContainer.VerticalScroll.Value = pnlPlanetsContainer.VerticalScroll.Minimum;
                pnlPlanetsContainer.PerformLayout();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while loading the file.\n" + ex.Message, "Couldn't open the file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbxViewFrom_SelectedValueChanged(object sender, EventArgs e)
        {
            manager.ViewFrom = (Planet)cbxViewFrom.SelectedItem;
        }

        public event EventHandler<PlanetEventArgs> PlanetRemoved;
        private void OnPlanetRemoved(DrawablePlanet planet)
        {
            if (PlanetRemoved != null)
                PlanetRemoved(this, new PlanetEventArgs(planet));
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            imageSizeDialog.ImageSize = new Size(pbxResult.Width, pbxResult.Height);
            if (imageSizeDialog.ShowDialog() == DialogResult.OK)
            {
                if (sfdExport.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    Bitmap image = new Bitmap(imageSizeDialog.ImageSize.Width, imageSizeDialog.ImageSize.Height);
                    manager.DrawPlanets(image);
                    ImageFormat format;
                    switch (Path.GetExtension(sfdExport.FileName))
                    {
                        case "png":
                            format = ImageFormat.Png;
                            break;
                        case "bmp":
                            format = ImageFormat.Bmp;
                            break;
                        default:
                            format = ImageFormat.Png;
                            break;
                    }
                    manager.Export(sfdExport.FileName, image, format);
                }
            }
        }


        private void bgwDrawImage_DoWork(object sender, DoWorkEventArgs e)
        {
            ProgressChangedEventHandler progressChanged = (s, args) => (sender as BackgroundWorker).ReportProgress(args.ProgressPercentage);
            manager.ProgressChanged += progressChanged;
            e.Result = manager.DrawPlanets((Bitmap)e.Argument);
            manager.ProgressChanged -= progressChanged;
        }

        private void bgwDrawImage_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void bgwDrawImage_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            pbxResult.Image = (Image)e.Result;
            progressBar1.Visible = false;
            btnDraw.Enabled = true;
        }
    }
}
