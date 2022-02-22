using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Conditionally turn on/off output from EnergyPlus.")]
    [JsonObject("OutputControl:Files")]
    public class OutputControl_Files : BHoMObject, IEnergyPlusClass
    {
        

        [JsonProperty("output_csv")]
        public EmptyNoYes OutputCsv { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [JsonProperty("output_mtr")]
        public EmptyNoYes OutputMtr { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_eso")]
        public EmptyNoYes OutputEso { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_eio")]
        public EmptyNoYes OutputEio { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_tabular")]
        public EmptyNoYes OutputTabular { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_sqlite")]
        public EmptyNoYes OutputSqlite { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_json")]
        public EmptyNoYes OutputJson { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_audit")]
        public EmptyNoYes OutputAudit { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_zone_sizing")]
        public EmptyNoYes OutputZoneSizing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_system_sizing")]
        public EmptyNoYes OutputSystemSizing { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_dxf")]
        public EmptyNoYes OutputDxf { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_bnd")]
        public EmptyNoYes OutputBnd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_rdd")]
        public EmptyNoYes OutputRdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_mdd")]
        public EmptyNoYes OutputMdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_mtd")]
        public EmptyNoYes OutputMtd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_end")]
        public EmptyNoYes OutputEnd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_shd")]
        public EmptyNoYes OutputShd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_dfs")]
        public EmptyNoYes OutputDfs { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_glhe")]
        public EmptyNoYes OutputGlhe { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_delightin")]
        public EmptyNoYes OutputDelightin { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_delighteldmp")]
        public EmptyNoYes OutputDelighteldmp { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_delightdfdmp")]
        public EmptyNoYes OutputDelightdfdmp { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_edd")]
        public EmptyNoYes OutputEdd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_dbg")]
        public EmptyNoYes OutputDbg { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_perflog")]
        public EmptyNoYes OutputPerflog { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_sln")]
        public EmptyNoYes OutputSln { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_sci")]
        public EmptyNoYes OutputSci { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_wrl")]
        public EmptyNoYes OutputWrl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_screen")]
        public EmptyNoYes OutputScreen { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [JsonProperty("output_extshd")]
        public EmptyNoYes OutputExtshd { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description("Not Implemented Yet")]
        [JsonProperty("output_tarcog")]
        public EmptyNoYes OutputTarcog { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}