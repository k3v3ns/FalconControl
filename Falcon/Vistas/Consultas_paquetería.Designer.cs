namespace Falcon
{
    partial class Consultas_paquetería
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultas_paquetería));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.hasta = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.desde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_consultas2 = new System.Windows.Forms.DataGridView();
            this.labelS = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BarraTituloPnl = new System.Windows.Forms.Panel();
            this.MinimizarBtn = new System.Windows.Forms.PictureBox();
            this.CerrarBtn = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultas2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.BarraTituloPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(299, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 39);
            this.button1.TabIndex = 29;
            this.button1.Text = "BUSCAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(29, 450);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(247, 42);
            this.button3.TabIndex = 28;
            this.button3.Text = "GENERAR REPORTE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hasta);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.desde);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 318);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(456, 115);
            this.panel1.TabIndex = 25;
            // 
            // hasta
            // 
            this.hasta.CustomFormat = "yyyy-MM-dd";
            this.hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.hasta.Location = new System.Drawing.Point(187, 63);
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(200, 35);
            this.hasta.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(131, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "A:";
            // 
            // desde
            // 
            this.desde.CustomFormat = "yyyy-MM-dd";
            this.desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.desde.Location = new System.Drawing.Point(187, 8);
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(200, 35);
            this.desde.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "PERIODO DE:";
            // 
            // dgv_consultas2
            // 
            this.dgv_consultas2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_consultas2.BackgroundColor = System.Drawing.Color.GhostWhite;
            this.dgv_consultas2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_consultas2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_consultas2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consultas2.EnableHeadersVisualStyles = false;
            this.dgv_consultas2.GridColor = System.Drawing.Color.DimGray;
            this.dgv_consultas2.Location = new System.Drawing.Point(575, 77);
            this.dgv_consultas2.Name = "dgv_consultas2";
            this.dgv_consultas2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_consultas2.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_consultas2.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_consultas2.Size = new System.Drawing.Size(1084, 665);
            this.dgv_consultas2.TabIndex = 24;
            this.dgv_consultas2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelS
            // 
            this.labelS.AutoSize = true;
            this.labelS.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelS.Location = new System.Drawing.Point(1036, 673);
            this.labelS.Name = "labelS";
            this.labelS.Size = new System.Drawing.Size(62, 17);
            this.labelS.TabIndex = 32;
            this.labelS.Text = "Activo";
            this.labelS.Click += new System.EventHandler(this.labelS_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(130, 49);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(389, 180);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Listado de paqueteria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(185, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(286, 20);
            this.label4.TabIndex = 35;
            this.label4.Text = "Consulte paqueria en el siguiente plazo";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Location = new System.Drawing.Point(558, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 716);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.Location = new System.Drawing.Point(540, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 716);
            this.panel3.TabIndex = 37;
            // 
            // BarraTituloPnl
            // 
            this.BarraTituloPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.BarraTituloPnl.Controls.Add(this.MinimizarBtn);
            this.BarraTituloPnl.Controls.Add(this.CerrarBtn);
            this.BarraTituloPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTituloPnl.Location = new System.Drawing.Point(0, 0);
            this.BarraTituloPnl.Name = "BarraTituloPnl";
            this.BarraTituloPnl.Size = new System.Drawing.Size(1671, 30);
            this.BarraTituloPnl.TabIndex = 38;
            this.BarraTituloPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTituloPnl_MouseDown);
            // 
            // MinimizarBtn
            // 
            this.MinimizarBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizarBtn.Image = ((System.Drawing.Image)(resources.GetObject("MinimizarBtn.Image")));
            this.MinimizarBtn.Location = new System.Drawing.Point(1611, 0);
            this.MinimizarBtn.Name = "MinimizarBtn";
            this.MinimizarBtn.Size = new System.Drawing.Size(30, 30);
            this.MinimizarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.MinimizarBtn.TabIndex = 1;
            this.MinimizarBtn.TabStop = false;
            this.MinimizarBtn.Click += new System.EventHandler(this.MinimizarBtn_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.Location = new System.Drawing.Point(1641, 0);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(30, 30);
            this.CerrarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.CerrarBtn.TabIndex = 0;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // Consultas_paquetería
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1671, 750);
            this.Controls.Add(this.BarraTituloPnl);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_consultas2);
            this.Controls.Add(this.labelS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Consultas_paquetería";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Consultas_paquetería_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consultas2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.BarraTituloPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinimizarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker desde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_consultas2;
        private System.Windows.Forms.Label labelS;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel BarraTituloPnl;
        private System.Windows.Forms.PictureBox MinimizarBtn;
        private System.Windows.Forms.PictureBox CerrarBtn;
    }
}