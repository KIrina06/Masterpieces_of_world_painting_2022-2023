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
    public partial class AddPainting : Form
    {
        public AddPainting()
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

        private string stringCon()
        {
            return @"Data Source=HONOR-PC\SQLEXPRESS;Initial Catalog=""Masterpieces of world painting"";Integrated Security=True";
        }

        private void AddPainting_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "masterpieces_of_world_paintingDataSet.vPaintings". При необходимости она может быть перемещена или удалена.
            this.vPaintingsTableAdapter.Fill(this.masterpieces_of_world_paintingDataSet.vPaintings);
            var queryListCodeRequest2 = "SELECT DISTINCT d.Name_direction FROM dbo.Directions AS d ORDER BY d.Name_direction";
            var queryListCodeRequest4 = "SELECT DISTINCT d.Name_artist FROM dbo.Artists AS d ORDER BY d.Name_artist";
            GetColoumnValues(queryListCodeRequest2, "Name_direction", comboBox2);
            GetColoumnValues(queryListCodeRequest4, "Name_artist", comboBox4);
            comboBox1.Items.AddRange(new string[] { "Абстракция", "Автопортрет", "Анималистика", "Батальный", "Бытовой", "Исторический", "Марина", "Мифологический", "Натюрморт", "Ню", "Пейзаж", "Портрет", "Жанровая сцена", "Религиозный" });
            comboBox3.Items.AddRange(new string[] { "15", "16", "17", "18", "19", "20", "21"});
        }

        public List<string> GetColoumnValues(string query, string coloumnName, ComboBox myBox)
        {
            List<string> coloumnValues = new List<string>();

            SqlConnection myCon = new SqlConnection(stringCon());
            myCon.Open();
            using (SqlCommand command = new SqlCommand(query, myCon))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    object coloumnValueObject = reader.GetValue(reader.GetOrdinal(coloumnName));
                    string coloumnValue = coloumnValueObject != DBNull.Value ? coloumnValueObject.ToString() : "";
                    coloumnValues.Add(coloumnValue);
                }
            }
            myBox.Items.AddRange(coloumnValues.ToArray());
            myBox.Items.Add("Другое...");
            myCon.Close();
            return coloumnValues;
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Другое...")
            {
                Form addDir = new AddDirections();
                addDir.Show();
                this.Hide();
            }
            if (comboBox4.Text == "Другое...")
            {
                Form addArt = new AddArtist();
                addArt.Show();
                this.Hide();
            }
            SqlConnection myCon2 = new SqlConnection(stringCon());
            myCon2.Open();
            SqlCommand command2 = new SqlCommand("INSERT INTO dbo.Paintings(Name_painting, Id_artist, Id_direction, Genre, Century) VALUES ('" + textBox2.Text + "', (SELECT Id_artist FROM dbo.Artists WHERE Name_artist = '" + comboBox4.Text + "'), (SELECT Id_direction FROM dbo.Directions WHERE Name_direction = '" + comboBox2.Text + "'), '" + comboBox1.Text + "', '" + comboBox3.Text + "')",
                myCon2);
            command2.ExecuteNonQuery();
            myCon2.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form findPainting = new PaintingFind();
            findPainting.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection myCon3 = new SqlConnection(stringCon());
            myCon3.Open();
            SqlCommand command3 = new SqlCommand("DELETE FROM dbo.Paintings WHERE Id_painting = '" + textBox1.Text + "'",
                myCon3);
            command3.ExecuteNonQuery();
            myCon3.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form f1 = new AddPainting();
            f1.Show();
            this.Hide();
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
    }
}
