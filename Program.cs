﻿using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var DunderMifflinInfinity = new Exercise("Dunder Mifflin Infity", "HTML1");
            var PaperFinder9000 = new Exercise("PaperFinder9000", "Javascript");
            var ScottsTots = new Exercise("Scott's Tots", "C#");
            var Bracket = new Exercise("Warehouse Bball Bracket", "Python");

            var D41 = new Cohort("Daytime 41");
            var N42 = new Cohort("Night 42");
            var D43 = new Cohort("Daytime 43");


            var Dwight = new Student("Dwight", "Schrute", "@beetFarmer01", "Daytime 41");
            var Andy = new Student("Andy", "Bernard", "@boatRower87", "Daytime 41");
            var Jim = new Student("Jim", "Halpert", "@tallBoi", "Night 42");
            var Erin = new Student("Erin", "Hannon", "@GabeisGross4Real", "Daytime 43");

            var Adam = new Instructor("Adam", "Schaeffer", "@Hatguy420", "hats", "Daytime 41");
            var Brenda = new Instructor("Brenda", "Long", "@jEepLuVr", "CSS", "Night 42");
            var Bryan = new Instructor("Bryan", "Nilsen", "@rawkShirtsRcool", "rocking and rolling", "Daytime 43");

            Bryan.AssignExercise(Erin, Bracket);
            Bryan.AssignExercise(Erin, ScottsTots);

            Brenda.AssignExercise(Jim, DunderMifflinInfinity);
            Brenda.AssignExercise(Jim, PaperFinder9000);

            Dwight.ShowAssignedExercises();
            Jim.ShowAssignedExercises();
            Erin.ShowAssignedExercises();


        }
    }
}
