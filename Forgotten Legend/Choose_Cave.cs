/*
* Program Name:     Forgotten_Legend
* Programmer:       Samuel Chinchar
*/

//future project... not in game
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forgotten_Legend
{
    public partial class Choose_Cave : Form
    {
        public int Dirrection;
        public int roomNum = 1;
        public Choose_Cave()
        {
            InitializeComponent();
        }
        //picking path to go
        #region
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (roomNum == 1)
            {

                if (Dirrection == 1)
                {
                    roomNum = 2;
                }
                if (Dirrection == 2)
                {
                    roomNum = 2;
                }
            }

            if (roomNum == 2)
            {
                if (Dirrection == 2)
                {
                    roomNum = 3;
                }
                if (Dirrection == 1)
                {
                    roomNum = 3;
                }

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (roomNum == 1)
            {


                if (Dirrection == 2)
                {
                    roomNum = 2;
                }
                if (Dirrection == 1)
                {
                    roomNum = 2;
                }
            }
            if (roomNum == 2)
            {
                if (Dirrection == 1)
                {
                    roomNum = 3;
                }
                if (Dirrection == 2)
                {
                    roomNum = 3;
                }

            }
        }

        private void Choose_Cave_Load(object sender, EventArgs e)
        {
            Random rndDirrection = new Random();
            Dirrection = rndDirrection.Next(1, 3);
        }

        private void pickTimer_Tick(object sender, EventArgs e)
        {
            if(roomNum == 2)
            {
                label1.Text = "Room: 2";
            }
            if(roomNum == 3)
            {
                pictureBox2.Visible = false;
            }
        }
        #endregion
    }
}
