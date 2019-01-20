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
    public partial class MainForm : Form
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
            if (e.PropertyName == nameof(MainFormViewModel.Ship))
            {
                mainFlowLayoutPanel.Controls.Clear();
                foreach (var port in Model.PortList)
                {
                    TableLayoutPanel portPanel = new TableLayoutPanel();
                    portPanel.RowCount = 3;
                    portPanel.ColumnCount = 2;
                    Label titlePort = new Label();
                    titlePort.Text = port.Title;
                    portPanel.Controls.Add(titlePort, 0, 0);
                    Label coordinatePort = new Label();
                    coordinatePort.Text = port.Coordinate.ToString();
                    portPanel.Controls.Add(coordinatePort, 1, 0);
                    Label narazgruzke = new Label();
                    narazgruzke.Text = "На разгрузке";
                    portPanel.Controls.Add(narazgruzke, 0, 1);
                    Label vportu = new Label();
                    vportu.Text = "В порту";
                    portPanel.Controls.Add(vportu, 1, 1);
                    ListBox razgruzka = new ListBox();
                    razgruzka.DataSource = port.OnUnloading;
                    razgruzka.DisplayMember = "Title";
                    portPanel.Controls.Add(razgruzka, 0, 2);
                    ListBox inPort = new ListBox();
                    inPort.DataSource = port.InPort;
                    inPort.DisplayMember = "Title";
                    ToolStripMenuItem fillToolStripMenuItem = new ToolStripMenuItem("Заправить");
                    fillToolStripMenuItem.Click += fillToolStripMenuItem_Click;
                    ToolStripMenuItem loadToolStripMenuItem = new ToolStripMenuItem("Загрузить");
                    loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
                    ToolStripMenuItem setRouteToolStripMenuItem = new ToolStripMenuItem("Установить маршрут");
                    setRouteToolStripMenuItem.Click += setRouteToolStripMenuItem_Click;
                    ToolStripMenuItem sendToolStripMenuItem = new ToolStripMenuItem("Отправить по маршруту");
                    sendToolStripMenuItem.Click += sendToolStripMenuItem_Click;
                    ToolStripMenuItem infoToolStripMenuItem = new ToolStripMenuItem("Информация");
                    infoToolStripMenuItem.Click += infoToolStripMenuItem_Click;
                    ToolStripMenuItem historyToolStripMenuItem = new ToolStripMenuItem("История");
                    historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
                    ContextMenuStrip shipContextMenuStrip = new ContextMenuStrip();
                    shipContextMenuStrip.Items.AddRange(new[] { fillToolStripMenuItem, loadToolStripMenuItem, setRouteToolStripMenuItem, sendToolStripMenuItem, infoToolStripMenuItem, historyToolStripMenuItem });
                    inPort.ContextMenuStrip = shipContextMenuStrip;
                    portPanel.Controls.Add(inPort, 1, 2);
                    Panel mainPanel = new Panel();
                    mainPanel.BorderStyle = BorderStyle.FixedSingle;
                    mainPanel.AutoSize = true;
                    mainPanel.Padding = new Padding(2, 2, 2, 2);
                    mainPanel.Controls.Add(portPanel);
                    mainFlowLayoutPanel.Controls.Add(mainPanel);
                }
            }                
        }

        public MainForm(MainFormViewModel model)
        {
            InitializeComponent();
            Model = model;
        }

        private void portToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PortForm portForm = new PortForm(Model);            
            portForm.ShowDialog();
        }        

        private void MainForm_Activated(object sender, EventArgs e)
        {
            
        }

        void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillForm fillForm = new FillForm(Model);
            Model.Ship = (IShip)(((sender as ToolStripMenuItem).GetCurrentParent() as ContextMenuStrip).SourceControl as ListBox).SelectedItem;
            fillForm.ShowDialog();
        }

        void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm loadForm = new LoadForm(Model);
            Model.Ship = (IShip)(((sender as ToolStripMenuItem).GetCurrentParent() as ContextMenuStrip).SourceControl as ListBox).SelectedItem;
            loadForm.ShowDialog();
        }

        void setRouteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetRouteForm setRouteForm = new SetRouteForm(Model);
            Model.Ship = (IShip)(((sender as ToolStripMenuItem).GetCurrentParent() as ContextMenuStrip).SourceControl as ListBox).SelectedItem;
            setRouteForm.ShowDialog();
        }

        void sendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Model.Ship = (IShip)(((sender as ToolStripMenuItem).GetCurrentParent() as ContextMenuStrip).SourceControl as ListBox).SelectedItem;
            Model.Send();
        }

        void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm infoForm = new InfoForm(Model);
            Model.Ship = (IShip)(((sender as ToolStripMenuItem).GetCurrentParent() as ContextMenuStrip).SourceControl as ListBox).SelectedItem;
            infoForm.ShowDialog();
        }

        void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm(Model);
            Model.Ship = (IShip)(((sender as ToolStripMenuItem).GetCurrentParent() as ContextMenuStrip).SourceControl as ListBox).SelectedItem;
            historyForm.ShowDialog();
        }

        private void routeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RouteForm routeForm = new RouteForm(Model);
            routeForm.ShowDialog();
        }

        private void fuelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FuelForm fuelForm = new FuelForm(Model);
            fuelForm.ShowDialog();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargoForm cargoForm = new CargoForm(Model);
            cargoForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void shipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShipForm shipForm = new ShipForm(Model);            
            shipForm.ShowDialog();
        }
    }
}
