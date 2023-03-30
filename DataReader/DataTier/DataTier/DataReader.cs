using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;

namespace DataTier
{
    public class DataReader { 

        public static List<Data> GetDataFromFile(String path)
        {
            List<Data> data = new List<Data>();
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split('|');
                    if (values.Length == 4)
                    {
                        data.Add(new Data()
                        {
                            FullName = values[0].Trim(),
                            JobPosition = values[1].Trim(),
                            Departament = values[2].Trim(),
                            Salary = double.Parse(values[3].Trim())
                        });
                    }
                }
            }
            return data;
        }

   
    }
}

