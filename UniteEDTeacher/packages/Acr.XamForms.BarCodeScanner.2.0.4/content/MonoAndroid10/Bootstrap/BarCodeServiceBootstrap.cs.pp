// HACK: this is to deal with the linker nuking the assembly
using Acr.XamForms.BarCodeScanner;

namespace $rootnamespace$.Bootstrap
{
    public class BarCodeServiceBootstrap 
    {
        public BarCodeServiceBootstrap() 
        {
            new BarCodeService();
        }
    }
}