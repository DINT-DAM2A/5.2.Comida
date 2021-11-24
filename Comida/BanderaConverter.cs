using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{
    class BanderaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string ruta = "";

            switch (value.ToString().ToLower())
            {
                case "americana":
                    ruta = "img/united_states.png";
                    break;
                case "china":
                    ruta = "img/china.png";
                    break;
                case "mexicana":
                    ruta = "img/mexico.png";
                    break;
            }

            return ruta;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
