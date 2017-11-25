﻿using UnityEngine;

namespace Cubizer
{
	public abstract class IBiomeGenerator : MonoBehaviour
	{
		public abstract CubizerContext context
		{
			get;
		}

		public abstract void Init(CubizerContext context);

		public abstract IBiomeData OnBuildBiome(int x, int y, int z);
	}
}