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
            txtResult = new TextBox();
            btnSubtracao = new Button();
            btnSoma = new Button();
            btnResult = new Button();
            button0 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            btnDivisao = new Button();
            label1 = new Label();
            btnMultiplicacao = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(26, 12);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(316, 23);
            txtResult.TabIndex = 0;
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnSubtracao
            // 
            btnSubtracao.Font = new Font("Segoe UI", 16F);
            btnSubtracao.Location = new Point(269, 73);
            btnSubtracao.Name = "btnSubtracao";
            btnSubtracao.Size = new Size(73, 72);
            btnSubtracao.TabIndex = 1;
            btnSubtracao.Text = "-";
            btnSubtracao.UseVisualStyleBackColor = true;
            btnSubtracao.Click += btnSubtracao_Click;
            // 
            // btnSoma
            // 
            btnSoma.Font = new Font("Segoe UI", 16F);
            btnSoma.Location = new Point(269, 149);
            btnSoma.Name = "btnSoma";
            btnSoma.Size = new Size(75, 72);
            btnSoma.TabIndex = 2;
            btnSoma.Text = "+";
            btnSoma.UseVisualStyleBackColor = true;
            btnSoma.Click += btnSoma_Click;
            // 
            // btnResult
            // 
            btnResult.Font = new Font("Segoe UI", 16F);
            btnResult.ForeColor = SystemColors.ActiveCaptionText;
            btnResult.ImageAlign = ContentAlignment.BottomCenter;
            btnResult.Location = new Point(269, 305);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(75, 146);
            btnResult.TabIndex = 3;
            btnResult.Text = "=";
            btnResult.UseVisualStyleBackColor = true;
            btnResult.Click += btnResult_Click;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 12F);
            button0.Location = new Point(26, 305);
            button0.Name = "button0";
            button0.Size = new Size(156, 72);
            button0.TabIndex = 4;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += button0_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F);
            button1.Location = new Point(26, 227);
            button1.Name = "button1";
            button1.Size = new Size(75, 72);
            button1.TabIndex = 5;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F);
            button2.Location = new Point(107, 227);
            button2.Name = "button2";
            button2.Size = new Size(75, 72);
            button2.TabIndex = 6;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F);
            button3.Location = new Point(188, 227);
            button3.Name = "button3";
            button3.Size = new Size(75, 72);
            button3.TabIndex = 7;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 12F);
            button4.Location = new Point(26, 149);
            button4.Name = "button4";
            button4.Size = new Size(75, 72);
            button4.TabIndex = 8;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 12F);
            button5.Location = new Point(107, 149);
            button5.Name = "button5";
            button5.Size = new Size(75, 72);
            button5.TabIndex = 9;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F);
            button6.Location = new Point(188, 149);
            button6.Name = "button6";
            button6.Size = new Size(75, 72);
            button6.TabIndex = 10;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 12F);
            button7.Location = new Point(26, 73);
            button7.Name = "button7";
            button7.Size = new Size(75, 72);
            button7.TabIndex = 11;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 12F);
            button8.Location = new Point(107, 73);
            button8.Name = "button8";
            button8.Size = new Size(75, 72);
            button8.TabIndex = 12;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 12F);
            button9.Location = new Point(188, 73);
            button9.Name = "button9";
            button9.Size = new Size(75, 72);
            button9.TabIndex = 13;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // btnDivisao
            // 
            btnDivisao.Font = new Font("Segoe UI", 16F);
            btnDivisao.Location = new Point(269, 227);
            btnDivisao.Name = "btnDivisao";
            btnDivisao.Size = new Size(75, 72);
            btnDivisao.TabIndex = 14;
            btnDivisao.Text = "/";
            btnDivisao.UseVisualStyleBackColor = true;
            btnDivisao.Click += btnDivisao_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 15);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 15;
            // 
            // btnMultiplicacao
            // 
            btnMultiplicacao.Font = new Font("Segoe UI", 16F);
            btnMultiplicacao.Location = new Point(188, 305);
            btnMultiplicacao.Name = "btnMultiplicacao";
            btnMultiplicacao.Size = new Size(75, 72);
            btnMultiplicacao.TabIndex = 16;
            btnMultiplicacao.Text = "x";
            btnMultiplicacao.UseVisualStyleBackColor = true;
            btnMultiplicacao.Click += btnMultiplicacao_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 16F);
            btnClear.Location = new Point(188, 379);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 72);
            btnClear.TabIndex = 17;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 463);
            Controls.Add(btnClear);
            Controls.Add(btnMultiplicacao);
            Controls.Add(label1);
            Controls.Add(btnDivisao);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button0);
            Controls.Add(btnResult);
            Controls.Add(btnSoma);
            Controls.Add(btnSubtracao);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btnSubtracao;
        private Button btnSoma;
        private Button btnResult;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button btnDivisao;
        private Label label1;
        private Button btnMultiplicacao;
        private Button btnClear;
    }
}
