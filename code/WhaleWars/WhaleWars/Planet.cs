using System;

namespace WhaleWars
{
    public class Planet
    {
        public string Name { get; set;}
        public PlanetType PlanType { get; set;}
        public string Description { get; set; }  //Planet description text, backstory, characteristics, etc.
        private Location location;

        public Planet() 
        {
            Name  = "nowhere";
            PlanType = PlanetType.barren;
            location  = new Location(1, 1, Sector.Blowholia);
        }

        public Planet(string planetName, PlanetType type, int x, int y, Sector sector)
        {
            Name = planetName;
            PlanType = type;
            location = new Location(x, y, sector);
        }
    }

    public class Location
    {
        public  int xLoc { get; set;}
        public  int yLoc { get; set;}
        public Sector sector { get; set;}

        public Location(int x, int  y, Sector aSector)
        {
            xLoc = x;
            yLoc = y;
            sector = aSector;
        }
    }
}