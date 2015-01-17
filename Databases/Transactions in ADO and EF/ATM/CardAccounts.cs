using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Model
{
    public class CardAccounts
    {
        public int Id { get; set; }

        [StringLength(10)]
        public string CardNumber { get; set; }

        [StringLength(4)]
        public string CardPIN { get; set; }

        public decimal CardCash { get; set; }
    }
}
