using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cadastrado com sucesso");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtSobrenome.Text = "";
            txtCpf.Text = "";
            cmbEstado.SelectedIndex = -1;
        }
    }
}
