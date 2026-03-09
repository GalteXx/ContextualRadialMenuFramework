using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using Barotrauma;

using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
[assembly: IgnoresAccessChecksTo("Barotrauma")]
[assembly: IgnoresAccessChecksTo("DedicatedServer")]
[assembly: IgnoresAccessChecksTo("BarotraumaCore")]

namespace RadialMenu
{
    public partial class RadialMenuPlugin : IAssemblyPlugin
    {
        public void Initialize()
        {

        }

        public void OnLoadCompleted()
        {
            DebugConsole.NewMessage("CRMF loaded");
            // After all plugins have loaded
            // Put code that interacts with other plugins here.
            
        }

        public void PreInitPatching()
        {
            // Not yet supported: Called during the Barotrauma startup phase before vanilla content is loaded.
        }

        public void Dispose()
        {
            // Cleanup your plugin!
            throw new NotImplementedException();
        }
    }
}
