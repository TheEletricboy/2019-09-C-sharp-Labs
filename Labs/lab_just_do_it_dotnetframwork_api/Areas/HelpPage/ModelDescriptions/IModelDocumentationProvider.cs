using System;
using System.Reflection;

namespace lab_just_do_it_dotnetframwork_api.Areas.HelpPage.ModelDescriptions
{
    public interface IModelDocumentationProvider
    {
        string GetDocumentation(MemberInfo member);

        string GetDocumentation(Type type);
    }
}