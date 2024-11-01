namespace rmbh_backoffice.MVC.Views.Learning.Card
{
    partial class CardView
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
            dataGridView = new DataGridView();
            Question = new DataGridViewTextBoxColumn();
            Answer = new DataGridViewTextBoxColumn();
            QuestionImg = new DataGridViewTextBoxColumn();
            AnswerImg = new DataGridViewTextBoxColumn();
            QuestionClarifier = new DataGridViewTextBoxColumn();
            AnswerClarifier = new DataGridViewTextBoxColumn();
            QuestionFootnote = new DataGridViewTextBoxColumn();
            AnswerFootnote = new DataGridViewTextBoxColumn();
            SortOrder = new DataGridViewTextBoxColumn();
            CreatedDate = new DataGridViewTextBoxColumn();
            ModifiedDate = new DataGridViewTextBoxColumn();
            panel_Operation.SuspendLayout();
            panel_DataGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel_Operation
            // 
            panel_Operation.Controls.Add(textBox1);
            panel_Operation.Controls.Add(button_Add);
            panel_Operation.Dock = DockStyle.Top;
            panel_Operation.Location = new Point(2, 3);
            panel_Operation.Margin = new Padding(3, 4, 3, 4);
            panel_Operation.Name = "panel_Operation";
            panel_Operation.Size = new Size(910, 73);
            panel_Operation.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(134, 19);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(443, 34);
            textBox1.TabIndex = 1;
            textBox1.Text = "Search...";
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
            panel_DataGrid.TabIndex = 1;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Question, Answer, QuestionImg, AnswerImg, QuestionClarifier, AnswerClarifier, QuestionFootnote, AnswerFootnote, SortOrder, CreatedDate, ModifiedDate });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(17, 0);
            dataGridView.Margin = new Padding(3, 4, 3, 4);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(876, 501);
            dataGridView.TabIndex = 0;
            // 
            // Question
            // 
            Question.HeaderText = "Front - Question";
            Question.MinimumWidth = 6;
            Question.Name = "Question";
            Question.Width = 125;
            // 
            // Answer
            // 
            Answer.HeaderText = "Back - Answer";
            Answer.MinimumWidth = 6;
            Answer.Name = "Answer";
            Answer.Width = 125;
            // 
            // QuestionImg
            // 
            QuestionImg.HeaderText = "Question Image";
            QuestionImg.MinimumWidth = 6;
            QuestionImg.Name = "QuestionImg";
            QuestionImg.Width = 125;
            // 
            // AnswerImg
            // 
            AnswerImg.HeaderText = "Answer Image";
            AnswerImg.MinimumWidth = 6;
            AnswerImg.Name = "AnswerImg";
            AnswerImg.Width = 125;
            // 
            // QuestionClarifier
            // 
            QuestionClarifier.HeaderText = "Question Clarifier";
            QuestionClarifier.MinimumWidth = 6;
            QuestionClarifier.Name = "QuestionClarifier";
            QuestionClarifier.Width = 125;
            // 
            // AnswerClarifier
            // 
            AnswerClarifier.HeaderText = "Answer Clarifier";
            AnswerClarifier.MinimumWidth = 6;
            AnswerClarifier.Name = "AnswerClarifier";
            AnswerClarifier.Width = 125;
            // 
            // QuestionFootnote
            // 
            QuestionFootnote.HeaderText = "Question Footnote";
            QuestionFootnote.MinimumWidth = 6;
            QuestionFootnote.Name = "QuestionFootnote";
            QuestionFootnote.Width = 125;
            // 
            // AnswerFootnote
            // 
            AnswerFootnote.HeaderText = "Answer Footnote";
            AnswerFootnote.MinimumWidth = 6;
            AnswerFootnote.Name = "AnswerFootnote";
            AnswerFootnote.Width = 125;
            // 
            // SortOrder
            // 
            SortOrder.HeaderText = "Sort Order";
            SortOrder.MinimumWidth = 6;
            SortOrder.Name = "SortOrder";
            SortOrder.Width = 125;
            // 
            // CreatedDate
            // 
            CreatedDate.HeaderText = "Date Created";
            CreatedDate.MinimumWidth = 6;
            CreatedDate.Name = "CreatedDate";
            CreatedDate.Width = 125;
            // 
            // ModifiedDate
            // 
            ModifiedDate.HeaderText = "Date Modified";
            ModifiedDate.MinimumWidth = 6;
            ModifiedDate.Name = "ModifiedDate";
            ModifiedDate.Width = 125;
            // 
            // CardView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(914, 600);
            Controls.Add(panel_DataGrid);
            Controls.Add(panel_Operation);
            Margin = new Padding(3, 5, 3, 5);
            Name = "CardView";
            Padding = new Padding(2, 3, 2, 3);
            Text = "UserView";
            Load += CardView_Load;
            panel_Operation.ResumeLayout(false);
            panel_Operation.PerformLayout();
            panel_DataGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Operation;
        private TextBox textBox1;
        private Button button_Add;
        private Panel panel_DataGrid;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Question;
        private DataGridViewTextBoxColumn Answer;
        private DataGridViewTextBoxColumn QuestionImg;
        private DataGridViewTextBoxColumn AnswerImg;
        private DataGridViewTextBoxColumn QuestionClarifier;
        private DataGridViewTextBoxColumn AnswerClarifier;
        private DataGridViewTextBoxColumn QuestionFootnote;
        private DataGridViewTextBoxColumn AnswerFootnote;
        private DataGridViewTextBoxColumn SortOrder;
        private DataGridViewTextBoxColumn CreatedDate;
        private DataGridViewTextBoxColumn ModifiedDate;
    }
}