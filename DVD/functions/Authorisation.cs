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
        public static ObservableCollection<Sotrudnik> sotr { get; set; }
        public static Sotrudnik AuthorisationSotr(int login, string password)
        {
            sotr=new ObservableCollection<Sotrudnik>(Connection.Connection.dvd.Sotrudnik.ToList());
            var userExists = sotr.Where(sotr => sotr.Id == login && sotr.Password == password).FirstOrDefault();
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
