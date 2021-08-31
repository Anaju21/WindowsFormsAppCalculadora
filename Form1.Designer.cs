
namespace WindowsFormsAppCalculadora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }










            #region Código gerado pelo Windows Form Designer

            /// <summary>
            /// Método necessário para suporte ao Designer - não modifique 
            /// o conteúdo deste método com o editor de código.
            /// </summary>
            private void InitializeComponent()
        {
            this.txt_visor = new System.Windows.Forms.TextBox();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_vezes = new System.Windows.Forms.Button();
            this.btn_dividir = new System.Windows.Forms.Button();
            this.btn_soma = new System.Windows.Forms.Button();
            this.btn_subtrai = new System.Windows.Forms.Button();
            this.btn_igual = new System.Windows.Forms.Button();
            this.btn_porcentagem = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_visor
            // 
            this.txt_visor.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_visor.Location = new System.Drawing.Point(12, 12);
            this.txt_visor.Name = "txt_visor";
            this.txt_visor.Size = new System.Drawing.Size(246, 49);
            this.txt_visor.TabIndex = 0;
            this.txt_visor.TextChanged += new System.EventHandler(this.txt_resultado_TextChanged);
            // 
            // btn_7
            // 
            this.btn_7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_7.Location = new System.Drawing.Point(12, 77);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(55, 56);
            this.btn_7.TabIndex = 1;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_8.Location = new System.Drawing.Point(73, 77);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(59, 56);
            this.btn_8.TabIndex = 2;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_9.Location = new System.Drawing.Point(138, 77);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(55, 56);
            this.btn_9.TabIndex = 3;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_4
            // 
            this.btn_4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_4.Location = new System.Drawing.Point(12, 137);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(55, 64);
            this.btn_4.TabIndex = 4;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_5.Location = new System.Drawing.Point(73, 139);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(59, 62);
            this.btn_5.TabIndex = 5;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_6.Location = new System.Drawing.Point(138, 139);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(55, 62);
            this.btn_6.TabIndex = 6;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_1
            // 
            this.btn_1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1.Location = new System.Drawing.Point(12, 207);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(55, 54);
            this.btn_1.TabIndex = 7;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // btn_2
            // 
            this.btn_2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2.Location = new System.Drawing.Point(73, 207);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(59, 54);
            this.btn_2.TabIndex = 8;
            this.btn_2.Text = "2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // btn_3
            // 
            this.btn_3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_3.Location = new System.Drawing.Point(138, 207);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(55, 54);
            this.btn_3.TabIndex = 9;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // btn_0
            // 
            this.btn_0.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_0.Location = new System.Drawing.Point(72, 267);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(59, 60);
            this.btn_0.TabIndex = 10;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_vezes
            // 
            this.btn_vezes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vezes.Location = new System.Drawing.Point(202, 116);
            this.btn_vezes.Name = "btn_vezes";
            this.btn_vezes.Size = new System.Drawing.Size(56, 32);
            this.btn_vezes.TabIndex = 11;
            this.btn_vezes.Text = "*";
            this.btn_vezes.UseVisualStyleBackColor = true;
            this.btn_vezes.Click += new System.EventHandler(this.btn_vezes_Click);
            // 
            // btn_dividir
            // 
            this.btn_dividir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dividir.Location = new System.Drawing.Point(202, 154);
            this.btn_dividir.Name = "btn_dividir";
            this.btn_dividir.Size = new System.Drawing.Size(56, 28);
            this.btn_dividir.TabIndex = 12;
            this.btn_dividir.Text = "/";
            this.btn_dividir.UseVisualStyleBackColor = true;
            this.btn_dividir.Click += new System.EventHandler(this.btn_dividir_Click);
            // 
            // btn_soma
            // 
            this.btn_soma.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_soma.Location = new System.Drawing.Point(202, 188);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(56, 32);
            this.btn_soma.TabIndex = 13;
            this.btn_soma.Text = "+";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // btn_subtrai
            // 
            this.btn_subtrai.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_subtrai.Location = new System.Drawing.Point(202, 227);
            this.btn_subtrai.Name = "btn_subtrai";
            this.btn_subtrai.Size = new System.Drawing.Size(56, 31);
            this.btn_subtrai.TabIndex = 14;
            this.btn_subtrai.Text = "-";
            this.btn_subtrai.UseVisualStyleBackColor = true;
            this.btn_subtrai.Click += new System.EventHandler(this.btn_subtrai_Click);
            // 
            // btn_igual
            // 
            this.btn_igual.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_igual.Location = new System.Drawing.Point(202, 266);
            this.btn_igual.Name = "btn_igual";
            this.btn_igual.Size = new System.Drawing.Size(56, 61);
            this.btn_igual.TabIndex = 15;
            this.btn_igual.Text = "=";
            this.btn_igual.UseVisualStyleBackColor = true;
            this.btn_igual.Click += new System.EventHandler(this.btn_igual_Click);
            // 
            // btn_porcentagem
            // 
            this.btn_porcentagem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_porcentagem.Location = new System.Drawing.Point(11, 267);
            this.btn_porcentagem.Name = "btn_porcentagem";
            this.btn_porcentagem.Size = new System.Drawing.Size(55, 60);
            this.btn_porcentagem.TabIndex = 16;
            this.btn_porcentagem.Text = "%";
            this.btn_porcentagem.UseVisualStyleBackColor = true;
            this.btn_porcentagem.Click += new System.EventHandler(this.btn_porcentagem_Click);
            // 
            // button17
            // 
            this.button17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(138, 267);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(57, 60);
            this.button17.TabIndex = 17;
            this.button17.Text = ",";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(202, 77);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(56, 33);
            this.btn_limpar.TabIndex = 18;
            this.btn_limpar.Text = "LIMPAR";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 331);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.btn_porcentagem);
            this.Controls.Add(this.btn_igual);
            this.Controls.Add(this.btn_subtrai);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.btn_dividir);
            this.Controls.Add(this.btn_vezes);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.txt_visor);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_visor;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_vezes;
        private System.Windows.Forms.Button btn_dividir;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Button btn_subtrai;
        private System.Windows.Forms.Button btn_igual;
        private System.Windows.Forms.Button btn_porcentagem;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btn_limpar;



    }
}

