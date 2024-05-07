﻿using System;
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
    public partial class ExpFind2 : Form
    {
        public ExpFind2()
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

            ToolStripMenuItem addInfoItem = new ToolStripMenuItem("Поиск");

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
            Form InfPaint = new PaintInfo2();
            InfPaint.Show();
            this.Hide();
        }

        void exposItem_Click(object sender, EventArgs e)
        {
            Form InfExp = new ExpositionInfo2();
            InfExp.Show();
            this.Hide();
        }

        void addPaintItem_Click(object sender, EventArgs e)
        {
            Form AddPaint = new PaintingFind2();
            AddPaint.Show();
            this.Hide();
        }

        void addArtistItem_Click(object sender, EventArgs e)
        {
            Form AddArt = new ArtistFind2();
            AddArt.Show();
            this.Hide();
        }

        void addDirItem_Click(object sender, EventArgs e)
        {
            Form AddDir = new DirFind2();
            AddDir.Show();
            this.Hide();
        }


        void addCIItem_Click(object sender, EventArgs e)
        {
            Form AddCult = new CultFind2();
            AddCult.Show();
            this.Hide();
        }

        void addExpItem_Click(object sender, EventArgs e)
        {
            Form AddExp = new ExpFind2();
            AddExp.Show();
            this.Hide();
        }

        private string stringCon()
        {
            return @"Data Source=HONOR-PC\SQLEXPRESS;Initial Catalog=""Masterpieces of world painting"";Integrated Security=True";
        }

        private void ExpFind_Load(object sender, EventArgs e)
        {
            var queryListCodeRequest = "SELECT DISTINCT c.Name_cult_inst FROM dbo.Cultural_institutions AS c ORDER BY c.Name_cult_inst";
            var queryListCodeRequest2 = "SELECT DISTINCT d.Name_artist FROM dbo.Artists AS d ORDER BY d.Name_artist";
            GetColoumnValues(queryListCodeRequest, "Name_cult_inst", comboBox1);
            GetColoumnValues(queryListCodeRequest2, "Name_artist", comboBox2);
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
            myCon.Close();
            return coloumnValues;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mynum;
            mynum = textBox2.Text;
            string sql;
            if (comboBox1.Text.ToString() == "")
            {
                if (comboBox2.Text.ToString() == "")
                {
                    sql = @"SELECT e.Name_exposition, a.Name_artist, e.Id_cult_inst, e.St_date, e.Fin_date
                            FROM dbo.Expositions AS e JOIN dbo.Artists AS a
                            ON a.Id_artist = e.Id_artist
                            JOIN dbo.Cultural_institutions AS c
                            ON c.Id_cult_inst = e.Id_cult_inst
                            WHERE e.Name_exposition LIKE '" + mynum + "%'"; //+mynum;
                }
                else
                {
                    sql = @"SELECT e.Name_exposition, a.Name_artist, e.Id_cult_inst, e.St_date, e.Fin_date
                            FROM dbo.Expositions AS e JOIN dbo.Artists AS a
                            ON a.Id_artist = e.Id_artist
                            JOIN dbo.Cultural_institutions AS c
                            ON c.Id_cult_inst = e.Id_cult_inst
                            WHERE e.Name_exposition LIKE '" + mynum + "%' AND e.Id_artist = (SELECT Id_artist FROM dbo.Artists WHERE Name_artist = '" + comboBox2.Text + "')"; //+mynum;
                }
            }
            else
            {
                if (comboBox2.Text.ToString() == "")
                {
                    sql = @"SELECT e.Name_exposition, a.Name_artist, e.Id_cult_inst, e.St_date, e.Fin_date
                            FROM dbo.Expositions AS e JOIN dbo.Artists AS a
                            ON a.Id_artist = e.Id_artist
                            JOIN dbo.Cultural_institutions AS c
                            ON c.Id_cult_inst = e.Id_cult_inst
                            WHERE e.Name_exposition LIKE '" + mynum + "%' AND e.Id_cult_inst = (SELECT Id_cult_inst FROM dbo.Cultural_institutions WHERE Name_cult_inst = '" + comboBox1.Text + "')"; //+mynum;
                }
                else
                {
                    sql = @"SELECT a.Name_artist, d.Name_direction, a.Date_of_birth, a.Date_of_death, c.Name_country
                        FROM dbo.Artists AS a JOIN dbo.Directions AS d
                        ON a.Id_direction = d.Id_direction
                        JOIN dbo.Countries AS c ON c.Id_country = a.Id_country
                        WHERE Name_artist LIKE '" + mynum + "%' AND e.Id_artist = (SELECT Id_artist FROM dbo.Artists WHERE Name_artist = '" + comboBox2.Text + "') AND WHERE e.Name_exposition LIKE '" + mynum + "%' AND e.Id_cult_inst = (SELECT Id_cult_inst FROM dbo.Cultural_institutions WHERE Name_cult_inst = '" + comboBox1.Text + "')";
                }
            }
            string conStr = @"Data Source=HONOR-PC\SQLEXPRESS;Initial Catalog=""Masterpieces of world painting"";Integrated Security=True";


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
            }

        }

        private void ExpFind_Load_1(object sender, EventArgs e)
        {
            var queryListCodeRequest = "SELECT DISTINCT c.Name_cult_inst FROM dbo.Cultural_institutions AS c ORDER BY c.Name_cult_inst";
            var queryListCodeRequest2 = "SELECT DISTINCT d.Name_artist FROM dbo.Artists AS d ORDER BY d.Name_artist";
            GetColoumnValues(queryListCodeRequest, "Name_cult_inst", comboBox1);
            GetColoumnValues(queryListCodeRequest2, "Name_artist", comboBox2);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string mynum;
            mynum = textBox2.Text;
            string sql;
            if (comboBox1.Text.ToString() == "")
            {
                if (comboBox2.Text.ToString() == "")
                {
                    sql = @"SELECT e.Name_exposition, a.Name_artist, e.Id_cult_inst, e.St_date, e.Fin_date
                            FROM dbo.Expositions AS e JOIN dbo.Artists AS a
                            ON a.Id_artist = e.Id_artist
                            JOIN dbo.Cultural_institutions AS c
                            ON c.Id_cult_inst = e.Id_cult_inst
                            WHERE e.Name_exposition LIKE '" + mynum + "%'"; //+mynum;
                }
                else
                {
                    sql = @"SELECT e.Name_exposition, a.Name_artist, e.Id_cult_inst, e.St_date, e.Fin_date
                            FROM dbo.Expositions AS e JOIN dbo.Artists AS a
                            ON a.Id_artist = e.Id_artist
                            JOIN dbo.Cultural_institutions AS c
                            ON c.Id_cult_inst = e.Id_cult_inst
                            WHERE e.Name_exposition LIKE '" + mynum + "%' AND e.Id_artist = (SELECT Id_artist FROM dbo.Artists WHERE Name_artist = '" + comboBox2.Text + "')"; //+mynum;
                }
            }
            else
            {
                if (comboBox2.Text.ToString() == "")
                {
                    sql = @"SELECT e.Name_exposition, a.Name_artist, e.Id_cult_inst, e.St_date, e.Fin_date
                            FROM dbo.Expositions AS e JOIN dbo.Artists AS a
                            ON a.Id_artist = e.Id_artist
                            JOIN dbo.Cultural_institutions AS c
                            ON c.Id_cult_inst = e.Id_cult_inst
                            WHERE e.Name_exposition LIKE '" + mynum + "%' AND e.Id_cult_inst = (SELECT Id_cult_inst FROM dbo.Cultural_institutions WHERE Name_cult_inst = '" + comboBox1.Text + "')"; //+mynum;
                }
                else
                {
                    sql = @"SELECT a.Name_artist, d.Name_direction, a.Date_of_birth, a.Date_of_death, c.Name_country
                        FROM dbo.Artists AS a JOIN dbo.Directions AS d
                        ON a.Id_direction = d.Id_direction
                        JOIN dbo.Countries AS c ON c.Id_country = a.Id_country
                        WHERE Name_artist LIKE '" + mynum + "%' AND e.Id_artist = (SELECT Id_artist FROM dbo.Artists WHERE Name_artist = '" + comboBox2.Text + "') AND WHERE e.Name_exposition LIKE '" + mynum + "%' AND e.Id_cult_inst = (SELECT Id_cult_inst FROM dbo.Cultural_institutions WHERE Name_cult_inst = '" + comboBox1.Text + "')";
                }
            }
            string conStr = @"Data Source=HONOR-PC\SQLEXPRESS;Initial Catalog=""Masterpieces of world painting"";Integrated Security=True";


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
            }
        }
    }
}