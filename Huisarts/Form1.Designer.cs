namespace Huisarts
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
            label1 = new Label();
            button1 = new Button();
            txtZoek = new TextBox();
            button2 = new Button();
            Patienten_dtg = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Patienten_dtg).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 32);
            label1.Name = "label1";
            label1.Size = new Size(170, 47);
            label1.TabIndex = 0;
            label1.Text = "Patiënten";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlText;
            button1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(659, 60);
            button1.Name = "button1";
            button1.Size = new Size(196, 69);
            button1.TabIndex = 1;
            button1.Text = "+ Nieuwe Patiënt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtZoek
            // 
            txtZoek.Font = new Font("Segoe UI", 15F);
            txtZoek.Location = new Point(12, 95);
            txtZoek.Name = "txtZoek";
            txtZoek.Size = new Size(259, 34);
            txtZoek.TabIndex = 2;
            txtZoek.Enter += txtZoek_Enter;
            txtZoek.Leave += txtZoek_Leave;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlText;
            button2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(277, 95);
            button2.Name = "button2";
            button2.Size = new Size(131, 34);
            button2.TabIndex = 3;
            button2.Text = "Zoeken";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Zoekbtn_Click;
            // 
            // Patienten_dtg
            // 
            Patienten_dtg.AllowUserToAddRows = false;
            Patienten_dtg.AllowUserToDeleteRows = false;
            Patienten_dtg.AllowUserToResizeColumns = false;
            Patienten_dtg.AllowUserToResizeRows = false;
            Patienten_dtg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Patienten_dtg.Location = new Point(12, 135);
            Patienten_dtg.MultiSelect = false;
            Patienten_dtg.Name = "Patienten_dtg";
            Patienten_dtg.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Patienten_dtg.Size = new Size(843, 650);
            Patienten_dtg.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 894);
            Controls.Add(Patienten_dtg);
            Controls.Add(button2);
            Controls.Add(txtZoek);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Patienten_dtg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtZoek;
        private Button button2;
        private DataGridView Patienten_dtg;
    }
}
