using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matricula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblpresentacion.Visible = true;
            cboDias.SelectedIndex = 0;
            rdbManana.Checked = true;
            lblCantidad.Text = "0";
            lblTotal.Text = "S/. 0";
        }

        private void cambiarEstadoPresentacion(object sender, EventArgs e)
        {
            if (chkDesarrollo.Checked || chkDiseno.Checked || chkAdmin.Checked || chkOfi.Checked)
            {
                lblpresentacion.Visible = false;
            }
            else
            {
                lblpresentacion.Visible = true;
                grupo.Text = "";
                grupo.Visible = false;
            }
        }

        private void chkDesarrollo_Click(object sender, EventArgs e)
        {
            if (chkDesarrollo.Checked)
            {
                cboDesarrollo.Visible = true;
                grupo.Visible = true;
            }
            else
            {
                cboDesarrollo.Visible = false;
            }
        }

        private void chkDiseno_Click(object sender, EventArgs e)
        {
            if (chkDiseno.Checked)
            {
                cboDiseno.Visible = true;
                grupo.Visible = true;
            }
            else
            {
                cboDiseno.Visible = false;
            }
        }

        private void chkAdmin_Click(object sender, EventArgs e)
        {
            if (chkAdmin.Checked)
            {
                cboAdmin.Visible = true;
                grupo.Visible = true;
            }
            else
            {
                cboAdmin.Visible = false;
            }
        }

        private void chkOfi_Click(object sender, EventArgs e)
        {
            if (chkOfi.Checked)
            {
                cboOfi.Visible = true;
                grupo.Visible = true;
            }
            else
            {
                cboOfi.Visible = false;
            }
        }

        // TEXTO DINAMICO GROUP BOX

        private void cboDesarrollo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextoDinamico(cboDesarrollo);
            txtPrecio.Text = "200";
        }

        private void cboDiseno_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextoDinamico(cboDiseno);
            txtPrecio.Text = "150";
        }

        private void cboAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextoDinamico(cboAdmin);
            txtPrecio.Text = "220";
        }

        private void cboOfi_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextoDinamico(cboOfi);
            txtPrecio.Text = "120";
        }

        public void TextoDinamico(ComboBox combo)
        {
            grupo.Text = combo.SelectedItem.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (grupo.Text == "")
            {
                MessageBox.Show("Debe seleccionar un curso", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string msg = "";
                int suma = 0;

                if (cboDesarrollo.Visible)
                {
                    lsbCurso.Items.Add(cboDesarrollo.SelectedItem.ToString());
                }
                else if (cboDiseno.Visible)
                {
                    lsbCurso.Items.Add(cboDiseno.SelectedItem.ToString());
                }
                else if (cboAdmin.Visible)
                {
                    lsbCurso.Items.Add(cboAdmin.SelectedItem.ToString());
                }
                else
                {
                    lsbCurso.Items.Add(cboOfi.SelectedItem.ToString());
                }

                if (rdbManana.Checked)
                {
                    msg = rdbManana.Text;
                }
                else if (rdbTarde.Checked)
                {
                    msg = rdbTarde.Text;
                }
                else
                {
                    msg = rdbNoche.Text;
                }

                lsbFrecuencia.Items.Add(cboDias.SelectedItem.ToString() + " por " + msg);
                lsbPrecio.Items.Add(txtPrecio.Text);

                foreach (object elemento in lsbPrecio.Items)
                {
                    suma += Convert.ToInt32(elemento);
                }

                lblCantidad.Text = lsbCurso.Items.Count.ToString();
                lblTotal.Text = "S/. " + suma.ToString();
            }
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            if(lsbCurso.Items.Count == 0 || lsbFrecuencia.Items.Count == 0 || lsbPrecio.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos en las listas", "MENSAJE DE ADVERTENCIA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
