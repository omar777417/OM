Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub
    Private Sub DateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        Timer1.Stop()
        Label1.Text = "Date :" & DateString

    End Sub
    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click

        Timer1.Stop()
        Label1.Text = DateTime.Now.ToLongTimeString()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Label1.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        End
    End Sub

    Private Sub MonthdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthdateToolStripMenuItem.Click
        Timer1.Stop()
        Label1.Text = "Month :" & DateTime.Now.Month.ToString()
    End Sub

    Private Sub YeardateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YeardateToolStripMenuItem.Click
        Timer1.Stop()
        Label1.Text = "Year :" & DateTime.Now.Year.ToString()
    End Sub

    Private Sub WeekdaydateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeekdaydateToolStripMenuItem.Click
        Timer1.Stop()
        Label1.Text = "Weekday :" & DateTime.Now.DayOfWeek.ToString()
    End Sub

    Private Sub HourdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourdateToolStripMenuItem.Click
        Timer1.Stop()
        Label1.Text = "Hour :" & DateTime.Now.Hour.ToString()
    End Sub
    Private Sub MinutedateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinutedateToolStripMenuItem.Click
        Timer1.Stop()
        Label1.Text = "Minute :" & DateTime.Now.Minute.ToString()
    End Sub

    Private Sub SeconddateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeconddateToolStripMenuItem.Click
        Timer1.Stop()
        Label1.Text = "Second :" & DateTime.Now.Second.ToString()
    End Sub

    Private Sub DateStringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateStringToolStripMenuItem.Click
        Timer1.Stop()
        Label1.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub NowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NowToolStripMenuItem.Click
        Timer1.Stop()
        Dim currentDate As String = DateTime.Now.ToShortDateString()
        Dim currentTime As String = DateTime.Now.ToLongTimeString()
        Label1.Text = "Date :" & currentDate & vbCrLf &
            "Time :" & currentTime
    End Sub

    Private Sub TimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimerToolStripMenuItem.Click
        Timer1.Start()
        Label1.Text = DateTime.Now.ToLongTimeString()
    End Sub
End Class