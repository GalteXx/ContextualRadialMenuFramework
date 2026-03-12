using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using RadialMenu.Items;

namespace RadialMenu
{
    internal class RadialMenuDrawer
    {

        public void DrawMenu(IEnumerable<IRadialMenuItem> items)
        {
            var center = Game.Instance.Window.ClientBounds.Center;
            MouseState currentMouseState = Mouse.GetState();
        }

    }
}
