using Barotrauma;
using HarmonyLib;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using RadialMenu.Items;

namespace RadialMenu.View
{
    [HarmonyPatch(typeof(GameScreen), "Draw")]
    internal class RadialMenuDrawer
    {
        private bool _isVisible = false;
        private static Texture2D _menuTexture;

        public void DrawMenu(IEnumerable<IRadialMenuItem> items)
        {
            var center = Game.Instance.Window.ClientBounds.Center.ToVector2();
            var itemsAmount = items.Count();
            MouseState currentMouseState = Mouse.GetState();

            /*for (int i = 0; i < itemsAmount; i++)
                        {
                            float a = i * (MathF.PI * 2 / itemsAmount);

                            Vector2 pos = center + new Vector2(
                                MathF.Cos(a),
                                MathF.Sin(a)
                            ) * 80f;


                        }*/
#if CLIENT
            _menuTexture = new Texture2D(GameMain.Instance.GraphicsDevice, 128, 128);
#endif
            Color[] data = new Color[128 * 128];
            for (int i = 0; i < 128; i++)
                for (int j = 0; j < 128; j++)
                {

                }
        }

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
