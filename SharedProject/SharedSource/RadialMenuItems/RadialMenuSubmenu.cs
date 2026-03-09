using Barotrauma;
using RadialMenu;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SharedProject.SharedSource.RadialMenuItems
{
    public class RadialMenuSubmenu : IRadialMenuItem
    {
        private Sprite _icon;
        private string _label;
        private bool _isEnabled;

        public RadialMenuSubmenu(Sprite icon, string label, bool isEnabled, IEnumerable<IRadialMenuItem> items)
        {
            _icon = icon;
            _label = label;
            _isEnabled = isEnabled;
            SubmenuItems = [.. items.Take(10)];
            if (items.Count() > 10)
                DebugConsole.ThrowError("Amount of items that can be displayed at once is capped at 10");
        }

        public Sprite Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                OnPropertyChanged();
            }
        }
        public string Label
        {
            get => _label;
            set
            {
                _label = value;
                OnPropertyChanged();
            }
        }
        public bool IsEnable
        {
            get => _isEnabled;
            set
            {
                _isEnabled = value;
                OnPropertyChanged();
            }
        }


        public ObservableCollection<IRadialMenuItem> SubmenuItems { get; }

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
