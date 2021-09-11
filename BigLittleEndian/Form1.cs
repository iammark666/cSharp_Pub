/*  BigLittleEndianTool
 *  Version 1.0
 *  2021年9月10日
 *  Zhao Mark
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BigLittleEndian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Big2Lit_Click(object sender, EventArgs e)
        {

                    //LittleEndian.Text = BigEndian.Text ;
                    //MessageBox.Show(Convert.ToString(BigEndian.Lines.Length));

            for (int i = 0; i < BigEndian.Lines.Length; i++)
            {
                    //MessageBox.Show(BigEndian.Lines[i]);
                string b = BigEndian.Lines[i].Substring(0, 2);
                    //MessageBox.Show(b);
                string c = BigEndian.Lines[i].Substring(2, 2); 

                string d = BigEndian.Lines[i].Substring(4, 2);
                string f = BigEndian.Lines[i].Substring(6, 2);

                /*  将text追加到LittleEndian.Text    */

                if (i == 0)
                {
                    LittleEndian.Text = f + d + c + b;
                }
                else
                {
                    LittleEndian.Text += "\r\n" + f + d + c + b;
                }
            }
            //MessageBox.Show(LittleEndian.Text);

                    //MessageBox.Show(Convert.ToString(j));
                    //MessageBox.Show(str_out[0]);
                    //MessageBox.Show(BitConverter.ToString(str_temp));



        }

        private void BigEndian_TextChanged(object sender, EventArgs e)
        {

        }

        private void LittleEndian_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lit2Big_Click(object sender, EventArgs e)
        {

            //BigEndian.Text = LittleEndian.Text;

            for (int i = 0; i < LittleEndian.Lines.Length; i++)
            {
                string b = LittleEndian.Lines[i].Substring(0, 2);
                //MessageBox.Show(b);
                string c = LittleEndian.Lines[i].Substring(2, 2); 

                string d = LittleEndian.Lines[i].Substring(4, 2);
                string f = LittleEndian.Lines[i].Substring(6, 2);

                /*  将text追加到 BigEndian.Text    */

                if (i == 0)
                {
                    BigEndian.Text = f + d + c + b;
                }
                else
                {
                    BigEndian.Text += "\r\n" + f + d + c + b;
                }
            }
            //MessageBox.Show(LittleEndian.Text);

        }
    }
}
