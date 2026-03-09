using System.Collections.ObjectModel;

namespace RadialMenu
{
    public class RadialMenuContext
    {
        private bool _isActive;

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
