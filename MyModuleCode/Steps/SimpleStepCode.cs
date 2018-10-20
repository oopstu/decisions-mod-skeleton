using DecisionsFramework.Design.Flow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// The simplest types of steps are method based sync steps.  Simply write whatever
/// .NET code you want and use an attribute on the CLASS or on the METHOD itself to 
/// register that code with the workflow engine as a flow step.
/// </summary>
namespace MyModuleCode.Steps
{
    [AutoRegisterMethodsOnClass(true, "My Co/Simple Flow Steps")]
    public class SimpleStepCode
    {
        public string GetGreetingFor(string CustomerName) {
            if (DateTime.Now.Hour < 12) {
                return $"Good Morning, {CustomerName}!";
            }
            return $"Good Day, {CustomerName}.";
        }

    }
}
