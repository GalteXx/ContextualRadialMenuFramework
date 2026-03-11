namespace RadialMenu
{
    internal class RadialMenu
    {
        public RadialMenuContext CurrentContext { get; private set; }



        public event EventHandler<ItemSelectedEventArgs>? ItemSelected;
    }
}