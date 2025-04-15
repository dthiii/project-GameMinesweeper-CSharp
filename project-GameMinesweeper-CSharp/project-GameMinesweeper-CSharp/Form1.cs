using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_GameMinesweeper_CSharp
{
    public partial class Form1 : Form
    {
        //0 là chưa gán giá trị
        //10 là vị trí có mìn
        //1 đến 8 là vị trí số
        //20 là vị trí trống

        byte[,] Positions;
        Button[,] ButtonList;

        public Form1()
        {
            InitializeComponent();
            easyToolStripMenuItem.Click += new EventHandler(levelToolStripMenuItem_Click);
            mediumToolStripMenuItem.Click += new EventHandler(levelToolStripMenuItem_Click);
            hardToolStripMenuItem.Click += new EventHandler(levelToolStripMenuItem_Click);
        }

        private void levelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = sender as ToolStripMenuItem;
            int row = 0, col = 0, mine = 0, flag = 0;

            if (clickedItem.Text == "Easy")
            {
                row = 9;
                col = 9;
                mine = 10;
                pnlBody.Size = new Size(308, 259);
                this.ClientSize = new Size(232, 270);
            }
            else if (clickedItem.Text == "Medium")
            {
                row = 16;
                col = 16;
                mine = 40;
                pnlBody.Size = new Size(544, 442);
                this.ClientSize = new Size(405, 425);
            }
            else if (clickedItem.Text == "Hard")
            {
                row = 16;
                col = 30;
                mine = 99;
                pnlBody.Size = new Size(1008, 442);
                this.ClientSize = new Size(760, 425);
            }

            pnlBody.Controls.Clear();
            txtFlag.Clear();
            txtScore.Clear();

            points = 0;
            flag = mine;
            txtFlag.Text = mine.ToString();
            Positions = new byte[row, col];
            ButtonList = new Button[row, col];
            pnlBody.Enabled = true;
            GenerateMines(row, col, mine);
            GeneratePositionValue(row, col);
            GenerateButtons(row, col);
        }

        private void GenerateMines(int row, int col, int mine)
        {
            Random rnd = new Random();
            int CountMines = 0;
            while (CountMines < mine)
            {
                int x = rnd.Next(0, row);
                int y = rnd.Next(0, col);

                if (Positions[x, y] == 0)
                {
                    Positions[x, y] = 10;
                    CountMines++;
                }
            }
        }

        private void GeneratePositionValue(int row, int col)
        {
            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    if (Positions[x, y] == 10)
                        continue;

                    byte mineCounts = 0;
                    for (int counterX = -1; counterX < 2; counterX++)
                    {
                        int checkerX = x + counterX;

                        for (int counterY = -1; counterY < 2; counterY++)
                        {
                            int checkerY = y + counterY;

                            if (checkerX == -1 || checkerY == -1 || checkerX > row - 1 || checkerY > col - 1)
                                continue;

                            if (checkerX == x && checkerY == y)
                                continue;

                            if (Positions[checkerX, checkerY] == 10)
                                mineCounts++;
                        }
                    }

                    if (mineCounts == 0)
                        Positions[x, y] = 20;
                    else
                        Positions[x, y] = mineCounts;
                }
            }
        }

        private void GenerateButtons(int row, int col)
        {
            int xLoc = 3;
            int yLoc = 6;

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    Button btn = new Button();
                    btn.Parent = pnlBody;
                    btn.Location = new Point(xLoc, yLoc);
                    btn.Size = new Size(25, 22);
                    btn.Tag = $"{x},{y}";
                    btn.Click += BtnClick;
                    btn.MouseUp += BtnMouseUp;
                    xLoc += 25;
                    ButtonList[x, y] = btn;
                }
                yLoc += 22;
                xLoc = 3;
            }
        }

        private void BtnClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int x = Convert.ToInt32(btn.Tag.ToString().Split(',').GetValue(0));
            int y = Convert.ToInt32(btn.Tag.ToString().Split(',').GetValue(1));
            byte value = Positions[x, y];

            if (value == 10)
            {
                btn.Image = Nhom8_LaptrinhGameMinesweeper_9301.Properties.Resources.mine;
                ShowAllMines();
                MessageBox.Show("GameOver");
                pnlBody.Enabled = false;
            }
            else if (value == 20)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = SystemColors.ControlDark;
                btn.FlatAppearance.BorderSize = 1;
                btn.Enabled = false;
                OpenAdjacentEmptyTile(btn);
                points++;
            }
            else
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = SystemColors.ControlDark;
                btn.FlatAppearance.MouseDownBackColor = btn.BackColor;
                btn.FlatAppearance.MouseOverBackColor = btn.BackColor;
                btn.Text = Positions[x, y].ToString();
                points++;
            }

            btn.Click -= BtnClick;
            txtScore.Text = points.ToString();

            int mineCount = 0;
            foreach (int i in Positions)
            {
                if (i == 10)
                    mineCount++;
            }

            if (points == (Positions.GetLength(0) * Positions.GetLength(1) - mineCount))
            {
                ShowAllMines();
                MessageBox.Show("You win");
                pnlBody.Enabled = false;
            }
        }

        private void OpenAdjacentEmptyTile(Button btn)
        {
            int x = Convert.ToInt32(btn.Tag.ToString().Split(',').GetValue(0));
            int y = Convert.ToInt32(btn.Tag.ToString().Split(',').GetValue(1));
            List<Button> emptyButtons = new List<Button>();

            for (int counterX = -1; counterX < 2; counterX++)
            {
                int checkerX = x + counterX;

                for (int counterY = -1; counterY < 2; counterY++)
                {
                    int checkerY = y + counterY;

                    if (checkerX == -1 || checkerY == -1 || checkerX > Positions.GetLength(0) - 1 || checkerY > Positions.GetLength(1) - 1)
                        continue;

                    if (checkerX == x && checkerY == y)
                        continue;

                    Button btnAdjacent = ButtonList[checkerX, checkerY];
                    byte value = Positions[checkerX, checkerY];

                    if (value == 20)
                    {
                        if (btnAdjacent.FlatStyle != FlatStyle.Flat)
                        {

                            btnAdjacent.FlatStyle = FlatStyle.Flat;
                            btnAdjacent.FlatAppearance.BorderSize = 1;
                            btnAdjacent.FlatAppearance.BorderColor = SystemColors.ControlDark;
                            btnAdjacent.Enabled = false;
                            emptyButtons.Add(btnAdjacent);
                            points++;
                        }
                    }

                    else if (value != 10)
                        btnAdjacent.PerformClick();

                    else if (btn.Enabled == false && btn.Image != null)
                    {
                        btn.Image = null; // Xóa lá cờ
                        txtFlag.Text = (Convert.ToInt32(txtFlag.Text) + 1).ToString();
                    }

                }
            }

            foreach (var btnEmpty in emptyButtons)
            {
                OpenAdjacentEmptyTile(btnEmpty);
            }

            txtScore.Text = points.ToString();
        }

        private void ShowAllMines()
        {
            for (int x = 0; x < Positions.GetLength(0); x++)
            {
                for (int y = 0; y < Positions.GetLength(1); y++)
                {
                    if (Positions[x, y] == 10)
                        ButtonList[x, y].Image = Nhom8_LaptrinhGameMinesweeper_9301.Properties.Resources.mine;
                }
            }
        }

        int points = 0;
        private void BtnMouseUp(object sender, MouseEventArgs e)
        {
            int flag = Convert.ToInt32(txtFlag.Text);
            if (e.Button == MouseButtons.Right)
            {
                Button btn = (Button)sender;
                if (btn.Image == null && btn.Text == "" && flag > 0)
                {
                    btn.Image = Nhom8_LaptrinhGameMinesweeper_9301.Properties.Resources.flag;
                    btn.Click -= BtnClick;
                    flag--;
                }
                else if (btn.Image != null)
                {
                    btn.Image = null;
                    btn.Click += BtnClick;
                    flag++;
                }
                txtFlag.Text = flag.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}