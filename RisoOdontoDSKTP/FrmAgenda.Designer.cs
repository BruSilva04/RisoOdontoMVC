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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgenda));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label data_E_HorarioLabel;
            System.Windows.Forms.Label tipo_EspecialidadeLabel;
            System.Windows.Forms.Label dr_Label;
            System.Windows.Forms.Label statusLabel;
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.database1DataSet = new RisoOdontoDSKTP.Database1DataSet();
            this.agendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendaTableAdapter = new RisoOdontoDSKTP.Database1DataSetTableAdapters.AgendaTableAdapter();
            this.tableAdapterManager = new RisoOdontoDSKTP.Database1DataSetTableAdapters.TableAdapterManager();
            this.agendaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.agendaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.agendaDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.data_E_HorarioDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tipo_EspecialidadeTextBox = new System.Windows.Forms.TextBox();
            this.dr_TextBox = new System.Windows.Forms.TextBox();
            this.statusTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            data_E_HorarioLabel = new System.Windows.Forms.Label();
            tipo_EspecialidadeLabel = new System.Windows.Forms.Label();
            dr_Label = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingNavigator)).BeginInit();
            this.agendaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(data_E_HorarioLabel);
            this.groupBox1.Controls.Add(statusLabel);
            this.groupBox1.Controls.Add(dr_Label);
            this.groupBox1.Controls.Add(descricaoLabel);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.tipo_EspecialidadeTextBox);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.statusTextBox);
            this.groupBox1.Controls.Add(this.dr_TextBox);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(this.data_E_HorarioDateTimePicker);
            this.groupBox1.Controls.Add(this.descricaoTextBox);
            this.groupBox1.Location = new System.Drawing.Point(181, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.BlueViolet;
            this.label6.Location = new System.Drawing.Point(331, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 23);
            this.label6.TabIndex = 2;
            this.label6.Text = "AGENDAMENTO";
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // agendaBindingSource
            // 
            this.agendaBindingSource.DataMember = "Agenda";
            this.agendaBindingSource.DataSource = this.database1DataSet;
            // 
            // agendaTableAdapter
            // 
            this.agendaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AgendaTableAdapter = this.agendaTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = RisoOdontoDSKTP.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agendaBindingNavigator
            // 
            this.agendaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agendaBindingNavigator.BindingSource = this.agendaBindingSource;
            this.agendaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agendaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.agendaBindingNavigatorSaveItem});
            this.agendaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agendaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendaBindingNavigator.Name = "agendaBindingNavigator";
            this.agendaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendaBindingNavigator.Size = new System.Drawing.Size(847, 25);
            this.agendaBindingNavigator.TabIndex = 3;
            this.agendaBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // agendaBindingNavigatorSaveItem
            // 
            this.agendaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agendaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("agendaBindingNavigatorSaveItem.Image")));
            this.agendaBindingNavigatorSaveItem.Name = "agendaBindingNavigatorSaveItem";
            this.agendaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agendaBindingNavigatorSaveItem.Text = "Salvar Dados";

            // 
            // agendaDataGridView
            // 
            this.agendaDataGridView.AutoGenerateColumns = false;
            this.agendaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.agendaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.agendaDataGridView.DataSource = this.agendaBindingSource;
            this.agendaDataGridView.Location = new System.Drawing.Point(58, 401);
            this.agendaDataGridView.Name = "agendaDataGridView";
            this.agendaDataGridView.Size = new System.Drawing.Size(743, 220);
            this.agendaDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descricao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Data_E_Horario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Data_E_Horario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Tipo_Especialidade";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tipo_Especialidade";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Dr_";
            this.dataGridViewTextBoxColumn6.HeaderText = "Dr_";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(177, 50);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(23, 16);
            idLabel.TabIndex = 4;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(206, 46);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(152, 76);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(48, 16);
            nomeLabel.TabIndex = 6;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(206, 72);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 7;
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoLabel.Location = new System.Drawing.Point(127, 102);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(73, 16);
            descricaoLabel.TabIndex = 8;
            descricaoLabel.Text = "Descricao:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(206, 98);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(200, 20);
            this.descricaoTextBox.TabIndex = 9;
            // 
            // data_E_HorarioLabel
            // 
            data_E_HorarioLabel.AutoSize = true;
            data_E_HorarioLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_E_HorarioLabel.Location = new System.Drawing.Point(97, 128);
            data_E_HorarioLabel.Name = "data_E_HorarioLabel";
            data_E_HorarioLabel.Size = new System.Drawing.Size(103, 16);
            data_E_HorarioLabel.TabIndex = 10;
            data_E_HorarioLabel.Text = "Data E Horario:";
            // 
            // data_E_HorarioDateTimePicker
            // 
            this.data_E_HorarioDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.agendaBindingSource, "Data_E_Horario", true));
            this.data_E_HorarioDateTimePicker.Location = new System.Drawing.Point(206, 124);
            this.data_E_HorarioDateTimePicker.Name = "data_E_HorarioDateTimePicker";
            this.data_E_HorarioDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_E_HorarioDateTimePicker.TabIndex = 11;
            // 
            // tipo_EspecialidadeLabel
            // 
            tipo_EspecialidadeLabel.AutoSize = true;
            tipo_EspecialidadeLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipo_EspecialidadeLabel.Location = new System.Drawing.Point(252, 248);
            tipo_EspecialidadeLabel.Name = "tipo_EspecialidadeLabel";
            tipo_EspecialidadeLabel.Size = new System.Drawing.Size(132, 16);
            tipo_EspecialidadeLabel.TabIndex = 12;
            tipo_EspecialidadeLabel.Text = "Tipo Especialidade:";
            // 
            // tipo_EspecialidadeTextBox
            // 
            this.tipo_EspecialidadeTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tipo_EspecialidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Tipo_Especialidade", true));
            this.tipo_EspecialidadeTextBox.Location = new System.Drawing.Point(206, 150);
            this.tipo_EspecialidadeTextBox.Name = "tipo_EspecialidadeTextBox";
            this.tipo_EspecialidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.tipo_EspecialidadeTextBox.TabIndex = 13;
            // 
            // dr_Label
            // 
            dr_Label.AutoSize = true;
            dr_Label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dr_Label.Location = new System.Drawing.Point(171, 177);
            dr_Label.Name = "dr_Label";
            dr_Label.Size = new System.Drawing.Size(29, 16);
            dr_Label.TabIndex = 14;
            dr_Label.Text = "Dr :";
            // 
            // dr_TextBox
            // 
            this.dr_TextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.dr_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Dr_", true));
            this.dr_TextBox.Location = new System.Drawing.Point(206, 176);
            this.dr_TextBox.Name = "dr_TextBox";
            this.dr_TextBox.Size = new System.Drawing.Size(200, 20);
            this.dr_TextBox.TabIndex = 15;
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            statusLabel.Location = new System.Drawing.Point(150, 206);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(50, 16);
            statusLabel.TabIndex = 16;
            statusLabel.Text = "Status:";
            // 
            // statusTextBox
            // 
            this.statusTextBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendaBindingSource, "Status", true));
            this.statusTextBox.Location = new System.Drawing.Point(206, 202);
            this.statusTextBox.Name = "statusTextBox";
            this.statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.statusTextBox.TabIndex = 17;
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(847, 647);
            this.Controls.Add(tipo_EspecialidadeLabel);
            this.Controls.Add(this.agendaDataGridView);
            this.Controls.Add(this.agendaBindingNavigator);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgenda";
            this.Text = "FrmAgenda";

            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendaBindingNavigator)).EndInit();
            this.agendaBindingNavigator.ResumeLayout(false);
            this.agendaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingNavigator agendaBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.BindingSource agendaBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton agendaBindingNavigatorSaveItem;
        private Database1DataSetTableAdapters.AgendaTableAdapter agendaTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView agendaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox tipo_EspecialidadeTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox statusTextBox;
        private System.Windows.Forms.TextBox dr_TextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker data_E_HorarioDateTimePicker;
        private System.Windows.Forms.TextBox descricaoTextBox;
    }
}