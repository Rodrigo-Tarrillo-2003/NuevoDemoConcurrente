namespace DemoC.oncurrencia
{
    partial class FrmConcurrencia
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
            splitContainer1 = new SplitContainer();
            btnCancelarHilo = new Button();
            btnIniciarTarea = new Button();
            btnIniciarHilos = new Button();
            btnIniciarSecuencial = new Button();
            TxtResultado = new TextBox();
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
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnCancelarHilo);
            splitContainer1.Panel1.Controls.Add(btnIniciarTarea);
            splitContainer1.Panel1.Controls.Add(btnIniciarHilos);
            splitContainer1.Panel1.Controls.Add(btnIniciarSecuencial);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(TxtResultado);
            splitContainer1.Size = new Size(808, 488);
            splitContainer1.SplitterDistance = 268;
            splitContainer1.TabIndex = 0;
            // 
            // btnCancelarHilo
            // 
            btnCancelarHilo.BackColor = Color.Red;
            btnCancelarHilo.Location = new Point(51, 366);
            btnCancelarHilo.Margin = new Padding(3, 4, 3, 4);
            btnCancelarHilo.Name = "btnCancelarHilo";
            btnCancelarHilo.Size = new Size(117, 48);
            btnCancelarHilo.TabIndex = 4;
            btnCancelarHilo.Text = "Cancelar procesos";
            btnCancelarHilo.UseVisualStyleBackColor = false;
            btnCancelarHilo.Click += btnCancelarHilo_Click;
            // 
            // btnIniciarTarea
            // 
            btnIniciarTarea.BackColor = Color.Blue;
            btnIniciarTarea.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarTarea.Location = new Point(46, 179);
            btnIniciarTarea.Margin = new Padding(3, 4, 3, 4);
            btnIniciarTarea.Name = "btnIniciarTarea";
            btnIniciarTarea.Size = new Size(122, 54);
            btnIniciarTarea.TabIndex = 2;
            btnIniciarTarea.Text = "IniciarTarea";
            btnIniciarTarea.UseVisualStyleBackColor = false;
            btnIniciarTarea.Click += btnIniciarTarea_Click;
            // 
            // btnIniciarHilos
            // 
            btnIniciarHilos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnIniciarHilos.BackColor = Color.Yellow;
            btnIniciarHilos.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarHilos.Location = new Point(46, 98);
            btnIniciarHilos.Margin = new Padding(3, 4, 3, 4);
            btnIniciarHilos.Name = "btnIniciarHilos";
            btnIniciarHilos.Size = new Size(122, 50);
            btnIniciarHilos.TabIndex = 1;
            btnIniciarHilos.Text = "Iniciar Hilo";
            btnIniciarHilos.UseVisualStyleBackColor = false;
            btnIniciarHilos.Click += btnIniciarHilos_Click;
            // 
            // btnIniciarSecuencial
            // 
            btnIniciarSecuencial.BackColor = Color.Lime;
            btnIniciarSecuencial.Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarSecuencial.Location = new Point(46, 27);
            btnIniciarSecuencial.Margin = new Padding(3, 4, 3, 4);
            btnIniciarSecuencial.Name = "btnIniciarSecuencial";
            btnIniciarSecuencial.Size = new Size(122, 54);
            btnIniciarSecuencial.TabIndex = 0;
            btnIniciarSecuencial.Text = "Iniciar Secuencial";
            btnIniciarSecuencial.UseVisualStyleBackColor = false;
            btnIniciarSecuencial.Click += btnIniciarSecuencial_Click;
            // 
            // TxtResultado
            // 
            TxtResultado.BackColor = Color.White;
            TxtResultado.Dock = DockStyle.Fill;
            TxtResultado.ForeColor = Color.Red;
            TxtResultado.Location = new Point(0, 0);
            TxtResultado.Margin = new Padding(3, 4, 3, 4);
            TxtResultado.Multiline = true;
            TxtResultado.Name = "TxtResultado";
            TxtResultado.Size = new Size(536, 488);
            TxtResultado.TabIndex = 0;
            // 
            // FrmConcurrencia
            // 
            AutoScaleDimensions = new SizeF(7F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 488);
            Controls.Add(splitContainer1);
            Font = new Font("Impact", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConcurrencia";
            Text = "Demostarcion de Concurrencia";
            Load += FrmConcurrencia_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnIniciarTarea;
        private Button btnIniciarHilos;
        private Button btnIniciarSecuencial;
        private TextBox TxtResultado;
        private Button btnCancelarHilo;
    }
}
