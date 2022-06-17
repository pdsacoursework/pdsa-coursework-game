using PDSACourseWork.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDSACourseWork.UI
{
    public partial class ShortestPathForm : Form
    {
        public ShortestPathForm()
        {
            InitializeComponent();
        }


        public static String[] vers = new String[10];
        public static String[] pathindexs = new String[10];
        public static int[] answerdistence = new int[10];
        public static int currentcityID;
        public static int x = 0;
        public static String[] parentTovertex = new String[100];

        public static String[] answerPaths = new String[12];
        public static string[] ABCMapping = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" };






        public class DijkstrasAlgorithm
        {

            private static readonly int NO_PARENT = -1;

            // Function that implements Dijkstra's
            // single source shortest path
            // algorithm for a graph represented
            // using adjacency matrix
            // representation
            public static void dijkstra(int[,] adjacencyMatrix,
                                                int startVertex)
            {
                int nVertices = adjacencyMatrix.GetLength(0);

                // shortestDistances[i] will hold the
                // shortest distance from src to i
                int[] shortestDistances = new int[nVertices];

                // added[i] will true if vertex i is
                // included / in shortest path tree
                // or shortest distance from src to
                // i is finalized
                bool[] added = new bool[nVertices];

                // Initialize all distances as
                // INFINITE and added[] as false
                for (int vertexIndex = 0; vertexIndex < nVertices;
                                                    vertexIndex++)
                {
                    shortestDistances[vertexIndex] = int.MaxValue;
                    added[vertexIndex] = false;
                }

                // Distance of source vertex from
                // itself is always 0
                shortestDistances[startVertex] = 0;

                // Parent array to store shortest
                // path tree
                int[] parents = new int[nVertices];

                // The starting vertex does not
                // have a parent
                parents[startVertex] = NO_PARENT;

                // Find shortest path for all
                // vertices
                for (int i = 1; i < nVertices; i++)
                {

                    // Pick the minimum distance vertex
                    // from the set of vertices not yet
                    // processed. nearestVertex is
                    // always equal to startNode in
                    // first iteration.
                    int nearestVertex = -1;
                    int shortestDistance = int.MaxValue;
                    for (int vertexIndex = 0;
                            vertexIndex < nVertices;
                            vertexIndex++)
                    {
                        if (!added[vertexIndex] &&
                            shortestDistances[vertexIndex] <
                            shortestDistance)
                        {
                            nearestVertex = vertexIndex;
                            shortestDistance = shortestDistances[vertexIndex];
                        }
                    }

                    // Mark the picked vertex as
                    // processed
                    added[nearestVertex] = true;

                    // Update dist value of the
                    // adjacent vertices of the
                    // picked vertex.
                    for (int vertexIndex = 0;
                            vertexIndex < nVertices;
                            vertexIndex++)
                    {
                        int edgeDistance = adjacencyMatrix[nearestVertex, vertexIndex];

                        if (edgeDistance > 0
                            && ((shortestDistance + edgeDistance) <
                                shortestDistances[vertexIndex]))
                        {
                            parents[vertexIndex] = nearestVertex;
                            shortestDistances[vertexIndex] = shortestDistance +
                                                            edgeDistance;
                        }
                    }
                }

                printSolution(startVertex, shortestDistances, parents);
            }

            static void printSolution(int startVertex,int[] distances,int[] parents)
            {
                int nVertices = distances.Length;
                Console.Write("Vertex\t Distance\tPath");

                for (int vertexIndex = 0; vertexIndex < nVertices; vertexIndex++)
                {
                    if (vertexIndex != startVertex)
                    {
                        currentcityID = startVertex;
                        parentTovertex[vertexIndex] = ABCMapping[startVertex] + " -> " + ABCMapping[vertexIndex];
                        answerdistence[vertexIndex] = distances[vertexIndex];
                        Console.Write("\n" + startVertex + " -> ");
                        Console.Write(vertexIndex + " \t\t ");
                        Console.Write(distances[vertexIndex] + "\t\t");
                        printPath(vertexIndex, parents);
                    }
                    else
                    {
                        x = x + 1;
                        answerPaths[vertexIndex + 1] = ABCMapping[vertexIndex];
                        parentTovertex[vertexIndex] = ABCMapping[startVertex] + " -> " + ABCMapping[vertexIndex];
                    }
                }
            }

            // Function to print shortest path
            // from source to currentVertex
            // using parents array
            private static void printPath(int currentVertex, int[] parents)
            {

                try
                {
                    // Base case : Source node has
                    // been processed
                    if (currentVertex == NO_PARENT)

                    {
                        x = x + 1;
                        return;
                    }
                    printPath(parents[currentVertex], parents);
                    Console.Write(currentVertex + " ");
                    answerPaths[x] = answerPaths[x] + ABCMapping[currentVertex];
                }
                catch(IndexOutOfRangeException e)
                {

                }

                
            }

        }




        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click_2(object sender, EventArgs e)
        {


            label1.BackColor = Color.Red;
            label15.BackColor = Color.Red;
            label16.BackColor = Color.Red;
            label17.BackColor = Color.Red;
            label18.BackColor = Color.Red;
            label19.BackColor = Color.Red;
            label20.BackColor = Color.Red;
            label21.BackColor = Color.Red;
            label22.BackColor = Color.Red;
            label23.BackColor = Color.Red;

            label24.BackColor = Color.Red;
            label25.BackColor = Color.Red;
            label26.BackColor = Color.Red;
            label27.BackColor = Color.Red;
            label28.BackColor = Color.Red;
            label29.BackColor = Color.Red;
            label30.BackColor = Color.Red;
            label31.BackColor = Color.Red;
            label32.BackColor = Color.Red;
            label33.BackColor = Color.Red;


            if (textBox1.Text != answerPaths[1])
            { label1.Text = answerPaths[1]; }
            else { label1.Text = "Correct!"; label1.BackColor = Color.Aqua; }
            if (textBox2.Text != answerPaths[2])
            { label15.Text = answerPaths[2]; }
            else { label15.Text = "Correct!"; label15.BackColor = Color.Aqua; }
            if (textBox3.Text != answerPaths[3])
            { label16.Text = answerPaths[3]; }
            else { label16.Text = "Correct!"; label16.BackColor = Color.Aqua; }
            if (textBox4.Text != answerPaths[4])
            { label17.Text = answerPaths[4]; }
            else { label17.Text = "Correct!"; label17.BackColor = Color.Aqua; }
            if (textBox5.Text != answerPaths[5])
            { label18.Text = answerPaths[5]; }
            else { label18.Text = "Correct!"; label18.BackColor = Color.Aqua; }
            if (textBox6.Text != answerPaths[6])
            { label19.Text = answerPaths[6]; }
            else { label19.Text = "Correct!"; label19.BackColor = Color.Aqua; }
            if (textBox7.Text != answerPaths[7])
            { label20.Text = answerPaths[7]; }
            else { label20.Text = "Correct!"; label20.BackColor = Color.Aqua; }
            if (textBox8.Text != answerPaths[8])
            { label21.Text = answerPaths[8]; }
            else { label21.Text = "Correct!"; label21.BackColor = Color.Aqua; }
            if (textBox9.Text != answerPaths[9])
            { label22.Text = answerPaths[9]; }
            else { label22.Text = "Correct!"; label22.BackColor = Color.Aqua; }
            if (textBox10.Text != answerPaths[10])
            { label23.Text = answerPaths[10]; }
            else { label23.Text = "Correct!"; label23.BackColor = Color.Aqua; }

            if (textBox11.Text != answerdistence[0].ToString())
            { label24.Text = answerdistence[0].ToString(); }
            if (textBox12.Text != answerdistence[1].ToString())
            { label25.Text = answerdistence[1].ToString(); }
            if (textBox13.Text != answerdistence[2].ToString())
            { label26.Text = answerdistence[2].ToString(); }
            if (textBox14.Text != answerdistence[3].ToString())
            { label27.Text = answerdistence[3].ToString(); }
            if (textBox15.Text != answerdistence[4].ToString())
            { label28.Text = answerdistence[4].ToString(); }
            if (textBox16.Text != answerdistence[5].ToString())
            { label29.Text = answerdistence[5].ToString(); }
            if (textBox17.Text != answerdistence[6].ToString())
            { label30.Text = answerdistence[6].ToString(); }
            if (textBox18.Text != answerdistence[7].ToString())
            { label31.Text = answerdistence[7].ToString(); }
            if (textBox19.Text != answerdistence[8].ToString())
            { label32.Text = answerdistence[8].ToString(); }
            if (textBox20.Text != answerdistence[9].ToString())
            { label33.Text = answerdistence[9].ToString(); }




            label1.Font = new Font("Arial", 12, FontStyle.Bold);
            label15.Font = new Font("Arial", 12, FontStyle.Bold);
            label16.Font = new Font("Arial", 12, FontStyle.Bold);
            label17.Font = new Font("Arial", 12, FontStyle.Bold);
            label18.Font = new Font("Arial", 12, FontStyle.Bold);
            label19.Font = new Font("Arial", 12, FontStyle.Bold);
            label20.Font = new Font("Arial", 12, FontStyle.Bold);
            label21.Font = new Font("Arial", 12, FontStyle.Bold);
            label22.Font = new Font("Arial", 12, FontStyle.Bold);
            label23.Font = new Font("Arial", 12, FontStyle.Bold);

            label24.Font = new Font("Arial", 12, FontStyle.Bold);
            label25.Font = new Font("Arial", 12, FontStyle.Bold);
            label26.Font = new Font("Arial", 12, FontStyle.Bold);
            label27.Font = new Font("Arial", 12, FontStyle.Bold);
            label28.Font = new Font("Arial", 12, FontStyle.Bold);
            label29.Font = new Font("Arial", 12, FontStyle.Bold);
            label30.Font = new Font("Arial", 12, FontStyle.Bold);
            label31.Font = new Font("Arial", 12, FontStyle.Bold);
            label32.Font = new Font("Arial", 12, FontStyle.Bold);
            label33.Font = new Font("Arial", 12, FontStyle.Bold);

            if(textBox21.Text == "")
            {
                MessageBox.Show("Please enter the player name", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (label1.Text == "Correct" && label15.Text == "Correct" && label16.Text == "Correct" && label17.Text == "Correct" && label18.Text == "Correct" && label19.Text == "Correct" && label20.Text == "Correct" && label21.Text == "Correct" && label22.Text == "Correct" && label23.Text == "Correct")
            {


                ShoertestPathService shortestPathService = new ShoertestPathService();
                shortestPathService.InsertShortestPathUser(textBox21.Text, string.Join(".", answerPaths));

                MessageBox.Show("You are the winner", "congratulations");

            }



        }

        private void restart_Click_1(object sender, EventArgs e)
        {
            // this.Controls.Clear();
            //this.InitializeComponent();
            //load();

           

            MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];
            Panel panel = (Panel)mainForm.Controls["ScreenPanel"];
            panel.Controls.Clear();

            var shortPathForm = new ShortestPathForm
            {
                TopLevel = false
            };

            panel.Controls.Add(shortPathForm);
            shortPathForm.Show();
        }

        private void ShortestPathForm_Load(object sender, EventArgs e)
        {


            //this.Controls.Clear();
            // this.InitializeComponent();
            load();



        }
        public void load()
        {

            DijkstrasAlgorithm objDije = new DijkstrasAlgorithm();


            int[] evenNums = new int[60];

            Random rnd = new Random();

            for (int i = 0; i < 44; i++)
            {
                evenNums[i] = rnd.Next(5, 50);

            }
            evenNums[0] = 0;

            int[,] adjacencyMatrix = {{ evenNums[0], evenNums[1], evenNums[2], evenNums[4], evenNums[7], evenNums[11],evenNums[16], evenNums[22],evenNums[29], evenNums[37]},
                                    {  evenNums[1], evenNums[0], evenNums[3], evenNums[5], evenNums[8], evenNums[12],evenNums[17], evenNums[23],evenNums[30], evenNums[38]},
                                    {  evenNums[2], evenNums[3], evenNums[0], evenNums[6], evenNums[9], evenNums[13],evenNums[18], evenNums[24],evenNums[31], evenNums[39]},
                                    {  evenNums[4], evenNums[5], evenNums[6], evenNums[0], evenNums[10],evenNums[14],evenNums[19], evenNums[25],evenNums[32], evenNums[40]},
                                    {  evenNums[7], evenNums[8], evenNums[9], evenNums[10],evenNums[0], evenNums[15],evenNums[20], evenNums[26],evenNums[33], evenNums[41]},
                                    {  evenNums[11],evenNums[12],evenNums[13],evenNums[14],evenNums[15],evenNums[0], evenNums[21], evenNums[27],evenNums[34], evenNums[42]},
                                    {  evenNums[16],evenNums[17],evenNums[18],evenNums[19],evenNums[20],evenNums[21],evenNums[0],  evenNums[28],evenNums[35], evenNums[43]},
                                    {  evenNums[22],evenNums[23],evenNums[24],evenNums[25],evenNums[26],evenNums[27],evenNums[28], evenNums[0], evenNums[36], evenNums[44]},
                                    {  evenNums[29],evenNums[30],evenNums[31],evenNums[32],evenNums[33],evenNums[34],evenNums[35], evenNums[36],evenNums[0],  evenNums[45]},
                                    {  evenNums[37],evenNums[38],evenNums[39],evenNums[40],evenNums[41],evenNums[42],evenNums[43], evenNums[44],evenNums[45], evenNums[0]},};



            int[,] adjacencyMatrix2 =  { {  evenNums[0],evenNums[0],evenNums[1],evenNums[2],evenNums[4],evenNums[7],evenNums[11],evenNums[16], evenNums[22],evenNums[29], evenNums[37]},
                                    {  evenNums[0],evenNums[1],evenNums[0],evenNums[3],evenNums[5],evenNums[8],evenNums[12],evenNums[17], evenNums[23],evenNums[30], evenNums[38]},
                                    {evenNums[0],  evenNums[2],evenNums[3],evenNums[0],evenNums[6],evenNums[9],evenNums[13],evenNums[18], evenNums[24],evenNums[31], evenNums[39]},
                                    { evenNums[0], evenNums[4],evenNums[5],evenNums[6],evenNums[0],evenNums[10],evenNums[14],evenNums[19], evenNums[25],evenNums[32], evenNums[40]},
                                    { evenNums[0], evenNums[7],evenNums[8],evenNums[9],evenNums[10],evenNums[0],evenNums[15],evenNums[20], evenNums[26],evenNums[33], evenNums[41]},
                                    { evenNums[0], evenNums[11],evenNums[12],evenNums[13],evenNums[14],evenNums[15],evenNums[0],evenNums[21], evenNums[27],evenNums[34], evenNums[42]},
                                    { evenNums[0], evenNums[16],evenNums[17],evenNums[18],evenNums[19],evenNums[20],evenNums[21],evenNums[0], evenNums[28],evenNums[35], evenNums[43]},
                                    { evenNums[0], evenNums[22],evenNums[23],evenNums[24],evenNums[25],evenNums[26],evenNums[27],evenNums[28], evenNums[0],evenNums[36], evenNums[14]},
                                    {evenNums[0],  evenNums[29],evenNums[30],evenNums[31],evenNums[32],evenNums[33],evenNums[34],evenNums[35], evenNums[36],evenNums[0], evenNums[15]},
                                    { evenNums[0], evenNums[37],evenNums[38],evenNums[39],evenNums[40],evenNums[41],evenNums[42],evenNums[43], evenNums[14],evenNums[15], evenNums[0]},};
            DijkstrasAlgorithm.dijkstra(adjacencyMatrix, rnd.Next(0, 9));



            int height = adjacencyMatrix2.GetLength(0);
            int width = adjacencyMatrix2.GetLength(1);

            this.dataGridView1.ColumnCount = width;

            for (int r = 0; r < height; r++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(this.dataGridView1);

                for (int c = 0; c < width; c++)
                {
                    row.Cells[c].Value = adjacencyMatrix2[r, c];
                }

                this.dataGridView1.Rows.Add(row);
            }

            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {


                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            dataGridView1.Columns[0].HeaderText = "City";
            dataGridView1.Columns[1].HeaderText = "A";
            dataGridView1.Columns[2].HeaderText = "B";
            dataGridView1.Columns[3].HeaderText = "C";
            dataGridView1.Columns[4].HeaderText = "D";
            dataGridView1.Columns[5].HeaderText = "E";
            dataGridView1.Columns[6].HeaderText = "F";
            dataGridView1.Columns[7].HeaderText = "G";
            dataGridView1.Columns[8].HeaderText = "H";
            dataGridView1.Columns[9].HeaderText = "I";
            dataGridView1.Columns[10].HeaderText = "J";
            this.dataGridView1.Rows[0].Cells[0].Value = "A";
            this.dataGridView1.Rows[1].Cells[0].Value = "B";
            this.dataGridView1.Rows[2].Cells[0].Value = "C";
            this.dataGridView1.Rows[3].Cells[0].Value = "D";
            this.dataGridView1.Rows[4].Cells[0].Value = "E";
            this.dataGridView1.Rows[5].Cells[0].Value = "F";
            this.dataGridView1.Rows[6].Cells[0].Value = "G";
            this.dataGridView1.Rows[7].Cells[0].Value = "H";
            this.dataGridView1.Rows[8].Cells[0].Value = "I";
            this.dataGridView1.Rows[9].Cells[0].Value = "J";



            dataGridView1.Rows[0].Cells[1].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[1].Cells[2].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[2].Cells[3].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[3].Cells[4].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[4].Cells[5].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[5].Cells[6].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[6].Cells[7].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[7].Cells[8].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[8].Cells[9].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.Rows[9].Cells[10].Style.BackColor = Color.FromArgb(54, 215, 183);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.AllowUserToAddRows = false;


            label2.Text = parentTovertex[0];
            label5.Text = parentTovertex[1];
            label6.Text = parentTovertex[2];
            label7.Text = parentTovertex[3];
            label8.Text = parentTovertex[4];
            label9.Text = parentTovertex[5];
            label10.Text = parentTovertex[6];
            label11.Text = parentTovertex[7];
            label12.Text = parentTovertex[8];
            label13.Text = parentTovertex[9];
        }
    }
}