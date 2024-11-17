Public Class FormSize
    Private ReadOnly xDiv As Double
    Private ReadOnly yDiv As Double

    Public Sub New(oldSizeX As Integer, oldSizeY As Integer, newSizeX As Integer, newSizeY As Integer)
        xDiv = newSizeX / oldSizeX
        yDiv = newSizeY / oldSizeY
    End Sub

    Public Sub SetControl(control As Control, Optional font As Boolean = True)
        control.Location = New Point(Round(control.Location.X * xDiv), Round(control.Location.Y * yDiv))
        control.Size = New Size(Round(control.Size.Width * xDiv), Round(control.Size.Height * yDiv))
        If font Then
            control.Font = New Font(control.Font.FontFamily, Round(control.Font.Size * If(xDiv < yDiv, xDiv, yDiv)))
        End If
        If TypeOf control Is ListBox Then
            Dim lb As ListBox = control
            lb.ItemHeight = Round(lb.ItemHeight * yDiv)
        End If
    End Sub

    Public Sub SetControls(controls As Control.ControlCollection)
        For i As Integer = 0 To controls.Count - 1
            SetControl(controls(i))
        Next
    End Sub

    Public Function GetNewX(x As Integer) As Integer
        Return Round(x * xDiv)
    End Function

    Public Function GetNewY(y As Integer) As Integer
        Return Round(y * yDiv)
    End Function

    Public Shared Function Round(num As Double) As Integer
        Return Math.Round(num)
    End Function
End Class
