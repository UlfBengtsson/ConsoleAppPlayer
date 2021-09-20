using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppPlayer.Models
{
    public class Player
    {
        static Random random = new Random();
        static string[] startCities = { "Växjö", "Stockholm", "Malmö", "Jönköping" };
        //array index start at 0.       // i0    // i1        // i2    // i3

        int vitalety;
        int inteligance;
        int strength;

        string name;
        string race;
        string gender;

        string borinIn;

        public Player(string name, string race, string gender)
        {
            this.name = name;
            this.race = race;
            this.gender = gender;

            vitalety = random.Next(1, 7);
            inteligance = random.Next(1, 7);
            strength = random.Next(1, 7);

            borinIn = startCities[random.Next(startCities.Length)];
            //Array.Fill(startCities, "_");
            //Array.Resize();
        }

        public string Status()
        {
            return $"--- Status ---\nName: {name}\nRace: {race}\nGender: {gender}\nVit: {vitalety}\nStr: {strength}\nInt: {inteligance}\nBorn in: {borinIn}\n-----\n";
        }
    }
}
