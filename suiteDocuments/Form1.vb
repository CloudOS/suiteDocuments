Public Class Form1
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
    Private Moving As Boolean

    Private offset As Size

    Private Sub Form1_Mousedown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        Moving = True

        offset = CType(e.Location, Drawing.Size)

    End Sub

    Private Sub Form1_Mousemove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If Moving Then

            Location = Point.Subtract(PointToScreen(e.Location), offset)

        End If

    End Sub

    Private Sub Form1_Mouseup(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        Moving = False

    End Sub
End Class
