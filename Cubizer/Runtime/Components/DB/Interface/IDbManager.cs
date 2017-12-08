﻿using System;

namespace Cubizer
{
	public interface IDbManager : IDisposable
	{
		void LoadChunk(ChunkPrimer chunk);
		void SaveChunk(ChunkPrimer chunk);

		void InsertBlock(int x, int y, int z, int xx, int yy, int zz, int ww);
	}
}