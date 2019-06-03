namespace Geometrics_Transfirmations_2D
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
            this.btn_refleX = new System.Windows.Forms.Button();
            this.btn_Traslate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_DrawnFigure = new System.Windows.Forms.Button();
            this.trackBar_Rotation = new System.Windows.Forms.TrackBar();
            this.btn_Rotation = new System.Windows.Forms.Button();
            this.WorkSPace = new System.Windows.Forms.Panel();
            this.btn_refleY = new System.Windows.Forms.Button();
            this.lblNameApp = new System.Windows.Forms.Label();
            this.txB_TraslationX = new System.Windows.Forms.TextBox();
            this.txB_TraslationY = new System.Windows.Forms.TextBox();
            this.lblTraslationY = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEscale = new System.Windows.Forms.Label();
            this.txb_Escale = new System.Windows.Forms.TextBox();
            this.lbl_Rotacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rotation)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_refleX
            // 
            this.btn_refleX.Location = new System.Drawing.Point(590, 178);
            this.btn_refleX.Name = "btn_refleX";
            this.btn_refleX.Size = new System.Drawing.Size(92, 23);
            this.btn_refleX.TabIndex = 1;
            this.btn_refleX.Text = "Reflection X";
            this.btn_refleX.UseVisualStyleBackColor = true;
            this.btn_refleX.Click += new System.EventHandler(this.Btn_refleX_Click);
            // 
            // btn_Traslate
            // 
            this.btn_Traslate.Location = new System.Drawing.Point(659, 290);
            this.btn_Traslate.Name = "btn_Traslate";
            this.btn_Traslate.Size = new System.Drawing.Size(60, 22);
            this.btn_Traslate.TabIndex = 2;
            this.btn_Traslate.Text = "Traslate";
            this.btn_Traslate.UseVisualStyleBackColor = true;
            this.btn_Traslate.Click += new System.EventHandler(this.Btn_Traslate_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(599, 394);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(186, 23);
            this.btn_Clear.TabIndex = 3;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // btn_DrawnFigure
            // 
            this.btn_DrawnFigure.Location = new System.Drawing.Point(599, 365);
            this.btn_DrawnFigure.Name = "btn_DrawnFigure";
            this.btn_DrawnFigure.Size = new System.Drawing.Size(186, 23);
            this.btn_DrawnFigure.TabIndex = 4;
            this.btn_DrawnFigure.Text = "Drawn Figure";
            this.btn_DrawnFigure.UseVisualStyleBackColor = true;
            this.btn_DrawnFigure.Click += new System.EventHandler(this.Btn_DrawnFigure_Click);
            // 
            // trackBar_Rotation
            // 
            this.trackBar_Rotation.Location = new System.Drawing.Point(584, 104);
            this.trackBar_Rotation.Maximum = 360;
            this.trackBar_Rotation.Name = "trackBar_Rotation";
            this.trackBar_Rotation.Size = new System.Drawing.Size(174, 45);
            this.trackBar_Rotation.TabIndex = 5;
            this.trackBar_Rotation.TickFrequency = 20;
            this.trackBar_Rotation.Scroll += new System.EventHandler(this.TrackBar_Rotation_Scroll);
            // 
            // btn_Rotation
            // 
            this.btn_Rotation.Location = new System.Drawing.Point(752, 104);
            this.btn_Rotation.Name = "btn_Rotation";
            this.btn_Rotation.Size = new System.Drawing.Size(36, 23);
            this.btn_Rotation.TabIndex = 6;
            this.btn_Rotation.Text = "R";
            this.btn_Rotation.UseVisualStyleBackColor = true;
            this.btn_Rotation.Click += new System.EventHandler(this.Btn_Rotation_Click);
            // 
            // WorkSPace
            // 
            this.WorkSPace.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WorkSPace.Location = new System.Drawing.Point(12, 27);
            this.WorkSPace.Name = "WorkSPace";
            this.WorkSPace.Size = new System.Drawing.Size(566, 411);
            this.WorkSPace.TabIndex = 7;
            this.WorkSPace.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WorkSPace_MouseClick);
            // 
            // btn_refleY
            // 
            this.btn_refleY.Location = new System.Drawing.Point(698, 178);
            this.btn_refleY.Name = "btn_refleY";
            this.btn_refleY.Size = new System.Drawing.Size(90, 23);
            this.btn_refleY.TabIndex = 8;
            this.btn_refleY.Text = "Reflection Y";
            this.btn_refleY.UseVisualStyleBackColor = true;
            this.btn_refleY.Click += new System.EventHandler(this.Btn_refleY_Click);
            // 
            // lblNameApp
            // 
            this.lblNameApp.AutoSize = true;
            this.lblNameApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameApp.Location = new System.Drawing.Point(586, 27);
            this.lblNameApp.Name = "lblNameApp";
            this.lblNameApp.Size = new System.Drawing.Size(202, 20);
            this.lblNameApp.TabIndex = 9;
            this.lblNameApp.Text = "Geometric Transformations";
            // 
            // txB_TraslationX
            // 
            this.txB_TraslationX.Location = new System.Drawing.Point(590, 292);
            this.txB_TraslationX.Name = "txB_TraslationX";
            this.txB_TraslationX.Size = new System.Drawing.Size(63, 20);
            this.txB_TraslationX.TabIndex = 10;
            // 
            // txB_TraslationY
            // 
            this.txB_TraslationY.Location = new System.Drawing.Point(725, 292);
            this.txB_TraslationY.Name = "txB_TraslationY";
            this.txB_TraslationY.Size = new System.Drawing.Size(63, 20);
            this.txB_TraslationY.TabIndex = 11;
            // 
            // lblTraslationY
            // 
            this.lblTraslationY.AutoSize = true;
            this.lblTraslationY.Location = new System.Drawing.Point(722, 274);
            this.lblTraslationY.Name = "lblTraslationY";
            this.lblTraslationY.Size = new System.Drawing.Size(63, 13);
            this.lblTraslationY.TabIndex = 13;
            this.lblTraslationY.Text = "Traslation Y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Traslation X";
            // 
            // lblEscale
            // 
            this.lblEscale.AutoSize = true;
            this.lblEscale.Location = new System.Drawing.Point(593, 229);
            this.lblEscale.Name = "lblEscale";
            this.lblEscale.Size = new System.Drawing.Size(39, 13);
            this.lblEscale.TabIndex = 15;
            this.lblEscale.Text = "Escale";
            // 
            // txb_Escale
            // 
            this.txb_Escale.Location = new System.Drawing.Point(638, 226);
            this.txb_Escale.Name = "txb_Escale";
            this.txb_Escale.Size = new System.Drawing.Size(150, 20);
            this.txb_Escale.TabIndex = 16;
            // 
            // lbl_Rotacion
            // 
            this.lbl_Rotacion.AutoSize = true;
            this.lbl_Rotacion.Location = new System.Drawing.Point(596, 87);
            this.lbl_Rotacion.Name = "lbl_Rotacion";
            this.lbl_Rotacion.Size = new System.Drawing.Size(66, 13);
            this.lbl_Rotacion.TabIndex = 17;
            this.lbl_Rotacion.Text = "Rotacion: 0°";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_Rotacion);
            this.Controls.Add(this.txb_Escale);
            this.Controls.Add(this.lblEscale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTraslationY);
            this.Controls.Add(this.txB_TraslationY);
            this.Controls.Add(this.txB_TraslationX);
            this.Controls.Add(this.lblNameApp);
            this.Controls.Add(this.btn_refleY);
            this.Controls.Add(this.WorkSPace);
            this.Controls.Add(this.btn_Rotation);
            this.Controls.Add(this.trackBar_Rotation);
            this.Controls.Add(this.btn_DrawnFigure);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Traslate);
            this.Controls.Add(this.btn_refleX);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Rotation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_refleX;
        private System.Windows.Forms.Button btn_Traslate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_DrawnFigure;
        private System.Windows.Forms.TrackBar trackBar_Rotation;
        private System.Windows.Forms.Button btn_Rotation;
        private System.Windows.Forms.Panel WorkSPace;
        private System.Windows.Forms.Button btn_refleY;
        private System.Windows.Forms.Label lblNameApp;
        private System.Windows.Forms.TextBox txB_TraslationX;
        private System.Windows.Forms.TextBox txB_TraslationY;
        private System.Windows.Forms.Label lblTraslationY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEscale;
        private System.Windows.Forms.TextBox txb_Escale;
        private System.Windows.Forms.Label lbl_Rotacion;
    }
}

