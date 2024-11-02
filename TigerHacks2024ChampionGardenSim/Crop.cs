using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TigerHacks2024ChampionGardenSim
{
    internal class Crop
    {
        //basic information
        private string name;
        private int quantity;
        //planting information
        private int plantSpacing;
        private int rowSpacing;
        private double seedDepth;
        private int seedsPlantedPer;
        //fertility information
        private bool isHeavyFeeder;
        private bool canShade;

        public Crop(string name, int plantSpacing, int rowSpacing, double seedDepth,
            int seedsPlantedPer, bool isHeavyFeeder, bool canShade)
        {
            quantity = 0;
            this.name = name;
            this.plantSpacing = plantSpacing;
            this.rowSpacing = rowSpacing;
            this.seedDepth = seedDepth;
            this.seedsPlantedPer = seedsPlantedPer;
            this.isHeavyFeeder = isHeavyFeeder;
            this.canShade = canShade;
        }

        public string getName()
        {
            return name;
        }

        public int getPlantSpacing()
        {
            return plantSpacing;
        }

        public int getRowSpacing()
        {
            return rowSpacing;
        }
        
        public double getSeedDepth()
        {
            return seedDepth;
        }

        public int getSeedsPlantedPer()
        {
            return seedsPlantedPer;
        }

        public bool getCanShade()
        {
            return canShade;
        }

        public bool getIsHeavyFeeder()
        {
            return isHeavyFeeder;
        }

    }
}
