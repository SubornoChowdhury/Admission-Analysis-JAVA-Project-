using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_RestaurentManagementSystemPRO
{
    class repo
    {
        string delete,select,insert,update,searc,lgin;

        internal string selectAll()
        {
            return select = "select * from restaurant";
        }


        internal string deleteEnp(string id)
        {
            
            return delete = "delete from restaurant where userid = '" + id + "';";

        }

      internal string insertemp(string id, string password, string status)
        {
          return insert = "insert into restaurant (userid,password,status) values ('" + id+ "','" + password + "','" + status + "') ";
        }

      internal string updateemp(string id, string password, string status)
        {
            return update = "update restaurant set password ='" + password + "', status ='" + status + "' where userid ='" + id + "'  "; 
        }
          internal string searchall(string search)
        {
            return searc = "select * from restaurant where (userid like '%" + search + "%') or (password like '%" + search + "%') or (status like '%" +search + "%')"; 
        }

        internal string login(string id, string password, string status)
        {
            return lgin = "select * from restaurant where userid ='" + id + "'and password ='"+ password +"'and status ='"+ status +"'";
         }


    }
}
