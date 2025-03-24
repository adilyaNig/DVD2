using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVD.Connection;
using System.Collections.ObjectModel;

namespace DVD.functions
{
    public class Authorisation
    {
        public static ObservableCollection<Employee> sotr { get; set; }
        public static Employee AuthorisationSotr(int login, string password)
        {
            sotr=new ObservableCollection<Employee>(Connection.Connection.dvd.Employee.ToList());
            var userExists = sotr.Where(sotr => sotr.id_employee == login && sotr.Lastname == password).FirstOrDefault();
            if (userExists != null)
            {
                return userExists;
            }
            else
            {
                return userExists;
            }
        }
            
    }
}
