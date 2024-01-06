using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEnumeracoesComposicoes.Entity.Enum
{
    enum OrderStatus : int
    {
        Pending_Payment = 0,
        Processing = 1,
        shipped = 2,
        Delivered = 3
    }
}
