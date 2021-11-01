using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachinePark.Pages
{
    // Razor and C# partials code combines. Instead of writing in one file with @ for everything
    public partial class MachineOverView
    {
        public string Name { get; set; }
        public Guid Id { get; set; }

        public Status Status { get; set; } = Status.Offline;

        public List<string> Log { get; set; } = new List<string>(); //null reference.
    }
}
