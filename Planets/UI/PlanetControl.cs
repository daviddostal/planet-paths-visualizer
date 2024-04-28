using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace Planets
{
    public partial class PlanetControl : UserControl
    {
        [Browsable(false)]
        public DrawablePlanet planet { get; private set; }
        private PlanetManager manager;
        private bool updated;

        public PlanetControl(DrawablePlanet planet, PlanetManager manager)
        {
            InitializeComponent();
            this.manager = manager;
            this.planet = planet;

            planet.PropertyChanged += planet_PropertyChanged;

            tbxName.DataBindings.Add("Text", planet, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            chbxVisible.DataBindings.Add("Checked", planet, "Visible", false, DataSourceUpdateMode.OnPropertyChanged);
            btnColor.DataBindings.Add("BackColor", planet, "Color", false, DataSourceUpdateMode.OnPropertyChanged);
            nudDistance.DataBindings.Add("Value", planet, "Distance", false, DataSourceUpdateMode.OnPropertyChanged);
            nudTime.DataBindings.Add("Value", planet, "OrbitTime", false, DataSourceUpdateMode.OnPropertyChanged);
            nudOffset.DataBindings.Add("Value", planet, "Offset", false, DataSourceUpdateMode.OnPropertyChanged);

            UpdateParentsList();

            cbxParent.MouseWheel += CbxParent_MouseWheel;
        }

        private void CbxParent_MouseWheel(object sender, MouseEventArgs e)
        {
            if(!updated)
            {
                UpdateParentsList();
            }
        }

        void planet_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Parent")
            {
                if (planet.Parent != null)
                {
                    planet.Parent.PropertyChanged -= Parent_PropertyChanged;
                    planet.Parent.PropertyChanged += Parent_PropertyChanged;
                }
            }
        }

        void Parent_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "Name")
            {
                UpdateParentsList();
            }
        }

        public void UpdateParentsList()
        {
            cbxParent.Items.Clear();
            cbxParent.Items.Add("<None>");
            cbxParent.Items.AddRange(manager.Planets.Where(x => planet.CanBeParent(x)).ToArray<DrawablePlanet>());
            cbxParent.SelectedItem = this.planet.Parent;
            if (planet.Parent == null)
            {
                cbxParent.SelectedIndex = 0;
            }
            updated = true;
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            cdlColor.Color = planet.Color;
            if (cdlColor.ShowDialog() == DialogResult.OK)
            {
                planet.Color = cdlColor.Color;
                btnColor.BackColor = cdlColor.Color;
            }
        }

        public event EventHandler<PlanetEventArgs> PlanetRemoved;
        private void OnPlanetRemoved()
        {
            if (PlanetRemoved != null)
                PlanetRemoved(this, new PlanetEventArgs(this.planet));
        }

        private void cbxParent_SelectedValueChanged(object sender, EventArgs e)
        {
                planet.Parent = cbxParent.SelectedItem as Planet;
        }

        private void cbxParent_Enter(object sender, EventArgs e)
        {
            UpdateParentsList();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            OnPlanetRemoved();
            this.Dispose();
        }

        public void RemoveUpdate(object sender, PlanetEventArgs e)
        {
            if(e.planet == planet.Parent)
            {
                planet.Parent = null;
                cbxParent.SelectedIndex = 0;
            }
        }

        private void MovePlanet(int direction)
        {
            Control parent = this.Parent;
            Planet viewFrom = manager.ViewFrom;
            int thisControlIndex = parent.Controls.IndexOf(this);
            int swapControlIndex = thisControlIndex + direction;
            int itemCount = manager.Planets.Count;

            if (swapControlIndex >= 0 && swapControlIndex <= (itemCount - 1))
            {
                Control swap = parent.Controls[swapControlIndex];
                parent.Controls.SetChildIndex(swap, thisControlIndex);
                parent.Controls.SetChildIndex(this, swapControlIndex);

                thisControlIndex = itemCount - 1 - thisControlIndex;
                swapControlIndex = thisControlIndex - direction;

                manager.Planets[thisControlIndex] = (swap as PlanetControl).planet;
                manager.Planets[swapControlIndex] = planet;
                manager.ViewFrom = viewFrom;
            }
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            MovePlanet(1);
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            MovePlanet(-1);
        }

        private void cbxParent_MouseEnter(object sender, EventArgs e)
        {
            if(!cbxParent.Focused)
            {
                updated = false;
            }
        }
    }
}
