namespace DemoC.oncurrencia
{
    partial class FrmCorreos
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
            splitContainer1 = new SplitContainer();
            lblContadorCorreo = new Label();
            BtnDetener = new Button();
            BtnEnviar = new Button();
            TxtResultadoCorreos = new TextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lblContadorCorreo);
            splitContainer1.Panel1.Controls.Add(BtnDetener);
            splitContainer1.Panel1.Controls.Add(BtnEnviar);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultadoCorreos);
            splitContainer1.Size = new Size(700, 428);
            splitContainer1.SplitterDistance = 233;
            splitContainer1.TabIndex = 0;
            // 
            // lblContadorCorreo
            // 
            lblContadorCorreo.AutoSize = true;
            lblContadorCorreo.BackColor = Color.Black;
            lblContadorCorreo.Font = new Font("Impact", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContadorCorreo.ForeColor = Color.White;
            lblContadorCorreo.Location = new Point(102, 165);
            lblContadorCorreo.Name = "lblContadorCorreo";
            lblContadorCorreo.Size = new Size(20, 22);
            lblContadorCorreo.TabIndex = 6;
            lblContadorCorreo.Text = "0";
            // 
            // BtnDetener
            // 
            BtnDetener.BackColor = Color.Red;
            BtnDetener.Location = new Point(17, 218);
            BtnDetener.Name = "BtnDetener";
            BtnDetener.Size = new Size(200, 59);
            BtnDetener.TabIndex = 5;
            BtnDetener.Text = "Detener";
            BtnDetener.UseVisualStyleBackColor = false;
            BtnDetener.Click += BtnDetener_Click;
            // 
            // BtnEnviar
            // 
            BtnEnviar.BackColor = Color.Cyan;
            BtnEnviar.Location = new Point(17, 71);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(200, 65);
            BtnEnviar.TabIndex = 4;
            BtnEnviar.Text = "Enviar";
            BtnEnviar.UseVisualStyleBackColor = false;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // TxtResultadoCorreos
            // 
            TxtResultadoCorreos.BackColor = Color.Black;
            TxtResultadoCorreos.Dock = DockStyle.Fill;
            TxtResultadoCorreos.ForeColor = Color.White;
            TxtResultadoCorreos.Location = new Point(0, 0);
            TxtResultadoCorreos.Margin = new Padding(3, 4, 3, 4);
            TxtResultadoCorreos.Multiline = true;
            TxtResultadoCorreos.Name = "TxtResultadoCorreos";
            TxtResultadoCorreos.Size = new Size(463, 428);
            TxtResultadoCorreos.TabIndex = 2;
            // 
            // FrmCorreos
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 428);
            Controls.Add(splitContainer1);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "FrmCorreos";
            Text = "Control de  Correos";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button BtnEnviar;
        private Button BtnDetener;
        private TextBox TxtResultadoCorreos;
        private Label lblContadorCorreo;
    }
}