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
            notatiebtn = new Button();
            Bewerkenbtn = new Button();
            button3 = new Button();
            label2 = new Label();
            volgbtn = new Button();
            terugbtn = new Button();
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
            button1.BackColor = SystemColors.Control;
            button1.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button1.ForeColor = Color.Black;
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
            button2.BackColor = SystemColors.Control;
            button2.Font = new Font("Segoe UI Semibold", 13F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ControlText;
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
            // notatiebtn
            // 
            notatiebtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            notatiebtn.Location = new Point(12, 791);
            notatiebtn.Name = "notatiebtn";
            notatiebtn.Size = new Size(92, 58);
            notatiebtn.TabIndex = 5;
            notatiebtn.Text = "Notatie";
            notatiebtn.UseVisualStyleBackColor = true;
            notatiebtn.Click += notatiebtn_Click;
            // 
            // Bewerkenbtn
            // 
            Bewerkenbtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Bewerkenbtn.Location = new Point(110, 791);
            Bewerkenbtn.Name = "Bewerkenbtn";
            Bewerkenbtn.Size = new Size(92, 59);
            Bewerkenbtn.TabIndex = 6;
            Bewerkenbtn.Text = "Bewerken";
            Bewerkenbtn.UseVisualStyleBackColor = true;
            Bewerkenbtn.Click += Bewerkenbtn_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(491, 60);
            button3.Name = "button3";
            button3.Size = new Size(162, 66);
            button3.TabIndex = 7;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(469, 794);
            label2.Name = "label2";
            label2.Size = new Size(25, 30);
            label2.TabIndex = 8;
            label2.Text = "1";
            // 
            // volgbtn
            // 
            volgbtn.Location = new Point(785, 791);
            volgbtn.Name = "volgbtn";
            volgbtn.Size = new Size(70, 45);
            volgbtn.TabIndex = 9;
            volgbtn.Text = "Volgende";
            volgbtn.UseVisualStyleBackColor = true;
            volgbtn.Click += volgbtn_Click;
            // 
            // terugbtn
            // 
            terugbtn.Location = new Point(390, 791);
            terugbtn.Name = "terugbtn";
            terugbtn.Size = new Size(73, 45);
            terugbtn.TabIndex = 10;
            terugbtn.Text = "Vorige";
            terugbtn.UseVisualStyleBackColor = true;
            terugbtn.Click += terugbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(879, 856);
            Controls.Add(terugbtn);
            Controls.Add(volgbtn);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(Bewerkenbtn);
            Controls.Add(notatiebtn);
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
        private Button notatiebtn;
        private Button Bewerkenbtn;
        private Button button3;
        private Label label2;
        private Button volgbtn;
        private Button terugbtn;
    }
}
