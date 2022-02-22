using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Sets internal gains or losses for \"other\" equipment in the zone.")]
    [JsonObject("OtherEquipment")]
    public class OtherEquipment : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("fuel_type")]
        public OtherEquipment_FuelType FuelType { get; set; } = (OtherEquipment_FuelType)Enum.Parse(typeof(OtherEquipment_FuelType), "None");
        

        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("units in Schedule should be fraction applied to design level of other equipment, " +
                     "generally (0.0 - 1.0)")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of other equipment. to set a loss, use a negative value in the following fields. for this set of attributes Choices: EquipmentLevel => Design Level -- simply enter power input of equipment Watts/Area or Power/Area => Power per Zone Floor Area -- enter the number to apply. Value * Floor Area = Equipment Level Watts/Person or Power/Person => Power per Person -- enter the number to apply. Value * Occupants = Equipment Level")]
        [JsonProperty("design_level_calculation_method")]
        public OtherEquipment_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (OtherEquipment_DesignLevelCalculationMethod)Enum.Parse(typeof(OtherEquipment_DesignLevelCalculationMethod), "EquipmentLevel");
        

        [JsonProperty("design_level")]
        public System.Nullable<float> DesignLevel { get; set; } = null;
        

        [JsonProperty("power_per_zone_floor_area")]
        public System.Nullable<float> PowerPerZoneFloorArea { get; set; } = null;
        

        [JsonProperty("power_per_person")]
        public System.Nullable<float> PowerPerPerson { get; set; } = null;
        

        [JsonProperty("fraction_latent")]
        public System.Nullable<float> FractionLatent { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_radiant")]
        public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_lost")]
        public System.Nullable<float> FractionLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("CO2 generation rate per unit of power input The default value assumes the equipme" +
                     "nt is fully vented.")]
        [JsonProperty("carbon_dioxide_generation_rate")]
        public System.Nullable<float> CarbonDioxideGenerationRate { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}