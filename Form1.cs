using Microsoft.VisualBasic.Devices;
using System.Text.RegularExpressions;


namespace VecEd
{
    public partial class MainForm : Form
    {
        // VARS
        bool mode = true;
        Shape shape;
        Color borderColor = Color.Black;
        Color backgroundColor = Color.White;
        //

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void selectMode(int whichOne)
        {
            switch (whichOne)
            {
                case 1:
                    {
                        modeSelectToolStripMenuItem.Checked = true;
                        modeChangeToolStripMenuItem.Checked = false;
                        break;
                    }
                case 2:
                    {
                        modeSelectToolStripMenuItem.Checked = false;
                        modeChangeToolStripMenuItem.Checked = true;
                        break;
                    }
            }
        }

        private void selectShape(int whichOne)
        {
            switch (whichOne)
            {
                case 1:
                    {
                        toolStripMenuItemLine.Checked = true;
                        ToolStripMenuItemEllipse.Checked = false;
                        ToolStripMenuItemPolygon.Checked = false;
                        break;
                    }
                case 2:
                    {
                        toolStripMenuItemLine.Checked = false;
                        ToolStripMenuItemEllipse.Checked = false;
                        ToolStripMenuItemPolygon.Checked = true;
                        break;
                    }
                case 3:
                    {
                        toolStripMenuItemLine.Checked = false;
                        ToolStripMenuItemEllipse.Checked = true;
                        ToolStripMenuItemPolygon.Checked = false;
                        break;
                    }
            }
        }

        private void selectLine(int whichOne)
        {
            switch (whichOne)
            {
                case 1:
                    {
                        straightToolStripMenuItem.Checked = true;
                        brokenToolStripMenuItem.Checked = false;
                        bezierToolStripMenuItem.Checked = false;
                        break;
                    }
                case 2:
                    {
                        straightToolStripMenuItem.Checked = false;
                        brokenToolStripMenuItem.Checked = true;
                        bezierToolStripMenuItem.Checked = false;
                        break;
                    }
                case 3:
                    {
                        straightToolStripMenuItem.Checked = false;
                        brokenToolStripMenuItem.Checked = false;
                        bezierToolStripMenuItem.Checked = true;
                        break;
                    }
            }
        }

        private void selectPolygon(int whichOne)
        {
            switch (whichOne)
            {
                case 1:
                    {
                        squareToolStripMenuItem1.Checked = true;
                        triangleToolStripMenuItem.Checked = false;
                        truePolygonToolStripMenuItem.Checked = false;
                        break;
                    }
                case 2:
                    {
                        squareToolStripMenuItem1.Checked = false;
                        triangleToolStripMenuItem.Checked = true;
                        truePolygonToolStripMenuItem.Checked = false;
                        break;
                    }
                case 3:
                    {
                        squareToolStripMenuItem1.Checked = false;
                        triangleToolStripMenuItem.Checked = false;
                        truePolygonToolStripMenuItem.Checked = true;
                        break;
                    }
            }
        }

        private void straightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(1);
            selectLine(1);
            shape = new Straight(borderColor, backgroundColor, 2);
        }

        private void brokenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(1);
            selectLine(2);
            shape = new Broken(borderColor, backgroundColor, 2);
        }

        private void bezierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(1);
            selectLine(3);
            shape = new Bezier(borderColor, backgroundColor, 2);
        }

        private void squareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectShape(2);
            selectPolygon(1);
            shape = new Square(borderColor, backgroundColor, 2);
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(2);
            selectPolygon(2);
            shape = new Triangle(borderColor, backgroundColor, 2);
        }

        private void ToolStripMenuItemEllipse_Click(object sender, EventArgs e)
        {
            selectShape(3);
            shape = new Ellipse(borderColor, backgroundColor, 2);
        }

        private void cornersToolStripTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (cornersToolStripTextBox.Text != ""))
            {
                for (int i = 0; i < cornersToolStripTextBox.Text.Length; i++)
                {
                    if (!("1234567890".Contains(cornersToolStripTextBox.Text[i])))
                    {
                        MessageBox.Show("Только цифры");
                        return;
                    }
                }
                if (Convert.ToInt32(cornersToolStripTextBox.Text) > 15)
                {
                    cornersToolStripTextBox.Text = "15";
                }
                selectShape(2);
                selectPolygon(3);
                shape = new Polygon(borderColor, backgroundColor, 2, Convert.ToInt32(cornersToolStripTextBox.Text));
            }
        }

        private void modeChangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = true;
            selectMode(2);
        }

        private void modeSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mode = false;
            selectMode(1);
        }

        private void borderColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                borderColor = colorDialog1.Color;
            }
        }

        private void fillColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                backgroundColor = colorDialog1.Color;
            }
        }
    }


}
