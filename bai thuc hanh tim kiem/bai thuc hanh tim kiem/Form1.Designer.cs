namespace bai_thuc_hanh_tim_kiem
{
    partial class Form1
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
            textID = new TextBox();
            information = new Label();
            datastudents = new DataGridView();
            label2 = new Label();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)datastudents).BeginInit();
            SuspendLayout();
            // 
            // textID
            // 
            textID.Location = new Point(273, 297);
            textID.Name = "textID";
            textID.Size = new Size(269, 27);
            textID.TabIndex = 0;
            // 
            // information
            // 
            information.AutoSize = true;
            information.Font = new Font("Segoe UI", 12F);
            information.Location = new Point(12, 373);
            information.Name = "information";
            information.Size = new Size(257, 28);
            information.TabIndex = 1;
            information.Text = "thong tin sinh vien can tim : ";
            information.Click += label1_Click;
            // 
            // datastudents
            // 
            datastudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datastudents.Location = new Point(12, 81);
            datastudents.Name = "datastudents";
            datastudents.RowHeadersWidth = 51;
            datastudents.Size = new Size(799, 191);
            datastudents.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(128, 297);
            label2.Name = "label2";
            label2.Size = new Size(31, 28);
            label2.TabIndex = 3;
            label2.Text = "ID";
            // 
            // search
            // 
            search.Location = new Point(624, 290);
            search.Name = "search";
            search.Size = new Size(88, 41);
            search.TabIndex = 4;
            search.Text = "timkiem";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(search);
            Controls.Add(label2);
            Controls.Add(datastudents);
            Controls.Add(information);
            Controls.Add(textID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)datastudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textID;
        private Label information;
        private DataGridView datastudents;
        private Label label2;
        private Button search;
    }
}
