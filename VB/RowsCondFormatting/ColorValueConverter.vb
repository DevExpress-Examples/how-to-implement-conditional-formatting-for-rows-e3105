Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Media
Imports DevExpress.Xpf.Core.WPFCompatibility
Imports System.Windows.Data
Imports System.Globalization

Namespace RowsCondFormatting
	Public Class ColorValueConverter
		Implements IValueConverter

		Private privateMaxValue As Integer
		Public Property MaxValue() As Integer
			Get
				Return privateMaxValue
			End Get
			Set(ByVal value As Integer)
				privateMaxValue = value
			End Set
		End Property

		Private privateMinValue As Integer
		Public Property MinValue() As Integer
			Get
				Return privateMinValue
			End Get
			Set(ByVal value As Integer)
				privateMinValue = value
			End Set
		End Property

		#Region "IValueConverter Members"
        Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.Convert
            Dim ratio As Double = (MaxValue - CInt(Fix(value))) / CDbl(MaxValue - MinValue)
            Return New SolidColorBrush(color.FromArgb(128, &HFF, CByte(&HAD + (&HFF - &HAD) * ratio), CByte(&H5D + (&HFF - &H5D) * ratio)))
        End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Nothing
		End Function
		#End Region
	End Class
End Namespace
