using System.Data;
using PDSACourseWork.Helper;
using PDSACourseWork.Service;

namespace PDSACourseWork.UI
{
    public partial class ChessBoardForm : Form
    {
        DataTable dt = new DataTable();
        int count = 0;
        int N = 8;

        public ChessBoardForm()
        {
            InitializeComponent();
        }

        private void ChessBoardForm_Load(object sender, EventArgs e)
        {
            StatusLabel.Visible = false;

            dt.Columns.Add("Possibilities", typeof(String));

            const int MaxN = 20;
            int[] M = new int[MaxN]; // the array of placements
            int p; // queen number
            int k; // number of placement options

            //// get the number of queens
            //int N = 8;


            // THE ALGORITHM FOR GENERATING PLACEMENTS
            // initial settings
            p = 1;
            M[p] = 0;
            M[0] = 0;
            k = 0;

            // the cycle of placements search
            while (p > 0) // if p==0, then exit from the loop
            {
                M[p] = M[p] + 1;
                if (p == N) // last item
                {
                    if (M[p] > N)
                    {
                        while (M[p] > N) p--; // rewind
                    }
                    else
                    {
                        if (!Strike(M, p))
                        {
                            // fix placement
                            AddToDataTable(M, N);
                            k++;
                            p--;
                        }
                    }
                }
                else // not the last item
                {
                    if (M[p] > N)
                    {
                        while (M[p] > N) p--; // rewind
                    }
                    else
                    {
                        if (!Strike(M, p)) // If M[p] does not overlap with previous M[1], M[2], ..., M[p-1]
                        {
                            p++; // go to the placement of the next queen
                            M[p] = 0;
                        }
                    }
                }
            }

            EightQueenService eightQueenService = new();
            eightQueenService.InsertAllPossibilities(dt);
        }

        #region ChechBox Click Event

        private void CheckBox1_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox2_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox3_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox4_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox5_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox6_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox7_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox8_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox9_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox10_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox11_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox12_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox13_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox14_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox15_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox16_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox17_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox18_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox19_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox20_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox21_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox22_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox23_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox24_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox25_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox26_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox27_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox28_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox29_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox30_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox31_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox32_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox33_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox34_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox35_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox36_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox37_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox38_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox39_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox40_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox41_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox42_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox43_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox44_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox45_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox46_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox47_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox48_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox49_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox50_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox51_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox52_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox53_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox54_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox55_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox56_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox57_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox58_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox59_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox60_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox61_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox62_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox63_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        private void CheckBox64_Click(object sender, EventArgs e) => SetCheckBoxImage((CheckBox)sender);

        #endregion

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool isCorrect = false;

            string playerName = PlayerNameTextBox.Text;

