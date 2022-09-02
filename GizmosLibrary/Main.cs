using OWML.ModHelper;

namespace GizmosLibrary
{
    public class Main : ModBehaviour
    {
        public override object GetApi() => new GizmosAPI();
    }
}
