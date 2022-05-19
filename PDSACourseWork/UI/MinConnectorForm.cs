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
    public partial class MinConnectorForm : Form
    {
        public MinConnectorForm()
        {
            InitializeComponent();
        }
        public virtual void Prim(int[,] G, int V, int startCity)
        {

            int INF = 9999999;

            int no_edge; // number of edge

            // create a array to track selected vertex
            // selected will become true otherwise false
            bool[] selected = new bool[V];

            // set selected false initially
            Array.Fill(selected, false);

            // set number of edge to 0
            no_edge = 0;

            // the number of egde in minimum spanning tree will be
            // always less than (V -1), where V is number of vertices in
            // graph

            // choose 0th vertex and make it true
            selected[startCity] = true;

            // print for edge and weight
            Console.WriteLine("Edge : Weight");

            while (no_edge < V - 1)
            {
                // For every vertex in the set S, find the all adjacent vertices
                // , calculate the distance from the vertex selected at step 1.
                // if the vertex is already in the set S, discard it otherwise
                // choose another vertex nearest to selected vertex at step 1.

                int min = INF;
                int x = 0; // row number
                int y = 0; // col number

                for (int i = 0; i < V; i++)
                {
                    if (selected[i] == true)
                    {
                        for (int j = 0; j < V; j++)
                        {
                            // not in selected and there is an edge
                            if (!selected[j] && G[i,j] != 0)
                            {
                                if (min > G[i,j])
                                {
                                    min = G[i,j];
                                    x = i;
                                    y = j;
                                }
                            }
                        }
                    }
                }
                string AllVertexes = "ABCDEFGHIJ";
                char fromVertex = AllVertexes[x];
                char toVertex = AllVertexes[y];

                string[] strRow = new string[] { "City "+fromVertex.ToString(), "City "+toVertex.ToString(), G[x,y].ToString() };

                //adding rows in the datagridview
                dataGridView3.Rows.Add(strRow);

                //Console.WriteLine(fromVertex + " - " + toVertex + " :  " + G[x][y]);
                selected[y] = true;
                no_edge++;
            }
        }

        int[,] disArray;
        String alphabet = "ABCDEFGHIJ";

        String cityFrom = "";
        int selectedCity = 0;



        private void MinConnectorForm_Load(object sender, EventArgs e)
        {
            loadData();
            //int V = 10;
            //Prim(disArray, V, selectedCity);
        }

        public void loadData()
        {
            dataGridView3.Visible = false;
            label6.Visible = false;
            dataGridView3.Rows.Clear();
            dataGridView3.Columns.Clear();

            disArray = new int[10, 10];

            int randNo;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Random rnd = new Random();
                    if (i == j)
                    {
                        disArray[i, j] = 0;
                    }
                    else
                    {
                        randNo = rnd.Next(5, 50);
                        disArray[i, j] = randNo;
                        disArray[j, i] = randNo;


                    }

                }
            }

            Random randCity = new Random();

            int randVal = randCity.Next(0, 9);

            selectedCity = randVal;
            labelSelectedCity.Text = "City " + alphabet[randVal].ToString();
            label3.Text = "Please select two cities you would choose to travell : ";

            //cityFrom = labelSelectedCity.Text;

            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();


            dataGridView1.ColumnCount = 11;
            //Set the columns name
            dataGridView1.Columns[0].Name = "City";
            dataGridView1.Columns[1].Name = "A";
            dataGridView1.Columns[2].Name = "B";
            dataGridView1.Columns[3].Name = "C";
            dataGridView1.Columns[4].Name = "D";
            dataGridView1.Columns[5].Name = "E";
            dataGridView1.Columns[6].Name = "F";
            dataGridView1.Columns[7].Name = "G";
            dataGridView1.Columns[8].Name = "H";
            dataGridView1.Columns[9].Name = "I";
            dataGridView1.Columns[10].Name = "J";






            for (int i = 0; i < 10; i++)
            {

                string[] row = new string[] { alphabet[i].ToString(), disArray[i, 0].ToString(), disArray[i, 1].ToString(), disArray[i, 2].ToString(), disArray[i, 3].ToString(), disArray[i, 4].ToString(), disArray[i, 5].ToString(), disArray[i, 6].ToString(), disArray[i, 7].ToString(), disArray[i, 8].ToString(), disArray[i, 9].ToString() };

                //adding rows in the datagridview
                dataGridView1.Rows.Add(row);
            }

            dataGridView2.Rows.Clear();
            dataGridView2.Columns.Clear();

            dataGridView2.ColumnCount = 3;
            //Set the columns name
            dataGridView2.Columns[0].Name = "City From";
            dataGridView2.Columns[1].Name = "City To";
            dataGridView2.Columns[2].Name = "Distance";


            //Set the columns name
            dataGridView3.ColumnCount = 3;
            dataGridView3.Columns[0].Name = "From";
            dataGridView3.Columns[1].Name = "To";
            dataGridView3.Columns[2].Name = "Distance";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                MessageBox.Show("Please re-check the 2 cities");
            }
            else
            {
                string[] selectedCityRow = new string[] { comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString(), disArray[Int16.Parse(comboBox1.SelectedIndex.ToString()), Int16.Parse(comboBox2.SelectedIndex.ToString())].ToString() };

                //adding rows in the datagridview
                dataGridView2.Rows.Add(selectedCityRow);
                //comboBox1.SelectedValue.ToString();

                //cityFrom = comboBox1.SelectedItem.ToString();
                comboBox1.SelectedItem = comboBox2.SelectedItem;
                //comboBox1.Text = "";
                comboBox2.Text = "";
            }

            

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // number of vertices in grapj


            int V = 10;
            Prim(disArray, V, selectedCity);

            //label6.Text = dataGridView3.Rows[0].Cells[0].Value.ToString();

            if(txtName.Text == "")
            {
                MessageBox.Show("Please enter the player name");
            }
            else
            {
                if (Int16.Parse(dataGridView3.RowCount.ToString()) == Int16.Parse(dataGridView2.RowCount.ToString()))
                {
                    int status = 1;
                    for (int x = 0; x < Int16.Parse(dataGridView3.RowCount.ToString()) - 1; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {

                            if (dataGridView3.Rows[x].Cells[y].Value.ToString() == dataGridView2.Rows[x].Cells[y].Value.ToString())
                            {

                            }
                            else
                            {
                                status = 0;
                                break;
                            }
                        }
                    }
                    if (status == 0)
                    {
                        MessageBox.Show("Submitted Anwser is Wrong");
                        dataGridView3.Visible = true;
                        label6.Visible = true;

                    }
                    else
                    {
                        
                        dataGridView3.Visible = false;
                        label6.Visible = false;

                        MinConnectorService minConnectorService = new MinConnectorService();
                        minConnectorService.InsertWinnerUser(txtName.Text);

                        for (int x = 0; x < Int16.Parse(dataGridView3.RowCount.ToString()) - 1; x++)
                        {
                            minConnectorService.InsertWinnerConnectorPaths(dataGridView3.Rows[x].Cells[0].Value.ToString(), dataGridView3.Rows[x].Cells[1].Value.ToString(), Int16.Parse(dataGridView3.Rows[x].Cells[2].Value.ToString()));
                        }

                        MessageBox.Show("Answer is Correct");
                        //InsertWinnerConnectorPaths
                    }
                }
                else
                {
                    MessageBox.Show("Submitted Anwser is Wrong");
                    dataGridView3.Visible = true;
                    label6.Visible = true;
                }

            }





        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
