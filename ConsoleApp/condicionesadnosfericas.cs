using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{

    public class Condiciones
    {
        public Result[] results { get; set; }
        public Pagination pagination { get; set; }
    }

    public class Pagination
    {
        public int page { get; set; }
        public int pageSize { get; set; }
        public int total { get; set; }
    }

    public class Result
    {
        public string _id { get; set; }
        public string cityid { get; set; }
        public string validdateutc { get; set; }
        public string winddirectioncardinal { get; set; }
        public string probabilityofprecip { get; set; }
        public string relativehumidity { get; set; }
        public string name { get; set; }
        public DateTime dateinsert { get; set; }
        public string longitude { get; set; }
        public string state { get; set; }
        public string lastreporttime { get; set; }
        public string skydescriptionlong { get; set; }
        public string stateabbr { get; set; }
        public string tempc { get; set; }
        public string latitude { get; set; }
        public string iconcode { get; set; }
        public string windspeedkm { get; set; }
    }

}
