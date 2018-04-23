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
            double ratio = (MaxValue - (int)value) / (double)(MaxValue - MinValue);
            return new SolidColorBrush(Color.FromArgb(128, 0xff, (byte)(0xAD + (0xff - 0xAD) * ratio), (byte)(0x5D + (0xff - 0x5D) * ratio)));
        }

        public object ConvertBack(object value, Type targetType, object parameter,
        CultureInfo culture) {
            return null;
        }
        #endregion
    }
}
