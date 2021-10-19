namespace SzamanClient.Model
{
    public sealed class Machine 
    {
        public string Name { get; set; }
        public int Number { get; set; }
        public string LanIP { get; set; }
        public string WanIP { get; set; }
        public string Info { get; set; }
        public MachineStatus Status { get; set; }

        public enum MachineStatus
        {
            Run,
            Stop,
            Pause
        }
    }
}