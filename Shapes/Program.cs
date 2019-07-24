using System;
using System.Collections.Generic;
using Shapes.Models;

namespace Shapes
{

  public class Program
  {

    public static void Main()
    {
      int shapeChoice;
      
      Console.WriteLine("1: Rectangle, 2: Cube, 3: Circle, 4: Sphere");
      shapeChoice = int.Parse(Console.ReadLine());

      if(shapeChoice == 1)
      {
        rectangleChoice();
      } else if(shapeChoice == 2)
      {
        cubeChoice();
      } else if(shapeChoice == 3)
      {
        circleChoice();
      } else if(shapeChoice == 4)
      {
        sphereChoice();
      }


    }

    static void rectangleChoice()
    {
      int length;
      int width;
      Console.WriteLine("Enter length in inches:");
      length = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter width in inches:");
      width = int.Parse(Console.ReadLine());
      Rectangle rectangle = new Rectangle(length, width);

      if(rectangle.IsSquare() == true)
      {
        Console.WriteLine("Your rectangle is also a square.");
      }

      Console.WriteLine("The area of your rectangle is: " + rectangle.GetArea());
      Console.WriteLine("1: Another shape, 2: Exit program");
      int exitChoice;
      exitChoice = int.Parse(Console.ReadLine());  
      if(exitChoice == 1)
      {
        Main();
      } else if(exitChoice == 2)
      {
        return;
      }

    }

    static void cubeChoice()
    {
      int length;
      Console.WriteLine("Enter cube side length in inches:");
      length = int.Parse(Console.ReadLine());
      Rectangle side1 = new Rectangle(length, length);
      Cube cube = new Cube(side1);

      Console.WriteLine("Cube volume: " + cube.GetVolume());
      Console.WriteLine("Cube surface area: " + cube.GetSurfaceArea());

      Console.WriteLine("1: Another shape, 2: Exit program");
      int exitChoice;
      exitChoice = int.Parse(Console.ReadLine());
      if (exitChoice == 1)
      {
        Main();
      }
      else if (exitChoice == 2)
      {
        return;
      }
    }

    static void circleChoice()
    {
      double radius;
      Console.WriteLine("Enter circle radius in inches:");
      radius = double.Parse(Console.ReadLine());
      Circle circle = new Circle(radius);

      Console.WriteLine("Circle diameter: " + circle.GetDiameter());
      Console.WriteLine("Circle circumference: " + circle.GetCircumference());

      Console.WriteLine("1: Another shape, 2: Exit program");
      int exitChoice;
      exitChoice = int.Parse(Console.ReadLine());
      if (exitChoice == 1)
      {
        Main();
      }
      else if (exitChoice == 2)
      {
        return;
      }
    }

    static void sphereChoice()
    {
      double radius;
      Console.WriteLine("Enter sphere radius in inches:");
      radius = double.Parse(Console.ReadLine());
      Circle disk1 = new Circle(radius);
      Sphere sphere = new Sphere(disk1);

      Console.WriteLine("Sphere volume: " + sphere.GetVolume());
      Console.WriteLine("Sphere surface area: " + sphere.GetSurfaceArea());

      Console.WriteLine("1: Another shape, 2: Exit program");
      int exitChoice;
      exitChoice = int.Parse(Console.ReadLine());
      if (exitChoice == 1)
      {
        Main();
      }
      else if (exitChoice == 2)
      {
        return;
      }
    }

  }

}