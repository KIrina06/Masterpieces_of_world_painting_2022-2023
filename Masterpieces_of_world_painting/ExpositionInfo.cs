using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Masterpieces_of_world_painting
{
    public partial class ExpositionInfo : Form
    {
        

        public ExpositionInfo()
        {
            InitializeComponent();
            ToolStripMenuItem fileItem = new ToolStripMenuItem("Меню");

            ToolStripMenuItem goToMenu = new ToolStripMenuItem("Перейти в меню");
            fileItem.DropDownItems.Add(goToMenu);
            goToMenu.Click += goToMenu_Click;
            ToolStripMenuItem changeUserItem = new ToolStripMenuItem("Сменить пользователя");
            fileItem.DropDownItems.Add(changeUserItem);
            changeUserItem.Click += changeUserItem_Click;
            ToolStripMenuItem exitItem = new ToolStripMenuItem("Выйти");
            fileItem.DropDownItems.Add(exitItem);
            exitItem.Click += exitItem_Click;

            menuStrip1.Items.Add(fileItem);

            ToolStripMenuItem infoItem = new ToolStripMenuItem("Просмотр");

            ToolStripMenuItem paintItem = new ToolStripMenuItem("Информация о картинах");
            infoItem.DropDownItems.Add(paintItem);
            paintItem.Click += paintItem_Click;
            ToolStripMenuItem exposItem = new ToolStripMenuItem("Информация о выставках");
            infoItem.DropDownItems.Add(exposItem);
            exposItem.Click += exposItem_Click;

            menuStrip1.Items.Add(infoItem);

            ToolStripMenuItem addInfoItem = new ToolStripMenuItem("Добавить/Редактировать");

            ToolStripMenuItem addPaintItem = new ToolStripMenuItem("Данные о картинах");
            addInfoItem.DropDownItems.Add(addPaintItem);
            addPaintItem.Click += addPaintItem_Click;
            ToolStripMenuItem addArtistItem = new ToolStripMenuItem("Данные о художниках");
            addInfoItem.DropDownItems.Add(addArtistItem);
            addArtistItem.Click += addArtistItem_Click;
            ToolStripMenuItem addDirItem = new ToolStripMenuItem("Данные о направлениях");
            addInfoItem.DropDownItems.Add(addDirItem);
            addDirItem.Click += addDirItem_Click;
            ToolStripMenuItem addCIItem = new ToolStripMenuItem("Данные об уреждениях культуры");
            addInfoItem.DropDownItems.Add(addCIItem);
            addCIItem.Click += addCIItem_Click;
            ToolStripMenuItem addExpItem = new ToolStripMenuItem("Данные о выставках");
            addInfoItem.DropDownItems.Add(addExpItem);
            addExpItem.Click += addExpItem_Click;

            menuStrip1.Items.Add(addInfoItem);

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.Click += aboutItem_Click;
            menuStrip1.Items.Add(aboutItem);
        }

        private void goToMenu_Click(object sender, EventArgs e)
        {
            Form menuForm = new MenuAdmin();
            menuForm.Show();
            this.Hide();
        }

        void aboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила: Кулешова Ирина\nГруппа: ИУ5-45Б");
        }

        void changeUserItem_Click(object sender, EventArgs e)
        {
            Form loginform = new LoginForm();
            loginform.Show();
            this.Hide();
        }

        void exitItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        void paintItem_Click(object sender, EventArgs e)
        {
            Form InfPaint = new PaintInfo();
            InfPaint.Show();
            this.Hide();
        }

        void exposItem_Click(object sender, EventArgs e)
        {
            Form InfExp = new ExpositionInfo();
            InfExp.Show();
            this.Hide();
        }

        void addPaintItem_Click(object sender, EventArgs e)
        {
            Form AddPaint = new AddPainting();
            AddPaint.Show();
            this.Hide();
        }

        void addArtistItem_Click(object sender, EventArgs e)
        {
            Form AddArt = new AddArtist();
            AddArt.Show();
            this.Hide();
        }

        void addDirItem_Click(object sender, EventArgs e)
        {
            Form AddDir = new AddDirections();
            AddDir.Show();
            this.Hide();
        }


        void addCIItem_Click(object sender, EventArgs e)
        {
            Form AddCult = new AddCultInst();
            AddCult.Show();
            this.Hide();
        }

        void addExpItem_Click(object sender, EventArgs e)
        {
            Form AddExp = new AddExpos();
            AddExp.Show();
            this.Hide();
        }

        private void ExpositionInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterpieces_of_world_paintingDataSet.vExpositions". При необходимости она может быть перемещена или удалена.
            this.vExpositionsTableAdapter.Fill(this.masterpieces_of_world_paintingDataSet.vExpositions);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterpieces_of_world_paintingDataSet.vPaintings". При необходимости она может быть перемещена или удалена.
            this.vPaintingsTableAdapter.Fill(this.masterpieces_of_world_paintingDataSet.vPaintings);

            string mynum;
            mynum = "1";

            string conStr = @"Data Source=HONOR-PC\SQLEXPRESS;Initial Catalog=""Masterpieces of world painting"";Integrated Security=True";
            string sql = @"SELECT e.Id_exposition AS 'Id выставки', e.Name_exposition AS 'Название выставки', c.Name_cult_inst AS 'Учреждение культуры', 
                            a.Name_artist AS 'Художник', e.St_date AS 'Дата начала', e.Fin_date AS 'Дата окончания' FROM dbo.Expositions AS e
                            LEFT JOIN dbo.Cultural_institutions AS c ON c.Id_cult_inst = e.Id_cult_inst
                            LEFT JOIN dbo.Artists AS a ON a.Id_artist = e.Id_artist
                            WHERE e.Id_cult_inst = " + mynum;

            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = new SqlCommand(sql, connection);
                DataSet ds = new DataSet();
                myadapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void textChangedEventHandler(object sender, EventArgs e)
        {
            string mynum;
            mynum = this.textBox1.Text;
            string conStr = @"Data Source=HONOR-PC\SQLEXPRESS;Initial Catalog=""Masterpieces of world painting"";Integrated Security=True";
            string sql = @"SELECT e.Id_exposition AS 'Id выставки', e.Name_exposition AS 'Название выставки', c.Name_cult_inst AS 'Учреждение культуры', 
                            a.Name_artist AS 'Художник', e.St_date AS 'Дата начала', e.Fin_date AS 'Дата окончания' FROM dbo.Expositions AS e
                            LEFT JOIN dbo.Cultural_institutions AS c ON c.Id_cult_inst = e.Id_cult_inst
                            LEFT JOIN dbo.Artists AS a ON a.Id_artist = e.Id_artist
                            WHERE e.Id_cult_inst = " + mynum;
            using (SqlConnection connection = new SqlConnection(conStr))
            {
                SqlDataAdapter myadapter = new SqlDataAdapter();
                myadapter.SelectCommand = new SqlCommand(sql, connection);
                DataSet ds = new DataSet();
                myadapter.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                dataGridView1.Columns[0].Width = 40;
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataGridView1.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ExpFind = new PaintingFind();
            ExpFind.Show();
        }

    }
}
