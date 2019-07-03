using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg3Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hakkındaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void durumÇubuğuToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            statusStrip1.Visible = durumÇubuğuToolStripMenuItem.Checked;
        }

        private void sözcükKaydırToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = sözcükKaydırToolStripMenuItem.Checked;
        }

        private void geriAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void kesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void kopyalaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void yapıştırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        bool acikDosyaVarmi = false;
        bool degisiklikVarmi = false;
        string acikDosyaAdi = "";

        public void dosyaAcmaIslemleri()
        {
          
            OpenFileDialog od = new OpenFileDialog();
            DialogResult basilan = od.ShowDialog();
            if (basilan == DialogResult.OK)
            {
                richTextBox1.Clear();
                acikDosyaAdi = od.FileName;
                acikDosyaVarmi = true;
                richTextBox1.LoadFile(acikDosyaAdi, RichTextBoxStreamType.PlainText);
                degisiklikVarmi = false;

            }
        }
        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (acikDosyaVarmi == false)
            {
                if (degisiklikVarmi == false)
                    dosyaAcmaIslemleri();
                else
                {
                    DialogResult basilan = MessageBox.Show("Kaydedilsin mi?", "Notepad", MessageBoxButtons.YesNoCancel);
                    if (basilan == DialogResult.No)
                        dosyaAcmaIslemleri();
                    else if (basilan == DialogResult.Yes)
                    {
                        SaveFileDialog sd = new SaveFileDialog();
                        DialogResult basilan2 = sd.ShowDialog();
                        if (basilan2 == DialogResult.OK)
                        {
                            richTextBox1.SaveFile(sd.FileName, RichTextBoxStreamType.PlainText);
                            dosyaAcmaIslemleri();
                        }
                    }
                }
            }
            else//acikdosyavarmi=true
            {
                if (degisiklikVarmi == false)
                    dosyaAcmaIslemleri();
                else
                {
                    DialogResult basilan = MessageBox.Show("Kaydedilsin mi?", "Notepad", MessageBoxButtons.YesNoCancel);
                    if (basilan == DialogResult.No)
                        dosyaAcmaIslemleri();
                    else if (basilan == DialogResult.Yes)
                    {
                        richTextBox1.SaveFile(acikDosyaAdi, RichTextBoxStreamType.PlainText);
                        dosyaAcmaIslemleri();
                    }


                }
            }//else if
        }//metot

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            degisiklikVarmi = true;
        }
    }//class
}//namespace
