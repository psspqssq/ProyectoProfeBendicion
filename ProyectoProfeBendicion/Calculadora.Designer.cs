namespace ProyectoProfeBendicion
{
    partial class frmCalc
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
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            txtFunction = new TextBox();
            txtDomain = new TextBox();
            label3 = new Label();
            label5 = new Label();
            btnEval = new Button();
            lblError = new Label();
            label6 = new Label();
            txtEndDomain = new TextBox();
            lstRange = new ListBox();
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(695, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(25, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 106);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 1;
            label1.Text = "Función";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 136);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 2;
            label2.Text = "Dominio";
            // 
            // txtFunction
            // 
            txtFunction.ForeColor = Color.DarkGoldenrod;
            txtFunction.Location = new Point(100, 103);
            txtFunction.Name = "txtFunction";
            txtFunction.Size = new Size(203, 23);
            txtFunction.TabIndex = 3;
            // 
            // txtDomain
            // 
            txtDomain.Location = new Point(100, 132);
            txtDomain.Name = "txtDomain";
            txtDomain.Size = new Size(34, 23);
            txtDomain.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Nirmala UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(226, 12);
            label3.Name = "label3";
            label3.Size = new Size(313, 41);
            label3.TabIndex = 5;
            label3.Text = "Sucesiones Numéricas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(456, 126);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 7;
            label5.Text = "Rango";
            // 
            // btnEval
            // 
            btnEval.FlatStyle = FlatStyle.Popup;
            btnEval.Font = new Font("Nirmala UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEval.Location = new Point(248, 133);
            btnEval.Name = "btnEval";
            btnEval.Size = new Size(55, 23);
            btnEval.TabIndex = 8;
            btnEval.Text = "Evaluar";
            btnEval.UseVisualStyleBackColor = true;
            btnEval.MouseClick += btnEval_MouseClick;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.IndianRed;
            lblError.Location = new Point(12, 159);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 15);
            lblError.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(140, 136);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 13;
            label6.Text = "hasta";
            // 
            // txtEndDomain
            // 
            txtEndDomain.Location = new Point(181, 132);
            txtEndDomain.Name = "txtEndDomain";
            txtEndDomain.Size = new Size(39, 23);
            txtEndDomain.TabIndex = 14;
            // 
            // lstRange
            // 
            lstRange.FormattingEnabled = true;
            lstRange.ItemHeight = 15;
            lstRange.Location = new Point(477, 159);
            lstRange.Name = "lstRange";
            lstRange.Size = new Size(229, 64);
            lstRange.TabIndex = 15;
            // 
            // frmCalc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(732, 273);
            Controls.Add(lstRange);
            Controls.Add(txtEndDomain);
            Controls.Add(label6);
            Controls.Add(lblError);
            Controls.Add(btnEval);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(txtDomain);
            Controls.Add(txtFunction);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCalc";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Label label1;
        private Label label2;
        private TextBox txtFunction;
        private TextBox txtDomain;
        private Label label3;
        private Label label5;
        private Button btnEval;
        private Label lblError;
        private GroupBox groupBox1;
        private Label label6;
        private TextBox txtEndDomain;
        private ListBox lstRange;
    }
}