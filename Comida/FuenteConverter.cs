using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Comida
{
    class FuenteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string fuente = "";

            switch (value.ToString().ToLower())
            {
                case "americana":
                    fuente = "Slim Summer";
                    break;
                case "china":
                    fuente = "Chinese Wok Food ST";
                    break;
                case "mexicana":
                    fuente = "Taco Salad";
                    break;
            }

            return fuente;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
