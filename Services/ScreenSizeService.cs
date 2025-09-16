using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace Cardapio.Services

{
    public class ScreenSizeService
    {
        private readonly IJSRuntime _jsRuntime;
        private int Width;
        private int Height;
        private bool Initialized;

        public ScreenSizeService(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async Task InitializeAsync()
        {
            if (!Initialized)
            {
                var dimensions = await _jsRuntime.InvokeAsync<WindowDimensions>("getWindowDimensions");
                Width = dimensions.Width;
                Height = dimensions.Height;
                Initialized = true;
            }
        }

        public int GetWidth() => Width;
        public int GetHeight() => Height;

        private class WindowDimensions
        {
            public int Width { get; set; }
            public int Height { get; set; }
        }

    }
}
