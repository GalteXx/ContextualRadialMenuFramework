using Barotrauma;

namespace RadialMenu.Context
{
    internal class RadialMenuContextManager
    {
        private static readonly RadialMenuContextManager instance = new(); //I wish I could use DI, but oh well
        public static RadialMenuContextManager Instance => instance;


        private readonly List<RadialMenuContext> ActiveContexts = [];
        private int _selectedContextIndex;

        public RadialMenuContext? SelectedActiveContext => ActiveContexts.Count == 0 ? null : ActiveContexts[_selectedContextIndex];

        public void ChangeSelectedActiveContext()
        {
            if (ActiveContexts.Count == 0)
                return;
            _selectedContextIndex = ++_selectedContextIndex % ActiveContexts.Count;
        }

        public void ActivateContext(RadialMenuContext context)
        {
            if (ActiveContexts.Contains(context))
            {
                DebugConsole.ThrowError("Attempted to enable already active context");
                return;
            }
            ActiveContexts.Add(context);
            _selectedContextIndex = ActiveContexts.Count - 1;
        }

        public void DeactivateContext(RadialMenuContext context)
        {
            if (!ActiveContexts.Remove(context))
            {
                DebugConsole.ThrowError("Attempted to Deactivate inactive context");
                return;
            }
            _selectedContextIndex = _selectedContextIndex >= ActiveContexts.Count ? ActiveContexts.Count - 1 : _selectedContextIndex;
        }
    }
}
