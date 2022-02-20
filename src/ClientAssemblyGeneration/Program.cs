using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClientAssemblyGeneration.Directors;
using EnergyPlusClientCodeGeneration;
using EnergyPlusJsonSchemas._9_5_0;
using JsonClientCodeGenerator.BHoM;
using Microsoft.CSharp;

namespace ClientAssemblyGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            ClientCodeCompileUnitBuilder builder = new BHoMClientCodeCompileUnitBuilder();
            ClientCodeCompileUnitDirector director = new EPClientCodeCompileUnitDirector(EPJsonSchema.GetOfficalEPJsonSchema, builder);
            CodeCompileUnit ePbHoMCodeCompileUnit = director.GetCodeCompileUnit();

            var cSharpCodeProvider = new CSharpCodeProvider();
            //options for the layout of the generated C# and VB code
            var codeGeneratorOptions = new CodeGeneratorOptions()
            {
                //BracingStyles: "Block", "C"
                BracingStyle = "C",
                BlankLinesBetweenMembers = true,
                IndentString = "    ",
                ElseOnClosing = false,
                VerbatimOrder = true
            };

            StringWriter stringWriterCSharp = new StringWriter();
            cSharpCodeProvider.GenerateCodeFromCompileUnit(ePbHoMCodeCompileUnit, stringWriterCSharp, codeGeneratorOptions);
            File.WriteAllText($@"C:\Git\EPJsonClientCodeGeneration\Output\EnergyPlus.cs", stringWriterCSharp.ToString());

        }
    }
}
