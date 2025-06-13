namespace VecEd
{
    public partial class MainForm : Form
    {
        // VARS
        int mode = 0;
        int shape = 0;
        Bezier asd = new Bezier(Color.Black, 123);
        //

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

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
        private void straightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectShape(1);
        }
    }
}
