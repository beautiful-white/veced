namespace VecEd
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItemLine = new ToolStripMenuItem();
            straightToolStripMenuItem = new ToolStripMenuItem();
            brokenToolStripMenuItem = new ToolStripMenuItem();
            bezierToolStripMenuItem = new ToolStripMenuItem();
            ToolStripMenuItemPolygon = new ToolStripMenuItem();
            squareToolStripMenuItem1 = new ToolStripMenuItem();
            triangleToolStripMenuItem = new ToolStripMenuItem();
            truePolygonToolStripMenuItem = new ToolStripMenuItem();
            cornersToolStripTextBox = new ToolStripTextBox();
            ToolStripMenuItemEllipse = new ToolStripMenuItem();
            режимToolStripMenuItem = new ToolStripMenuItem();
            modeSelectToolStripMenuItem = new ToolStripMenuItem();
            modeChangeToolStripMenuItem = new ToolStripMenuItem();
            цветЛинииToolStripMenuItem = new ToolStripMenuItem();
            borderColorToolStripMenuItem = new ToolStripMenuItem();
            fillColorToolStripMenuItem = new ToolStripMenuItem();
            colorDialog1 = new ColorDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2, режимToolStripMenuItem, цветЛинииToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1053, 33);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemLine, ToolStripMenuItemPolygon, ToolStripMenuItemEllipse });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(87, 29);
            toolStripMenuItem2.Text = "Фигура";
            // 
            // toolStripMenuItemLine
            // 
            toolStripMenuItemLine.DropDownItems.AddRange(new ToolStripItem[] { straightToolStripMenuItem, brokenToolStripMenuItem, bezierToolStripMenuItem });
            toolStripMenuItemLine.Name = "toolStripMenuItemLine";
            toolStripMenuItemLine.Size = new Size(243, 34);
            toolStripMenuItemLine.Text = "Линия";
            // 
            // straightToolStripMenuItem
            // 
            straightToolStripMenuItem.Name = "straightToolStripMenuItem";
            straightToolStripMenuItem.Size = new Size(187, 34);
            straightToolStripMenuItem.Text = "Прямая";
            straightToolStripMenuItem.Click += straightToolStripMenuItem_Click;
            // 
            // brokenToolStripMenuItem
            // 
            brokenToolStripMenuItem.Name = "brokenToolStripMenuItem";
            brokenToolStripMenuItem.Size = new Size(187, 34);
            brokenToolStripMenuItem.Text = "Ломаная";
            brokenToolStripMenuItem.Click += brokenToolStripMenuItem_Click;
            // 
            // bezierToolStripMenuItem
            // 
            bezierToolStripMenuItem.Name = "bezierToolStripMenuItem";
            bezierToolStripMenuItem.Size = new Size(187, 34);
            bezierToolStripMenuItem.Text = "Безье";
            bezierToolStripMenuItem.Click += bezierToolStripMenuItem_Click;
            // 
            // ToolStripMenuItemPolygon
            // 
            ToolStripMenuItemPolygon.DropDownItems.AddRange(new ToolStripItem[] { squareToolStripMenuItem1, triangleToolStripMenuItem, truePolygonToolStripMenuItem });
            ToolStripMenuItemPolygon.Name = "ToolStripMenuItemPolygon";
            ToolStripMenuItemPolygon.Size = new Size(243, 34);
            ToolStripMenuItemPolygon.Text = "Многоугольник";
            // 
            // squareToolStripMenuItem1
            // 
            squareToolStripMenuItem1.Name = "squareToolStripMenuItem1";
            squareToolStripMenuItem1.Size = new Size(312, 34);
            squareToolStripMenuItem1.Text = "Прямоугольник";
            squareToolStripMenuItem1.Click += squareToolStripMenuItem1_Click;
            // 
            // triangleToolStripMenuItem
            // 
            triangleToolStripMenuItem.Name = "triangleToolStripMenuItem";
            triangleToolStripMenuItem.Size = new Size(312, 34);
            triangleToolStripMenuItem.Text = "Треугольник";
            triangleToolStripMenuItem.Click += triangleToolStripMenuItem_Click;
            // 
            // truePolygonToolStripMenuItem
            // 
            truePolygonToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cornersToolStripTextBox });
            truePolygonToolStripMenuItem.Name = "truePolygonToolStripMenuItem";
            truePolygonToolStripMenuItem.Size = new Size(312, 34);
            truePolygonToolStripMenuItem.Text = "Реально многоугольник";
            // 
            // cornersToolStripTextBox
            // 
            cornersToolStripTextBox.AcceptsReturn = true;
            cornersToolStripTextBox.AutoCompleteCustomSource.AddRange(new string[] { "10", "15", "20", "25", "30", "35", "40" });
            cornersToolStripTextBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cornersToolStripTextBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
            cornersToolStripTextBox.AutoSize = false;
            cornersToolStripTextBox.MaxLength = 2;
            cornersToolStripTextBox.Name = "cornersToolStripTextBox";
            cornersToolStripTextBox.Size = new Size(70, 31);
            cornersToolStripTextBox.ToolTipText = "углов";
            cornersToolStripTextBox.KeyDown += cornersToolStripTextBox_KeyDown;
            // 
            // ToolStripMenuItemEllipse
            // 
            ToolStripMenuItemEllipse.Name = "ToolStripMenuItemEllipse";
            ToolStripMenuItemEllipse.Size = new Size(243, 34);
            ToolStripMenuItemEllipse.Text = "Эллипс";
            ToolStripMenuItemEllipse.Click += ToolStripMenuItemEllipse_Click;
            // 
            // режимToolStripMenuItem
            // 
            режимToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { modeSelectToolStripMenuItem, modeChangeToolStripMenuItem });
            режимToolStripMenuItem.Name = "режимToolStripMenuItem";
            режимToolStripMenuItem.Size = new Size(83, 29);
            режимToolStripMenuItem.Text = "Режим";
            // 
            // modeSelectToolStripMenuItem
            // 
            modeSelectToolStripMenuItem.Name = "modeSelectToolStripMenuItem";
            modeSelectToolStripMenuItem.Size = new Size(205, 34);
            modeSelectToolStripMenuItem.Text = "Выделения";
            modeSelectToolStripMenuItem.Click += modeSelectToolStripMenuItem_Click;
            // 
            // modeChangeToolStripMenuItem
            // 
            modeChangeToolStripMenuItem.Checked = true;
            modeChangeToolStripMenuItem.CheckState = CheckState.Checked;
            modeChangeToolStripMenuItem.Name = "modeChangeToolStripMenuItem";
            modeChangeToolStripMenuItem.Size = new Size(205, 34);
            modeChangeToolStripMenuItem.Text = "Изменения";
            modeChangeToolStripMenuItem.Click += modeChangeToolStripMenuItem_Click;
            // 
            // цветЛинииToolStripMenuItem
            // 
            цветЛинииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { borderColorToolStripMenuItem, fillColorToolStripMenuItem });
            цветЛинииToolStripMenuItem.Name = "цветЛинииToolStripMenuItem";
            цветЛинииToolStripMenuItem.Size = new Size(67, 29);
            цветЛинииToolStripMenuItem.Text = "Цвет";
            // 
            // borderColorToolStripMenuItem
            // 
            borderColorToolStripMenuItem.Name = "borderColorToolStripMenuItem";
            borderColorToolStripMenuItem.Size = new Size(270, 34);
            borderColorToolStripMenuItem.Text = "Линия";
            borderColorToolStripMenuItem.Click += borderColorToolStripMenuItem_Click;
            // 
            // fillColorToolStripMenuItem
            // 
            fillColorToolStripMenuItem.Name = "fillColorToolStripMenuItem";
            fillColorToolStripMenuItem.Size = new Size(270, 34);
            fillColorToolStripMenuItem.Text = "Заполнение";
            fillColorToolStripMenuItem.Click += fillColorToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 692);
            Controls.Add(menuStrip1);
            Name = "MainForm";
            Text = "Редактирование векторной графики";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem режимToolStripMenuItem;
        private ToolStripMenuItem modeSelectToolStripMenuItem;
        private ToolStripMenuItem modeChangeToolStripMenuItem;
        private ToolStripMenuItem цветЛинииToolStripMenuItem;
        private ColorDialog colorDialog1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItemLine;
        private ToolStripMenuItem ToolStripMenuItemPolygon;
        private ToolStripMenuItem squareToolStripMenuItem1;
        private ToolStripMenuItem triangleToolStripMenuItem;
        private ToolStripMenuItem truePolygonToolStripMenuItem;
        private ToolStripMenuItem ToolStripMenuItemEllipse;
        private ToolStripTextBox cornersToolStripTextBox;
        private ToolStripMenuItem borderColorToolStripMenuItem;
        private ToolStripMenuItem fillColorToolStripMenuItem;
        private ToolStripMenuItem straightToolStripMenuItem;
        private ToolStripMenuItem brokenToolStripMenuItem;
        private ToolStripMenuItem bezierToolStripMenuItem;
    }
}
