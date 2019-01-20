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
    public partial class LoadForm : Form
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

        public LoadForm(MainFormViewModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void LoadForm_Activated(object sender, EventArgs e)
        {
            cargoListBox.DataSource = Model.CargoList;
            cargoListBox.DisplayMember = "Cost";
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            foreach(var cargo in cargoListBox.SelectedItems)
            {
                Model.LoadShip((ICargo)cargo);               
            }            
            Close();
        }
    }
}
