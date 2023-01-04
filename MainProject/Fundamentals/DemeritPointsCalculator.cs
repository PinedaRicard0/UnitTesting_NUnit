using System;
namespace MainProject.Fundamentals
{
	public class DemeritPointsCalculator
	{
		private const int SpeedLimit = 65;

		public int CalculateDemtericPoints(int speed)
		{
			if (speed < 0)
				throw new ArgumentOutOfRangeException();

			if (speed <= SpeedLimit)
				return 0;

			const int KmPerDemeritPoint = 5;
			var demeritPoints = (speed - SpeedLimit) / KmPerDemeritPoint;

			return demeritPoints;
		}
	}
}

