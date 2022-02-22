using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.FluidProperties
{
    [Description(@"property values for fluid properties list of up to 250 temperatures, note that number of property values must match the number of properties in other words, there must be a one-to-one correspondence between the property values in this list and the actual properties list in other syntax degrees C (for all temperature inputs)")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class FluidProperties_Temperatures : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance.")]
        public string NodeName { get; set; } = "";
        

        [JsonProperty("temperature_1")]
        public System.Nullable<float> Temperature1 { get; set; } = null;
        

        [JsonProperty("temperature_2")]
        public System.Nullable<float> Temperature2 { get; set; } = null;
        

        [JsonProperty("temperature_3")]
        public System.Nullable<float> Temperature3 { get; set; } = null;
        

        [JsonProperty("temperature_4")]
        public System.Nullable<float> Temperature4 { get; set; } = null;
        

        [JsonProperty("temperature_5")]
        public System.Nullable<float> Temperature5 { get; set; } = null;
        

        [JsonProperty("temperature_6")]
        public System.Nullable<float> Temperature6 { get; set; } = null;
        

        [JsonProperty("temperature_7")]
        public System.Nullable<float> Temperature7 { get; set; } = null;
        

        [JsonProperty("temperature_8")]
        public System.Nullable<float> Temperature8 { get; set; } = null;
        

        [JsonProperty("temperature_9")]
        public System.Nullable<float> Temperature9 { get; set; } = null;
        

        [JsonProperty("temperature_10")]
        public System.Nullable<float> Temperature10 { get; set; } = null;
        

        [JsonProperty("temperature_11")]
        public System.Nullable<float> Temperature11 { get; set; } = null;
        

        [JsonProperty("temperature_12")]
        public System.Nullable<float> Temperature12 { get; set; } = null;
        

        [JsonProperty("temperature_13")]
        public System.Nullable<float> Temperature13 { get; set; } = null;
        

        [JsonProperty("temperature_14")]
        public System.Nullable<float> Temperature14 { get; set; } = null;
        

        [JsonProperty("temperature_15")]
        public System.Nullable<float> Temperature15 { get; set; } = null;
        

        [JsonProperty("temperature_16")]
        public System.Nullable<float> Temperature16 { get; set; } = null;
        

        [JsonProperty("temperature_17")]
        public System.Nullable<float> Temperature17 { get; set; } = null;
        

        [JsonProperty("temperature_18")]
        public System.Nullable<float> Temperature18 { get; set; } = null;
        

        [JsonProperty("temperature_19")]
        public System.Nullable<float> Temperature19 { get; set; } = null;
        

        [JsonProperty("temperature_20")]
        public System.Nullable<float> Temperature20 { get; set; } = null;
        

        [JsonProperty("temperature_21")]
        public System.Nullable<float> Temperature21 { get; set; } = null;
        

        [JsonProperty("temperature_22")]
        public System.Nullable<float> Temperature22 { get; set; } = null;
        

        [JsonProperty("temperature_23")]
        public System.Nullable<float> Temperature23 { get; set; } = null;
        

        [JsonProperty("temperature_24")]
        public System.Nullable<float> Temperature24 { get; set; } = null;
        

        [JsonProperty("temperature_25")]
        public System.Nullable<float> Temperature25 { get; set; } = null;
        

        [JsonProperty("temperature_26")]
        public System.Nullable<float> Temperature26 { get; set; } = null;
        

        [JsonProperty("temperature_27")]
        public System.Nullable<float> Temperature27 { get; set; } = null;
        

        [JsonProperty("temperature_28")]
        public System.Nullable<float> Temperature28 { get; set; } = null;
        

        [JsonProperty("temperature_29")]
        public System.Nullable<float> Temperature29 { get; set; } = null;
        

        [JsonProperty("temperature_30")]
        public System.Nullable<float> Temperature30 { get; set; } = null;
        

        [JsonProperty("temperature_31")]
        public System.Nullable<float> Temperature31 { get; set; } = null;
        

        [JsonProperty("temperature_32")]
        public System.Nullable<float> Temperature32 { get; set; } = null;
        

        [JsonProperty("temperature_33")]
        public System.Nullable<float> Temperature33 { get; set; } = null;
        

        [JsonProperty("temperature_34")]
        public System.Nullable<float> Temperature34 { get; set; } = null;
        

        [JsonProperty("temperature_35")]
        public System.Nullable<float> Temperature35 { get; set; } = null;
        

        [JsonProperty("temperature_36")]
        public System.Nullable<float> Temperature36 { get; set; } = null;
        

        [JsonProperty("temperature_37")]
        public System.Nullable<float> Temperature37 { get; set; } = null;
        

        [JsonProperty("temperature_38")]
        public System.Nullable<float> Temperature38 { get; set; } = null;
        

        [JsonProperty("temperature_39")]
        public System.Nullable<float> Temperature39 { get; set; } = null;
        

        [JsonProperty("temperature_40")]
        public System.Nullable<float> Temperature40 { get; set; } = null;
        

        [JsonProperty("temperature_41")]
        public System.Nullable<float> Temperature41 { get; set; } = null;
        

        [JsonProperty("temperature_42")]
        public System.Nullable<float> Temperature42 { get; set; } = null;
        

        [JsonProperty("temperature_43")]
        public System.Nullable<float> Temperature43 { get; set; } = null;
        

        [JsonProperty("temperature_44")]
        public System.Nullable<float> Temperature44 { get; set; } = null;
        

        [JsonProperty("temperature_45")]
        public System.Nullable<float> Temperature45 { get; set; } = null;
        

        [JsonProperty("temperature_46")]
        public System.Nullable<float> Temperature46 { get; set; } = null;
        

        [JsonProperty("temperature_47")]
        public System.Nullable<float> Temperature47 { get; set; } = null;
        

        [JsonProperty("temperature_48")]
        public System.Nullable<float> Temperature48 { get; set; } = null;
        

        [JsonProperty("temperature_49")]
        public System.Nullable<float> Temperature49 { get; set; } = null;
        

        [JsonProperty("temperature_50")]
        public System.Nullable<float> Temperature50 { get; set; } = null;
        

        [JsonProperty("temperature_51")]
        public System.Nullable<float> Temperature51 { get; set; } = null;
        

        [JsonProperty("temperature_52")]
        public System.Nullable<float> Temperature52 { get; set; } = null;
        

        [JsonProperty("temperature_53")]
        public System.Nullable<float> Temperature53 { get; set; } = null;
        

        [JsonProperty("temperature_54")]
        public System.Nullable<float> Temperature54 { get; set; } = null;
        

        [JsonProperty("temperature_55")]
        public System.Nullable<float> Temperature55 { get; set; } = null;
        

        [JsonProperty("temperature_56")]
        public System.Nullable<float> Temperature56 { get; set; } = null;
        

        [JsonProperty("temperature_57")]
        public System.Nullable<float> Temperature57 { get; set; } = null;
        

        [JsonProperty("temperature_58")]
        public System.Nullable<float> Temperature58 { get; set; } = null;
        

        [JsonProperty("temperature_59")]
        public System.Nullable<float> Temperature59 { get; set; } = null;
        

        [JsonProperty("temperature_60")]
        public System.Nullable<float> Temperature60 { get; set; } = null;
        

        [JsonProperty("temperature_61")]
        public System.Nullable<float> Temperature61 { get; set; } = null;
        

        [JsonProperty("temperature_62")]
        public System.Nullable<float> Temperature62 { get; set; } = null;
        

        [JsonProperty("temperature_63")]
        public System.Nullable<float> Temperature63 { get; set; } = null;
        

        [JsonProperty("temperature_64")]
        public System.Nullable<float> Temperature64 { get; set; } = null;
        

        [JsonProperty("temperature_65")]
        public System.Nullable<float> Temperature65 { get; set; } = null;
        

        [JsonProperty("temperature_66")]
        public System.Nullable<float> Temperature66 { get; set; } = null;
        

        [JsonProperty("temperature_67")]
        public System.Nullable<float> Temperature67 { get; set; } = null;
        

        [JsonProperty("temperature_68")]
        public System.Nullable<float> Temperature68 { get; set; } = null;
        

        [JsonProperty("temperature_69")]
        public System.Nullable<float> Temperature69 { get; set; } = null;
        

        [JsonProperty("temperature_70")]
        public System.Nullable<float> Temperature70 { get; set; } = null;
        

        [JsonProperty("temperature_71")]
        public System.Nullable<float> Temperature71 { get; set; } = null;
        

        [JsonProperty("temperature_72")]
        public System.Nullable<float> Temperature72 { get; set; } = null;
        

        [JsonProperty("temperature_73")]
        public System.Nullable<float> Temperature73 { get; set; } = null;
        

        [JsonProperty("temperature_74")]
        public System.Nullable<float> Temperature74 { get; set; } = null;
        

        [JsonProperty("temperature_75")]
        public System.Nullable<float> Temperature75 { get; set; } = null;
        

        [JsonProperty("temperature_76")]
        public System.Nullable<float> Temperature76 { get; set; } = null;
        

        [JsonProperty("temperature_77")]
        public System.Nullable<float> Temperature77 { get; set; } = null;
        

        [JsonProperty("temperature_78")]
        public System.Nullable<float> Temperature78 { get; set; } = null;
        

        [JsonProperty("temperature_79")]
        public System.Nullable<float> Temperature79 { get; set; } = null;
        

        [JsonProperty("temperature_80")]
        public System.Nullable<float> Temperature80 { get; set; } = null;
        

        [JsonProperty("temperature_81")]
        public System.Nullable<float> Temperature81 { get; set; } = null;
        

        [JsonProperty("temperature_82")]
        public System.Nullable<float> Temperature82 { get; set; } = null;
        

        [JsonProperty("temperature_83")]
        public System.Nullable<float> Temperature83 { get; set; } = null;
        

        [JsonProperty("temperature_84")]
        public System.Nullable<float> Temperature84 { get; set; } = null;
        

        [JsonProperty("temperature_85")]
        public System.Nullable<float> Temperature85 { get; set; } = null;
        

        [JsonProperty("temperature_86")]
        public System.Nullable<float> Temperature86 { get; set; } = null;
        

        [JsonProperty("temperature_87")]
        public System.Nullable<float> Temperature87 { get; set; } = null;
        

        [JsonProperty("temperature_88")]
        public System.Nullable<float> Temperature88 { get; set; } = null;
        

        [JsonProperty("temperature_89")]
        public System.Nullable<float> Temperature89 { get; set; } = null;
        

        [JsonProperty("temperature_90")]
        public System.Nullable<float> Temperature90 { get; set; } = null;
        

        [JsonProperty("temperature_91")]
        public System.Nullable<float> Temperature91 { get; set; } = null;
        

        [JsonProperty("temperature_92")]
        public System.Nullable<float> Temperature92 { get; set; } = null;
        

        [JsonProperty("temperature_93")]
        public System.Nullable<float> Temperature93 { get; set; } = null;
        

        [JsonProperty("temperature_94")]
        public System.Nullable<float> Temperature94 { get; set; } = null;
        

        [JsonProperty("temperature_95")]
        public System.Nullable<float> Temperature95 { get; set; } = null;
        

        [JsonProperty("temperature_96")]
        public System.Nullable<float> Temperature96 { get; set; } = null;
        

        [JsonProperty("temperature_97")]
        public System.Nullable<float> Temperature97 { get; set; } = null;
        

        [JsonProperty("temperature_98")]
        public System.Nullable<float> Temperature98 { get; set; } = null;
        

        [JsonProperty("temperature_99")]
        public System.Nullable<float> Temperature99 { get; set; } = null;
        

        [JsonProperty("temperature_100")]
        public System.Nullable<float> Temperature100 { get; set; } = null;
        

        [JsonProperty("temperature_101")]
        public System.Nullable<float> Temperature101 { get; set; } = null;
        

        [JsonProperty("temperature_102")]
        public System.Nullable<float> Temperature102 { get; set; } = null;
        

        [JsonProperty("temperature_103")]
        public System.Nullable<float> Temperature103 { get; set; } = null;
        

        [JsonProperty("temperature_104")]
        public System.Nullable<float> Temperature104 { get; set; } = null;
        

        [JsonProperty("temperature_105")]
        public System.Nullable<float> Temperature105 { get; set; } = null;
        

        [JsonProperty("temperature_106")]
        public System.Nullable<float> Temperature106 { get; set; } = null;
        

        [JsonProperty("temperature_107")]
        public System.Nullable<float> Temperature107 { get; set; } = null;
        

        [JsonProperty("temperature_108")]
        public System.Nullable<float> Temperature108 { get; set; } = null;
        

        [JsonProperty("temperature_109")]
        public System.Nullable<float> Temperature109 { get; set; } = null;
        

        [JsonProperty("temperature_110")]
        public System.Nullable<float> Temperature110 { get; set; } = null;
        

        [JsonProperty("temperature_111")]
        public System.Nullable<float> Temperature111 { get; set; } = null;
        

        [JsonProperty("temperature_112")]
        public System.Nullable<float> Temperature112 { get; set; } = null;
        

        [JsonProperty("temperature_113")]
        public System.Nullable<float> Temperature113 { get; set; } = null;
        

        [JsonProperty("temperature_114")]
        public System.Nullable<float> Temperature114 { get; set; } = null;
        

        [JsonProperty("temperature_115")]
        public System.Nullable<float> Temperature115 { get; set; } = null;
        

        [JsonProperty("temperature_116")]
        public System.Nullable<float> Temperature116 { get; set; } = null;
        

        [JsonProperty("temperature_117")]
        public System.Nullable<float> Temperature117 { get; set; } = null;
        

        [JsonProperty("temperature_118")]
        public System.Nullable<float> Temperature118 { get; set; } = null;
        

        [JsonProperty("temperature_119")]
        public System.Nullable<float> Temperature119 { get; set; } = null;
        

        [JsonProperty("temperature_120")]
        public System.Nullable<float> Temperature120 { get; set; } = null;
        

        [JsonProperty("temperature_121")]
        public System.Nullable<float> Temperature121 { get; set; } = null;
        

        [JsonProperty("temperature_122")]
        public System.Nullable<float> Temperature122 { get; set; } = null;
        

        [JsonProperty("temperature_123")]
        public System.Nullable<float> Temperature123 { get; set; } = null;
        

        [JsonProperty("temperature_124")]
        public System.Nullable<float> Temperature124 { get; set; } = null;
        

        [JsonProperty("temperature_125")]
        public System.Nullable<float> Temperature125 { get; set; } = null;
        

        [JsonProperty("temperature_126")]
        public System.Nullable<float> Temperature126 { get; set; } = null;
        

        [JsonProperty("temperature_127")]
        public System.Nullable<float> Temperature127 { get; set; } = null;
        

        [JsonProperty("temperature_128")]
        public System.Nullable<float> Temperature128 { get; set; } = null;
        

        [JsonProperty("temperature_129")]
        public System.Nullable<float> Temperature129 { get; set; } = null;
        

        [JsonProperty("temperature_130")]
        public System.Nullable<float> Temperature130 { get; set; } = null;
        

        [JsonProperty("temperature_131")]
        public System.Nullable<float> Temperature131 { get; set; } = null;
        

        [JsonProperty("temperature_132")]
        public System.Nullable<float> Temperature132 { get; set; } = null;
        

        [JsonProperty("temperature_133")]
        public System.Nullable<float> Temperature133 { get; set; } = null;
        

        [JsonProperty("temperature_134")]
        public System.Nullable<float> Temperature134 { get; set; } = null;
        

        [JsonProperty("temperature_135")]
        public System.Nullable<float> Temperature135 { get; set; } = null;
        

        [JsonProperty("temperature_136")]
        public System.Nullable<float> Temperature136 { get; set; } = null;
        

        [JsonProperty("temperature_137")]
        public System.Nullable<float> Temperature137 { get; set; } = null;
        

        [JsonProperty("temperature_138")]
        public System.Nullable<float> Temperature138 { get; set; } = null;
        

        [JsonProperty("temperature_139")]
        public System.Nullable<float> Temperature139 { get; set; } = null;
        

        [JsonProperty("temperature_140")]
        public System.Nullable<float> Temperature140 { get; set; } = null;
        

        [JsonProperty("temperature_141")]
        public System.Nullable<float> Temperature141 { get; set; } = null;
        

        [JsonProperty("temperature_142")]
        public System.Nullable<float> Temperature142 { get; set; } = null;
        

        [JsonProperty("temperature_143")]
        public System.Nullable<float> Temperature143 { get; set; } = null;
        

        [JsonProperty("temperature_144")]
        public System.Nullable<float> Temperature144 { get; set; } = null;
        

        [JsonProperty("temperature_145")]
        public System.Nullable<float> Temperature145 { get; set; } = null;
        

        [JsonProperty("temperature_146")]
        public System.Nullable<float> Temperature146 { get; set; } = null;
        

        [JsonProperty("temperature_147")]
        public System.Nullable<float> Temperature147 { get; set; } = null;
        

        [JsonProperty("temperature_148")]
        public System.Nullable<float> Temperature148 { get; set; } = null;
        

        [JsonProperty("temperature_149")]
        public System.Nullable<float> Temperature149 { get; set; } = null;
        

        [JsonProperty("temperature_150")]
        public System.Nullable<float> Temperature150 { get; set; } = null;
        

        [JsonProperty("temperature_151")]
        public System.Nullable<float> Temperature151 { get; set; } = null;
        

        [JsonProperty("temperature_152")]
        public System.Nullable<float> Temperature152 { get; set; } = null;
        

        [JsonProperty("temperature_153")]
        public System.Nullable<float> Temperature153 { get; set; } = null;
        

        [JsonProperty("temperature_154")]
        public System.Nullable<float> Temperature154 { get; set; } = null;
        

        [JsonProperty("temperature_155")]
        public System.Nullable<float> Temperature155 { get; set; } = null;
        

        [JsonProperty("temperature_156")]
        public System.Nullable<float> Temperature156 { get; set; } = null;
        

        [JsonProperty("temperature_157")]
        public System.Nullable<float> Temperature157 { get; set; } = null;
        

        [JsonProperty("temperature_158")]
        public System.Nullable<float> Temperature158 { get; set; } = null;
        

        [JsonProperty("temperature_159")]
        public System.Nullable<float> Temperature159 { get; set; } = null;
        

        [JsonProperty("temperature_160")]
        public System.Nullable<float> Temperature160 { get; set; } = null;
        

        [JsonProperty("temperature_161")]
        public System.Nullable<float> Temperature161 { get; set; } = null;
        

        [JsonProperty("temperature_162")]
        public System.Nullable<float> Temperature162 { get; set; } = null;
        

        [JsonProperty("temperature_163")]
        public System.Nullable<float> Temperature163 { get; set; } = null;
        

        [JsonProperty("temperature_164")]
        public System.Nullable<float> Temperature164 { get; set; } = null;
        

        [JsonProperty("temperature_165")]
        public System.Nullable<float> Temperature165 { get; set; } = null;
        

        [JsonProperty("temperature_166")]
        public System.Nullable<float> Temperature166 { get; set; } = null;
        

        [JsonProperty("temperature_167")]
        public System.Nullable<float> Temperature167 { get; set; } = null;
        

        [JsonProperty("temperature_168")]
        public System.Nullable<float> Temperature168 { get; set; } = null;
        

        [JsonProperty("temperature_169")]
        public System.Nullable<float> Temperature169 { get; set; } = null;
        

        [JsonProperty("temperature_170")]
        public System.Nullable<float> Temperature170 { get; set; } = null;
        

        [JsonProperty("temperature_171")]
        public System.Nullable<float> Temperature171 { get; set; } = null;
        

        [JsonProperty("temperature_172")]
        public System.Nullable<float> Temperature172 { get; set; } = null;
        

        [JsonProperty("temperature_173")]
        public System.Nullable<float> Temperature173 { get; set; } = null;
        

        [JsonProperty("temperature_174")]
        public System.Nullable<float> Temperature174 { get; set; } = null;
        

        [JsonProperty("temperature_175")]
        public System.Nullable<float> Temperature175 { get; set; } = null;
        

        [JsonProperty("temperature_176")]
        public System.Nullable<float> Temperature176 { get; set; } = null;
        

        [JsonProperty("temperature_177")]
        public System.Nullable<float> Temperature177 { get; set; } = null;
        

        [JsonProperty("temperature_178")]
        public System.Nullable<float> Temperature178 { get; set; } = null;
        

        [JsonProperty("temperature_179")]
        public System.Nullable<float> Temperature179 { get; set; } = null;
        

        [JsonProperty("temperature_180")]
        public System.Nullable<float> Temperature180 { get; set; } = null;
        

        [JsonProperty("temperature_181")]
        public System.Nullable<float> Temperature181 { get; set; } = null;
        

        [JsonProperty("temperature_182")]
        public System.Nullable<float> Temperature182 { get; set; } = null;
        

        [JsonProperty("temperature_183")]
        public System.Nullable<float> Temperature183 { get; set; } = null;
        

        [JsonProperty("temperature_184")]
        public System.Nullable<float> Temperature184 { get; set; } = null;
        

        [JsonProperty("temperature_185")]
        public System.Nullable<float> Temperature185 { get; set; } = null;
        

        [JsonProperty("temperature_186")]
        public System.Nullable<float> Temperature186 { get; set; } = null;
        

        [JsonProperty("temperature_187")]
        public System.Nullable<float> Temperature187 { get; set; } = null;
        

        [JsonProperty("temperature_188")]
        public System.Nullable<float> Temperature188 { get; set; } = null;
        

        [JsonProperty("temperature_189")]
        public System.Nullable<float> Temperature189 { get; set; } = null;
        

        [JsonProperty("temperature_190")]
        public System.Nullable<float> Temperature190 { get; set; } = null;
        

        [JsonProperty("temperature_191")]
        public System.Nullable<float> Temperature191 { get; set; } = null;
        

        [JsonProperty("temperature_192")]
        public System.Nullable<float> Temperature192 { get; set; } = null;
        

        [JsonProperty("temperature_193")]
        public System.Nullable<float> Temperature193 { get; set; } = null;
        

        [JsonProperty("temperature_194")]
        public System.Nullable<float> Temperature194 { get; set; } = null;
        

        [JsonProperty("temperature_195")]
        public System.Nullable<float> Temperature195 { get; set; } = null;
        

        [JsonProperty("temperature_196")]
        public System.Nullable<float> Temperature196 { get; set; } = null;
        

        [JsonProperty("temperature_197")]
        public System.Nullable<float> Temperature197 { get; set; } = null;
        

        [JsonProperty("temperature_198")]
        public System.Nullable<float> Temperature198 { get; set; } = null;
        

        [JsonProperty("temperature_199")]
        public System.Nullable<float> Temperature199 { get; set; } = null;
        

        [JsonProperty("temperature_200")]
        public System.Nullable<float> Temperature200 { get; set; } = null;
        

        [JsonProperty("temperature_201")]
        public System.Nullable<float> Temperature201 { get; set; } = null;
        

        [JsonProperty("temperature_202")]
        public System.Nullable<float> Temperature202 { get; set; } = null;
        

        [JsonProperty("temperature_203")]
        public System.Nullable<float> Temperature203 { get; set; } = null;
        

        [JsonProperty("temperature_204")]
        public System.Nullable<float> Temperature204 { get; set; } = null;
        

        [JsonProperty("temperature_205")]
        public System.Nullable<float> Temperature205 { get; set; } = null;
        

        [JsonProperty("temperature_206")]
        public System.Nullable<float> Temperature206 { get; set; } = null;
        

        [JsonProperty("temperature_207")]
        public System.Nullable<float> Temperature207 { get; set; } = null;
        

        [JsonProperty("temperature_208")]
        public System.Nullable<float> Temperature208 { get; set; } = null;
        

        [JsonProperty("temperature_209")]
        public System.Nullable<float> Temperature209 { get; set; } = null;
        

        [JsonProperty("temperature_210")]
        public System.Nullable<float> Temperature210 { get; set; } = null;
        

        [JsonProperty("temperature_211")]
        public System.Nullable<float> Temperature211 { get; set; } = null;
        

        [JsonProperty("temperature_212")]
        public System.Nullable<float> Temperature212 { get; set; } = null;
        

        [JsonProperty("temperature_213")]
        public System.Nullable<float> Temperature213 { get; set; } = null;
        

        [JsonProperty("temperature_214")]
        public System.Nullable<float> Temperature214 { get; set; } = null;
        

        [JsonProperty("temperature_215")]
        public System.Nullable<float> Temperature215 { get; set; } = null;
        

        [JsonProperty("temperature_216")]
        public System.Nullable<float> Temperature216 { get; set; } = null;
        

        [JsonProperty("temperature_217")]
        public System.Nullable<float> Temperature217 { get; set; } = null;
        

        [JsonProperty("temperature_218")]
        public System.Nullable<float> Temperature218 { get; set; } = null;
        

        [JsonProperty("temperature_219")]
        public System.Nullable<float> Temperature219 { get; set; } = null;
        

        [JsonProperty("temperature_220")]
        public System.Nullable<float> Temperature220 { get; set; } = null;
        

        [JsonProperty("temperature_221")]
        public System.Nullable<float> Temperature221 { get; set; } = null;
        

        [JsonProperty("temperature_222")]
        public System.Nullable<float> Temperature222 { get; set; } = null;
        

        [JsonProperty("temperature_223")]
        public System.Nullable<float> Temperature223 { get; set; } = null;
        

        [JsonProperty("temperature_224")]
        public System.Nullable<float> Temperature224 { get; set; } = null;
        

        [JsonProperty("temperature_225")]
        public System.Nullable<float> Temperature225 { get; set; } = null;
        

        [JsonProperty("temperature_226")]
        public System.Nullable<float> Temperature226 { get; set; } = null;
        

        [JsonProperty("temperature_227")]
        public System.Nullable<float> Temperature227 { get; set; } = null;
        

        [JsonProperty("temperature_228")]
        public System.Nullable<float> Temperature228 { get; set; } = null;
        

        [JsonProperty("temperature_229")]
        public System.Nullable<float> Temperature229 { get; set; } = null;
        

        [JsonProperty("temperature_230")]
        public System.Nullable<float> Temperature230 { get; set; } = null;
        

        [JsonProperty("temperature_231")]
        public System.Nullable<float> Temperature231 { get; set; } = null;
        

        [JsonProperty("temperature_232")]
        public System.Nullable<float> Temperature232 { get; set; } = null;
        

        [JsonProperty("temperature_233")]
        public System.Nullable<float> Temperature233 { get; set; } = null;
        

        [JsonProperty("temperature_234")]
        public System.Nullable<float> Temperature234 { get; set; } = null;
        

        [JsonProperty("temperature_235")]
        public System.Nullable<float> Temperature235 { get; set; } = null;
        

        [JsonProperty("temperature_236")]
        public System.Nullable<float> Temperature236 { get; set; } = null;
        

        [JsonProperty("temperature_237")]
        public System.Nullable<float> Temperature237 { get; set; } = null;
        

        [JsonProperty("temperature_238")]
        public System.Nullable<float> Temperature238 { get; set; } = null;
        

        [JsonProperty("temperature_239")]
        public System.Nullable<float> Temperature239 { get; set; } = null;
        

        [JsonProperty("temperature_240")]
        public System.Nullable<float> Temperature240 { get; set; } = null;
        

        [JsonProperty("temperature_241")]
        public System.Nullable<float> Temperature241 { get; set; } = null;
        

        [JsonProperty("temperature_242")]
        public System.Nullable<float> Temperature242 { get; set; } = null;
        

        [JsonProperty("temperature_243")]
        public System.Nullable<float> Temperature243 { get; set; } = null;
        

        [JsonProperty("temperature_244")]
        public System.Nullable<float> Temperature244 { get; set; } = null;
        

        [JsonProperty("temperature_245")]
        public System.Nullable<float> Temperature245 { get; set; } = null;
        

        [JsonProperty("temperature_246")]
        public System.Nullable<float> Temperature246 { get; set; } = null;
        

        [JsonProperty("temperature_247")]
        public System.Nullable<float> Temperature247 { get; set; } = null;
        

        [JsonProperty("temperature_248")]
        public System.Nullable<float> Temperature248 { get; set; } = null;
        

        [JsonProperty("temperature_249")]
        public System.Nullable<float> Temperature249 { get; set; } = null;
        

        [JsonProperty("temperature_250")]
        public System.Nullable<float> Temperature250 { get; set; } = null;
    }
}