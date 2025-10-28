<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateStringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YeardateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeekdaydateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinutedateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeconddateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClockToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(462, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClockToolStripMenuItem
        '
        Me.ClockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem, Me.TimeToolStripMenuItem})
        Me.ClockToolStripMenuItem.Name = "ClockToolStripMenuItem"
        Me.ClockToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ClockToolStripMenuItem.Text = "Clock"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateStringToolStripMenuItem, Me.NowToolStripMenuItem, Me.MonthdateToolStripMenuItem, Me.YeardateToolStripMenuItem, Me.WeekdaydateToolStripMenuItem})
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.DateToolStripMenuItem.Text = "&Date"
        '
        'DateStringToolStripMenuItem
        '
        Me.DateStringToolStripMenuItem.Name = "DateStringToolStripMenuItem"
        Me.DateStringToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.DateStringToolStripMenuItem.Text = "&DateString"
        '
        'NowToolStripMenuItem
        '
        Me.NowToolStripMenuItem.Name = "NowToolStripMenuItem"
        Me.NowToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.NowToolStripMenuItem.Text = "&Now"
        '
        'MonthdateToolStripMenuItem
        '
        Me.MonthdateToolStripMenuItem.Name = "MonthdateToolStripMenuItem"
        Me.MonthdateToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MonthdateToolStripMenuItem.Text = "&Month(date)"
        '
        'YeardateToolStripMenuItem
        '
        Me.YeardateToolStripMenuItem.Name = "YeardateToolStripMenuItem"
        Me.YeardateToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.YeardateToolStripMenuItem.Text = "&Year(date)"
        '
        'WeekdaydateToolStripMenuItem
        '
        Me.WeekdaydateToolStripMenuItem.Name = "WeekdaydateToolStripMenuItem"
        Me.WeekdaydateToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.WeekdaydateToolStripMenuItem.Text = "&Weekday(date)"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimerToolStripMenuItem, Me.HourdateToolStripMenuItem, Me.MinutedateToolStripMenuItem, Me.SeconddateToolStripMenuItem})
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(100, 22)
        Me.TimeToolStripMenuItem.Text = "&Time"
        '
        'TimerToolStripMenuItem
        '
        Me.TimerToolStripMenuItem.Name = "TimerToolStripMenuItem"
        Me.TimerToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.TimerToolStripMenuItem.Text = "&Timer"
        '
        'HourdateToolStripMenuItem
        '
        Me.HourdateToolStripMenuItem.Name = "HourdateToolStripMenuItem"
        Me.HourdateToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.HourdateToolStripMenuItem.Text = "&Hour(date)"
        '
        'MinutedateToolStripMenuItem
        '
        Me.MinutedateToolStripMenuItem.Name = "MinutedateToolStripMenuItem"
        Me.MinutedateToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.MinutedateToolStripMenuItem.Text = "&Minute(date)"
        '
        'SeconddateToolStripMenuItem
        '
        Me.SeconddateToolStripMenuItem.Name = "SeconddateToolStripMenuItem"
        Me.SeconddateToolStripMenuItem.Size = New System.Drawing.Size(144, 22)
        Me.SeconddateToolStripMenuItem.Text = "&Second(date)"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Blue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 75)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Lime
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 12.0!, CType(((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline) _
                Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(311, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "خروج"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(462, 261)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents DateStringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YeardateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeekdaydateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HourdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinutedateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeconddateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimerToolStripMenuItem As ToolStripMenuItem
End Class
