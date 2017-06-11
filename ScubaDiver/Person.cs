using System;

namespace ScubaDiver
{
    class Person
    {
        //This Person class is the overview of our person object in the suba game
        int height; //in Feet
        int weight; //in LB
        float health; //out of 100
        float maxHealth;
        float speed; //out of 10
        int stamina; // 20 out of possible 100 with leveling up
        int maxStamina;
        int endurance;//out of 100
        int maxEndurance;
        bool awake; //true by default (always start the game awake)
        bool daylight; //true for now as we will start in Daylight
        double time; //24 hour clock

        Person()
        {
            height = 6;
            weight = 200;
            health = 100;
            maxHealth = 100;
            speed = 5;
            stamina = 20;
            maxStamina = 100;
            endurance = 20;
            maxEndurance = 100;
            awake = true;
            daylight = true;
            time = 06.00;
        }

        void isAwake()
        {
            if (awake.Equals(true))
                Console.WriteLine("You are now awake");
            //if button is pressed labeled sleep, go to sleep and place awake to false;
        }

        void TimeofDay()
        {
            if (time <= 06.00 || time >= 19.5)
            {
                //It's dark
                daylight = false;
            }
            else
            {
                //It's daytime
                daylight = true;
            }
        }
    }
}