using LiveCharts.Wpf;
using LiveCharts;
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
    public partial class GraphicForm : Form
    {
        public GraphicForm()
        {
            InitializeComponent();

            var districts = DBUtils.GetDistricts();

            SeriesCollection series = new SeriesCollection(); //отображение данных на график. Линии и т.д.
            ChartValues<double> zp = new ChartValues<double>(); //Значения которые будут на линии, будет создания чуть позже.
            List<string> date = new List<string>(); //здесь будут храниться значения для оси X
            foreach (var item in districts) //Заполняем коллекции
            {
                zp.Add(item.square);
                date.Add(item.name);
            }
            cartesianChart1.AxisX.Clear(); //Очищаем ось X от значений по умолчанию
            cartesianChart1.AxisX.Add(new Axis //Добавляем на ось X значения, через блок инициализатора.
            {
                Title = "Название",
                Labels = date
            });

            LineSeries line = new LineSeries(); //Создаем линию, задаем ей значения из коллекции
            line.Title = "кв.км";
            line.Values = zp;

            series.Add(line); //Добавляем линию на график
            cartesianChart1.Series = series; //Отрисовываем график в интерфейсе

            SeriesCollection series2 = new SeriesCollection(); //отображение данных на график. Линии и т.д.
            ChartValues<double> zp2 = new ChartValues<double>(); //Значения которые будут на линии, будет создания чуть позже.
            List<string> date2 = new List<string>(); //здесь будут храниться значения для оси X
            foreach (var item in districts) //Заполняем коллекции
            {
                zp2.Add(item.population);
                date2.Add(item.name);
            }
            cartesianChart2.AxisX.Clear(); //Очищаем ось X от значений по умолчанию
            cartesianChart2.AxisX.Add(new Axis //Добавляем на ось X значения, через блок инициализатора.
            {
                Title = "Название",
                Labels = date2
            });

            LineSeries line2 = new LineSeries(); //Создаем линию, задаем ей значения из коллекции
            line2.Title = "тыс чел";
            line2.Values = zp2;

            series2.Add(line2); //Добавляем линию на график
            cartesianChart2.Series = series2; //Отрисовываем график в интерфейсе
        }
    }
}
