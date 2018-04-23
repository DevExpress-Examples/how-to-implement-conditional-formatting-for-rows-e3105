# How to implement conditional formatting for rows


<p>The following sample demonstrates how to change the appearance of grid rows based on some condition. For example, in this tutorial you can see that the background color of grid rows is gradually changed based on the value in the Age data column.</p><p>This is done by binding the Background property of a Grid control placed within <strong>RowDecorationTemplate</strong>, to a specified column value. This converter is represented by the <strong>ColorValueConverter</strong> class that implements the <strong>IValueConverter</strong> interface and returns a color according to the provided numerical value.</p>

<br/>


