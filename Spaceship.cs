using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5__P
{
    public abstract class Spacecraft
    {
        public string Name { get; protected set; }

        public Spacecraft(string name)
        {
            Name = name;
        }
    }

    // Конкретні класи космічних кораблів
    public class Shuttle : Spacecraft
    {
        public Shuttle(string name) : base(name) { }
    }

    public class CargoShip : Spacecraft
    {
        public CargoShip(string name) : base(name) { }
    }

    public class Explorer : Spacecraft
    {
        public Explorer(string name) : base(name) { }
    }

    // Абстрактна фабрика для космічних кораблів
    public interface ISpacecraftFactory
    {
        Shuttle CreateShuttle();
        CargoShip CreateCargoShip();
        Explorer CreateExplorer();
    }

    // Конкретні реалізації фабрики для планети з густою атмосферою
    public class DenseAtmosphereFactory : ISpacecraftFactory
    {
        public Shuttle CreateShuttle()
        {
            return new Shuttle("Dense Shuttle");
        }

        public CargoShip CreateCargoShip()
        {
            return new CargoShip("Dense Cargo Ship");
        }

        public Explorer CreateExplorer()
        {
            return new Explorer("Dense Explorer");
        }
    }

    // Конкретні реалізації фабрики для планети без атмосфери
    public class NoAtmosphereFactory : ISpacecraftFactory
    {
        public Shuttle CreateShuttle()
        {
            return new Shuttle("No Atmosphere Shuttle");
        }

        public CargoShip CreateCargoShip()
        {
            return new CargoShip("No Atmosphere Cargo Ship");
        }

        public Explorer CreateExplorer()
        {
            return new Explorer("No Atmosphere Explorer");
        }
    }

    // Конкретні реалізації фабрики для планети з високою гравітацією
    public class HighGravityFactory : ISpacecraftFactory
    {
        public Shuttle CreateShuttle()
        {
            return new Shuttle("High Gravity Shuttle");
        }

        public CargoShip CreateCargoShip()
        {
            return new CargoShip("High Gravity Cargo Ship");
        }

        public Explorer CreateExplorer()
        {
            return new Explorer("High Gravity Explorer");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення космічних кораблів для планети з густою атмосферою
            ISpacecraftFactory denseAtmosphereFactory = new DenseAtmosphereFactory();
            Shuttle shuttle1 = denseAtmosphereFactory.CreateShuttle();
            CargoShip cargoShip1 = denseAtmosphereFactory.CreateCargoShip();
            Explorer explorer1 = denseAtmosphereFactory.CreateExplorer();
            Console.WriteLine("Spacecraft for dense atmosphere: {0}, {1}, {2}", shuttle1.Name, cargoShip1.Name, explorer1.Name);

            // Створення космічних кораблів для планети без атмосфери
            ISpacecraftFactory noAtmosphereFactory = new NoAtmosphereFactory();
            Shuttle shuttle2 = noAtmosphereFactory.CreateShuttle();
            CargoShip cargoShip2 = noAtmosphereFactory.CreateCargoShip();
            Explorer explorer2 = noAtmosphereFactory.CreateExplorer();
            Console.WriteLine("Spacecraft for no atmosphere: {0}, {1}, {2}", shuttle2.Name, cargoShip2.Name, explorer2.Name);

            // Створення космічних кораблів для планети з високою гравітацією
            ISpacecraftFactory highGravityFactory = new HighGravityFactory();
            Shuttle shuttle3 = highGravityFactory.CreateShuttle();
            CargoShip cargoShip3 = highGravityFactory.CreateCargoShip();
            Explorer explorer3 = highGravityFactory.CreateExplorer();
            Console.WriteLine("Spacecraft for high gravity: {0}, {1}, {2}", shuttle3.Name, cargoShip3.Name, explorer3.Name);

            Console.ReadLine();
        }
    }
}
