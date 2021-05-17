using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoSegSocial_MiguelRodrigues
{
    public partial class Form1 : Form
    {
        public Queue<string> filageral;
        public Queue<string> filaprio;


        public Form1()
        {
            InitializeComponent();
            filageral = new Queue<string>();
            filaprio = new Queue<string>();

        }
        int ngeral,nprio,cont = 0;//dúvida
        char abc = 'A';

        private void btnchamar_Click(object sender, EventArgs e)
        {

            if (filageral.Count() == 0 && filaprio.Count() == 0)
            {
                MessageBox.Show("Não há senhas para atender");
            }
            else
            if (filaprio.Count()== 0 && filageral.Count()> 0)
            {
                string balc = filageral.Peek();
                label7_balcao1.Text = balc;
                
                filageral.Dequeue();
            }else
            if(filaprio.Count()>0 && filageral.Count()==0)
            {
                string balc = filaprio.Peek();
                label7_balcao1.Text = balc;
               
                filaprio.Dequeue();
            }
            if(filageral.Count()>0 && filaprio.Count()>0)
            {
                if (cont < 3)
                {
                    cont++;
                    string balc = filaprio.Peek();
                    label7_balcao1.Text = balc;
                   
                    filaprio.Dequeue();
                }
                else
                {
                    string balc = filageral.Peek();
                    label7_balcao1.Text = balc;
                   
                    filageral.Dequeue();
                    cont = 0;
                }
            }
        }
        private void btngeral_Click(object sender, EventArgs e)
        {
            string senhag="G-";   
            senhag += abc.ToString();
            ngeral++;
            if(ngeral>99)
            {
                ngeral = 0;
                ngeral++;
                abc++;
                senhag=abc.ToString();
            }
            string s = ngeral.ToString().PadLeft(2, '0');
            senhag+= s;
            filageral.Enqueue(senhag);
            string senhalast = filageral.Last();
            if (filageral.Count > 0)
            {
                label5.Text = senhalast;
            }
        }


        private void btnbalcao2_Click(object sender, EventArgs e)
        {

            if (filageral.Count() == 0 && filaprio.Count() == 0)
            {
                MessageBox.Show("Não há senhas para atender");
            }
            else
            if (filaprio.Count() == 0 && filageral.Count() > 0)
            {
                string balc = filageral.Peek();
                label7_balcao2.Text= balc;
              
                filageral.Dequeue();
            }
            else
            if (filaprio.Count() > 0 && filageral.Count() == 0)
            {
                string balc = filaprio.Peek();
                label7_balcao2.Text = balc;
              
                filaprio.Dequeue();
            }
            if (filageral.Count() > 0 && filaprio.Count() > 0)
            {
                if (cont < 3)
                {
                    cont++;
                    string balc = filaprio.Peek();
                    label7_balcao2.Text = balc;
               
                    filaprio.Dequeue();
                }
                else
                {
                    string balc = filageral.Peek();
                    label7_balcao2.Text = balc;
                
                    filageral.Dequeue();
                    cont = 0;
                }
            }
        }

        private void btnbalcao3_Click(object sender, EventArgs e)
        {

            if (filageral.Count() == 0 && filaprio.Count() == 0)
            {
                MessageBox.Show("Não há senhas para atender");
            }
            else
            if (filaprio.Count() == 0 && filageral.Count() > 0)
            {
                string balc = filageral.Peek();
                label8_balcao3.Text = balc;
           
                filageral.Dequeue();
            }
            else
            if (filaprio.Count() > 0 && filageral.Count() == 0)
            {
                string balc = filaprio.Peek();
                label8_balcao3.Text = balc;
           
                filaprio.Dequeue();
            }
            if (filageral.Count() > 0 && filaprio.Count() > 0)
            {
                if (cont < 3)
                {
                    cont++;
                    string balc = filaprio.Peek();
                    label8_balcao3.Text = balc;
           
                    filaprio.Dequeue();
                }
                else
                {
                    string balc = filageral.Peek();
                    label8_balcao3.Text = balc;
            
                    filageral.Dequeue();
                    cont = 0;
                }
            }
        }

        private void btnprio_Click(object sender, EventArgs e)
        {
            //
            string senhap = "P-";
            senhap += abc.ToString();
            nprio++;
            if (nprio > 99)
            {
                nprio = 0;
                nprio++;
                abc++;
                senhap = abc.ToString();
            }
            string s = nprio.ToString().PadLeft(2, '0');
            senhap += s;
            filaprio.Enqueue(senhap);
            string senhaplast = filaprio.Last();
            if (filaprio.Count > 0)
            {
                label6.Text = senhaplast;
            }
        }
    }
}
