using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Ovningsprov_1 {
	internal class Program {
		static void Main(string[] args) {

			// Uppgift 5
			WaterGun waterGun = new WaterGun(5);
			waterGun.RefillWater(5);
			Console.WriteLine(waterGun.Squirt());

			// Uppgift 9
			List<WaterCannon> waterCannons = new List<WaterCannon>() {
				new WaterCannon(3, 20),
				new WaterCannon(5, 10),
				new WaterCannon(6, 15),
			};

			for (int i = 0; i < waterCannons.Count; i++) {
				Console.WriteLine(waterCannons[i].Burst());
				Console.WriteLine(waterCannons[i].EngageFullBlast());
			}
		}
	}
}
