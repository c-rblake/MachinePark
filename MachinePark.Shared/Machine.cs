using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachinePark.Shared
{
    public class Machine
    {
        public string Name { get; set; }
        public Guid MachineId { get; set; }

        public Status Status { get; set; } = Status.Offline;

        public List<string> Log { get; set; } = new List<string>(); //null reference.

        public Machine()
        {
            MachineId = Guid.NewGuid();
        }
    }
}
