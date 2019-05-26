using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DTO
{
    public class KisiHobiDTO
    {
        public int KisiID { get; set; }
        public List<int> HobiIdList { get; set; }
        public virtual List<KisiBilgileriDTO> kisiler { get; set; }
    }
}
