namespace RisoOdontoDSKTP
{
    partial class FrmAgenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.LblStatus = new System.Windows.Forms.Label();
            this.CmbTipo = new System.Windows.Forms.ComboBox();
            this.mskDataHorario = new System.Windows.Forms.MaskedTextBox();
            this.txtDr = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label6 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.novoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.AgendarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExcluirtoolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.listView1 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LblStatus);
            this.groupBox1.Controls.Add(this.CmbTipo);
            this.groupBox1.Controls.Add(this.mskDataHorario);
            this.groupBox1.Controls.Add(this.txtDr);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(330, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 303);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(142, 16);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 23);
            this.txtNome.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Nome";
            // 
            // LblStatus
            // 
            this.LblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStatus.Location = new System.Drawing.Point(142, 223);
            this.LblStatus.Name = "LblStatus";
            this.LblStatus.Size = new System.Drawing.Size(101, 22);
            this.LblStatus.TabIndex = 9;
            this.LblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CmbTipo
            // 
            this.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbTipo.FormattingEnabled = true;
            this.CmbTipo.Items.AddRange(new object[] {
            "1 - Odontopediatria",
            "2 - Clínico geral",
            "3 - Implantodontia",
            "4 - Odontologia estética",
            "5 - Radiologia odontológica",
            "6 - Ortodontia"});
            this.CmbTipo.Location = new System.Drawing.Point(160, 131);
            this.CmbTipo.Name = "CmbTipo";
            this.CmbTipo.Size = new System.Drawing.Size(251, 21);
            this.CmbTipo.TabIndex = 8;
            // 
            // mskDataHorario
            // 
            this.mskDataHorario.Location = new System.Drawing.Point(143, 91);
            this.mskDataHorario.Mask = "00/00/0000 00:00";
            this.mskDataHorario.Name = "mskDataHorario";
            this.mskDataHorario.Size = new System.Drawing.Size(100, 20);
            this.mskDataHorario.TabIndex = 7;
            // 
            // txtDr
            // 
            this.txtDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDr.Location = new System.Drawing.Point(142, 178);
            this.txtDr.MaxLength = 50;
            this.txtDr.Name = "txtDr";
            this.txtDr.Size = new System.Drawing.Size(269, 23);
            this.txtDr.TabIndex = 6;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(142, 52);
            this.txtDescricao.MaxLength = 50;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(269, 23);
            this.txtDescricao.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dr.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de Especialidade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data e Horário";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCalendar1.Location = new System.Drawing.Point(62, 85);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "AGENDAMENTO";
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripButton,
            this.toolStripSeparator,
            this.AgendarToolStripButton,
            this.toolStripSeparator1,
            this.ExcluirtoolStripButton1});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(62, 256);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 154);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // novoToolStripButton
            // 
            this.novoToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.novoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("novoToolStripButton.Image")));
            this.novoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.novoToolStripButton.Name = "novoToolStripButton";
            this.novoToolStripButton.Size = new System.Drawing.Size(109, 39);
            this.novoToolStripButton.Text = "&Novo";
            this.novoToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.novoToolStripButton.ToolTipText = "Nova tarefa";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(109, 6);
            // 
            // AgendarToolStripButton
            // 
            this.AgendarToolStripButton.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AgendarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("AgendarToolStripButton.Image")));
            this.AgendarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AgendarToolStripButton.Name = "AgendarToolStripButton";
            this.AgendarToolStripButton.Size = new System.Drawing.Size(109, 39);
            this.AgendarToolStripButton.Text = "&Agendar";
            this.AgendarToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.AgendarToolStripButton.ToolTipText = "Agendar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // ExcluirtoolStripButton1
            // 
            this.ExcluirtoolStripButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ExcluirtoolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ExcluirtoolStripButton1.Image")));
            this.ExcluirtoolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcluirtoolStripButton1.Name = "ExcluirtoolStripButton1";
            this.ExcluirtoolStripButton1.Size = new System.Drawing.Size(109, 39);
            this.ExcluirtoolStripButton1.Text = "&Excluir";
            this.ExcluirtoolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ExcluirtoolStripButton1.ToolTipText = "Excluir agendamento";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(28, 432);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(787, 224);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 676);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgenda";
            this.Text = "FrmAgenda";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskDataHorario;
        private System.Windows.Forms.TextBox txtDr;
        private System.Windows.Forms.ComboBox CmbTipo;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton novoToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton AgendarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ExcluirtoolStripButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label LblStatus;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label7;
    }
}