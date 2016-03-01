using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmptyKeys.UserInterface.Data;
using EmptyKeys.UserInterface.Input;
using EmptyKeys.UserInterface.Mvvm;

namespace GameData
{
    public class CustomWindow : WindowViewModel
    {
        private string textData;

        public string TextData
        {
            get { return textData; }
            set { SetProperty(ref textData, value); }
        }
            
        private ICommand hideCommand;

        public ICommand HideCommand
        {
            get { return hideCommand; }
            set { hideCommand = value; }
        }        

        public CustomWindow()
            : base("CustomWindowTemplate")
        {
            TextData = "Custom Window";

            Top = 10;
            Left = 700;
            Height = 100;
            Width = 200;
            Opacity = 0.9f;
            IsHitTestVisible = true;
            IsOnTop = true;
            Title = "Title";
            IsVisible = true;

            HideCommand = new RelayCommand(new Action<object>(OnHide));

            GeneratedPropertyInfo.RegisterGeneratedProperty(this.GetType(), "ManualBinding", typeof(ManualBindingProperty));
        }

        private void OnHide(object obj)
        {
            IsVisible = false;
        }
    }    
}
