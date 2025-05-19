Public Class FormSize
    Private ReadOnly xDiv As Double
    Private ReadOnly yDiv As Double

    Public Sub New(oldSizeX As Integer, oldSizeY As Integer, newSizeX As Integer, newSizeY As Integer)
        xDiv = newSizeX / oldSizeX
        yDiv = newSizeY / oldSizeY
    End Sub

    Public Sub SetControl(control As Control, Optional setFont As Boolean = True, Optional loc As Boolean = True)
        If loc Then
            control.Location = New Point(Round(control.Location.X * xDiv), Round(control.Location.Y * yDiv))
        End If

        control.Size = New Size(Round(control.Size.Width * xDiv), Round(control.Size.Height * yDiv))

        If setFont Then
            Dim newSize As Single = Roundf(control.Font.Size * If((xDiv < yDiv AndAlso xDiv > 1) OrElse (xDiv > yDiv AndAlso xDiv < 1), xDiv, yDiv))
            control.Font = New Font(control.Font.FontFamily, newSize)
        End If
    End Sub

    Public Sub SetControls(controls As Control.ControlCollection)
        For Each ctrl As Control In controls
            SetControl(ctrl)
            If TypeOf ctrl Is Panel Then
                SetControls(ctrl.Controls)
            End If
        Next
    End Sub

    Public Function GetNewPoint(p As Point) As Point
        Return New Point(Round(p.X * xDiv), Round(p.Y * yDiv))
    End Function

    Public Function GetNewSize(sz As Size) As Size
        Return New Size(Round(sz.Width * xDiv), Round(sz.Height * yDiv))
    End Function

    Public Function GetNewX(x As Integer) As Integer
        Return Round(x * xDiv)
    End Function

    Public Function GetNewY(y As Integer) As Integer
        Return Round(y * yDiv)
    End Function

    Public Shared Function Round(num As Double) As Integer
        Return Math.Round(num)
    End Function

    Public Shared Function Roundf(num As Double) As Single
        Return Math.Round(num, 3)
    End Function
End Class
