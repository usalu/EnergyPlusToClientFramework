using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    [Description("fluid properties for the saturated region")]
    [JsonObject("FluidProperties:Saturated")]
    public class FluidProperties_Saturated : BHoMObject
    {
        

        [JsonProperty("fluid_name")]
        public string FluidName { get; set; } = "";
        

        [Description("Enthalpy Units are J/kg Density Units are kg/m3 SpecificHeat Units are J/kg-K Pre" +
                     "ssure Units are Pa")]
        [JsonProperty("fluid_property_type")]
        public EmptyNoYes FluidPropertyType { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Fluid=saturated fluid FluidGas=saturated vapor")]
        [JsonProperty("fluid_phase")]
        public EmptyNoYes FluidPhase { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Empty");
        

        [Description("Enter the name of a FluidProperties:Temperatures object.")]
        [JsonProperty("temperature_values_name")]
        public string TemperatureValuesName { get; set; } = "";
        

        [JsonProperty("property_value_1")]
        public System.Nullable<float> PropertyValue1 { get; set; } = null;
        

        [JsonProperty("property_value_2")]
        public System.Nullable<float> PropertyValue2 { get; set; } = null;
        

        [JsonProperty("property_value_3")]
        public System.Nullable<float> PropertyValue3 { get; set; } = null;
        

        [JsonProperty("property_value_4")]
        public System.Nullable<float> PropertyValue4 { get; set; } = null;
        

        [JsonProperty("property_value_5")]
        public System.Nullable<float> PropertyValue5 { get; set; } = null;
        

        [JsonProperty("property_value_6")]
        public System.Nullable<float> PropertyValue6 { get; set; } = null;
        

        [JsonProperty("property_value_7")]
        public System.Nullable<float> PropertyValue7 { get; set; } = null;
        

        [JsonProperty("property_value_8")]
        public System.Nullable<float> PropertyValue8 { get; set; } = null;
        

        [JsonProperty("property_value_9")]
        public System.Nullable<float> PropertyValue9 { get; set; } = null;
        

        [JsonProperty("property_value_10")]
        public System.Nullable<float> PropertyValue10 { get; set; } = null;
        

        [JsonProperty("property_value_11")]
        public System.Nullable<float> PropertyValue11 { get; set; } = null;
        

        [JsonProperty("property_value_12")]
        public System.Nullable<float> PropertyValue12 { get; set; } = null;
        

        [JsonProperty("property_value_13")]
        public System.Nullable<float> PropertyValue13 { get; set; } = null;
        

        [JsonProperty("property_value_14")]
        public System.Nullable<float> PropertyValue14 { get; set; } = null;
        

        [JsonProperty("property_value_15")]
        public System.Nullable<float> PropertyValue15 { get; set; } = null;
        

        [JsonProperty("property_value_16")]
        public System.Nullable<float> PropertyValue16 { get; set; } = null;
        

        [JsonProperty("property_value_17")]
        public System.Nullable<float> PropertyValue17 { get; set; } = null;
        

        [JsonProperty("property_value_18")]
        public System.Nullable<float> PropertyValue18 { get; set; } = null;
        

        [JsonProperty("property_value_19")]
        public System.Nullable<float> PropertyValue19 { get; set; } = null;
        

        [JsonProperty("property_value_20")]
        public System.Nullable<float> PropertyValue20 { get; set; } = null;
        

        [JsonProperty("property_value_21")]
        public System.Nullable<float> PropertyValue21 { get; set; } = null;
        

        [JsonProperty("property_value_22")]
        public System.Nullable<float> PropertyValue22 { get; set; } = null;
        

        [JsonProperty("property_value_23")]
        public System.Nullable<float> PropertyValue23 { get; set; } = null;
        

        [JsonProperty("property_value_24")]
        public System.Nullable<float> PropertyValue24 { get; set; } = null;
        

        [JsonProperty("property_value_25")]
        public System.Nullable<float> PropertyValue25 { get; set; } = null;
        

        [JsonProperty("property_value_26")]
        public System.Nullable<float> PropertyValue26 { get; set; } = null;
        

        [JsonProperty("property_value_27")]
        public System.Nullable<float> PropertyValue27 { get; set; } = null;
        

        [JsonProperty("property_value_28")]
        public System.Nullable<float> PropertyValue28 { get; set; } = null;
        

        [JsonProperty("property_value_29")]
        public System.Nullable<float> PropertyValue29 { get; set; } = null;
        

        [JsonProperty("property_value_30")]
        public System.Nullable<float> PropertyValue30 { get; set; } = null;
        

        [JsonProperty("property_value_31")]
        public System.Nullable<float> PropertyValue31 { get; set; } = null;
        

        [JsonProperty("property_value_32")]
        public System.Nullable<float> PropertyValue32 { get; set; } = null;
        

        [JsonProperty("property_value_33")]
        public System.Nullable<float> PropertyValue33 { get; set; } = null;
        

        [JsonProperty("property_value_34")]
        public System.Nullable<float> PropertyValue34 { get; set; } = null;
        

        [JsonProperty("property_value_35")]
        public System.Nullable<float> PropertyValue35 { get; set; } = null;
        

        [JsonProperty("property_value_36")]
        public System.Nullable<float> PropertyValue36 { get; set; } = null;
        

        [JsonProperty("property_value_37")]
        public System.Nullable<float> PropertyValue37 { get; set; } = null;
        

        [JsonProperty("property_value_38")]
        public System.Nullable<float> PropertyValue38 { get; set; } = null;
        

        [JsonProperty("property_value_39")]
        public System.Nullable<float> PropertyValue39 { get; set; } = null;
        

        [JsonProperty("property_value_40")]
        public System.Nullable<float> PropertyValue40 { get; set; } = null;
        

        [JsonProperty("property_value_41")]
        public System.Nullable<float> PropertyValue41 { get; set; } = null;
        

        [JsonProperty("property_value_42")]
        public System.Nullable<float> PropertyValue42 { get; set; } = null;
        

        [JsonProperty("property_value_43")]
        public System.Nullable<float> PropertyValue43 { get; set; } = null;
        

        [JsonProperty("property_value_44")]
        public System.Nullable<float> PropertyValue44 { get; set; } = null;
        

        [JsonProperty("property_value_45")]
        public System.Nullable<float> PropertyValue45 { get; set; } = null;
        

        [JsonProperty("property_value_46")]
        public System.Nullable<float> PropertyValue46 { get; set; } = null;
        

        [JsonProperty("property_value_47")]
        public System.Nullable<float> PropertyValue47 { get; set; } = null;
        

        [JsonProperty("property_value_48")]
        public System.Nullable<float> PropertyValue48 { get; set; } = null;
        

        [JsonProperty("property_value_49")]
        public System.Nullable<float> PropertyValue49 { get; set; } = null;
        

        [JsonProperty("property_value_50")]
        public System.Nullable<float> PropertyValue50 { get; set; } = null;
        

        [JsonProperty("property_value_51")]
        public System.Nullable<float> PropertyValue51 { get; set; } = null;
        

        [JsonProperty("property_value_52")]
        public System.Nullable<float> PropertyValue52 { get; set; } = null;
        

        [JsonProperty("property_value_53")]
        public System.Nullable<float> PropertyValue53 { get; set; } = null;
        

        [JsonProperty("property_value_54")]
        public System.Nullable<float> PropertyValue54 { get; set; } = null;
        

        [JsonProperty("property_value_55")]
        public System.Nullable<float> PropertyValue55 { get; set; } = null;
        

        [JsonProperty("property_value_56")]
        public System.Nullable<float> PropertyValue56 { get; set; } = null;
        

        [JsonProperty("property_value_57")]
        public System.Nullable<float> PropertyValue57 { get; set; } = null;
        

        [JsonProperty("property_value_58")]
        public System.Nullable<float> PropertyValue58 { get; set; } = null;
        

        [JsonProperty("property_value_59")]
        public System.Nullable<float> PropertyValue59 { get; set; } = null;
        

        [JsonProperty("property_value_60")]
        public System.Nullable<float> PropertyValue60 { get; set; } = null;
        

        [JsonProperty("property_value_61")]
        public System.Nullable<float> PropertyValue61 { get; set; } = null;
        

        [JsonProperty("property_value_62")]
        public System.Nullable<float> PropertyValue62 { get; set; } = null;
        

        [JsonProperty("property_value_63")]
        public System.Nullable<float> PropertyValue63 { get; set; } = null;
        

        [JsonProperty("property_value_64")]
        public System.Nullable<float> PropertyValue64 { get; set; } = null;
        

        [JsonProperty("property_value_65")]
        public System.Nullable<float> PropertyValue65 { get; set; } = null;
        

        [JsonProperty("property_value_66")]
        public System.Nullable<float> PropertyValue66 { get; set; } = null;
        

        [JsonProperty("property_value_67")]
        public System.Nullable<float> PropertyValue67 { get; set; } = null;
        

        [JsonProperty("property_value_68")]
        public System.Nullable<float> PropertyValue68 { get; set; } = null;
        

        [JsonProperty("property_value_69")]
        public System.Nullable<float> PropertyValue69 { get; set; } = null;
        

        [JsonProperty("property_value_70")]
        public System.Nullable<float> PropertyValue70 { get; set; } = null;
        

        [JsonProperty("property_value_71")]
        public System.Nullable<float> PropertyValue71 { get; set; } = null;
        

        [JsonProperty("property_value_72")]
        public System.Nullable<float> PropertyValue72 { get; set; } = null;
        

        [JsonProperty("property_value_73")]
        public System.Nullable<float> PropertyValue73 { get; set; } = null;
        

        [JsonProperty("property_value_74")]
        public System.Nullable<float> PropertyValue74 { get; set; } = null;
        

        [JsonProperty("property_value_75")]
        public System.Nullable<float> PropertyValue75 { get; set; } = null;
        

        [JsonProperty("property_value_76")]
        public System.Nullable<float> PropertyValue76 { get; set; } = null;
        

        [JsonProperty("property_value_77")]
        public System.Nullable<float> PropertyValue77 { get; set; } = null;
        

        [JsonProperty("property_value_78")]
        public System.Nullable<float> PropertyValue78 { get; set; } = null;
        

        [JsonProperty("property_value_79")]
        public System.Nullable<float> PropertyValue79 { get; set; } = null;
        

        [JsonProperty("property_value_80")]
        public System.Nullable<float> PropertyValue80 { get; set; } = null;
        

        [JsonProperty("property_value_81")]
        public System.Nullable<float> PropertyValue81 { get; set; } = null;
        

        [JsonProperty("property_value_82")]
        public System.Nullable<float> PropertyValue82 { get; set; } = null;
        

        [JsonProperty("property_value_83")]
        public System.Nullable<float> PropertyValue83 { get; set; } = null;
        

        [JsonProperty("property_value_84")]
        public System.Nullable<float> PropertyValue84 { get; set; } = null;
        

        [JsonProperty("property_value_85")]
        public System.Nullable<float> PropertyValue85 { get; set; } = null;
        

        [JsonProperty("property_value_86")]
        public System.Nullable<float> PropertyValue86 { get; set; } = null;
        

        [JsonProperty("property_value_87")]
        public System.Nullable<float> PropertyValue87 { get; set; } = null;
        

        [JsonProperty("property_value_88")]
        public System.Nullable<float> PropertyValue88 { get; set; } = null;
        

        [JsonProperty("property_value_89")]
        public System.Nullable<float> PropertyValue89 { get; set; } = null;
        

        [JsonProperty("property_value_90")]
        public System.Nullable<float> PropertyValue90 { get; set; } = null;
        

        [JsonProperty("property_value_91")]
        public System.Nullable<float> PropertyValue91 { get; set; } = null;
        

        [JsonProperty("property_value_92")]
        public System.Nullable<float> PropertyValue92 { get; set; } = null;
        

        [JsonProperty("property_value_93")]
        public System.Nullable<float> PropertyValue93 { get; set; } = null;
        

        [JsonProperty("property_value_94")]
        public System.Nullable<float> PropertyValue94 { get; set; } = null;
        

        [JsonProperty("property_value_95")]
        public System.Nullable<float> PropertyValue95 { get; set; } = null;
        

        [JsonProperty("property_value_96")]
        public System.Nullable<float> PropertyValue96 { get; set; } = null;
        

        [JsonProperty("property_value_97")]
        public System.Nullable<float> PropertyValue97 { get; set; } = null;
        

        [JsonProperty("property_value_98")]
        public System.Nullable<float> PropertyValue98 { get; set; } = null;
        

        [JsonProperty("property_value_99")]
        public System.Nullable<float> PropertyValue99 { get; set; } = null;
        

        [JsonProperty("property_value_100")]
        public System.Nullable<float> PropertyValue100 { get; set; } = null;
        

        [JsonProperty("property_value_101")]
        public System.Nullable<float> PropertyValue101 { get; set; } = null;
        

        [JsonProperty("property_value_102")]
        public System.Nullable<float> PropertyValue102 { get; set; } = null;
        

        [JsonProperty("property_value_103")]
        public System.Nullable<float> PropertyValue103 { get; set; } = null;
        

        [JsonProperty("property_value_104")]
        public System.Nullable<float> PropertyValue104 { get; set; } = null;
        

        [JsonProperty("property_value_105")]
        public System.Nullable<float> PropertyValue105 { get; set; } = null;
        

        [JsonProperty("property_value_106")]
        public System.Nullable<float> PropertyValue106 { get; set; } = null;
        

        [JsonProperty("property_value_107")]
        public System.Nullable<float> PropertyValue107 { get; set; } = null;
        

        [JsonProperty("property_value_108")]
        public System.Nullable<float> PropertyValue108 { get; set; } = null;
        

        [JsonProperty("property_value_109")]
        public System.Nullable<float> PropertyValue109 { get; set; } = null;
        

        [JsonProperty("property_value_110")]
        public System.Nullable<float> PropertyValue110 { get; set; } = null;
        

        [JsonProperty("property_value_111")]
        public System.Nullable<float> PropertyValue111 { get; set; } = null;
        

        [JsonProperty("property_value_112")]
        public System.Nullable<float> PropertyValue112 { get; set; } = null;
        

        [JsonProperty("property_value_113")]
        public System.Nullable<float> PropertyValue113 { get; set; } = null;
        

        [JsonProperty("property_value_114")]
        public System.Nullable<float> PropertyValue114 { get; set; } = null;
        

        [JsonProperty("property_value_115")]
        public System.Nullable<float> PropertyValue115 { get; set; } = null;
        

        [JsonProperty("property_value_116")]
        public System.Nullable<float> PropertyValue116 { get; set; } = null;
        

        [JsonProperty("property_value_117")]
        public System.Nullable<float> PropertyValue117 { get; set; } = null;
        

        [JsonProperty("property_value_118")]
        public System.Nullable<float> PropertyValue118 { get; set; } = null;
        

        [JsonProperty("property_value_119")]
        public System.Nullable<float> PropertyValue119 { get; set; } = null;
        

        [JsonProperty("property_value_120")]
        public System.Nullable<float> PropertyValue120 { get; set; } = null;
        

        [JsonProperty("property_value_121")]
        public System.Nullable<float> PropertyValue121 { get; set; } = null;
        

        [JsonProperty("property_value_122")]
        public System.Nullable<float> PropertyValue122 { get; set; } = null;
        

        [JsonProperty("property_value_123")]
        public System.Nullable<float> PropertyValue123 { get; set; } = null;
        

        [JsonProperty("property_value_124")]
        public System.Nullable<float> PropertyValue124 { get; set; } = null;
        

        [JsonProperty("property_value_125")]
        public System.Nullable<float> PropertyValue125 { get; set; } = null;
        

        [JsonProperty("property_value_126")]
        public System.Nullable<float> PropertyValue126 { get; set; } = null;
        

        [JsonProperty("property_value_127")]
        public System.Nullable<float> PropertyValue127 { get; set; } = null;
        

        [JsonProperty("property_value_128")]
        public System.Nullable<float> PropertyValue128 { get; set; } = null;
        

        [JsonProperty("property_value_129")]
        public System.Nullable<float> PropertyValue129 { get; set; } = null;
        

        [JsonProperty("property_value_130")]
        public System.Nullable<float> PropertyValue130 { get; set; } = null;
        

        [JsonProperty("property_value_131")]
        public System.Nullable<float> PropertyValue131 { get; set; } = null;
        

        [JsonProperty("property_value_132")]
        public System.Nullable<float> PropertyValue132 { get; set; } = null;
        

        [JsonProperty("property_value_133")]
        public System.Nullable<float> PropertyValue133 { get; set; } = null;
        

        [JsonProperty("property_value_134")]
        public System.Nullable<float> PropertyValue134 { get; set; } = null;
        

        [JsonProperty("property_value_135")]
        public System.Nullable<float> PropertyValue135 { get; set; } = null;
        

        [JsonProperty("property_value_136")]
        public System.Nullable<float> PropertyValue136 { get; set; } = null;
        

        [JsonProperty("property_value_137")]
        public System.Nullable<float> PropertyValue137 { get; set; } = null;
        

        [JsonProperty("property_value_138")]
        public System.Nullable<float> PropertyValue138 { get; set; } = null;
        

        [JsonProperty("property_value_139")]
        public System.Nullable<float> PropertyValue139 { get; set; } = null;
        

        [JsonProperty("property_value_140")]
        public System.Nullable<float> PropertyValue140 { get; set; } = null;
        

        [JsonProperty("property_value_141")]
        public System.Nullable<float> PropertyValue141 { get; set; } = null;
        

        [JsonProperty("property_value_142")]
        public System.Nullable<float> PropertyValue142 { get; set; } = null;
        

        [JsonProperty("property_value_143")]
        public System.Nullable<float> PropertyValue143 { get; set; } = null;
        

        [JsonProperty("property_value_144")]
        public System.Nullable<float> PropertyValue144 { get; set; } = null;
        

        [JsonProperty("property_value_145")]
        public System.Nullable<float> PropertyValue145 { get; set; } = null;
        

        [JsonProperty("property_value_146")]
        public System.Nullable<float> PropertyValue146 { get; set; } = null;
        

        [JsonProperty("property_value_147")]
        public System.Nullable<float> PropertyValue147 { get; set; } = null;
        

        [JsonProperty("property_value_148")]
        public System.Nullable<float> PropertyValue148 { get; set; } = null;
        

        [JsonProperty("property_value_149")]
        public System.Nullable<float> PropertyValue149 { get; set; } = null;
        

        [JsonProperty("property_value_150")]
        public System.Nullable<float> PropertyValue150 { get; set; } = null;
        

        [JsonProperty("property_value_151")]
        public System.Nullable<float> PropertyValue151 { get; set; } = null;
        

        [JsonProperty("property_value_152")]
        public System.Nullable<float> PropertyValue152 { get; set; } = null;
        

        [JsonProperty("property_value_153")]
        public System.Nullable<float> PropertyValue153 { get; set; } = null;
        

        [JsonProperty("property_value_154")]
        public System.Nullable<float> PropertyValue154 { get; set; } = null;
        

        [JsonProperty("property_value_155")]
        public System.Nullable<float> PropertyValue155 { get; set; } = null;
        

        [JsonProperty("property_value_156")]
        public System.Nullable<float> PropertyValue156 { get; set; } = null;
        

        [JsonProperty("property_value_157")]
        public System.Nullable<float> PropertyValue157 { get; set; } = null;
        

        [JsonProperty("property_value_158")]
        public System.Nullable<float> PropertyValue158 { get; set; } = null;
        

        [JsonProperty("property_value_159")]
        public System.Nullable<float> PropertyValue159 { get; set; } = null;
        

        [JsonProperty("property_value_160")]
        public System.Nullable<float> PropertyValue160 { get; set; } = null;
        

        [JsonProperty("property_value_161")]
        public System.Nullable<float> PropertyValue161 { get; set; } = null;
        

        [JsonProperty("property_value_162")]
        public System.Nullable<float> PropertyValue162 { get; set; } = null;
        

        [JsonProperty("property_value_163")]
        public System.Nullable<float> PropertyValue163 { get; set; } = null;
        

        [JsonProperty("property_value_164")]
        public System.Nullable<float> PropertyValue164 { get; set; } = null;
        

        [JsonProperty("property_value_165")]
        public System.Nullable<float> PropertyValue165 { get; set; } = null;
        

        [JsonProperty("property_value_166")]
        public System.Nullable<float> PropertyValue166 { get; set; } = null;
        

        [JsonProperty("property_value_167")]
        public System.Nullable<float> PropertyValue167 { get; set; } = null;
        

        [JsonProperty("property_value_168")]
        public System.Nullable<float> PropertyValue168 { get; set; } = null;
        

        [JsonProperty("property_value_169")]
        public System.Nullable<float> PropertyValue169 { get; set; } = null;
        

        [JsonProperty("property_value_170")]
        public System.Nullable<float> PropertyValue170 { get; set; } = null;
        

        [JsonProperty("property_value_171")]
        public System.Nullable<float> PropertyValue171 { get; set; } = null;
        

        [JsonProperty("property_value_172")]
        public System.Nullable<float> PropertyValue172 { get; set; } = null;
        

        [JsonProperty("property_value_173")]
        public System.Nullable<float> PropertyValue173 { get; set; } = null;
        

        [JsonProperty("property_value_174")]
        public System.Nullable<float> PropertyValue174 { get; set; } = null;
        

        [JsonProperty("property_value_175")]
        public System.Nullable<float> PropertyValue175 { get; set; } = null;
        

        [JsonProperty("property_value_176")]
        public System.Nullable<float> PropertyValue176 { get; set; } = null;
        

        [JsonProperty("property_value_177")]
        public System.Nullable<float> PropertyValue177 { get; set; } = null;
        

        [JsonProperty("property_value_178")]
        public System.Nullable<float> PropertyValue178 { get; set; } = null;
        

        [JsonProperty("property_value_179")]
        public System.Nullable<float> PropertyValue179 { get; set; } = null;
        

        [JsonProperty("property_value_180")]
        public System.Nullable<float> PropertyValue180 { get; set; } = null;
        

        [JsonProperty("property_value_181")]
        public System.Nullable<float> PropertyValue181 { get; set; } = null;
        

        [JsonProperty("property_value_182")]
        public System.Nullable<float> PropertyValue182 { get; set; } = null;
        

        [JsonProperty("property_value_183")]
        public System.Nullable<float> PropertyValue183 { get; set; } = null;
        

        [JsonProperty("property_value_184")]
        public System.Nullable<float> PropertyValue184 { get; set; } = null;
        

        [JsonProperty("property_value_185")]
        public System.Nullable<float> PropertyValue185 { get; set; } = null;
        

        [JsonProperty("property_value_186")]
        public System.Nullable<float> PropertyValue186 { get; set; } = null;
        

        [JsonProperty("property_value_187")]
        public System.Nullable<float> PropertyValue187 { get; set; } = null;
        

        [JsonProperty("property_value_188")]
        public System.Nullable<float> PropertyValue188 { get; set; } = null;
        

        [JsonProperty("property_value_189")]
        public System.Nullable<float> PropertyValue189 { get; set; } = null;
        

        [JsonProperty("property_value_190")]
        public System.Nullable<float> PropertyValue190 { get; set; } = null;
        

        [JsonProperty("property_value_191")]
        public System.Nullable<float> PropertyValue191 { get; set; } = null;
        

        [JsonProperty("property_value_192")]
        public System.Nullable<float> PropertyValue192 { get; set; } = null;
        

        [JsonProperty("property_value_193")]
        public System.Nullable<float> PropertyValue193 { get; set; } = null;
        

        [JsonProperty("property_value_194")]
        public System.Nullable<float> PropertyValue194 { get; set; } = null;
        

        [JsonProperty("property_value_195")]
        public System.Nullable<float> PropertyValue195 { get; set; } = null;
        

        [JsonProperty("property_value_196")]
        public System.Nullable<float> PropertyValue196 { get; set; } = null;
        

        [JsonProperty("property_value_197")]
        public System.Nullable<float> PropertyValue197 { get; set; } = null;
        

        [JsonProperty("property_value_198")]
        public System.Nullable<float> PropertyValue198 { get; set; } = null;
        

        [JsonProperty("property_value_199")]
        public System.Nullable<float> PropertyValue199 { get; set; } = null;
        

        [JsonProperty("property_value_200")]
        public System.Nullable<float> PropertyValue200 { get; set; } = null;
        

        [JsonProperty("property_value_201")]
        public System.Nullable<float> PropertyValue201 { get; set; } = null;
        

        [JsonProperty("property_value_202")]
        public System.Nullable<float> PropertyValue202 { get; set; } = null;
        

        [JsonProperty("property_value_203")]
        public System.Nullable<float> PropertyValue203 { get; set; } = null;
        

        [JsonProperty("property_value_204")]
        public System.Nullable<float> PropertyValue204 { get; set; } = null;
        

        [JsonProperty("property_value_205")]
        public System.Nullable<float> PropertyValue205 { get; set; } = null;
        

        [JsonProperty("property_value_206")]
        public System.Nullable<float> PropertyValue206 { get; set; } = null;
        

        [JsonProperty("property_value_207")]
        public System.Nullable<float> PropertyValue207 { get; set; } = null;
        

        [JsonProperty("property_value_208")]
        public System.Nullable<float> PropertyValue208 { get; set; } = null;
        

        [JsonProperty("property_value_209")]
        public System.Nullable<float> PropertyValue209 { get; set; } = null;
        

        [JsonProperty("property_value_210")]
        public System.Nullable<float> PropertyValue210 { get; set; } = null;
        

        [JsonProperty("property_value_211")]
        public System.Nullable<float> PropertyValue211 { get; set; } = null;
        

        [JsonProperty("property_value_212")]
        public System.Nullable<float> PropertyValue212 { get; set; } = null;
        

        [JsonProperty("property_value_213")]
        public System.Nullable<float> PropertyValue213 { get; set; } = null;
        

        [JsonProperty("property_value_214")]
        public System.Nullable<float> PropertyValue214 { get; set; } = null;
        

        [JsonProperty("property_value_215")]
        public System.Nullable<float> PropertyValue215 { get; set; } = null;
        

        [JsonProperty("property_value_216")]
        public System.Nullable<float> PropertyValue216 { get; set; } = null;
        

        [JsonProperty("property_value_217")]
        public System.Nullable<float> PropertyValue217 { get; set; } = null;
        

        [JsonProperty("property_value_218")]
        public System.Nullable<float> PropertyValue218 { get; set; } = null;
        

        [JsonProperty("property_value_219")]
        public System.Nullable<float> PropertyValue219 { get; set; } = null;
        

        [JsonProperty("property_value_220")]
        public System.Nullable<float> PropertyValue220 { get; set; } = null;
        

        [JsonProperty("property_value_221")]
        public System.Nullable<float> PropertyValue221 { get; set; } = null;
        

        [JsonProperty("property_value_222")]
        public System.Nullable<float> PropertyValue222 { get; set; } = null;
        

        [JsonProperty("property_value_223")]
        public System.Nullable<float> PropertyValue223 { get; set; } = null;
        

        [JsonProperty("property_value_224")]
        public System.Nullable<float> PropertyValue224 { get; set; } = null;
        

        [JsonProperty("property_value_225")]
        public System.Nullable<float> PropertyValue225 { get; set; } = null;
        

        [JsonProperty("property_value_226")]
        public System.Nullable<float> PropertyValue226 { get; set; } = null;
        

        [JsonProperty("property_value_227")]
        public System.Nullable<float> PropertyValue227 { get; set; } = null;
        

        [JsonProperty("property_value_228")]
        public System.Nullable<float> PropertyValue228 { get; set; } = null;
        

        [JsonProperty("property_value_229")]
        public System.Nullable<float> PropertyValue229 { get; set; } = null;
        

        [JsonProperty("property_value_230")]
        public System.Nullable<float> PropertyValue230 { get; set; } = null;
        

        [JsonProperty("property_value_231")]
        public System.Nullable<float> PropertyValue231 { get; set; } = null;
        

        [JsonProperty("property_value_232")]
        public System.Nullable<float> PropertyValue232 { get; set; } = null;
        

        [JsonProperty("property_value_233")]
        public System.Nullable<float> PropertyValue233 { get; set; } = null;
        

        [JsonProperty("property_value_234")]
        public System.Nullable<float> PropertyValue234 { get; set; } = null;
        

        [JsonProperty("property_value_235")]
        public System.Nullable<float> PropertyValue235 { get; set; } = null;
        

        [JsonProperty("property_value_236")]
        public System.Nullable<float> PropertyValue236 { get; set; } = null;
        

        [JsonProperty("property_value_237")]
        public System.Nullable<float> PropertyValue237 { get; set; } = null;
        

        [JsonProperty("property_value_238")]
        public System.Nullable<float> PropertyValue238 { get; set; } = null;
        

        [JsonProperty("property_value_239")]
        public System.Nullable<float> PropertyValue239 { get; set; } = null;
        

        [JsonProperty("property_value_240")]
        public System.Nullable<float> PropertyValue240 { get; set; } = null;
        

        [JsonProperty("property_value_241")]
        public System.Nullable<float> PropertyValue241 { get; set; } = null;
        

        [JsonProperty("property_value_242")]
        public System.Nullable<float> PropertyValue242 { get; set; } = null;
        

        [JsonProperty("property_value_243")]
        public System.Nullable<float> PropertyValue243 { get; set; } = null;
        

        [JsonProperty("property_value_244")]
        public System.Nullable<float> PropertyValue244 { get; set; } = null;
        

        [JsonProperty("property_value_245")]
        public System.Nullable<float> PropertyValue245 { get; set; } = null;
        

        [JsonProperty("property_value_246")]
        public System.Nullable<float> PropertyValue246 { get; set; } = null;
        

        [JsonProperty("property_value_247")]
        public System.Nullable<float> PropertyValue247 { get; set; } = null;
        

        [JsonProperty("property_value_248")]
        public System.Nullable<float> PropertyValue248 { get; set; } = null;
        

        [JsonProperty("property_value_249")]
        public System.Nullable<float> PropertyValue249 { get; set; } = null;
        

        [JsonProperty("property_value_250")]
        public System.Nullable<float> PropertyValue250 { get; set; } = null;
    }
}