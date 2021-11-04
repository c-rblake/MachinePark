using MachinePark.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachinePark.Components
{
    public partial class AddMachineDialog :ComponentBase
    {
        public Machine Machine { get; set; } = new Machine() { Status= Status.Offline}; // Some Values have to be set on instantiation for databinding to work


        public bool ShowDialog { get; set; }
    }
}
