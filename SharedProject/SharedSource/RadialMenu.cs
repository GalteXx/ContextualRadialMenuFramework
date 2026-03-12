using RadialMenu.Context;
using RadialMenu.Items;

namespace RadialMenu
{
    internal sealed class RadialMenu
    {
        public RadialMenuContext? CurrentContext { get; private set; }



        public event EventHandler<ItemSelectedEventArgs>? ItemSelected;
    }
}