using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notatnik
{
    public partial class Notatnik : Form
    {
        #region Zmienne
        string sciezka = "";
        #endregion Zmienne
        #region Konstruktor
        public Notatnik()
        {
            InitializeComponent();
        }
        #endregion Konstruktor
        #region Plik
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogresult=MessageBox.Show("Czy chcesz zapisać plik?","Uwaga",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question);
            if(dialogresult ==DialogResult.Yes)
            {
                zapiszJakoToolStripMenuItem_Click(sender, e);
                textBox1.Text = "";
                sciezka = "";
            }
            else if (dialogresult == DialogResult.No)
            {
                textBox1.Text = "";
                sciezka = "";
            }
            else if (dialogresult == DialogResult.Cancel)
            {
                return;
            }
            
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = openFileDialog1;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                sciezka = dialog.FileName;
                textBox1.Text = File.ReadAllText(sciezka);
            }
            else return;
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sciezka))
            {
                SaveFileDialog dialog = saveFileDialog1;
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    File.WriteAllText(dialog.FileName, textBox1.Text);
                    sciezka = dialog.FileName;
                    MessageBox.Show("Tekst zapisany", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else return;

            }
            else
            {
                File.WriteAllText(sciezka, textBox1.Text);
                MessageBox.Show("Tekst zapisany", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void zapiszJakoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = saveFileDialog1;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, textBox1.Text);
                sciezka = dialog.FileName;
                MessageBox.Show("Tekst zapisany", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else return;

        }
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            { this.Close();
            }
            else
            {
                DialogResult dialogresult = MessageBox.Show("Czy chcesz zapisać plik?","Uwaga", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogresult == DialogResult.Yes)
                    zapiszJakoToolStripMenuItem_Click(sender, e);
                else if (dialogresult == DialogResult.No)
                    this.Close();
                else if (dialogresult == DialogResult.Cancel)
                    return;
            }
            
        }
        #endregion Plik
        #region Edycja
        private void edycjaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void wytnjCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void kopiujCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void wklejCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }
        #endregion Edycja
        #region Format
        private void zawijanieWierszyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (zawijanieWierszyToolStripMenuItem.Checked == true)
            {
                zawijanieWierszyToolStripMenuItem.Checked = false;
                textBox1.WordWrap = false;
                textBox1.ScrollBars = ScrollBars.Both;
            }
            else
            {
                zawijanieWierszyToolStripMenuItem.Checked = true;
                textBox1.WordWrap = true;
                textBox1.ScrollBars = ScrollBars.Vertical;
            }

        }

        private void czcionkaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = fontDialog1;
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Font = dialog.Font;
            }
            else
            {
                return;
            }


        }
        #endregion Format
        #region Pomoc
        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 a = new AboutBox1();
            a.Show();
        }
        #endregion Edycja

        
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

       
    }
}
