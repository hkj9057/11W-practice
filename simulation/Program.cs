
namespace simulation
{
	class Program
	{
		static void Main()
		{
			autoDoor   myDoor = new autoDoor(autoDoor.DoorState.closed);
			Light	   light2 = new Light();
			tvCtrl         tv = new tvCtrl();

			// create remote-control
			remoteCtrl mycontrol = new remoteCtrl(new autoDoor(autoDoor.DoorState.closed));
			// append other-device into remote-control
			mycontrol.Append(new Light(), 1);
			mycontrol.Append(new airCondition(), 2);
			mycontrol.Append(light2, 3);
			mycontrol.Append(new tvCtrl(), 4);

			// Door 직접 제어
			//myDoor.Open();
			//Console.WriteLine("[[ if you want to close door immediately , Press Enter-key ]]");
			//Console.ReadLine();

			// Light 직접 제어
			//light2.On();
			//light2.Off();
			//light2.Active();
			//light2.Deactive();

			// 리모컨을 이용한 제어
			// Light Control with remoteControl
			//mycontrol.PushOpen();

			//// Change control device in remote-control
			//mycontrol.Change(0);
			//mycontrol.PushOpen();
			//Console.WriteLine("[[ if you want to close door immediately , Press Enter-key ]]");
			//Console.ReadLine();
			//mycontrol.PushClose();
			//// 동작
			//mycontrol.Change(1);
			//mycontrol.PushOpen();
			//mycontrol.PushClose();
			//// 동작
			//mycontrol.Change(2);
			//mycontrol.PushOpen();
			//mycontrol.PushClose();
			//// 동작
			//mycontrol.Change(3);
			//mycontrol.PushOpen();
			//mycontrol.PushClose();
			mycontrol.Change(4);
			mycontrol.PushOpen();
			mycontrol.PushClose();
		}
	}

}