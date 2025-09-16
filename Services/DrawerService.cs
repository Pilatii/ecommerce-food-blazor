namespace Cardapio.Services
{
    public class DrawerService
    {
        private Action<bool>? ToogleDrawer;
        private bool DrawerState;

        public void Register(Action<bool> toggleDrawer)
        {
            ToogleDrawer = toggleDrawer;
        }

        public void Open() => ToogleDrawer.Invoke(true);
        public void Close() => ToogleDrawer.Invoke(false);
        public void Toggle(bool state) => ToogleDrawer.Invoke(!state);


        public void SetState(bool state) => DrawerState = state;
    }
}
