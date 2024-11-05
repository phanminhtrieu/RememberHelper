namespace rmbh_backoffice.MVC.Views.Learning.Deck
{
    partial class DeckView
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
            dataGridView = new DataGridView();
            panel_DataGrid = new Panel();
            textBox_Searching = new TextBox();
            button_Add = new Button();
            panel_Operation = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            panel_DataGrid.SuspendLayout();
            panel_Operation.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(17, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(876, 501);
            dataGridView.TabIndex = 0;
            // 
            // panel_DataGrid
            // 
            panel_DataGrid.Controls.Add(dataGridView);
            panel_DataGrid.Dock = DockStyle.Fill;
            panel_DataGrid.Location = new Point(2, 76);
            panel_DataGrid.Margin = new Padding(3, 4, 3, 4);
            panel_DataGrid.Name = "panel_DataGrid";
            panel_DataGrid.Padding = new Padding(17, 0, 17, 20);
            panel_DataGrid.Size = new Size(910, 521);
            panel_DataGrid.TabIndex = 3;
            // 
            // textBox_Searching
            // 
            textBox_Searching.BorderStyle = BorderStyle.FixedSingle;
            textBox_Searching.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Searching.Location = new Point(134, 19);
            textBox_Searching.Margin = new Padding(3, 4, 3, 4);
            textBox_Searching.Name = "textBox_Searching";
            textBox_Searching.PlaceholderText = "   Search by first name, last name, email";
            textBox_Searching.Size = new Size(443, 34);
            textBox_Searching.TabIndex = 1;
            textBox_Searching.TextChanged += textBox_Searching_TextChanged;
            // 
            // button_Add
            // 
            button_Add.BackColor = Color.YellowGreen;
            button_Add.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button_Add.Location = new Point(14, 13);
            button_Add.Margin = new Padding(3, 4, 3, 4);
            button_Add.Name = "button_Add";
            button_Add.Size = new Size(101, 45);
            button_Add.TabIndex = 0;
            button_Add.Text = "Add";
            button_Add.UseVisualStyleBackColor = false;
            button_Add.Click += button_Add_Click;
            // 
            // panel_Operation
            // 
            panel_Operation.Controls.Add(textBox_Searching);
            panel_Operation.Controls.Add(button_Add);
            panel_Operation.Dock = DockStyle.Top;
            panel_Operation.Location = new Point(2, 3);
            panel_Operation.Margin = new Padding(3, 4, 3, 4);
            panel_Operation.Name = "panel_Operation";
            panel_Operation.Size = new Size(910, 73);
            panel_Operation.TabIndex = 2;
            panel_Operation.Paint += panel_Operation_Paint;
            // 
            // DeckView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel_DataGrid);
            Controls.Add(panel_Operation);
            Margin = new Padding(3, 5, 3, 5);
            Name = "DeckView";
            Padding = new Padding(2, 3, 2, 3);
            Text = "Deck";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            panel_DataGrid.ResumeLayout(false);
            panel_Operation.ResumeLayout(false);
            panel_Operation.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView;
        private Panel panel_DataGrid;
        private TextBox textBox_Searching;
        private Button button_Add;
        private Panel panel_Operation;
    }
}