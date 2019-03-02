using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tuc_tac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool turn=true;
        int turncount = 0;
        private void a1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn == true)
            {
                b.Text = "x";
            }
            else {
                b.Text = "o";
            }
            turn =! turn;
            b.Enabled = false;
            hori();
           verti();
           Cross();
           turncount++;
           if (turncount > 8)
           {
               disable();

               MessageBox.Show("Draw !");
           }
           b.Enabled = false;
            
        }
        void hori()
        {
            bool winner = false;
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {                disable();

                winner = true;
            }
            if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                winner = true;
            }
            if ((c1.Text == c2.Text) && (c2.Text == c3.Text) && (!c1.Enabled))
            {
                winner = true;
            }

            
            if (winner)
            {                disable();

               MessageBox.Show("YOU WIN");
            }
        }
        void verti()
        {
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            {
                disable();
                MessageBox.Show("YOU WIN");
            }
            if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            {
                disable();

                MessageBox.Show("YOU WIN");
            }
            if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
            {
                disable();

                MessageBox.Show("YOU WIN");
            }
        }
        void Cross()
        {
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            {
                disable();

                MessageBox.Show("YOU WIN");
            }
            if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!a3.Enabled))
            {
                disable();

                MessageBox.Show("YOU WIN");
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turncount = 0;
           
            try{
                foreach (Control c in Controls)
                {
                    Button bb = (Button)c;
                    bb.Enabled = true;
                    bb.Text = "";
                }
            }
            catch {}
            try
            {
                Button b = (Button)sender;

                // b.Enabled=true;
                if (turn == true)
                {
                    b.Text = "x";
                }
                else
                {
                    b.Text = "o";
                }
                turn = !turn;
                b.Enabled = false;
                hori();
                verti();
                Cross();
                turncount++;
                if (turncount > 8)
                {
                    disable();

                    MessageBox.Show("Draw !");
                }
                b.Enabled = false;

            }
            catch { }
            
        }
        void disable() 
        {    

            try{
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch {}
            }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Syed AKhter ");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
          DialogResult dr = MessageBox.Show ("Are you want to exit?","conform",MessageBoxButtons.YesNo);
          //MessageBoxIcon.Question;
          if (dr== DialogResult.Yes)
          this.Close();
        }

        private void filrToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        
        
        
        }

    }

