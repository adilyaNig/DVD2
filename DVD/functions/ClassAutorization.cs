using DVD.Connection;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVD.functions
{
    internal class ClassAutorization
    {
        public static ObservableCollection<Employee> sotrudniks { get; set; }

        public static void RegistrationSotr (string fio, string phone,string password)
        {
            Employee newSotr = new Employee();
            newSotr.Lastname = fio.Trim();
            newSotr.Phone = phone.Trim();
            newSotr.Lastname = password.Trim();
            newSotr.id_role = 1;
            newSotr.Salary = 25000;

            Connection.Connection.dvd.Employee.Add(newSotr);
            Connection.Connection.dvd.SaveChanges();
        }
    }
}
