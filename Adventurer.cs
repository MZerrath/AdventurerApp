using System;
using System.Collections.Generic;
using System.Text;

namespace AdventurerApp
{
    class Adventurer
    {
        // Data members
        string name = "Adventurer";
        int dungeonsRaided = 0;
        bool hasFlashlight = false;
        float runningSpeed = 0f;
        decimal totalMoney = 0m;

        // Default constructor
        public Adventurer()
        {
        }

        // Constructor
        public Adventurer(string aName, int aDungeonsRaided, bool aHasFlashlight, float aRunningSpeed, decimal aTotalMoney)
        {
            name = aName;
            dungeonsRaided = aDungeonsRaided;
            hasFlashlight = aHasFlashlight;
            runningSpeed = aRunningSpeed;
            totalMoney = aTotalMoney;
        }

        // Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int DungeonsRaided
        {
            get
            {
                return dungeonsRaided;
            }
            set
            {
                dungeonsRaided = value;
            }
        }

        public bool HasFlashlight
        {
            get
            {
                return hasFlashlight;
            }
            set
            {
                hasFlashlight = value;
            }
        }

        public float RunningSpeed
        {
            get
            {
                return runningSpeed;
            }
            set
            {
                runningSpeed = value;
            }
        }

        public decimal TotalMoney
        {
            get
            {
                return totalMoney;
            }
            set
            {
                totalMoney = value;
            }
        }

        // Instance method
        public override string ToString()
        {
            return "Name: " + name +
                   ", Dungeons Raided: " + dungeonsRaided +
                   ", Has a Flashlight: " + hasFlashlight +
                   ", Running Speed: " + runningSpeed +
                   "m/s, Total Money on hand: $" + totalMoney;
        }
    }
}
