using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientAssemblyGeneration
{
    interface IClientCodeCompileUnit
    {
        void setNamespaces(CodeNamespaceCollection namespaces);
        void setAttributes(Dictionary<CodeNamespace,CodeTypeMemberCollection> attributes);
        void setEnums(Dictionary<CodeNamespace, CodeTypeMemberCollection> enums);
        void setClasses(Dictionary<CodeNamespace, CodeTypeMemberCollection> classes);
        void setProperties(Dictionary<CodeTypeMember, IEnumerable<CodeMemberProperty>> properties);
        void setMethods(Dictionary<CodeTypeMember, IEnumerable<CodeMemberMethod>> methods);
        void setEvents(Dictionary<CodeTypeMember, IEnumerable<CodeMemberEvent>> events);

    }
}
