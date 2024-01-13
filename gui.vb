Public Class Form1
    Private Sub Form1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias

        DrawTaijitu(g, New Point(50, 50), 200, True)
        DrawTaijitu(g, New Point(10, 10), 60, True)
    End Sub
    Private Sub DrawTaijitu(ByVal g As Graphics, ByVal pt As Point, ByVal width As Integer, ByVal hasOutline As Boolean)
        g.FillPie(Brushes.Black, pt.X, pt.Y, width, width, 90, 180)
        g.FillPie(Brushes.White, pt.X, pt.Y, width, width, 270, 180)
        g.FillEllipse(Brushes.Black, CSng(pt.X + (width * 0.25)), CSng(pt.Y), CSng(width * 0.5), CSng(width * 0.5))
        g.FillEllipse(Brushes.White, CSng(pt.X + (width * 0.25)), CSng(pt.Y + (width * 0.5)), CSng(width * 0.5), CSng(width * 0.5))
        g.FillEllipse(Brushes.White, CSng(pt.X + (width * 0.4375)), CSng(pt.Y + (width * 0.1875)), CSng(width * 0.125), CSng(width * 0.125))
        g.FillEllipse(Brushes.Black, CSng(pt.X + (width * 0.4375)), CSng(pt.Y + (width * 0.6875)), CSng(width * 0.125), CSng(width * 0.125))
        If hasOutline Then g.DrawEllipse(Pens.Black, pt.X, pt.Y, width, width)
    End Sub

End Class





Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim newForm As New Form

        newForm.Text = "It's a new window"
        newForm.Show()

    End Sub
End Class