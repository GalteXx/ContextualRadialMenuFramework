using Barotrauma;
using System.Collections.ObjectModel;

namespace RadialMenu
{
    public class RadialMenuContext
    {
        private bool _isActive;

        private readonly string _name;
        private readonly Sprite _icon;

        public RadialMenuContext(string name, Sprite icon, IEnumerable<IRadialMenuItem> menuItems)
        {
            _name = name;
            _icon = icon;
            MenuItems = [.. menuItems];
        }

        public ObservableCollection<IRadialMenuItem> MenuItems { get; }

        public event EventHandler? ItemSelected;

        public bool IsActive
        {
            get => _isActive;
            set
            {
                _isActive = value;
                if(_isActive)
                    RadialMenuContextManager.Instance.ActivateContext(this);
                else
                    RadialMenuContextManager.Instance.DeactivateContext(this);
            }
        }

    }
}
