using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Monto_a_Pagar : Form
    {
        public Monto_a_Pagar()
        {
            InitializeComponent();
        }

        public void AsignarMonto(string monto)
        {

            txt_total.Text = monto;

        }

        

        private void txt_Monto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {

                if((Convert.ToInt32(txt_Monto.Text) < Convert.ToInt32(txt_total.Text))){
                    
                    MessageBox.Show("El Monto a pagar debe ser mayor que el total vendido","EEROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                
                }else{
                
                lbl_Vuelto.Text = ((Convert.ToInt32(txt_Monto.Text) - Convert.ToInt32(txt_total.Text)).ToString());

                }
                
            
            }
        }

        private void Monto_a_Pagar_Load(object sender, EventArgs e)
        {

        }
        
    }
}
