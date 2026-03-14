using Barotrauma;
using HarmonyLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RadialMenu.Items;
using System.Runtime.CompilerServices;


[assembly: IgnoresAccessChecksTo("Barotrauma")]
[assembly: IgnoresAccessChecksTo("DedicatedServer")]
[assembly: IgnoresAccessChecksTo("BarotraumaCore")]
[assembly: IgnoresAccessChecksTo("Microsoft.Xna.Framework")]

namespace RadialMenu.View
{
    [HarmonyPatch(typeof(GameScreen), "Draw")]
    internal class RadialMenuDrawer
    {
        private bool _isVisible = false;
        private static Texture2D _menuTexture;

#if CLIENT
        public void DrawMenu(IEnumerable<IRadialMenuItem> items)
        {
            
            var center = GameMain.Instance.Window.ClientBounds.Center.ToVector2();
            var itemsAmount = items.Count();
            MouseState currentMouseState = Mouse.GetState();
            _menuTexture = new Texture2D(GameMain.Instance.GraphicsDevice, 128, 128);


            Color[] data = new Color[128 * 128];
            for (int i = 0; i < 128; i++)
                for (int j = 0; j < 128; j++)
                {
                    data[i * 128 + j] = new Color((float)i * 128 / 256, (float)j * 128 / 256, 0);
                }
        }
#endif

        static void Postfix(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(
              _menuTexture,
              new Vector2(300, 300),
              Color.White
            );
        }

    }
}
