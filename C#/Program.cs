using System;
using System.Collections.Generic;

namespace ObserverPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
			var alarm = new Alarm();
			alarm.AddWatcher(new FireStation());
			alarm.AddWatcher(new PoliceStation());
			alarm.AddWatcher(new HospitalStation());
			alarm.Notify();
			Console.ReadKey();
		}

		public class Alarm
		{

			List<IWatcher<Alarm>> watchers = new List<IWatcher<Alarm>>();

			public void AddWatcher(IWatcher<Alarm> alarmWatcher)
			{
				watchers.Add(alarmWatcher);
			}

			public void Notify()
			{
				foreach (var w in watchers)
				{
					w.Alert(this);
				}
			}
		}

		public interface IWatcher<Alarm>
		{
			public void Alert(Alarm value);
		}

		public class FireStation : IWatcher<Alarm>
		{
			public void Alert(Alarm value)
			{
				Console.WriteLine("Bombeiros respondendo! Estamos a caminho");
			}
		}

		public class PoliceStation : IWatcher<Alarm>
		{
			public void Alert(Alarm value)
			{
				Console.WriteLine("Policia respondendo! Estamos a caminho");
			}
		}

		public class HospitalStation : IWatcher<Alarm>
		{
			public void Alert(Alarm value)
			{
				Console.WriteLine("Hospital respondendo! Estamos a caminho");
			}
		}

	}
}
