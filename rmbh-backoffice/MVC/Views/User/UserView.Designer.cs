namespace rmbh_backoffice.MVC.Views.User
{
    partial class UserView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Operation = new Panel();
            textBox1 = new TextBox();
            button_Add = new Button();
            panel_DataGrid = new Panel();
            dataGridView1 = new DataGridView();
            panel_Operation.SuspendLayout();
            panel_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel_Operation
            // 
            panel_Operation.Controls.Add(textBox1);
            panel_Operation.Controls.Add(button_Add);
            panel_Operation.Dock = DockStyle.Top;
            panel_Operation.Location = new Point(2, 2);
            panel_Operation.Name = "panel_Operation";
            panel_Operation.Size = new Size(796, 55);
            panel_Operation.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(117, 14);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(388, 29);
            textBox1.TabIndex = 1;
            textBox1.Text = "Search...";
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.YellowGreen;
            button_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.Location = new Point(12, 10);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(88, 34);
            button_Add.TabIndex = 0;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            // 
            // panel_DataGrid
            // 
            panel_DataGrid.Controls.Add(dataGridView1);
            panel_DataGrid.Dock = DockStyle.Fill;
            panel_DataGrid.Location = new Point(2, 57);
            panel_DataGrid.Name = "panel_DataGrid";
            panel_DataGrid.Padding = new Padding(15, 0, 15, 15);
            panel_DataGrid.Size = new Size(796, 391);
            panel_DataGrid.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(15, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(766, 376);
            dataGridView1.TabIndex = 0;
            // 
            // UserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(800, 450);
            Controls.Add(panel_DataGrid);
            Controls.Add(panel_Operation);
            Name = "UserView";
            Text = "UserView";
            panel_Operation.ResumeLayout(false);
            panel_Operation.PerformLayout();
            panel_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Operation;
        private TextBox textBox1;
        private Button button_Add;
        private Panel panel_DataGrid;
        private DataGridView dataGridView1;
    }
}