using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PinMaui.ViewModels
{
    public class PinViewModel : BaseViewModel
    {
        #region Popiedades
        private string text;
        public string Text
        {
            get
            {
                return text;
            }
            set
            {
                text = value;
                LoadItemId(value);
            }
        }
        #endregion

        public ObservableCollection<Pin> Pins { get; }
        public PinViewModel()
        {
            Pins = new ObservableCollection<Pin>();
        }

        public void OnAppearing()
        {
            if (Pins.Count <= 0)
            {
                Pins.Add(new Pin { Existe = false });
                Pins.Add(new Pin { Existe = false });
                Pins.Add(new Pin { Existe = false });
                Pins.Add(new Pin { Existe = false });
            }
        }

        private void LoadItemId(string value)
        {
            for (int i = 0; i < 4; i++)
            {
                Pins[i] = new Pin { Existe = false };
            }

            for (int i = 0; i < value.Length; i++)
            {
                Pins[i] = new Pin { Existe = true };
            }
        }

        public void Focus()
        {
            //for (int i = 0; i < 4; i++)
            //{
            //    Pins[i] = new Pin { Existe = false };
            //}
        }
    }

    public class Pin
    {
        public string Letra { get; set; }
        public string Color { get; set; }
        public int Zize { get; set; }
        public string Icono { get; set; } = "&#xf111;";
        public bool Existe { get; set; }
    }
}
