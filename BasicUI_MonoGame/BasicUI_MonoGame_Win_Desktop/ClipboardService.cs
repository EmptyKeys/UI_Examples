using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using EmptyKeys.UserInterface.Mvvm;

namespace BasicUI_MonoGame_Win_Desktop
{
    public class ClipboardService : IClipboardService
    {
        public string GetText()
        {
            string text = string.Empty;
            Thread thread = new Thread(() => text = Clipboard.GetText());
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
            return text;
        }

        public void SetText(string text)
        {
            Thread thread = new Thread(() => Clipboard.SetText(text));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();
        }
    }
}
