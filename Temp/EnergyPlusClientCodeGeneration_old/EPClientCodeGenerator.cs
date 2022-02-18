using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using EnergyPlusJsonSchemas._9_5_0;

namespace EPJsonClientCodeGenerator
{
    public abstract class EPClientCodeGenerator
    {
        public EPJsonSchema epJsonSchema { get; }

        public EPClientCode EPClientCode;

        public CodeCompileUnit EPCompileUnit;


    }
}
