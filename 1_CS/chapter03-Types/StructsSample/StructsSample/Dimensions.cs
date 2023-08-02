using System;
namespace StructsSample
{
	public readonly struct Dimensions
	{
		public double Length { get; }
		public double Width { get; }

		public double Diagonal => Math.Sqrt(Length * Length + Width * Width);

		public Dimensions(double length, double width)
		{
			Length = length;
			Width = width;
		}

	}
}

