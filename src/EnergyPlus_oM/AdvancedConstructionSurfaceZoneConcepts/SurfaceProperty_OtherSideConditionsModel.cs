using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object sets up modifying the other side conditions for a surface from other " +
                 "model results.")]
    [JsonObject("SurfaceProperty:OtherSideConditionsModel")]
    public class SurfaceProperty_OtherSideConditionsModel : BHoMObject, IEnergyPlusClass
    {
        

        [Description(@"GapConvectionRadiation provides boundary conditions for convection and linearized thermal radiation across a gap or cavity on the other side of the surface that are modeled separately. UndergroundPipingSystemSurface provides boundary conditions for surfaces in contact with PipingSystem:Underground domains GroundCoupledSurface provides boundary conditions for surfaces in contact with GroundDomain objects ConvectiveUnderwater provides a connection between a surface and an underwater boundary condition defined using a SurfaceProperty:Underwater object")]
        [JsonProperty("type_of_modeling")]
        public SurfaceProperty_OtherSideConditionsModel_TypeOfModeling TypeOfModeling { get; set; } = (SurfaceProperty_OtherSideConditionsModel_TypeOfModeling)Enum.Parse(typeof(SurfaceProperty_OtherSideConditionsModel_TypeOfModeling), "GapConvectionRadiation");
    }
}