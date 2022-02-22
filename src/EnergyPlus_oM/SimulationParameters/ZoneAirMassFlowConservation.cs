using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description(@"Enforces the zone air mass flow balance by either adjusting zone mixing object flow only, adjusting zone total return flow only, zone mixing and the zone total return flows, or adjusting the zone total return and zone mixing object flows. Zone infiltration flow air flow is increased or decreased depending user selection in the infiltration treatment method. If either of zone mixing or zone return flow adjusting methods or infiltration is active, then the zone air mass flow balance calculation will attempt to enforce conservation of mass for each zone. If flow balancing method is ""None"" and infiltration is ""None"", then the zone air mass flow calculation defaults to assume self-balanced simple flow mixing and infiltration objects.")]
    public class ZoneAirMassFlowConservation : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"If ""AdjustMixingOnly"", zone mixing object flow rates are adjusted to balance the zone air mass flow and zone infiltration air flow may be increased or decreased if required in order to balance the zone air mass flow. If ""AdjustReturnOnly"", zone total return flow rate is adjusted to balance the zone air mass flow and zone infiltration air flow may be increased or decreased if required in order to balance the zone air mass flow. If ""AdjustMixingThenReturn"", first the zone mixing objects flow rates are adjusted to balance the zone air flow, second zone total return flow rate is adjusted and zone infiltration air flow may be increased or decreased if required in order to balance the zone air mass flow. If ""AdjustReturnThenMixing"", first zone total return flow rate is adjusted to balance the zone air flow, second the zone mixing object flow rates are adjusted and infiltration air flow may be increased or decreased if required in order to balance the zone air mass flow.")]
        [JsonProperty("adjust_zone_mixing_and_return_for_air_mass_flow_balance")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance AdjustZoneMixingAndReturnForAirMassFlowBalance { get; set; } = (ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance)Enum.Parse(typeof(ZoneAirMassFlowConservation_AdjustZoneMixingAndReturnForAirMassFlowBalance), "None");
        

        [Description(@"This input field allows user to choose how zone infiltration flow is treated during the zone air mass flow balance calculation. AddInfiltrationFlow may add infiltration to the base flow specified in the infiltration object to balance the zone air mass flow. The additional infiltration air mass flow is not self-balanced. The base flow is assumed to be self-balanced. AdjustInfiltrationFlow may adjust the base flow calculated using the base flow specified in the infiltration object to balance the zone air mass flow. If it If no adjustment is required, then the base infiltration is assumed to be self-balanced. None will make no changes to the base infiltration flow.")]
        [JsonProperty("infiltration_balancing_method")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneAirMassFlowConservation_InfiltrationBalancingMethod InfiltrationBalancingMethod { get; set; } = (ZoneAirMassFlowConservation_InfiltrationBalancingMethod)Enum.Parse(typeof(ZoneAirMassFlowConservation_InfiltrationBalancingMethod), "AddInfiltrationFlow");
        

        [Description(@"This input field allows user to choose which zones are included in infiltration balancing. MixingSourceZonesOnly allows infiltration balancing only in zones which as source zones for mixing which also have an infiltration object defined. AllZones allows infiltration balancing in any zone which has an infiltration object defined.")]
        [JsonProperty("infiltration_balancing_zones")]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneAirMassFlowConservation_InfiltrationBalancingZones InfiltrationBalancingZones { get; set; } = (ZoneAirMassFlowConservation_InfiltrationBalancingZones)Enum.Parse(typeof(ZoneAirMassFlowConservation_InfiltrationBalancingZones), "MixingSourceZonesOnly");
    }
}