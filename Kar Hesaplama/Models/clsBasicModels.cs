using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kar_Hesaplama.Models
{
    public class clsBasicModels
    {
        public int id { get; set; }
        public String? Appearence { get; set; }
    }
    public class clsUevcbModel : clsBasicModels
    {
        public int sirketId { get; set; }
    }
}