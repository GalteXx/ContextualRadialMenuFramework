namespace RadialMenu.Items
{
    public class ItemSelectedEventArgs : EventArgs
    {
        public RadialMenuItem SelectedItem { get; }

        public ItemSelectedEventArgs(RadialMenuItem selectedItem)
        {
            SelectedItem = selectedItem;
        }
    }
}
