
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SzamanClient.Model;


namespace SzamanClient.ViewModel
{
    public class ApplicationViewModel : INotifyPropertyChanged
    {
        private Machine selectedMachine;
        private uint selectedMachineIndex;

        public ObservableCollection<Machine> Machines { get; set; }

        public Machine SelectedMachine
        {
            get { return selectedMachine; }
            set
            {
                selectedMachine = value;
                OnPropertyChanged();
            }
        }

        public uint SelectedMachineIndex
        {
            get { return selectedMachineIndex; }
            set { selectedMachineIndex = value; }
        }

        public ApplicationViewModel()
        {
            Machines = new ObservableCollection<Machine>
            {
                new Machine{Name="PC1", Number=1, LanIP="10.0.0.10", WanIP="10.137.24.100", Info="Nowy PC", Status=Machine.MachineStatus.Run},
                new Machine{Name="PC2", Number=1, LanIP="10.0.0.10", WanIP="10.137.24.102", Info="Nowy PC", Status=Machine.MachineStatus.Pause},
                new Machine{Name="PC133", Number=1, LanIP="10.0.0.23", WanIP="10.137.24.103", Info="Nowy PC", Status=Machine.MachineStatus.Stop}
            };
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}
