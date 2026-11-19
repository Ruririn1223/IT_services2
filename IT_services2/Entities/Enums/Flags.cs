using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_services2.Entities.Enums
{
    [Flags]
    public enum Flags
    {
        None = 0,           // 0000
        NDA = 1,            // 0001 — неразглашение
        Urgent = 2,         // 0010 — срочный
        Prepayment = 4,     // 0100 — с предоплатой
        LongTerm = 8        // 1000 — долгосрочный
    }
}
