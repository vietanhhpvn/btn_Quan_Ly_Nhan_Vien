using BTL_QuanLyNhanVien.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_QuanLyNhanVien
{
    public class ListEmployee
    {
        public static ListEmployee instance;
        public List<Dao.Employee> listEmploy;

        public List<Employee> ListEmploy { get => listEmploy; set => listEmploy = value; }
        public static ListEmployee Instance 
        {
            get
            {
                if (instance == null)
                    instance = new ListEmployee();
                return instance;
            } 
            set => instance = value;
        }

        public ListEmployee()
        {
            listEmploy = new List<Employee>();
            listEmploy.Add(new Employee("Viet Anh",new DateTime(2000,5,2), "HP","", "", "", "", "", "", 123, "",123, 123, ""));
        }
    }
}
