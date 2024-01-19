using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace practice_course_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            UpdateGridView(DBUtils.GetDistricts());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var addDistrictForm = new AddDistrictForm();

            addDistrictForm.ShowDialog();

            UpdateGridView(DBUtils.GetDistricts());
        }

        private void UpdateGridView(IEnumerable<District> districts)
        {
            dataGridView1.Rows.Clear();

            foreach (var district in districts)
            {
                dataGridView1.Rows.Add(district.id.ToString(), district.name, district.square, (double)district.population / 1000);

            }
        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            UpdateGridView(DBUtils.GetDistricts());
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;

            UpdateGridView(DBUtils.GetDistrictsWhereName(name));
        }

        private void maxSquareBtn_Click(object sender, EventArgs e)
        {
            var districts = DBUtils.GetDistrictsWithMaxSquare();

            UpdateGridView(districts);
        }

        private void minPopulationBtn_Click(object sender, EventArgs e)
        {
            var districts = DBUtils.GetDistrictsWithMaxPopulation();

            UpdateGridView(districts);
        }

        private void avgPopulationBtn_Click(object sender, EventArgs e)
        {
            var averagePopulation = (int)(DBUtils.GetAveragePopulation()/ 1000);

            MessageBox.Show(string.Format("Среднее население: {0} тыс. чел.", averagePopulation.ToString()));
        }

        private void deleteDtn_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.SelectedRows[0];

                DBUtils.DeleteDistrict(int.Parse(row.Cells[0].Value.ToString()));

                UpdateGridView(DBUtils.GetDistricts());
            }
            catch(Exception error)
            {
                MessageBox.Show("Необходимо выбрать запись");
                throw error;
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var row = dataGridView1.SelectedRows[0];


                var district = new District() { id = int.Parse(row.Cells[0].Value.ToString()), name= row.Cells[1].Value.ToString(),
                    square=double.Parse(row.Cells[2].Value.ToString()), population=(int)(double.Parse(row.Cells[2].Value.ToString()) * 1000)
                };

                var updateDistrictForm = new UpdateDistrictForm(district);

                updateDistrictForm.ShowDialog();

                UpdateGridView(DBUtils.GetDistricts());
            }
            catch (Exception error)
            {
                MessageBox.Show("Необходимо выбрать запись");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var graphicsForm = new GraphicForm();

            graphicsForm.ShowDialog();
        }
    }
}
