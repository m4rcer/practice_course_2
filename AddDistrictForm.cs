using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice_course_2
{
    public partial class AddDistrictForm : Form
    {
        public AddDistrictForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name;
            double square;
            int population;

            try
            {
                name = nameTextBox.Text;

                if (name.Length == 0)
                    throw new Exception();
            }
            catch(Exception error)
            {
                MessageBox.Show("Название заполнено неправильно");
                return;
            }

            try
            {
                square = double.Parse(squareTextBox.Text);

                if(square <= 0)
                        throw new Exception();
            }
            catch (Exception error)
            {
                MessageBox.Show("Площадь заполнена неправильно");
                return;
            }

            try
            {
                var _population = double.Parse(populationTextBox.Text) * 1000;

                population = (int)_population;

                if (population <= 0)
                    throw new Exception();
            }
            catch (Exception error)
            {
                MessageBox.Show("Население заполнено неправильно");
                return;
            }

            var district = new District() { name = name, square = square, population = population };

            DBUtils.AddDistrict(district);

            this.Close();
        }
    }
}
