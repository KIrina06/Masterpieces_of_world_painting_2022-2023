namespace Masterpieces_of_world_painting
{
    partial class AddCultInst
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcultinstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecultinstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namecountryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vCultInstBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.masterpieces_of_world_paintingDataSet1 = new Masterpieces_of_world_painting.Masterpieces_of_world_paintingDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.vCultInstBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterpieces_of_world_paintingDataSet = new Masterpieces_of_world_painting.Masterpieces_of_world_paintingDataSet();
            this.vCultInstTableAdapter = new Masterpieces_of_world_painting.Masterpieces_of_world_paintingDataSetTableAdapters.vCultInstTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCultInstBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterpieces_of_world_paintingDataSet1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vCultInstBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterpieces_of_world_paintingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 584);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcultinstDataGridViewTextBoxColumn,
            this.namecultinstDataGridViewTextBoxColumn,
            this.namecountryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vCultInstBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(494, 545);
            this.dataGridView1.TabIndex = 47;
            // 
            // idcultinstDataGridViewTextBoxColumn
            // 
            this.idcultinstDataGridViewTextBoxColumn.DataPropertyName = "Id_cult_inst";
            this.idcultinstDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idcultinstDataGridViewTextBoxColumn.Name = "idcultinstDataGridViewTextBoxColumn";
            this.idcultinstDataGridViewTextBoxColumn.Visible = false;
            // 
            // namecultinstDataGridViewTextBoxColumn
            // 
            this.namecultinstDataGridViewTextBoxColumn.DataPropertyName = "Name_cult_inst";
            this.namecultinstDataGridViewTextBoxColumn.HeaderText = "Название учреждения культуры";
            this.namecultinstDataGridViewTextBoxColumn.Name = "namecultinstDataGridViewTextBoxColumn";
            // 
            // namecountryDataGridViewTextBoxColumn
            // 
            this.namecountryDataGridViewTextBoxColumn.DataPropertyName = "Name_country";
            this.namecountryDataGridViewTextBoxColumn.HeaderText = "Страна";
            this.namecountryDataGridViewTextBoxColumn.Name = "namecountryDataGridViewTextBoxColumn";
            // 
            // vCultInstBindingSource1
            // 
            this.vCultInstBindingSource1.DataMember = "vCultInst";
            this.vCultInstBindingSource1.DataSource = this.masterpieces_of_world_paintingDataSet1;
            // 
            // masterpieces_of_world_paintingDataSet1
            // 
            this.masterpieces_of_world_paintingDataSet1.DataSetName = "Masterpieces_of_world_paintingDataSet";
            this.masterpieces_of_world_paintingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(1029, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 28);
            this.button2.TabIndex = 46;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(897, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(271, 24);
            this.comboBox1.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("GOST type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(795, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 22);
            this.label6.TabIndex = 44;
            this.label6.Text = "Страна:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(897, 89);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 28);
            this.textBox2.TabIndex = 32;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("GOST type B", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(579, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 22);
            this.label2.TabIndex = 33;
            this.label2.Text = "Название учреждения культуры:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(198)))), ((int)(((byte)(221)))));
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 47);
            this.panel2.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(548, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Обновить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(529, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Удалить текущую запись";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1029, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vCultInstBindingSource1, "Id_cult_inst", true));
            this.textBox1.Location = new System.Drawing.Point(69, 267);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 48;
            // 
            // vCultInstBindingSource
            // 
            this.vCultInstBindingSource.DataMember = "vCultInst";
            this.vCultInstBindingSource.DataSource = this.masterpieces_of_world_paintingDataSet;
            // 
            // masterpieces_of_world_paintingDataSet
            // 
            this.masterpieces_of_world_paintingDataSet.DataSetName = "Masterpieces_of_world_paintingDataSet";
            this.masterpieces_of_world_paintingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vCultInstTableAdapter
            // 
            this.vCultInstTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 24);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AddCultInst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 584);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddCultInst";
            this.Text = "AddCultInst";
            this.Load += new System.EventHandler(this.AddCultInst_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vCultInstBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterpieces_of_world_paintingDataSet1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vCultInstBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterpieces_of_world_paintingDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vCultInstBindingSource;
        private Masterpieces_of_world_paintingDataSet masterpieces_of_world_paintingDataSet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Masterpieces_of_world_paintingDataSet masterpieces_of_world_paintingDataSet1;
        private System.Windows.Forms.BindingSource vCultInstBindingSource1;
        private Masterpieces_of_world_paintingDataSetTableAdapters.vCultInstTableAdapter vCultInstTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcultinstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecultinstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecountryDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}