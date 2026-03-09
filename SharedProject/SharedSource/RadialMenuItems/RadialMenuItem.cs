using Barotrauma;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace RadialMenu
{
    internal class RadialMenuItem(string label, Sprite icon, bool isEnabled) : IRadialMenuItem
    {
        private string _label = label;
        private Sprite _icon = icon;
        private bool _isEnabled = isEnabled;

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

        private void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
