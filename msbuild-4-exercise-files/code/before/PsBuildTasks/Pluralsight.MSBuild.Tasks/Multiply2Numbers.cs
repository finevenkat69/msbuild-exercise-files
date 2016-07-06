
using Microsoft.Build.Framework;
using Microsoft.Build.Utilities;

namespace Pluralsight.MSBuild.Tasks
{
    public class Multiply2Numbers : Task
    {
        [Required]
        public double Number1 { get; set; }

        [Required]
        public double Number2 { get; set; }

        [Output]
        public double Result { get; set; }


        public override bool Execute()
        {
            Log.LogMessage(MessageImportance.High, "Multiplied 2 numbers", null);

            Result = Number1 * Number2;

            return true;
        }
    }
}
