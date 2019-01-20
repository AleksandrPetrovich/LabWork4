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
    public partial class SetRouteForm : Form
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

        public SetRouteForm(MainFormViewModel model)
        {
            InitializeComponent();
            Model = model;
        }        

        private void SetRouteForm_Activated(object sender, EventArgs e)
        {
            routeListBox.DataSource = Model.RouteList;
            routeListBox.DisplayMember = "Arrival.Title";
        }

        private void setRouteButton_Click(object sender, EventArgs e)
        {
            Model.SetRoute((IRoute)routeListBox.SelectedItem);
            Close();
        }
    }
}
