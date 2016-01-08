namespace CIS_SDK_CSharp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVersao = new System.Windows.Forms.Label();
            this.btnCancelarLeitura = new System.Windows.Forms.Button();
            this.btnLerImagemWSQ = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarLeituraImagem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teste de conexão com a DLL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ler DLL (Versão SDK)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ler e comparar as digitais";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 140);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ler digital - Dedo 1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 41);
            this.button3.TabIndex = 4;
            this.button3.Text = "Ler digital - Dedo 2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(221, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(171, 41);
            this.button4.TabIndex = 5;
            this.button4.Text = "Comparar as digitais";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pasta das digitais: C:\\CIS_SDK\\DIGITAIS";
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(209, 50);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(65, 13);
            this.lblVersao.TabIndex = 7;
            this.lblVersao.Text = "Versão SDK";
            // 
            // btnCancelarLeitura
            // 
            this.btnCancelarLeitura.Enabled = false;
            this.btnCancelarLeitura.Location = new System.Drawing.Point(21, 234);
            this.btnCancelarLeitura.Name = "btnCancelarLeitura";
            this.btnCancelarLeitura.Size = new System.Drawing.Size(171, 22);
            this.btnCancelarLeitura.TabIndex = 8;
            this.btnCancelarLeitura.Text = "Cancelar leitura";
            this.btnCancelarLeitura.UseVisualStyleBackColor = true;
            this.btnCancelarLeitura.Click += new System.EventHandler(this.btnCancelarLeitura_Click);
            // 
            // btnLerImagemWSQ
            // 
            this.btnLerImagemWSQ.Location = new System.Drawing.Point(21, 319);
            this.btnLerImagemWSQ.Name = "btnLerImagemWSQ";
            this.btnLerImagemWSQ.Size = new System.Drawing.Size(171, 41);
            this.btnLerImagemWSQ.TabIndex = 10;
            this.btnLerImagemWSQ.Text = "Ler Imagem WSQ";
            this.btnLerImagemWSQ.UseVisualStyleBackColor = true;
            this.btnLerImagemWSQ.Click += new System.EventHandler(this.btnLerImagemWSQ_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ler imagens";
            // 
            // btnCancelarLeituraImagem
            // 
            this.btnCancelarLeituraImagem.Enabled = false;
            this.btnCancelarLeituraImagem.Location = new System.Drawing.Point(21, 366);
            this.btnCancelarLeituraImagem.Name = "btnCancelarLeituraImagem";
            this.btnCancelarLeituraImagem.Size = new System.Drawing.Size(171, 22);
            this.btnCancelarLeituraImagem.TabIndex = 11;
            this.btnCancelarLeituraImagem.Text = "Cancelar leitura imagem";
            this.btnCancelarLeituraImagem.UseVisualStyleBackColor = true;
            this.btnCancelarLeituraImagem.Click += new System.EventHandler(this.btnCancelarLeituraImagem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Pasta das imagens: C:\\CIS_SDK\\IMAGENS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 403);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelarLeituraImagem);
            this.Controls.Add(this.btnLerImagemWSQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelarLeitura);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CIS SDK C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Button btnCancelarLeitura;
        private System.Windows.Forms.Button btnLerImagemWSQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarLeituraImagem;
        private System.Windows.Forms.Label label5;
    }
}

