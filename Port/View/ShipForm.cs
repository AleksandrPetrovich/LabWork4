using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Port.View
{
    public partial class ShipForm : Form
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

        public ShipForm(MainFormViewModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void ShipForm_Activated(object sender, EventArgs e)
        {
            portShipComboBox.DataSource = Model.PortList;
            portShipComboBox.DisplayMember = "Title";            
        }

        private void createShipButton_Click(object sender, EventArgs e)
        {
            Model.CreateShip(titleShipTextBox.Text, (Model.Port)portShipComboBox.SelectedItem);
            Close();
        }
    }
}
