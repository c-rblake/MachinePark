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
        [Inject]
        public State State { get; set; }
        public Machine Machine { get; set; } = new Machine() { Status= Status.Offline}; // Some Values have to be set on instantiation for databinding to work
        public bool ShowDialog { get; set; }

        public void Show()
        {
            ResetDialog();
            ShowDialog = true;
            StateHasChanged(); //Redraw "UI" Component Like in the ToDo list from 3 november end. This would have been good.
        }

        public void Close() // Add to Razor Code
        {
            ShowDialog = false;
            StateHasChanged();
        }

        private void ResetDialog()
        {
            Machine = new Machine() { Status = Status.Offline };
        }

        protected void HandleValidSubmit()
        {
            State.Machines.Add(Machine); //Works as intended
            ShowDialog = false;

            StateHasChanged();
        }
    }
}
