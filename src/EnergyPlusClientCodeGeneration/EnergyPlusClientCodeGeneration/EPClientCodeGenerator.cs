using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EnergyPlusJsonSchemas._9_5_0;
using Microsoft.CSharp;

namespace EPJsonClientCodeGenerator
{
    public class EPClientCodeGenerator
    {
        public EPJsonSchema EPJsonSchema { get; }

        

        public EPClientCodeGenerator()
        {
            //string json = File.ReadAllText(@"C:\Git\EPJsonClientCodeGenerator\Input\EnergyPlusV9-5-0\Energy+.schema.epJSON");
            string json = EPJsonSchema.GetOfficalEPJsonSchema;

            //remove unwanted attributes
            //var temp = JObject.Parse(json);
            //temp.Descendants()
            //    .OfType<JProperty>()
            //    .Where(attr => attr.Name == "legacy_idd")
            //    .ToList() // you should call ToList because you're about to changing the result, which is not possible if it is IEnumerable
            //    .ForEach(attr => attr.Remove()); // removing unwanted attributes
            //json = temp.ToString(); // backing result to json

            EPJsonSchema = EPJsonSchema.FromJson(json);
        }

        public static void GenerateCSharp( string folder)
        {
            string baseName = "EnergyPlus";

            var cSharpCodeProvider = new CSharpCodeProvider();
            //options for the layout of the generated C# and VB code
            var codeGeneratorOptions = new CodeGeneratorOptions()
            {
                //BracingStyles: "Block", "C"
                BracingStyle = "C",
                BlankLinesBetweenMembers = true,
                IndentString = "    ",
                ElseOnClosing = false,
                VerbatimOrder = false
            };

            StringWriter stringWriterCSharp = new StringWriter();
            cSharpCodeProvider.GenerateCodeFromCompileUnit(GetEPCodeCompileUnit(), stringWriterCSharp, codeGeneratorOptions);
            File.WriteAllText($@"{folder}\{baseName}.cs", stringWriterCSharp.ToString());

        }

        private virtual 

    }
}
