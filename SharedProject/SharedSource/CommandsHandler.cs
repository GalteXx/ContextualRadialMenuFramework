using Barotrauma;
using RadialMenu.Items;

namespace RadialMenu
{
    internal class CommandsHandler
    {
        private RadialMenuDrawer _drawer;
        public CommandsHandler()
        {
            _drawer = new();
        }

        public void RegisterCommands()
        {
            DebugConsole.Commands.Add(new DebugConsole.Command(
                "DrawRadialMenu",
                "Draws a fake radial menu, for debugging purposes",
                DrawMenuDebug));
        }

        private void DrawMenuDebug(string[] commandArgs)
        {
            var elementsAmount = Convert.ToInt16(commandArgs[0]);
            bool drawSubmenu = !(commandArgs.Length < 2 || commandArgs[1] == "false");

            var elements = new List<IRadialMenuItem>();
            for (int i = 0; i < elementsAmount; i++)
            {
                if (drawSubmenu)
                    elements.Add(new RadialMenuSubmenu($"Debug Submenu _{i}", null, i % 2 == 0, []));
                else
                    elements.Add(new RadialMenuItem("", null, i % 2 == 0));
            }
            _drawer.DrawMenu(elements);
        }


    }
}
