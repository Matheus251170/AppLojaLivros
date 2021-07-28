using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Frm : Form
    {
        public Frm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
   
        }

        private void lblFrete_Click(object sender, EventArgs e)
        {

        }

        void limpar_campos()
        {
            txtNome.Clear();
            txtLiv.Clear();
            txtPreco.Clear();
            cmbEst.Items.Clear();
            cmbEst.Items.Add("São Paulo");
            cmbEst.Items.Add("Rio de Janeiro");
            cmbEst.Items.Add("Amapá");
            cmbEst.Items.Add("Goiás");
            cmbEst.Items.Add("Paraná");
            cmbEst.Items.Add("Tocantins");
            cmbEst.Items.Add("Bahia");
            cmbEst.Items.Add("Rio Grande do Sul");
            cmbEst.Items.Add("Rio Grande do Norte");
            cmbEst.Items.Add("Amazonas");
            cmbEst.Items.Add("Maranhão");
            cmbEst.Items.Add("Paraíba");
            cmbEst.Items.Add("Santa Catarina");
            cmbEst.Items.Add("Minas Gerais");
            cmbEst.Items.Add("Espirito Santo");
            cmbEst.Items.Add("Rondônia");
            cmbEst.Items.Add("Alagoas");
            cmbEst.Items.Add("Acre");
            cmbEst.Items.Add("Piauí");
            cmbEst.Items.Add("Sergipe");
            cmbEst.Items.Add("Ceará");
            cmbQnt.Items.Clear();
            cmbQnt.Items.Add(1);
            cmbPag.Items.Clear();
            cmbPag.Items.Add("Boleto");
            cmbPag.Items.Add("Cartão de Crédito");
            cmbPag.Items.Add("Cartão de Débito");
            cmbPag.Items.Add("Bitcoin");
            cmbPag.Items.Add("Paypal");
            cmbPag.Items.Add("Blockchain");
            BoxLvr1.Checked = false;
            BoxLvr2.Checked = false;
            BoxLvr3.Checked = false;
            BoxLvr4.Checked = false;
            BoxLvr5.Checked = false;
            BoxLvr6.Checked = false;
            txtNome.ReadOnly = false;
            cmbPag.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxLvr3.Checked == true)
            {
                grpCompra.Show();
                grpLvr1.Hide();
                grpLvr2.Hide();
                grpLvr4.Hide();
                grpLvr5.Hide();
                grpLvr6.Hide();
                txtPreco.Text = Convert.ToString("$36,50");
                txtLiv.Text = grpLvr3.Text;
            }
            else
            {
                grpCompra.Hide();
                grpLvr1.Show();
                grpLvr2.Show();
                grpLvr4.Show();
                grpLvr5.Show();
                grpLvr6.Show();
            }
        }

        private void BoxLvr1_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxLvr1.Checked == true)
            {
                
                grpCompra.Show();
                grpLvr2.Hide();
                grpLvr3.Hide();
                grpLvr4.Hide();
                grpLvr5.Hide();
                grpLvr6.Hide();
                txtLiv.Text = grpLvr1.Text;
                txtPreco.Text = Convert.ToString("$41,00");
            }
            else
            {
                grpCompra.Hide();
                grpLvr2.Show();
                grpLvr3.Show();
                grpLvr4.Show();
                grpLvr5.Show();
                grpLvr6.Show();
            }
        }

        private void BoxLvr2_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxLvr2.Checked == true)
            {
                grpCompra.Show();
                grpLvr1.Hide();
                grpLvr3.Hide();
                grpLvr4.Hide();
                grpLvr5.Hide();
                grpLvr6.Hide();
                txtPreco.Text = Convert.ToString("$45,60");
                txtLiv.Text = grpLvr2.Text;
            }
            else
            {
                grpCompra.Hide();
                grpLvr1.Show();
                grpLvr3.Show();
                grpLvr4.Show();
                grpLvr5.Show();
                grpLvr6.Show();
            }
        }

        private void BoxLvr4_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxLvr4.Checked == true)
            {
                grpCompra.Show();
                grpLvr1.Hide();
                grpLvr2.Hide();
                grpLvr3.Hide();
                grpLvr5.Hide();
                grpLvr6.Hide();
                txtPreco.Text = Convert.ToString("$35,00");
                txtLiv.Text = grpLvr4.Text;
            }
            else
            {
                grpCompra.Hide();
                grpLvr1.Show();
                grpLvr2.Show();
                grpLvr3.Show();
                grpLvr5.Show();
                grpLvr6.Show();
            }
        }

        private void BoxLvr5_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxLvr5.Checked == true)
            {
                grpCompra.Show();
                grpLvr1.Hide();
                grpLvr2.Hide();
                grpLvr3.Hide();
                grpLvr4.Hide();
                grpLvr6.Hide();
                txtPreco.Text = Convert.ToString("$39,90");
                txtLiv.Text = grpLvr5.Text;
            }
            else
            {
                grpCompra.Hide();
                grpLvr1.Show();
                grpLvr2.Show();
                grpLvr3.Show();
                grpLvr4.Show();
                grpLvr6.Show();
            }
        }

        private void BoxLvr6_CheckedChanged(object sender, EventArgs e)
        {
            if (BoxLvr6.Checked == true)
            {
                grpCompra.Show();
                grpLvr1.Hide();
                grpLvr2.Hide();
                grpLvr3.Hide();
                grpLvr4.Hide();
                grpLvr5.Hide();
                txtPreco.Text = Convert.ToString("$49,99");
                txtLiv.Text = grpLvr6.Text;
            }
            else
            {
                grpCompra.Hide();
                grpLvr1.Show();
                grpLvr2.Show();
                grpLvr3.Show();
                grpLvr4.Show();
                grpLvr5.Show();
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Frm_Load(object sender, EventArgs e)
        {
            cmbPag.Items.Add("Boleto");
            cmbPag.Items.Add("Cartão de Crédito");
            cmbPag.Items.Add("Cartão de Débito");
            cmbPag.Items.Add("Bitcoin");
            cmbPag.Items.Add("Paypal");
            cmbPag.Items.Add("Blockchain");
            
            cmbQnt.Items.Add("1");

            cmbEst.Items.Add("São Paulo");
            cmbEst.Items.Add("Rio de Janeiro");
            cmbEst.Items.Add("Amapá");
            cmbEst.Items.Add("Goiás");
            cmbEst.Items.Add("Paraná");
            cmbEst.Items.Add("Tocantins");
            cmbEst.Items.Add("Bahia");
            cmbEst.Items.Add("Rio Grande do Sul");
            cmbEst.Items.Add("Rio Grande do Norte");
            cmbEst.Items.Add("Amazonas");
            cmbEst.Items.Add("Maranhão");
            cmbEst.Items.Add("Paraíba");
            cmbEst.Items.Add("Santa Catarina");
            cmbEst.Items.Add("Minas Gerais");
            cmbEst.Items.Add("Espirito Santo");
            cmbEst.Items.Add("Rondônia");
            cmbEst.Items.Add("Alagoas");
            cmbEst.Items.Add("Acre");
            cmbEst.Items.Add("Piauí");
            cmbEst.Items.Add("Sergipe");
            cmbEst.Items.Add("Ceará");

            

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string x = txtNome.Text, y = cmbPag.Text;

            if(x == "")
            {
                MessageBox.Show("Por favor, insira um nome válido!");
            }
            else if(y == ""){
                MessageBox.Show("Por favor, escolha um método de pagamento!");
            }
            else
            {
                MessageBox.Show("Seus dados foram confirmados, " + x + "!" + "\nA forma de pagamento será " + y + "!");
                txtNome.ReadOnly = true;
                cmbPag.Enabled = false;
            }
            
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            string z = txtLiv.Text, x = txtNome.Text, y = cmbPag.Text, w = cmbQnt.Text, n = cmbEst.Text, v = txtPreco.Text;
             
            MessageBox.Show("Proprietário da compra: " + x + "\nForma de pagamento: " + y + "\nQuantidade: " + w + "\nEstado: " + n + "\nProduto: " + z + "\n\n-----------O valor da compra será de: " + v + "!----------");


        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            string z = txtLiv.Text, x = txtNome.Text, y = cmbPag.Text, w = cmbQnt.Text, n = cmbEst.Text;

            if (x == "")
            {
                MessageBox.Show("Por favor, insira um nome válido!");
            }
            else if (y == "")
            {
                MessageBox.Show("Por favor, escolha um método de pagamento!");
            }
            else if (z == "" || w == "" || n == "")
            {
                MessageBox.Show("Preencha os campos corretamente!");
            }
            else
            {
                MessageBox.Show("Compra realizada com sucesso!"); 
            }  
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.limpar_campos();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            cmbPag.Items.Clear();
            cmbPag.Items.Add("Boleto");
            cmbPag.Items.Add("Cartão de Crédito");
            cmbPag.Items.Add("Cartão de Débito");
            cmbPag.Items.Add("Bitcoin");
            cmbPag.Items.Add("Paypal");
            cmbPag.Items.Add("Blockchain");
            txtNome.Clear();
            txtNome.ReadOnly = false;
            cmbPag.Enabled = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}
