Imports System.Collections
Imports System.Windows.Forms

Public Class ListViewIntegerDescSorter
    Implements IComparer

    Public Function Compare(x As Object, y As Object) As Integer Implements IComparer.Compare
        Dim itemX As ListViewItem = CType(x, ListViewItem)
        Dim itemY As ListViewItem = CType(y, ListViewItem)

        ' Target index 1 (the 2nd column)
        Dim valX As Integer = 0
        Dim valY As Integer = 0

        ' Safely parse the text to integers to avoid crashes
        Integer.TryParse(itemX.SubItems(1).Text, valX)
        Integer.TryParse(itemY.SubItems(1).Text, valY)

        ' Reverse the standard comparison (valY to valX) to force Descending order
        Return valY.CompareTo(valX)
    End Function
End Class