            if (count == 8)
            {
                if (!string.IsNullOrEmpty(playerName) && !string.IsNullOrWhiteSpace(playerName))
                {
                    List<string> possitionList = new();

                    foreach (Control control in Controls)
                    {
                        if (control is CheckBox)
                        {
                            CheckBox checkbox = (CheckBox)control;

                            if (checkbox.Checked == true)
                            {
                                possitionList.Add(checkbox.AccessibleName);
                            }
                        }
                    }

                    possitionList = possitionList.OrderBy(x => x).ToList();

                    EightQueenService eightQueenService = new();
                    List<string> allPossibilities = eightQueenService.GetAllPossibilities();

                    isCorrect = EightQueenHelper.CompareLists(possitionList, allPossibilities);

                    if (isCorrect == true)
                    {
                        List<string> winnerPossibilities = eightQueenService.GetWinnerPossibilities();

                        if (winnerPossibilities.Count < 92)
                        {
                            bool isAnswerTaken = EightQueenHelper.CompareLists(possitionList, winnerPossibilities);

                            if (isAnswerTaken == false)
                            {
                                StatusLabel.Text = "You are a winner!";
                                StatusLabel.ForeColor = Color.FromArgb(46, 204, 113);
                                StatusLabel.Visible = true;

                                string answer = string.Empty;

                                for (int i = 0; i < possitionList.Count; i++)
                                {
                                    answer += possitionList[i] + (i == 7 ? "" : "-");
                                }

                                int success = eightQueenService.SaveAnswer(PlayerNameTextBox.Text, answer);

                                if (success > 0)
                                {
                                    MessageBox.Show("Answer save successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                            else
                            {
                                StatusLabel.Text = "Sorry answer already taken. \n Please try again!";
                                StatusLabel.ForeColor = Color.FromArgb(142, 68, 173);
                                StatusLabel.Visible = true;
                            }
                        }
                        else
                        {
                            StatusLabel.Text = "You are a winner!";
                            StatusLabel.ForeColor = Color.FromArgb(46, 204, 113);
                            StatusLabel.Visible = true;

                            string answer = string.Empty;

                            for (int i = 0; i < possitionList.Count; i++)
                            {
                                answer += possitionList[i] + (i == 8 ? "" : "-");
                            }

                            int success = eightQueenService.SaveAnswer(PlayerNameTextBox.Text, answer);

                            if (success > 0)
                            {
                                MessageBox.Show("Answer save successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                    }
                    else
                    {
                        StatusLabel.Text = "Wrong answer! Try again!";
                        StatusLabel.ForeColor = Color.FromArgb(231, 76, 60);
                        StatusLabel.Visible = true;
                    }
                }
                else
                {
                    MessageBox.Show("Please provide a player name!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                
            }
            else
            {
                MessageBox.Show("Please place 8!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void TryAgainButton_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            Panel panel = (Panel)mainForm.Controls["ScreenPanel"];
            panel.Controls.Clear();

            var chessBoardForm = new ChessBoardForm
            {
                TopLevel = false
            };

            panel.Controls.Add(chessBoardForm);
            chessBoardForm.Show();
        }

        private void SetCheckBoxImage(CheckBox checkBox)
        {
            if (count < 8 || (count == 8 && checkBox.Checked == true))
            {
                if (checkBox.Checked != true)
                {
                    checkBox.BackgroundImage = Properties.Resources.Queen;
                    checkBox.BackgroundImageLayout = ImageLayout.Zoom;

                    checkBox.Checked = true;
                    count++;
                }
                else
                {
                    checkBox.BackgroundImage = null;

                    checkBox.Checked = false;
                    count--;
                }
            }
            else
            {
                MessageBox.Show("Only 8 queens can be place!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        // write string to datatble
        void AddToDataTable(int[] M, int N)
        {
            DataRow rw = dt.NewRow();

            // add string to data Table
            string s = "";
            for (int i = 1; i <= N; i++)
                s = s + M[i].ToString() + "," + i.ToString() + (i == 8 ? "" : "-");
            rw["Possibilities"] = s;
            dt.Rows.Add(rw);
        }

        // Checking if 2 queens are beating. It returns false if they are not beating
        bool IsStrike(int x1, int y1, int x2, int y2)
        {
            // 1. Horizontal, vertical
            // Queens beat each other if the corresponding 2 parameters match
            if ((x1 == x2) || (y1 == y2)) return true;

            // 2. Main diagonal
            int tx, ty; // additional variables

            // 2.1. Left-Up
            tx = x1 - 1; ty = y1 - 1;
            while ((tx >= 1) && (ty >= 1))
            {
                if ((tx == x2) && (ty == y2)) return true;
                tx--; ty--;
            }

            // 2.2. Right-Down
            tx = x1 + 1; ty = y1 + 1;
            while ((tx <= N) && (ty <= N))
            {
                if ((tx == x2) && (ty == y2)) return true;
                tx++; ty++;
            }

            // 3. Additional diagonal
            // 3.1. Right-Up
            tx = x1 + 1; ty = y1 - 1;
            while ((tx <= N) && (ty >= 1))
            {
                if ((tx == x2) && (ty == y2)) return true;
                tx++; ty--;
            }

            // 3.2. Left-Down
            tx = x1 - 1; ty = y1 + 1;
            while ((tx >= 1) && (ty <= N))
            {
                if ((tx == x2) && (ty == y2)) return true;
                tx--; ty++;
            }
            return false;
        }

        // Checking whether the last element M [p]is superimposed
        // with elements M[1], M[2], ..., M[p-1].
        // This function uses the IsStrike() function.
        bool Strike(int[] M, int p)
        {
            int px, py, x, y;
            int i;

            px = M[p];
            py = p;

            for (i = 1; i <= p - 1; i++)
            {
                x = M[i];
                y = i;
                if (IsStrike(x, y, px, py))
                    return true;
            }
            return false;
        }
    }
}
