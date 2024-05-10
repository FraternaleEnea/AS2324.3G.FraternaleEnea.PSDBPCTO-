namespace AS2324._3G.FraternaleEnea.PSDBPCTO_
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
            dataGridView1 = new DataGridView();
            piloti = new Button();
            gare = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(891, 338);
            dataGridView1.TabIndex = 0;
            // 
            // piloti
            // 
            piloti.Location = new Point(265, 49);
            piloti.Name = "piloti";
            piloti.Size = new Size(152, 41);
            piloti.TabIndex = 1;
            piloti.Text = "Elenco piloti";
            piloti.UseVisualStyleBackColor = true;
            // 
            // gare
            // 
            gare.Location = new Point(539, 49);
            gare.Name = "gare";
            gare.Size = new Size(158, 41);
            gare.TabIndex = 2;
            gare.Text = "Elenco gare";
            gare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 515);
            Controls.Add(gare);
            Controls.Add(piloti);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button piloti;
        private Button gare;
    }
}