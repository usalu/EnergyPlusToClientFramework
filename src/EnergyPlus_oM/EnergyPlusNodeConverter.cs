using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Adapters.EnergyPlus;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EnergyPlus_oM
{

    public class EnergyPlusNodeConverter : JsonConverter<IEnergyPlusNode>
    {
      
        //public override void WriteJson(JsonWriter writer, IEnergyPlusNode value, JsonSerializer serializer)
        //{
        //    JToken t = JToken.FromObject(value);

        //    if (t.Type != JTokenType.Object)
        //    {
        //        t.WriteTo(writer);
        //    }
        //    else
        //    {
        //        JObject o = (JObject)t;
        //        IList<string> propertyNames = o.Properties().Select(p => p.Name).ToList();

        //        string uniqueEPNamePropertydName = "Name";
        //        if (propertyNames.Contains(uniqueEPNamePropertydName))
        //        {
        //            new JProperty((string)value.GetType().GetProperty(uniqueEPNamePropertydName).GetValue(value, null), o).WriteTo(writer);
        //        }
        //        else
        //        {
        //            o.WriteTo(writer);
        //        }

        //    }
        //}
        public override void WriteJson(JsonWriter writer, IEnergyPlusNode value, JsonSerializer serializer)
        {
            JToken t = JToken.FromObject(value);

            //if (t.Type != JTokenType.Object)
            //{
            //    t.WriteTo(writer);
            //}
            //else
            //{
            //    JObject o = (JObject)t;
            //    //This needs to make sure that every instance of that class has a Name property.
            //    //For further implementation, this can be changed to getMethod in interface but requires adjusting in code
            //    string name = (string)value.GetType().GetProperty("Name").GetValue(value, null);
            //    var jProp = new JProperty(name, o);
            //    //writer.WriteRaw("Name");
            //    writer.WriteRawValue(jProp.ToString());
            //}

            JObject o = (JObject)t;

            //This needs to make sure that every instance of that class has a Name property.
            //For further implementation, this can be changed to getMethod in interface but requires adjusting in code
            string name = (string)value.GetType().GetProperty("NodeName").GetValue(value, null);
            var jProp = new JProperty(name, o);
            //writer.WriteRaw("Name");

            writer.WriteToken(JsonToken.StartObject);
            writer.WriteRaw(jProp.ToString());
            writer.WriteToken(JsonToken.EndObject);

            //o.WriteTo(writer);

        }

        public override IEnergyPlusNode ReadJson(JsonReader reader, Type objectType, IEnergyPlusNode existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            string s = (string)reader.Value;

            throw new NotImplementedException();
        }
    }


}
