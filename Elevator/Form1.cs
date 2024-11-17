namespace Elevator
{
    public partial class frmBuilding : Form
    {

        ElevatorController controller;

        public frmBuilding()
        {
            InitializeComponent();
        }


        private void txtFloors_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnCreateBuilding_Click(object sender, EventArgs e)
        {
            if (txtFloors.Text.Length == 0 || Convert.ToInt16(txtFloors.Text) < 2)
            {
                MessageBox.Show("La cantidad de pisos debe ser mayor que 0");
            }
            controller = new ElevatorController(Convert.ToInt16(txtFloors.Text));
            btnDrills.Visible = true;
            messageList.Items.Clear();
            messageList.Visible = true;

        }

        private void btnDrills_Click(object sender, EventArgs e)
        {
            controller.requestElevator(1, 3);
            messageList.Items.Add("Del piso 1 al 3");
            controller.requestElevator(3, 2);
            messageList.Items.Add("Del piso 3 al 2");
            controller.requestElevator(2, 5);
            messageList.Items.Add("Del piso 2 al 5");
            controller.requestElevator(5, 1);
            messageList.Items.Add("Del piso 5 al 1");

            controller.processRequest();
        }
    }
}
