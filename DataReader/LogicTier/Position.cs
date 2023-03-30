using System;
using DataTier;

namespace LogicTier
{
    public class Position
    {
       private Data _data;

       public Position(Data data)
        {
            _data = data;
        }

        public string FullName
        {
            get { return _data.FullName; }
            set { _data.FullName = value; }
        }

        public string JobPosition
        {
            get { return _data.JobPosition; }
            set { _data.JobPosition = value; }
        } 

        public string Departament
        {
            get { return _data.Departament; }
            set { _data.Departament = value; }
        }

        public double Salary
        {
            get { return _data.Salary; }
            set { _data.Salary = value; }
        }

        public string DataList
        {
            get
            {
                return _data.FullName;
            }
        }
    }
}
