using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace task 4.Models
{
    public class user_provid
{
    public int user_id { get; set; }
    public List<user> _user { get; set; }
    public int p_id { get; set;}
    public List<provider> _providers { get; set; }
}
}
