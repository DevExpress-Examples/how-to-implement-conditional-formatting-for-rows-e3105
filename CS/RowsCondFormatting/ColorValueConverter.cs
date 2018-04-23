using System;
using System.Windows.Media;
using DevExpress.Xpf.Core.WPFCompatibility;
using System.Windows.Data;
using System.Globalization;

namespace RowsCondFormatting {
    public class ColorValueConverter : IValueConverter {

        public int MaxValue {get; set;}

        public int MinValue {get; set;}

        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            int count = MaxValue - (int)value;
            Color color = Color.FromArgb(0xff, 0xff, 0xAD, 0x5D);

            double r = color.R + (0xff - color.R) * count / ( MaxValue - MinValue);
            double g = color.G + (0xff - color.G) * count / ( MaxValue - MinValue);
            double b = color.B + (0xff - color.B) * count / ( MaxValue - MinValue);

            return new SolidColorBrush(Color.FromArgb(128, (byte)r, (byte)g, (byte)b));
        }

        public object ConvertBack(object value, Type targetType, object parameter,
        CultureInfo culture) {
            return null;
        }
        #endregion
    }
}
