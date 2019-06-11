using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SModel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int factorial(int x)
        {
            int result = 1;
            if (x == 0)
                return 1;
            else
            {
                for (int i = 1; i <= x; i++)
                {
                    result = result * i;
                }
                return result;
            }
            
        }
        public double sigma(int min, int max, string s,double bien)
        {
            double result =0;
            if(s == "p0MMC")
            {
                for (int i = min; i <= max; i++)
                {
                    result = result + Math.Pow(bien, i) / (factorial(i));
                }
                return result;
            }
            else if (s == "p01MMCK")
            {
                for (int i = min; i <=max; i++)
                {
                    result = result + Math.Pow(bien, i) / factorial(i);
                }
                return result;
            }
            else if (s =="LqMMCK")
            {
                for (int i= min; i<=max; i++)
                {
                    result = result + i * Math.Pow(bien, i);
                }
            }
            return result;
          
        }
        public double sigma(int min, int max, string s, double bien1,double bien2)
        {
            double result = 0;
            if (s =="p02MMCK")
            {
                for (int i = min; i <=max; i++)
                {
                    result =result+ Math.Pow((bien1 / bien2), i);
                }
            }
            return result;
        }
        private void btnSim_Click(object sender, EventArgs e)
        {
            double lambda = Convert.ToDouble(txt_lambda.Text);
            double mu = Convert.ToDouble(txt_mu.Text);
            double c = 0 ;
            double k=  0 ;
            double rho = lambda/mu;
            double r;
            double p0 = 0, pk = 0;
            double L = 0, Lq = 0, W = 0, Wq = 0;
            double x = 0;
            double alpha = 0;
            double lambdaE = 0;
            string model = cmb_model.Text;
            if (string.IsNullOrWhiteSpace(txt_c.Text))
            { }
            else
                c = Convert.ToDouble(txt_c.Text);
            if (string.IsNullOrEmpty(txt_k.Text))
            { }
            else
                k = Convert.ToDouble(txt_k.Text);
                txt_result.Text = Convert.ToString(lambda / mu);
            if (cmb_model.Text == "M/M/1")
            {
                p0 = (1 - rho);
                L = rho / (1 - rho);
                Lq = L - 1;
                W = 1 / (mu - lambda);
                Wq = rho / (mu - lambda);
            }
            else if (cmb_model.Text == "M/M/1/K")
            {
                double numL = 0;
                double detL = 0;
                if (rho == 1)
                {
                    p0 = 1 / (k + 1);
                    L = k / 2;
                    Lq = k * (k - 1) / (2 * (k + 1));
                }
                else
                {
                    p0 = (1 - rho) / (1 - Math.Pow(rho, k + 1));
                    numL = 1 + k * Math.Pow(rho, k + 1) - (k + 1) * Math.Pow(rho, k);
                    detL = (1 - rho) * (1 - Math.Pow(rho, k + 1));
                    L = rho * numL / detL;
                    Lq = L - (rho * (1 - Math.Pow(rho, k))) / (1 - Math.Pow(rho, k + 1));
                }
                pk = p0 * Math.Pow(rho, k);
                W = L / (lambda * (1 - pk));
                Wq = W - 1 / mu;
            }
            else if (cmb_model.Text == "M/M/C")
            {
                r = lambda / mu;
                rho = r / c;
                p0 = 1 / (c * Math.Pow(r, c) / (factorial(Convert.ToInt32(c)) * (c - r)) + sigma(0, Convert.ToInt32(c - 1), "p0MMC", r));
                Lq = p0 * Math.Pow(r, c) * rho / (factorial(Convert.ToInt32(c)) * Math.Pow(1 - rho, 2));
                L = Lq + r;
                Wq = Lq / lambda;
                W = Wq + 1 / mu;
            }
            else if (cmb_model.Text == "M/M/C/K")
            {        
                alpha = lambda / mu;
                x = alpha / c;
                p0 = 1 / (sigma(0, Convert.ToInt32(c), "p01MMCK", alpha) + Math.Pow(alpha, c) / factorial(Convert.ToInt32(c)) * sigma(1, Convert.ToInt32(k - c), "p02MMCK", alpha, c));
                pk = Math.Pow(alpha, c) / factorial(Convert.ToInt32(c)) * Math.Pow((alpha / c), k - c) * p0;
                Lq = Math.Pow(alpha, c) / factorial(Convert.ToInt32(c)) * p0 * sigma(0, Convert.ToInt32(k - c), "LqMMCK", x);
                lambdaE = lambda*(1 - pk);
                Wq = Lq / lambdaE;
                W = Wq + 1 / mu;
                L = lambdaE * W;
            }
            txt_result.Text = Convert.ToString("p0= "+p0+"pk ="+ pk);
            lbl_L.Text = "Số lượng khách trung bình trong hệ thống: L = " + Math.Round(L,4).ToString();
            lbl_Lq.Text = "Số lượng khách trung bình trong hàng chờ: Lq = " + Math.Round(Lq,4).ToString();
            lbl_W.Text = "Thời gian chờ trung bình trong hệ thống: W = " + Math.Round(W,4).ToString();
            lbl_Wq.Text = "Thời gian chờ trung bình trong hàng chờ: Wq = " + Math.Round(Wq,4).ToString();
            
        }

        private void cmb_model_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmb_model_TextChanged(object sender, EventArgs e)
        {
            if (cmb_model.Text == "M/M/1")
            {
                txt_c.Text = "1";
                txt_k.Enabled = false;
            }
            else if (cmb_model.Text == "M/M/1/K")
            {
                txt_c.Text = "1";
                txt_k.Enabled = true;
            }
            else if (cmb_model.Text == "M/M/C")
            {
                txt_k.Enabled = false;
            }
            else if (cmb_model.Text == "M/M/C/K")
            {
                txt_k.Enabled = true;
            }
        }
    }
}
