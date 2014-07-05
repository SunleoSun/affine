using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using OpenGL;

namespace glWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.view.Invalidate(null, false);
        }

        private void fbFill_Click(object sender, EventArgs e)
        {
            this.view.paint_style = OpenGL.ViewGL.PaintStyle.Fill;
            this.view.Refresh();
            view.Refresh();
            view.Refresh();
        }

        private void fbLines_Click(object sender, EventArgs e)
        {
            this.view.paint_style = OpenGL.ViewGL.PaintStyle.Lines;
            this.view.Refresh();
            view.Refresh();
            view.Refresh();
        }

        private void fbPoints_Click(object sender, EventArgs e)
        {
            this.view.paint_style = OpenGL.ViewGL.PaintStyle.Points;
            this.view.Refresh();
            view.Refresh();
            view.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                view.ScaleFactor = (double)numericUpDown1.Value;
                view.Refresh();
                view.Refresh();
                view.Refresh();
                return;
            }
            if (groupBox2.Enabled)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = true;
                view.RotateAngle = (int)numericUpDown2.Value;
                view.Refresh();
                view.Refresh();
                view.Refresh();
                return;
            }
            if (groupBox3.Enabled)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                view.TransferValue = (double)numericUpDown3.Value;
                view.Refresh();
                view.Refresh();
                view.Refresh();
                return;
            }
        }



        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            view.RotateAngle = (int)numericUpDown2.Value;
            view.RotateX = (double)fnudX.Value;
            view.RotateY = (double)fnudY.Value;
            view.Refresh();
            view.Refresh();
            view.Refresh();

        }


        private void fbApply_Click(object sender, EventArgs e)
        {
            if (groupBox1.Enabled)
            {
                view.ScaleFactor = (double)numericUpDown1.Value;
                view.Refresh();
                view.Refresh();
                view.Refresh();

                return;
            }
            if (groupBox2.Enabled)
            {
                view.RotateAngle = (int)numericUpDown2.Value;
                view.RotateX = (double)fnudX.Value;
                view.RotateY = (double)fnudY.Value;
                view.Refresh();
                view.Refresh();
                view.Refresh();

                return;
            }
            if (groupBox3.Enabled)
            {
                view.TransferValue = (double)numericUpDown3.Value;
                view.Refresh();
                view.Refresh();
                view.Refresh();

                return;
            }

        }

        private void fbReset_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            view.RotateAngle = 0;
            view.RotateX = 0;
            view.RotateY = 4;
            view.ScaleFactor = 1;
            view.TransferValue = 0;
            numericUpDown1.Value = 1;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            fnudX.Value = 0;
            fnudY.Value = 0;
            view.ReflashMaxMinXY();
            view.Refresh();
            view.Refresh();
            view.Refresh();

        }

        private void fnudX_ValueChanged(object sender, EventArgs e)
        {
            view.RotateX = (double)fnudX.Value;
            view.Refresh();
            view.Refresh();
            view.Refresh();

        }

        private void fnudY_ValueChanged(object sender, EventArgs e)
        {
            view.RotateY = (double)fnudY.Value;
            view.Refresh();
            view.Refresh();
            view.Refresh();

        }

    }
}
