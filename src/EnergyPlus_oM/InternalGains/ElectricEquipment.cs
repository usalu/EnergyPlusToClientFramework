using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.InternalGains
{
    [Description("Sets internal gains for electric equipment in the zone. If you use a ZoneList in " +
                 "the Zone or ZoneList name field then this definition applies to all the zones in" +
                 " the ZoneList.")]
    [JsonObject("ElectricEquipment")]
    public class ElectricEquipment : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("zone_or_zonelist_name")]
        public string ZoneOrZonelistName { get; set; } = "";
        

        [Description("units in schedule should be fraction applied to design level of electric equipmen" +
                     "t, generally (0.0 - 1.0)")]
        [JsonProperty("schedule_name")]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"The entered calculation method is used to create the maximum amount of electric equipment for this set of attributes Choices: EquipmentLevel => Equipment Level -- simply enter watts of equipment Watts/Area => Watts per Zone Floor Area -- enter the number to apply. Value * Floor Area = Equipment Level Watts/Person => Watts per Person -- enter the number to apply. Value * Occupants = Equipment Level")]
        [JsonProperty("design_level_calculation_method")]
        public ElectricEquipment_DesignLevelCalculationMethod DesignLevelCalculationMethod { get; set; } = (ElectricEquipment_DesignLevelCalculationMethod)Enum.Parse(typeof(ElectricEquipment_DesignLevelCalculationMethod), "EquipmentLevel");
        

        [JsonProperty("design_level")]
        public System.Nullable<float> DesignLevel { get; set; } = null;
        

        [JsonProperty("watts_per_zone_floor_area")]
        public System.Nullable<float> WattsPerZoneFloorArea { get; set; } = null;
        

        [JsonProperty("watts_per_person")]
        public System.Nullable<float> WattsPerPerson { get; set; } = null;
        

        [JsonProperty("fraction_latent")]
        public System.Nullable<float> FractionLatent { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_radiant")]
        public System.Nullable<float> FractionRadiant { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty("fraction_lost")]
        public System.Nullable<float> FractionLost { get; set; } = (System.Nullable<float>)Single.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Any text may be used here to categorize the end-uses in the ABUPS End Uses by Sub" +
                     "category table.")]
        [JsonProperty("end_use_subcategory")]
        public string EndUseSubcategory { get; set; } = (System.String)"General";
    }
}