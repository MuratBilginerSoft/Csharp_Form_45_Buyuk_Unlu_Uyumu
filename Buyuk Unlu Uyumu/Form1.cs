using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace Buyuk_Unlu_Uyumu
{
    public partial class Form1 : Form
    {

        #region Tanımlamalar

        ArrayList harfler=new ArrayList();


        string[] kalınünlüler = {"a","ı","o","u" };

        string[] inceünlüler = {"e","i","ö","ü"};

        #endregion

        #region Değişkenler

        string kelime;

        int b = 0;

        int c = 0;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            harfler.Clear();

        
            b = 0;
            c = 0;

            kelime = textBox1.Text;

            foreach (char harf in kelime)
            {
                harfler.Add(harf.ToString());
                
            }

            for (int i = 0; i < harfler.Count; i++)
            {
                foreach (string harf2 in kalınünlüler)
                {
                    if (harf2 == harfler[i].ToString())
                        b++;
                }

                foreach (string harf3 in inceünlüler)
                {
                    if (harf3==harfler[i].ToString())
                        c++;
                }
            }

            if (b!=0 && c!=0)
            {
                label3.Text = "Kelime büyük ünlü uyumuna uymamaktadır";
            }

            else if (b==0 && c==0)
            {
                 label3.Text = "Kelimede ünlü harf bulunmamaktadır.";
            }

            else 
	        {
                label3.Text = "Kelime büyük ünlü uyumuna uymaktadır";
	        }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
