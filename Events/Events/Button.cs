using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Button
    {
        public event Action<string> OnClick;
        public void ClickButton()
        {
            OnClick?.Invoke("Button is clicked");
        }
    }
}
