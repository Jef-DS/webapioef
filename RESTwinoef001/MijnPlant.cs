using RESTapioef001.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RESTwinoef001
{
    public class MijnPlant: PLANTEN
    {
        private static String[] maanden = {"Januari", "Februari","Maart", "April", "Mei", "Juni",
                               "Juli", "Augustus", "September", "Oktober", "November", "December"};
        public String BeginBloeiMaand
        {
            get { return maanden[Convert.ToInt32(BLOEIBEGIN)-1];}
        }
        public String EindBloeiMaand
        {
            get { return maanden[Convert.ToInt32(BLOEIEINDE) -1 ];}
        }

    }
}
