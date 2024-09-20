using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_Ovningsprov_1 {
	internal class WaterGun {
		private int _maxWater;
		private int _water;
		private int _squirtSize;

		protected int MaxWater {
			private set {
				_maxWater = value;
			}
			get {
				return _maxWater;
			}
		}

		public int Water {
			protected set {
				if (value < 0) {
					_water = 0;
				} else if (value > MaxWater) {
					_water = MaxWater;
				} else {
					_water = value;
				}
				// Eller: 
				//if (0 <= value && value <= MaxWater) {
				//	_water = value;
				//}
			}
			get {
				return _water;
			}
		}

		protected int SquirtSize {
			private set {
				_squirtSize = value;
			}
			get {
				return _squirtSize;
			}
		}

		public WaterGun(int inputSquirtSize) {
			MaxWater = 50;
			Water = 20;
			SquirtSize = inputSquirtSize;
		}

		public void RefillWater(int amount) {
			Water += amount;
		}

		public string Squirt() {
			if (Water <= 0) {
				return "Out of Water";
			} else {
				return "Squirted a size " + SquirtSize;
			}
		}

	}
}
