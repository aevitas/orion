using System;
using System.Diagnostics;
using System.Threading;

namespace Orion.GlobalOffensive.Test
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			Console.Title = "Orion.GlobalOffensive";
			var proc = Process.GetProcessesByName("csgo")[0];

			Orion.Attach(proc);

			while (true)
			{
				Orion.Objects.Update();
				Console.Clear();

				Console.WriteLine("State: {0}\n\n", Orion.Client.State);

				if (Orion.Client.InGame && Orion.Me != null && Orion.Me.IsValid)
				{
					var me = Orion.Me;
					Console.WriteLine("ID:\t\t{0}", me.Id);
					Console.WriteLine("Health:\t\t{0}", me.Health);
					Console.WriteLine("Position:\t{0}", me.Position);
					Console.WriteLine("Team:\t\t{0}", me.Team);
					Console.WriteLine("ObjectCount:\t{0}", Orion.Objects.Players.Count);

					Console.WriteLine("Weapon:\t{0}", me.CurrentWeapon);
				}

				Thread.Sleep(500);
			}
		}
	}
}