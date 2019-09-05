using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace SDI.Converters {
    /// <summary>
    /// Convierte un numero a cadena
    /// </summary>
    public class StringToNullConverter : IValueConverter {
        #region Miembros de IValueConverter

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            if (value == null)
                return null;
            else if (String.IsNullOrWhiteSpace(value.ToString()))
                return null;
            return value;
        }
        #endregion
    }
}
