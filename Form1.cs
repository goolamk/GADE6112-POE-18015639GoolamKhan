using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace GADE6112_POE_18015639GoolamKhan
{
    public partial class Form1 : Form
    {
        GameEngine engine;
        public Form1()
        {
            InitializeComponent();
        }
        BinaryFormatter bf = new BinaryFormatter();
        Map m = new Map();
        FileStream fs = new FileStream("Save.dat", FileMode.Create, FileAccess.Write, FileShare.None);

        private void BtnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void BtnPause_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblRound.Text = "Round: " + engine.Round.ToString();
            engine.Update();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            engine = new GameEngine(20, txtInfo, grpMap);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            //FileStream fs = new FileStream("Save.dat", FileMode.Create, FileAccess.Write, FileShare.None);

            try
            {
                using (fs)
                {
                    bf.Serialize(fs,m);
                    MessageBox.Show("Game Saved");
                }

            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Death.dat", FileMode.Open, FileAccess.Read, FileShare.None);

            try
            {
                using (fs)
                {
                    m = (Map)bf.Deserialize(fs);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
