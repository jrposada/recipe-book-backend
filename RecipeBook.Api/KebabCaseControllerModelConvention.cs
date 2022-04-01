using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RecipeBook.Api.Controllers
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class KebabCaseControllerModelConvention : Attribute, IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            foreach (var selector in controller.Selectors)
            {
                selector.AttributeRouteModel = ReplaceControllerTemplate(selector, controller.ControllerName);
            }

            foreach (var selector in controller.Actions.SelectMany(a => a.Selectors))
            {
                selector.AttributeRouteModel = ReplaceControllerTemplate(selector, controller.ControllerName);
            }
        }

        private static AttributeRouteModel ReplaceControllerTemplate(SelectorModel selector, string name)
        {
            return selector.AttributeRouteModel != null
                ? new AttributeRouteModel
                {
                    Template = selector.AttributeRouteModel.Template
                    .Replace("[controller]", PascalToKebabCase(name))
                }
                : null;
        }

        private static string PascalToKebabCase(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            return Regex.Replace(
                value,
                "(?<!^)([A-Z][a-z]|(?<=[a-z])[A-Z])",
                "-$1",
                RegexOptions.Compiled)
                .Trim()
                .ToLower();
        }
    }
}
