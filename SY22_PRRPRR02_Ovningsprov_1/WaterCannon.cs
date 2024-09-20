using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Ovningsprov_1 {
	internal class WaterCannon : WaterGun {

		private int _backupTanks;

		public WaterCannon(int inputBackupTanks, int inputSquirtSize) : base(inputSquirtSize) {
			_backupTanks = inputBackupTanks;
		}

		public void SwitchTank() {
			if (_backupTanks > 0) {
				Water = MaxWater;
				_backupTanks--;
			}
		}

		public string Burst() {
			if (Water > SquirtSize * 3) {
				Squirt();
				Squirt();
				Squirt();
				return "Squirted 3 times, totalling " + (SquirtSize * 3) + " units of water";
			} else {
				return "Not enough water";
			}
		}

		public string EngageFullBlast() {
			if (Water > 0) {
				int use = Water;
				Water = 0;
				return "Blasted " + use + " units of water";
			} else {
				return "Out of Water";
			}

		}
	}
}
