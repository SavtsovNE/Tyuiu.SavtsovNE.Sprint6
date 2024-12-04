using System.Numerics;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.SavtsovNE.Sprint6.Task3.V19.Lib
{
	public class DataService : ISprint6Task3V19
	{
		public int[,] Calculate(int[,] matrix)
		{
			int rows = matrix.GetUpperBound(0) + 1;
			int colums = matrix.Length / rows;
			int[] res = new int[rows];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < colums; j++)
				{
					if (j == 4)
					{
						res[i] = matrix[i, j];
					}

				}
			}
			Array.Sort(res);
			for (int i = 0; i < rows; ++i)
			{
				for (int j = 0; j < colums; j++)
				{
					if (j == 4)
					{
						matrix[i, j] = res[i];
					}
				}
			}
			return matrix;
		}

	}
}