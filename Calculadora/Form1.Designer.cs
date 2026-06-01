namespace Calculadora
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
            txtResultado = new TextBox();
            btn0 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnVirgula = new Button();
            btn_igual = new Button();
            btnDiv = new Button();
            btnMulti = new Button();
            btnSub = new Button();
            btnSoma = new Button();
            btnLimpar = new Button();
            lblOperaçao = new Label();
            SuspendLayout();
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(30, 41);
            txtResultado.Margin = new Padding(4);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(347, 26);
            txtResultado.TabIndex = 0;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            txtResultado.TextChanged += textBox1_TextChanged;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(255, 255, 128);
            btn0.Location = new Point(121, 436);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(80, 76);
            btn0.TabIndex = 1;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += btn0_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(255, 255, 128);
            btn7.Location = new Point(30, 352);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(80, 76);
            btn7.TabIndex = 2;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(255, 255, 128);
            btn8.Location = new Point(122, 352);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(80, 76);
            btn8.TabIndex = 3;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(255, 255, 128);
            btn9.Location = new Point(210, 352);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(80, 76);
            btn9.TabIndex = 4;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += btn9_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(255, 255, 128);
            btn4.Location = new Point(30, 268);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(80, 76);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(255, 255, 128);
            btn5.Location = new Point(121, 268);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(80, 76);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(255, 255, 128);
            btn6.Location = new Point(210, 268);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(80, 76);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += btn6_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(255, 255, 128);
            btn1.Location = new Point(30, 184);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(80, 76);
            btn1.TabIndex = 8;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(255, 255, 128);
            btn2.Location = new Point(122, 184);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(80, 76);
            btn2.TabIndex = 9;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(255, 255, 128);
            btn3.Location = new Point(209, 184);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(80, 76);
            btn3.TabIndex = 10;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += btn3_Click;
            // 
            // btnVirgula
            // 
            btnVirgula.BackColor = Color.FromArgb(192, 192, 255);
            btnVirgula.Location = new Point(30, 436);
            btnVirgula.Margin = new Padding(4);
            btnVirgula.Name = "btnVirgula";
            btnVirgula.Size = new Size(80, 76);
            btnVirgula.TabIndex = 11;
            btnVirgula.Text = ",";
            btnVirgula.UseVisualStyleBackColor = false;
            btnVirgula.Click += btnVirgula_Click;
            // 
            // btn_igual
            // 
            btn_igual.BackColor = Color.FromArgb(192, 192, 255);
            btn_igual.Location = new Point(210, 436);
            btn_igual.Margin = new Padding(4);
            btn_igual.Name = "btn_igual";
            btn_igual.Size = new Size(80, 76);
            btn_igual.TabIndex = 12;
            btn_igual.Text = "=";
            btn_igual.UseVisualStyleBackColor = false;
            btn_igual.Click += btn_igual_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = Color.FromArgb(192, 192, 255);
            btnDiv.Location = new Point(298, 184);
            btnDiv.Margin = new Padding(4);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(80, 76);
            btnDiv.TabIndex = 13;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMulti
            // 
            btnMulti.BackColor = Color.FromArgb(192, 192, 255);
            btnMulti.Location = new Point(297, 268);
            btnMulti.Margin = new Padding(4);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(80, 76);
            btnMulti.TabIndex = 14;
            btnMulti.Text = "X";
            btnMulti.UseVisualStyleBackColor = false;
            btnMulti.Click += btnMulti_Click;
            // 
            // btnSub
            // 
            btnSub.BackColor = Color.FromArgb(192, 192, 255);
            btnSub.Location = new Point(298, 352);
            btnSub.Margin = new Padding(4);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(80, 76);
            btnSub.TabIndex = 15;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = false;
            btnSub.Click += btnSub_Click;
            // 
            // btnSoma
            // 
            btnSoma.BackColor = Color.FromArgb(192, 192, 255);
            btnSoma.Location = new Point(298, 436);
            btnSoma.Margin = new Padding(4);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(80, 76);
            btnSoma.TabIndex = 16;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = false;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = Color.FromArgb(192, 192, 255);
            btnLimpar.Location = new Point(297, 131);
            btnLimpar.Margin = new Padding(4);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(80, 45);
            btnLimpar.TabIndex = 17;
            btnLimpar.Text = "C";
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += btn_Limpar_Click;
            // 
            // lblOperaçao
            // 
            lblOperaçao.AutoSize = true;
            lblOperaçao.BackColor = Color.White;
            lblOperaçao.Location = new Point(30, 44);
            lblOperaçao.Name = "lblOperaçao";
            lblOperaçao.Size = new Size(0, 18);
            lblOperaçao.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(413, 541);
            Controls.Add(lblOperaçao);
            Controls.Add(btnLimpar);
            Controls.Add(btnSoma);
            Controls.Add(btnSub);
            Controls.Add(btnMulti);
            Controls.Add(btnDiv);
            Controls.Add(btn_igual);
            Controls.Add(btnVirgula);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn0);
            Controls.Add(txtResultado);
            Font = new Font("Lucida Sans", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResultado;
        private Button btn0;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnVirgula;
        private Button btn_igual;
        private Button btnDiv;
        private Button btnMulti;
        private Button btnSub;
        private Button btnSoma;
        private Button btnLimpar;
        private Label label1;
        private Label lblOperaçao;
    }
}
