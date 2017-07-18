using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntelligentSystem
{
    partial class WorkedCustomer : Customer
    {
        public Enumerable.Proffesion Prof { get; set; }
        public decimal Money { get; set; }

        public WorkedCustomer(int id, string name, decimal money, Enumerable.Proffesion prof) : base(id, name)
        {
            this.Prof = prof;
            this.Money = money;
        }

        public override string ToString()
        {
            return String.Format("{0}; Proffesion: {1}", base.ToString(), Prof.ToString());
        }

    }
}
