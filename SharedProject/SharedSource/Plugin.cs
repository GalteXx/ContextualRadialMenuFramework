using Barotrauma;

using System.Runtime.CompilerServices;
using SharedProject.SharedSource;
using Microsoft.Xna.Framework;
[assembly: IgnoresAccessChecksTo("Barotrauma")]
[assembly: IgnoresAccessChecksTo("DedicatedServer")]
[assembly:IgnoresAccessChecksTo("Microsoft.Xna.Framework")]
[assembly: IgnoresAccessChecksTo("BarotraumaCore")]

namespace RadialMenu
{
    public partial class RadialMenuPlugin : IAssemblyPlugin
    {
        private CommandsHandler _commandsHandler;

        public void Initialize()
        {
        }

        public void OnLoadCompleted()
        {
            DebugConsole.NewMessage("CRMF loaded");
            _commandsHandler = new();
            _commandsHandler.RegisterCommands();
            var gi = GameMain.Instance;
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
