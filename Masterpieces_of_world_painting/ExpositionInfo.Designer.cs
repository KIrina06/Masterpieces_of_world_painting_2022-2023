namespace Masterpieces_of_world_painting
{
    partial class ExpositionInfo
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
            this.masterpieces_of_world_paintingDataSet = new Masterpieces_of_world_painting.Masterpieces_of_world_paintingDataSet();
            this.vPaintingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vPaintingsTableAdapter = new Masterpieces_of_world_painting.Masterpieces_of_world_paintingDataSetTableAdapters.vPaintingsTableAdapter();
            this.tableAdapterManager = new Masterpieces_of_world_painting.Masterpieces_of_world_paintingDataSetTableAdapters.TableAdapterManager();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vExpositionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vExpositionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vExpositionsTableAdapter = new Masterpieces_of_world_painting.Masterpieces_of_world_paintingDataSetTableAdapters.vExpositionsTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.masterpieces_of_world_paintingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPaintingsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vExpositionsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vExpositionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // masterpieces_of_world_paintingDataSet
            // 
            this.masterpieces_of_world_paintingDataSet.DataSetName = "Masterpieces_of_world_paintingDataSet";
            this.masterpieces_of_world_paintingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vPaintingsBindingSource
            // 
            this.vPaintingsBindingSource.DataMember = "vPaintings";
            this.vPaintingsBindingSource.DataSource = this.masterpieces_of_world_paintingDataSet;
            // 
            // vPaintingsTableAdapter
            // 
            this.vPaintingsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ArtistsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CountriesTableAdapter = null;
            this.tableAdapterManager.Cultural_institutionsTableAdapter = null;
            this.tableAdapterManager.DirectionsTableAdapter = null;
            this.tableAdapterManager.ExpositionsTableAdapter = null;
            this.tableAdapterManager.MaterialsTableAdapter = null;
            this.tableAdapterManager.PaintingsTableAdapter = null;
            this.tableAdapterManager.Relationship_paintings_cult_instTableAdapter = null;
            this.tableAdapterManager.Relationship_paintings_materialsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Masterpieces_of_world_painting.Masterpieces_of_world_paintingDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.vExpositionsDataGridView);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Century Schoolbook", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1420, 508);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1271, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поиск";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(413, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1004, 398);
            this.dataGridView1.TabIndex = 2;
            // 
            // vExpositionsDataGridView
            // 
            this.vExpositionsDataGridView.AutoGenerateColumns = false;
            this.vExpositionsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.vExpositionsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vExpositionsDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.vExpositionsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vExpositionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vExpositionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.vExpositionsDataGridView.DataSource = this.vExpositionsBindingSource;
            this.vExpositionsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.vExpositionsDataGridView.Location = new System.Drawing.Point(0, 33);
            this.vExpositionsDataGridView.Name = "vExpositionsDataGridView";
            this.vExpositionsDataGridView.ReadOnly = true;
            this.vExpositionsDataGridView.RowTemplate.Height = 24;
            this.vExpositionsDataGridView.Size = new System.Drawing.Size(406, 473);
            this.vExpositionsDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Учреждение культуры";
            this.dataGridViewTextBoxColumn2.HeaderText = "Учреждение культуры";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Кол-во экспозиций";
            this.dataGridViewTextBoxColumn3.HeaderText = "Кол-во экспозиций";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 149;
            // 
            // vExpositionsBindingSource
            // 
            this.vExpositionsBindingSource.DataMember = "vExpositions";
            this.vExpositionsBindingSource.DataSource = this.masterpieces_of_world_paintingDataSet;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vExpositionsBindingSource, "Id", true));
            this.textBox1.Location = new System.Drawing.Point(0, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(93, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textChangedEventHandler);
            // 
            // vExpositionsTableAdapter
            // 
            this.vExpositionsTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1420, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ExpositionInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1420, 508);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ExpositionInfo";
            this.Text = "ExpositionInfo";
            this.Load += new System.EventHandler(this.ExpositionInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.masterpieces_of_world_paintingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vPaintingsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vExpositionsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vExpositionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Masterpieces_of_world_paintingDataSet masterpieces_of_world_paintingDataSet;
        private System.Windows.Forms.BindingSource vPaintingsBindingSource;
        private Masterpieces_of_world_paintingDataSetTableAdapters.vPaintingsTableAdapter vPaintingsTableAdapter;
        private Masterpieces_of_world_paintingDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource vExpositionsBindingSource;
        private Masterpieces_of_world_paintingDataSetTableAdapters.vExpositionsTableAdapter vExpositionsTableAdapter;
        private System.Windows.Forms.DataGridView vExpositionsDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}