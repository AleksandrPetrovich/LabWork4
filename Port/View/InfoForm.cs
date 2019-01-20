using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Port.Interfaces;

namespace Port.View
{
    public partial class InfoForm : Form
    {
        private MainFormViewModel _model;

        private MainFormViewModel Model
        {
            get => _model;
            set
            {
                if (_model != null)
                {
                    _model.PropertyChanged -= _model_PropertyChanged;
                }
                _model = value;
                _model.PropertyChanged += _model_PropertyChanged;
            }
        }

        private void _model_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
        }
               
        public InfoForm(MainFormViewModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void InfoForm_Activated(object sender, EventArgs e)
        {
            titleShipLabel.Text = Model.Ship.Title;
            costFuelLabel.Text = Model.Ship.Fuel.Cost.ToString();
            titlePortLabel.Text = Model.Ship.Route.Arrival.Title;
            cargoListBox.DataSource = Model.Ship.Cargos;
            cargoListBox.DisplayMember = "Cost";
        }
    }
}
