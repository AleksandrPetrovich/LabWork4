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
    public partial class FillForm : Form
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

        public FillForm(MainFormViewModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void FillForm_Activated(object sender, EventArgs e)
        {
            fuelListBox.DataSource = Model.FuelList;
            fuelListBox.DisplayMember = "Cost";
        }

        private void fillButton_Click(object sender, EventArgs e)
        {
            Model.FillShip((IFuel)fuelListBox.SelectedItem);            
            Close();
        }
    }
}
