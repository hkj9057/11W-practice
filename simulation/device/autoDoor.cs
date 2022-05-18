using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace simulation
{
    internal class autoDoor : Icontrol
	{
		private int isState;
		public enum DoorState { closed, opened, closing, opening };
		private DoorState State;
		private System.Timers.Timer autoClosetimer;

		public autoDoor(DoorState initState)
		{
			this.State = initState;
			autoClosetimer = new System.Timers.Timer(4000);
			autoClosetimer.Elapsed += OnTimedEvent;
			autoClosetimer.AutoReset = true;
		}
		private void OnTimedEvent(object source, ElapsedEventArgs e)
		{
			Console.WriteLine($" >>> auto closed timer done {e.SignalTime}");
			this.Close();

		}
		//public void Open()
		//{
		//	Console.WriteLine($"Door Open -> Time => {DateTime.Now}");
		//	State = DoorState.opened;
		//	Console.WriteLine("\tauto Close-Timer Start");
		//	Console.WriteLine("\t[ Waiting 3~5 seconds...] ");
		//	autoClosetimer.Enabled = true;
		//	autoClosetimer.Start();
		//}
		//public void Close()
		//{
		//	State = DoorState.closed;
		//	Console.WriteLine($"Door Closed -> Time => {DateTime.Now}");
		//	Console.WriteLine("\t[auto Close-Timer Stop] ");
		//	autoClosetimer.Enabled = false;
		//}

		public void Active() { this.Open(); }
		public void Deactive() { this.Close(); }
	}
}
