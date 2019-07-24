using System;
using System.Collections.Generic;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle Disk { get; set; }

    public Sphere (Circle instance)
    {
      Disk = instance;
    }

    public double GetVolume()
    {
      double radius = Disk.Radius;
      return (4.0/3.0)*Math.PI*(Math.Pow(radius, 3));
    }

    public double GetSurfaceArea()
    {
      double radius = Disk.Radius;
      return 4.0*Math.PI*(Math.Pow(radius, 2));
    }
  }
}