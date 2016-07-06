
namespace Automobiles
{
    public class MiniCooper : IAutomobile
    {
        public string Name
        {
            get { return "Mini Cooper"; }
        }

        public string Start()
        {
            return "VRoooom!";
        }

        public string Stop()
        {
            return "Screech!";
        }
    }
}