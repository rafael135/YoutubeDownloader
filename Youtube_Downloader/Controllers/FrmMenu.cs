using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Youtube_Downloader.Controllers
{
    public partial class FrmMenu : UserControl
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private bool clicked = false;
        private Point coordMouse;

        private Form ActiveForm() // Retorna o formulario ativo do controle
        {
            return Form.ActiveForm;
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            
        }

        private void FrmMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                clicked = true;
                coordMouse = e.Location;
            }
        }

        private void FrmMenu_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void FrmMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked == false)
            {
                return;
            }

            Point newCoord = new Point(MousePosition.X - coordMouse.X, MousePosition.Y - coordMouse.Y);
            ActiveForm().Location = newCoord;


        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            try
            {
                Form activeFrm = ActiveForm();
                activeFrm.WindowState = FormWindowState.Minimized; // Minimiza o formulario ativo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            try
            {
                Form activeFrm = ActiveForm();
                activeFrm.Close(); // Fecha o formulario ativo
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void formLoaded()
        {
            try
            {
                Form activeFrm = ActiveForm();
                lblFormName.Text = "Youtube Downloader";
            }
            catch (Exception ex)
            {

            }
        }

        private void picClose_MouseHover(object sender, EventArgs e)
        {
            picClose.BackColor = Color.FromArgb(17, 181, 228);
        }

        private void picMinimize_MouseHover(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.FromArgb(17, 181, 228);
        }

        private void FrmMenu_Validated(object sender, EventArgs e)
        {
            
        }

        private void picMinimize_MouseLeave(object sender, EventArgs e)
        {
            picMinimize.BackColor = Color.Transparent;
        }

        private void picClose_MouseLeave(object sender, EventArgs e)
        {
            picClose.BackColor = Color.Transparent;
        }
    }
}
