using Life;
using ModKit.Interfaces;
using ModKit.Internal;
using RTG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop581
{
    public class Main : ModKit.ModKit
    {
        public static PluginInformations Informations { get; private set; } = new PluginInformations("Shop581", "1.0.0", "Shape581");

        ///////////////////////////////////////////////
        //Ce Code n'est pas le code complet du Plugin//
        ///////////////////////////////////////////////

        public Main(IGameAPI api) : base(api) 
        {
            PluginInformations = new ModKit.Interfaces.PluginInformations("Shop581", "1.0.0", "Shop581");
        }

        public override void OnPluginInit()
        {
            base.OnPluginInit();
            Orm.RegisterTable<Shop581.ShopPoints>();
            Orm.RegisterTable<Shop581.ShopItems>();
            Orm.RegisterTable<Shop581.ShopPaterns>();
            Logger.LogSuccess(PluginInformations.SourceName, "Initialise !");
        }
    }
}
