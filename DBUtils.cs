using CsvHelper;
using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace practice_course_2
{
    internal static class DBUtils
    {
        const string disctrictsTable = "districts.csv";
        static public IEnumerable<District> GetDistricts()
        {
            List<District> districts = new List<District>();

            try
            {
                using (var reader = new StreamReader(disctrictsTable))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    districts = csv.GetRecords<District>().ToList();
                }

                return districts;
            }
            catch(Exception e)
            {
                MessageBox.Show("Ошибка при получении округов");

                return districts;
            }
        }

        static public IEnumerable<District> GetDistrictsWhereName(string name)
        {
            var districts = GetDistricts();

            return districts.Where(district => district.name == name);
        }

        static public IEnumerable<District> GetDistrictsWithMaxSquare()
        {
            var districts = GetDistricts();

            var maxSquare = districts.Max(district => district.square);

            return districts.Where(district => district.square == maxSquare);
        }

        static public IEnumerable<District> GetDistrictsWithMaxPopulation()
        {
            var districts = GetDistricts();

            var minPopulation = districts.Max(district => district.population);

            return districts.Where(district => district.population == minPopulation);
        }

        static public double GetAveragePopulation()
        {
            var districts = GetDistricts();

            return districts.Average(district => district.population);
        }

        static public void AddDistrict(District district)
        {
            try
            {
                var districts = GetDistricts().ToList();

                district.id = 1;

                var filemode = FileMode.Create;

                if (districts.Count() != 0)
                {
                    district.id = districts.Last().id + 1;
                    filemode = FileMode.Append;
                }

                var config = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = false,
                };

                using (var stream = File.Open(disctrictsTable, FileMode.Create))
                using (var writer = new StreamWriter(stream))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    districts.Add(district);
                    csv.WriteRecords(districts);
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Ошибка при добавлении округа");
            }
        }

        static public void DeleteDistrict(int id)
        {
            try
            {
                List<District> disctricts;

                using (var reader = new StreamReader(disctrictsTable))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    disctricts = csv.GetRecords<District>().ToList();

                    for (int i = 0; i < disctricts.Count; ++i)
                    {
                        if (disctricts[i].id == id)
                        {
                            disctricts.RemoveAt(i);
                        }
                    }
                }

                using (var writer = new StreamWriter(disctrictsTable))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(disctricts);
                }

            }
            catch(Exception e)
            {
                MessageBox.Show("Ошибка при удалении округа");
            }
        }

        static public void UpdateDistrict(District district)
        {
            try
            {
                List<District> disctricts;

                using (var reader = new StreamReader(disctrictsTable))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    disctricts = csv.GetRecords<District>().ToList();

                    for (int i = 0; i < disctricts.Count; ++i)
                    {
                        if (disctricts[i].id == district.id)
                        {
                            disctricts[i] = district;
                        }
                    }
                }

                using (var writer = new StreamWriter(disctrictsTable))
                using (var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(disctricts);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("Ошибка при обновлении округа");
            }
        }
    }
}
