using Blazor.FlexGrid.DataAdapters;
using MachinePark.Components;
using MachinePark.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MachinePark.Pages
{
    // Razor and C# partials code combines. Instead of writing in one file with @ for everything
    public partial class MachineOverView : ComponentBase 
    {
        [Inject]
        public State State { get; set; }

        protected AddMachineDialog AddMachineDialog { get; set; } //Points to the @ref in OverView.razor.
                                                                  //This is how Blazor gives access to components in my UI. @ref + Property in code behind.

        protected void QuickAddMachine()
        {
            AddMachineDialog.Show(); //Invokable Methods.
            //AddMachineDialog.ShowDialog(); NOT INVOKABLE member. Property fields etc
        }
        public void AddMachineDialog_OnDialogClose()
        {
            StateHasChanged();
        }
        private MachinesList machines = new MachinesList();

        protected override async Task OnInitialedAsync()
        {
            machines = await 
        }

        //public List<Machine> Machines { get; set; }

        //private void InitializeMachines()
        //{
        //    Machines = new List<Machine>()
        //    {
        //        new Machine{MachineId = Guid.NewGuid(), Log = new List<string>(){"Up", "And Going" }, Status = Shared.Status.Online, Name = "Old Sparky" },
        //        new Machine{MachineId = Guid.NewGuid(), Log = new List<string>(){"Up", "Trecking" }, Status = Shared.Status.Online, Name = "New Sparky" },
        //        new Machine{MachineId = Guid.NewGuid(), Log = new List<string>(){"Crash", "Not Going" }, Status = Shared.Status.Offline, Name = "Old Shiny" },
        //        new Machine{MachineId = Guid.NewGuid(), Log = new List<string>(){"Crash", "Not Going" }, Status = Shared.Status.Offline, Name = "New Shiny" },

        //    };
        //}


        //protected override Task OnInitializedAsync() //Blazor Method that initalizes data. Create or Download from Webserver.
        //{
        //    InitializeMachines();
        //    return base.OnInitializedAsync();
        //}

        //Flex Grid Serverside Nugget.
        //public CollectionTableDataAdapter<Machine> Machines { get; set; }

        //protected override Task OnInitializedAsync()
        //{

        //    var machines = new List<Machine>()
        //    {
        //        new Machine{Id = Guid.NewGuid(), Log = new List<string>(){"Up", "And Going" }, Status = Shared.Status.Online, Name = "Old Sparky" },
        //        new Machine{Id = Guid.NewGuid(), Log = new List<string>(){"Just Here", "Not Going" }, Status = 0, Name = "New Shiny" }

        //    };
        //    Machines = new CollectionTableDataAdapter<Machine>(machines);
        //    return base.OnInitializedAsync();
        //}


    }
}
