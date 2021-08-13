using NJsonSchema.CodeGeneration.CSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NJsonSchema;
using Newtonsoft.Json;
using DotLiquid;
using Newtonsoft.Json.Converters;

namespace EPJSONToDOMCompilor
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenerateEPJSONCSharpFramework();


        }

        public static void GenerateEPJSONCSharpFramework()
        {
            string contentSchema =
                File.ReadAllText(
                    @"E:\Dokumente\GitHub\EPJSONToDOMCompilor\Input\EnergyPlusV9-5-0\Energy+.schema.epJSON");
            var schema = JsonConvert.DeserializeObject<JsonSchema>(contentSchema);

            var generator = new CSharpGenerator(schema, new CSharpGeneratorSettings()
            {
                ClassStyle = CSharpClassStyle.Poco,
                GenerateJsonMethods = true,
                

            });
            var file = generator.GenerateFile();
            File.WriteAllText(@"E:\Dokumente\GitHub\EPJSONToDOMCompilor\Output\EPJSON.cs", file);
        }
    }
}
