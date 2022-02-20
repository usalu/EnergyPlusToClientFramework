using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Specifies the \"basic\" timestep for the simulation. The value entered here is also" +
                 " known as the Zone Timestep. This is used in the Zone Heat Balance Model calcula" +
                 "tion as the driving timestep for heat transfer and load calculations.")]
    [JsonObject("Timestep")]
    public class Timestep : BHoMObject
    {
        

        [Description(@"Number in hour: normal validity 4 to 60: 6 suggested Must be evenly divisible into 60 Allowable values include 1, 2, 3, 4, 5, 6, 10, 12, 15, 20, 30, and 60 Normal 6 is minimum as lower values may cause inaccuracies A minimum value of 20 is suggested for both ConductionFiniteDifference and CombinedHeatAndMoistureFiniteElement surface heat balance algorithms A minimum of 12 is suggested for simulations involving a Vegetated Roof (Material:RoofVegetation).")]
        [JsonProperty("number_of_timesteps_per_hour")]
        public System.Nullable<float> NumberOfTimestepsPerHour { get; set; } = (System.Nullable<float>)Single.Parse("6", CultureInfo.InvariantCulture);
    }
}