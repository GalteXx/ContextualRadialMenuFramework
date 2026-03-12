using Barotrauma;
using System.ComponentModel;

namespace RadialMenu.Items
{
    public interface IRadialMenuItem : INotifyPropertyChanged
    {
        Sprite? Icon { get; set; }
        string Label { get; set; }
        bool IsEnable { get; set; }
    }
}
