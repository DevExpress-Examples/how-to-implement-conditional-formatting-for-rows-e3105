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
			Dim count As Integer = MaxValue - CInt(Fix(value))
			Dim color As Color = Color.FromArgb(&Hff, &Hff, &HAD, &H5D)

			Dim r As Double = color.R + (&Hff - color.R) * count / (MaxValue - MinValue)
			Dim g As Double = color.G + (&Hff - color.G) * count / (MaxValue - MinValue)
			Dim b As Double = color.B + (&Hff - color.B) * count / (MaxValue - MinValue)

			Return New SolidColorBrush(Color.FromArgb(128, CByte(r), CByte(g), CByte(b)))
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As CultureInfo) As Object Implements IValueConverter.ConvertBack
			Return Nothing
		End Function
		#End Region
	End Class
End Namespace
