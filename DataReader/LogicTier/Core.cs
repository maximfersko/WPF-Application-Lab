using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTier;
using System.IO;
using System.Windows;

namespace LogicTier
{
    public class Core
    {
        List<Data> _tmp = new List<Data>();
        List<Position> _list = new List<Position>();
        private double _TotalSalary = 0;
        private int _ProfessorCount = 0;

        public Core(String path, bool flag)
        {
            _tmp = DataReader.GetDataFromFile(path);
            getCalc(path, flag);
             
            foreach (var elm in _tmp)
            {
               _list.Add(new Position(elm));
            }
        }
        private void getCalc(String path, bool flag)
        {
            if (flag)
            {
                if (File.Exists(path))
                {
                    Console.WriteLine(path);
                    var lines = File.ReadAllLines(path);

                    foreach (var line in lines)
                    {
                        var parts = line.Split('|');
                        var salary = double.Parse(parts[3].Trim());
                        _TotalSalary += salary;
                        if (parts[1].Trim() == "профессор")
                        {
                            _ProfessorCount++;
                        }
                    }
                }
                
            }
        }

        public List<Position> DataList
        {
            get { return _list; }
        }

        public double TotalWages
        {
            get
            {
                return _TotalSalary;
            }
        }

        public int TotalCount
        {
            get
            {
                return _ProfessorCount;
            }
        }

        
    }
}
