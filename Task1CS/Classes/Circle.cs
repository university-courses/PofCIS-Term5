using System;
using System.IO;
using System.Collections.Generic;

using Task1CS.Interfaces;

namespace Task1CS.Classes
{
	/// <summary>
	/// Class of circle shape.
	/// </summary>
	public class Circle : IShape
	{
		private Point[] _points;
		private double _radius;
		
		private const int PointsCount = 2;

		/// <summary>
		/// Default constructor for circle.
		/// </summary>
		public Circle()
		{
			_points = new Point[PointsCount];
		}
		
		/// <summary>
		/// Constructor with parameter.
		/// </summary>
		/// <param name="points">Array of points.
		/// First point mut be center,
		/// second point from the circumference.</param>
		/// <exception cref="NullReferenceException">Throws if array of points is null.</exception>
		/// <exception cref="InvalidDataException">Trows if both points are the same.</exception>
		public Circle(Point[] points)
		{
			if (points == null)
			{
				throw new NullReferenceException("points is null");
			}
			
			if (points[0] == points[1])
			{
				throw new InvalidDataException("no circle entered");
			}

			_points = points;
			_radius = CalcRadius();
		}

		/// <summary>
		/// Function to calculate radius of the circle. 
		/// </summary>
		/// <returns>Radius.</returns>
		/// <exception cref="NullReferenceException">Throws if array of points is null.</exception>
		public double CalcRadius()
		{
			if (_points == null)
			{
				throw new NullReferenceException("points not set");
			}

			return Point.CalcDistance(_points[0], _points[1]);
		}

		/// <summary>
		/// Function to parse string of data into the element of circle class.
		/// </summary>
		/// <param name="line">Line to parse.</param>
		/// <returns>True if line was parsed,
		/// false if line was not parsed, or if parsed points are the same.</returns>
		public bool Parse(string line)
		{
			var points = Helpers.ParseShapePoints(
				line, @"Circle\{\s*((-?\d+\s+){3}-?\d+)\s*\}", Helpers.Const.CoordinatesPerPoint, PointsCount
			);

			if (points == null)
			{
				return false;
			}

			if (points[0].Equals(points[1]))
			{
				return false;
			}

			_points = points;
			_radius = CalcRadius();

			return true;
		}

		/// <summary>
		/// Function that calculates square of the circle.
		/// </summary>
		/// <returns>Square.</returns>
		/// <exception cref="NullReferenceException">Throws if array of points is null.</exception>
		public double CalcSquare()
		{
			if (_points == null)
			{
				throw new NullReferenceException("points not set");
			}
			return Math.PI * Math.Pow(_radius, 2);
		}

		/// <summary>
		/// Function that calculates perimeter of the circle.
		/// </summary>
		/// <returns>Perimeter.</returns>
		/// <exception cref="NullReferenceException">Throws if array of points is null.</exception>
		public double CalcPerimeter()
		{
			if (_points == null)
			{
				throw new NullReferenceException("points not set");
			}
			return 2 * Math.PI * _radius;
		}

		/// <summary>
		/// Function to get points of center and from the circumference.
		/// </summary>
		/// <returns>Array of points.</returns>
		/// <exception cref="NullReferenceException">Throws if array of points is null.</exception>
		public IEnumerable<Point> GetPoints()
		{
			if (_points == null)
			{
				throw new NullReferenceException("points not set");
			}
			return _points;
		}
		
		/// <summary>
		/// Function to convert element of circle class to string.
		/// </summary>
		/// <returns>Text interpretation of the element of circle class.</returns>
		/// <exception cref="NullReferenceException">Throws if array of points is null.</exception>
		public override string ToString()
		{
			if (_points == null)
			{
				throw new NullReferenceException("points not set");
			}
			var result = $"Circle:\n  Radius: {_radius}\n  Points:";
			for (var i = 0; i < _points.Length; i++)
			{
				result += $"\n    Point {i}: x={_points[i].X}, y={_points[i].Y}";
			}

			return result;
		}
	}
}
