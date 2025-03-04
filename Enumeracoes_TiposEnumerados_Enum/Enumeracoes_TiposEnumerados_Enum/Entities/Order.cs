﻿using System;
using System.Collections.Generic;
using System.Text;
using Enumeracoes_TiposEnumerados_Enum.Entities.Enums;

namespace Enumeracoes_TiposEnumerados_Enum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public int MyProperty { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id 
                +", "
                +Moment
                +", "
                +Status;
        }

    }
}
