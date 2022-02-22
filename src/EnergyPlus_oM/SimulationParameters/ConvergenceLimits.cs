using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Specifies limits on HVAC system simulation timesteps and iterations. This item is" +
                 " an advanced feature that should be used only with caution.")]
    [JsonObject("ConvergenceLimits")]
    public class ConvergenceLimits : BHoMObject, IEnergyPlusClass
    {
        

        [Description("0 sets the minimum to the zone timestep (ref: Timestep) 1 is normal (ratchet down" +
                     " to 1 minute) setting greater than zone timestep (in minutes) will effectively s" +
                     "et to zone timestep")]
        [JsonProperty("minimum_system_timestep")]
        public System.Nullable<float> MinimumSystemTimestep { get; set; } = null;
        

        [JsonProperty("maximum_hvac_iterations")]
        public System.Nullable<float> MaximumHvacIterations { get; set; } = (System.Nullable<float>)Single.Parse("20", CultureInfo.InvariantCulture);
        

        [Description(@"Controls the minimum number of plant system solver iterations within a single HVAC iteration Larger values will increase runtime but might improve solution accuracy for complicated plant systems Complex plants include: several interconnected loops, heat recovery, thermal load following generators, etc.")]
        [JsonProperty("minimum_plant_iterations")]
        public System.Nullable<float> MinimumPlantIterations { get; set; } = (System.Nullable<float>)Single.Parse("2", CultureInfo.InvariantCulture);
        

        [Description("Controls the maximum number of plant system solver iterations within a single HVA" +
                     "C iteration Smaller values might decrease runtime but could decrease solution ac" +
                     "curacy for complicated plant systems")]
        [JsonProperty("maximum_plant_iterations")]
        public System.Nullable<float> MaximumPlantIterations { get; set; } = (System.Nullable<float>)Single.Parse("8", CultureInfo.InvariantCulture);
    }
}