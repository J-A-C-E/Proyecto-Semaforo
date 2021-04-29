namespace Semaforo
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBlanco = new System.Windows.Forms.Button();
            this.btnPreventiva = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAmarillo = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.pbRojo2 = new System.Windows.Forms.PictureBox();
            this.pbAmarillo2 = new System.Windows.Forms.PictureBox();
            this.pbVerde1 = new System.Windows.Forms.PictureBox();
            this.pbRojo1 = new System.Windows.Forms.PictureBox();
            this.pbAmarillo1 = new System.Windows.Forms.PictureBox();
            this.pbVerde3 = new System.Windows.Forms.PictureBox();
            this.pbRojo3 = new System.Windows.Forms.PictureBox();
            this.pbAmarillo3 = new System.Windows.Forms.PictureBox();
            this.pbVerde4 = new System.Windows.Forms.PictureBox();
            this.pbRojo4 = new System.Windows.Forms.PictureBox();
            this.pbAmarillo4 = new System.Windows.Forms.PictureBox();
            this.pbVerde2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBlanco);
            this.groupBox1.Controls.Add(this.btnPreventiva);
            this.groupBox1.Controls.Add(this.btnDetener);
            this.groupBox1.Controls.Add(this.btnIniciar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(532, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 109);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tiempos";
            // 
            // btnBlanco
            // 
            this.btnBlanco.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlanco.Font = new System.Drawing.Font("Digital-7 Italic", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlanco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBlanco.Location = new System.Drawing.Point(231, 51);
            this.btnBlanco.Name = "btnBlanco";
            this.btnBlanco.Size = new System.Drawing.Size(40, 40);
            this.btnBlanco.TabIndex = 16;
            this.btnBlanco.Text = "1";
            this.btnBlanco.UseVisualStyleBackColor = false;
            this.btnBlanco.Visible = false;
            // 
            // btnPreventiva
            // 
            this.btnPreventiva.Location = new System.Drawing.Point(87, 51);
            this.btnPreventiva.Name = "btnPreventiva";
            this.btnPreventiva.Size = new System.Drawing.Size(110, 23);
            this.btnPreventiva.TabIndex = 15;
            this.btnPreventiva.Text = "Preventivas";
            this.btnPreventiva.UseVisualStyleBackColor = true;
            this.btnPreventiva.Click += new System.EventHandler(this.btnPreventiva_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(10, 81);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(93, 23);
            this.btnDetener.TabIndex = 14;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(6, 51);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 13;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Serif Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Rojo";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Serif Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(81, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Amarillo";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Serif Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(170, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Verde";
            this.label1.Visible = false;
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRojo.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRojo.ForeColor = System.Drawing.Color.Red;
            this.btnRojo.Location = new System.Drawing.Point(253, 87);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(40, 40);
            this.btnRojo.TabIndex = 10;
            this.btnRojo.UseVisualStyleBackColor = false;
            // 
            // btnAmarillo
            // 
            this.btnAmarillo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAmarillo.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmarillo.ForeColor = System.Drawing.Color.Yellow;
            this.btnAmarillo.Location = new System.Drawing.Point(289, 87);
            this.btnAmarillo.Name = "btnAmarillo";
            this.btnAmarillo.Size = new System.Drawing.Size(40, 40);
            this.btnAmarillo.TabIndex = 9;
            this.btnAmarillo.UseVisualStyleBackColor = false;
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnVerde.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerde.ForeColor = System.Drawing.Color.Lime;
            this.btnVerde.Location = new System.Drawing.Point(326, 87);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(40, 40);
            this.btnVerde.TabIndex = 8;
            this.btnVerde.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // pbRojo2
            // 
            this.pbRojo2.BackColor = System.Drawing.Color.Transparent;
            this.pbRojo2.Image = global::Semaforo.Properties.Resources.red;
            this.pbRojo2.Location = new System.Drawing.Point(370, 133);
            this.pbRojo2.Name = "pbRojo2";
            this.pbRojo2.Size = new System.Drawing.Size(11, 11);
            this.pbRojo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRojo2.TabIndex = 3;
            this.pbRojo2.TabStop = false;
            // 
            // pbAmarillo2
            // 
            this.pbAmarillo2.BackColor = System.Drawing.Color.Transparent;
            this.pbAmarillo2.Image = global::Semaforo.Properties.Resources.Amrillo_preview_rev_1;
            this.pbAmarillo2.Location = new System.Drawing.Point(371, 153);
            this.pbAmarillo2.Name = "pbAmarillo2";
            this.pbAmarillo2.Size = new System.Drawing.Size(11, 11);
            this.pbAmarillo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAmarillo2.TabIndex = 2;
            this.pbAmarillo2.TabStop = false;
            this.pbAmarillo2.Visible = false;
            // 
            // pbVerde1
            // 
            this.pbVerde1.BackColor = System.Drawing.Color.Transparent;
            this.pbVerde1.Image = global::Semaforo.Properties.Resources.green;
            this.pbVerde1.Location = new System.Drawing.Point(355, 48);
            this.pbVerde1.Name = "pbVerde1";
            this.pbVerde1.Size = new System.Drawing.Size(11, 11);
            this.pbVerde1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVerde1.TabIndex = 11;
            this.pbVerde1.TabStop = false;
            // 
            // pbRojo1
            // 
            this.pbRojo1.BackColor = System.Drawing.Color.Transparent;
            this.pbRojo1.Image = global::Semaforo.Properties.Resources.red;
            this.pbRojo1.Location = new System.Drawing.Point(314, 48);
            this.pbRojo1.Name = "pbRojo1";
            this.pbRojo1.Size = new System.Drawing.Size(11, 11);
            this.pbRojo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRojo1.TabIndex = 13;
            this.pbRojo1.TabStop = false;
            this.pbRojo1.Visible = false;
            // 
            // pbAmarillo1
            // 
            this.pbAmarillo1.BackColor = System.Drawing.Color.Transparent;
            this.pbAmarillo1.Image = global::Semaforo.Properties.Resources.Amrillo_preview_rev_1;
            this.pbAmarillo1.Location = new System.Drawing.Point(336, 48);
            this.pbAmarillo1.Name = "pbAmarillo1";
            this.pbAmarillo1.Size = new System.Drawing.Size(11, 11);
            this.pbAmarillo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAmarillo1.TabIndex = 12;
            this.pbAmarillo1.TabStop = false;
            this.pbAmarillo1.Visible = false;
            // 
            // pbVerde3
            // 
            this.pbVerde3.BackColor = System.Drawing.Color.Transparent;
            this.pbVerde3.Image = global::Semaforo.Properties.Resources.green;
            this.pbVerde3.Location = new System.Drawing.Point(228, 77);
            this.pbVerde3.Name = "pbVerde3";
            this.pbVerde3.Size = new System.Drawing.Size(11, 11);
            this.pbVerde3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVerde3.TabIndex = 8;
            this.pbVerde3.TabStop = false;
            this.pbVerde3.Visible = false;
            // 
            // pbRojo3
            // 
            this.pbRojo3.BackColor = System.Drawing.Color.Transparent;
            this.pbRojo3.Image = global::Semaforo.Properties.Resources.red;
            this.pbRojo3.Location = new System.Drawing.Point(227, 116);
            this.pbRojo3.Name = "pbRojo3";
            this.pbRojo3.Size = new System.Drawing.Size(11, 11);
            this.pbRojo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRojo3.TabIndex = 10;
            this.pbRojo3.TabStop = false;
            // 
            // pbAmarillo3
            // 
            this.pbAmarillo3.BackColor = System.Drawing.Color.Transparent;
            this.pbAmarillo3.Image = global::Semaforo.Properties.Resources.Amrillo_preview_rev_1;
            this.pbAmarillo3.Location = new System.Drawing.Point(228, 96);
            this.pbAmarillo3.Name = "pbAmarillo3";
            this.pbAmarillo3.Size = new System.Drawing.Size(11, 11);
            this.pbAmarillo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAmarillo3.TabIndex = 9;
            this.pbAmarillo3.TabStop = false;
            this.pbAmarillo3.Visible = false;
            // 
            // pbVerde4
            // 
            this.pbVerde4.BackColor = System.Drawing.Color.Transparent;
            this.pbVerde4.Image = global::Semaforo.Properties.Resources.green;
            this.pbVerde4.Location = new System.Drawing.Point(248, 187);
            this.pbVerde4.Name = "pbVerde4";
            this.pbVerde4.Size = new System.Drawing.Size(11, 11);
            this.pbVerde4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVerde4.TabIndex = 5;
            this.pbVerde4.TabStop = false;
            // 
            // pbRojo4
            // 
            this.pbRojo4.BackColor = System.Drawing.Color.Transparent;
            this.pbRojo4.Image = global::Semaforo.Properties.Resources.red;
            this.pbRojo4.Location = new System.Drawing.Point(289, 187);
            this.pbRojo4.Name = "pbRojo4";
            this.pbRojo4.Size = new System.Drawing.Size(11, 11);
            this.pbRojo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRojo4.TabIndex = 7;
            this.pbRojo4.TabStop = false;
            this.pbRojo4.Visible = false;
            // 
            // pbAmarillo4
            // 
            this.pbAmarillo4.BackColor = System.Drawing.Color.Transparent;
            this.pbAmarillo4.Image = global::Semaforo.Properties.Resources.Amrillo_preview_rev_1;
            this.pbAmarillo4.Location = new System.Drawing.Point(269, 187);
            this.pbAmarillo4.Name = "pbAmarillo4";
            this.pbAmarillo4.Size = new System.Drawing.Size(11, 11);
            this.pbAmarillo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAmarillo4.TabIndex = 6;
            this.pbAmarillo4.TabStop = false;
            this.pbAmarillo4.Visible = false;
            // 
            // pbVerde2
            // 
            this.pbVerde2.BackColor = System.Drawing.Color.Transparent;
            this.pbVerde2.Image = global::Semaforo.Properties.Resources.green;
            this.pbVerde2.Location = new System.Drawing.Point(370, 174);
            this.pbVerde2.Name = "pbVerde2";
            this.pbVerde2.Size = new System.Drawing.Size(11, 11);
            this.pbVerde2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVerde2.TabIndex = 1;
            this.pbVerde2.TabStop = false;
            this.pbVerde2.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Semaforo.Properties.Resources.crucesemaforo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 318);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(819, 467);
            this.Controls.Add(this.pbRojo2);
            this.Controls.Add(this.pbAmarillo2);
            this.Controls.Add(this.pbVerde1);
            this.Controls.Add(this.pbRojo1);
            this.Controls.Add(this.pbAmarillo1);
            this.Controls.Add(this.pbVerde3);
            this.Controls.Add(this.pbRojo3);
            this.Controls.Add(this.pbAmarillo3);
            this.Controls.Add(this.btnVerde);
            this.Controls.Add(this.btnAmarillo);
            this.Controls.Add(this.btnRojo);
            this.Controls.Add(this.pbVerde4);
            this.Controls.Add(this.pbRojo4);
            this.Controls.Add(this.pbAmarillo4);
            this.Controls.Add(this.pbVerde2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Semaforo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRojo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAmarillo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbVerde2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbVerde2;
        private System.Windows.Forms.PictureBox pbAmarillo2;
        private System.Windows.Forms.PictureBox pbRojo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAmarillo;
        private System.Windows.Forms.PictureBox pbVerde4;
        private System.Windows.Forms.PictureBox pbRojo4;
        private System.Windows.Forms.PictureBox pbAmarillo4;
        private System.Windows.Forms.PictureBox pbVerde3;
        private System.Windows.Forms.PictureBox pbRojo3;
        private System.Windows.Forms.PictureBox pbAmarillo3;
        private System.Windows.Forms.PictureBox pbVerde1;
        private System.Windows.Forms.PictureBox pbRojo1;
        private System.Windows.Forms.PictureBox pbAmarillo1;
        private System.Windows.Forms.Button btnPreventiva;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnBlanco;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

