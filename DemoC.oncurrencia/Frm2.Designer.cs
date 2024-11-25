namespace DemoC.oncurrencia
{
    partial class FrmBloqueos
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
            lblContador = new Label();
            splitContainer1 = new SplitContainer();
            BtnDisminuir = new Button();
            BtnIncrementar = new Button();
            TxtResultado = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.BackColor = Color.Red;
            lblContador.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContador.Location = new Point(123, 224);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(20, 22);
            lblContador.TabIndex = 0;
            lblContador.Text = "0";
            lblContador.Click += lblContador_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(BtnDisminuir);
            splitContainer1.Panel1.Controls.Add(lblContador);
            splitContainer1.Panel1.Controls.Add(BtnIncrementar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(866, 503);
            splitContainer1.SplitterDistance = 288;
            splitContainer1.TabIndex = 3;
            // 
            // BtnDisminuir
            // 
            BtnDisminuir.BackColor = Color.Lime;
            BtnDisminuir.Location = new Point(22, 128);
            BtnDisminuir.Name = "BtnDisminuir";
            BtnDisminuir.Size = new Size(228, 62);
            BtnDisminuir.TabIndex = 4;
            BtnDisminuir.Text = "Disminuir";
            BtnDisminuir.UseVisualStyleBackColor = false;
            BtnDisminuir.Click += BtnDisminuir_Click;
            // 
            // BtnIncrementar
            // 
            BtnIncrementar.BackColor = Color.Yellow;
            BtnIncrementar.Location = new Point(22, 26);
            BtnIncrementar.Name = "BtnIncrementar";
            BtnIncrementar.Size = new Size(228, 68);
            BtnIncrementar.TabIndex = 3;
            BtnIncrementar.Text = "Incrementar";
            BtnIncrementar.UseVisualStyleBackColor = false;
            BtnIncrementar.Click += BtnIncrementar_Click_1;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.Silver;
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.ForeColor = Color.Red;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Margin = new Padding(3, 4, 3, 4);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(574, 503);
            TxtResultado.TabIndex = 1;
            // 
            // FrmBloqueos
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 503);
            Controls.Add(splitContainer1);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmBloqueos";
            ShowIcon = false;
            Text = "Gestion de Bloqueos";
            Load += FrmBloqueos_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblContador;
        private SplitContainer splitContainer1;
        private Button BtnDisminuir;
        private Button BtnIncrementar;
        private TextBox TxtResultado;
    }
}