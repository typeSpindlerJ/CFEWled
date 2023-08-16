using Kevsoft.WLED;
using System.Xml;

namespace LEDControl.Pages
{
    public partial class Controller1
    {
        private int currentCount = 0;
        private WLedClient _client = new("http://192.168.0.100/");

        private async void TurnOff()
        {
            currentCount++;

            await _client.Post(new StateRequest { On = false });

        }

        private async void TurnOn()
        {
            currentCount++;
            await _client.Post(new StateRequest { On = true });

        }

        private async void Effect()
        {
            currentCount++;


            var something = new StateRequest()
            {
                On = true,
                Brightness = 128,
                MainSegment = new SegmentRequest()
                {
                    EffectId = 
                }
            };

  


            await _client.Post(new SegmentRequest[] {en});
        }
    }
}
