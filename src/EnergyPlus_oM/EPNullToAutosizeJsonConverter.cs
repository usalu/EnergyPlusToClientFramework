using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace EnergyPlus_oM
{
    public class EPNullToAutosizeJsonConverter : JsonConverter<float?>
    {
        public EPNullToAutosizeJsonConverter()
        {

        }

        public override void WriteJson(JsonWriter writer, float? value, JsonSerializer serializer)
        {
            if (value==null)
            {
                writer.WriteRawValue("Autosize");
            }
            else
            {
                JToken t = JToken.FromObject(value);
                t.WriteTo(writer);
            }
        }

        public override float? ReadJson(JsonReader reader, Type objectType, float? existingValue, bool hasExistingValue,
            JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
