Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Threading
Imports System.Windows.Forms
Public Class Form1

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Edited By : بہۣۗروفہۣۗسور الہۣۗنهہۣروانہۣ!", vbInformation, "Battery Notify 1.5")
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Thread.Sleep(&H7D0)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Me.test()
    End Sub

    Private Sub ExitApplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitApplicationToolStripMenuItem.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Opacity = 0
        Me.Width = Screen.PrimaryScreen.Bounds.Width
        Me.Height = CInt(Math.Round(CDbl((CDbl(Screen.PrimaryScreen.Bounds.Height) / 3))))
        Dim point2 As New Point(0, CInt(Math.Round(CDbl((CDbl(Screen.PrimaryScreen.Bounds.Height) / 3)))))
        Me.Location = point2
        Me.BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub notify_MouseClick(sender As Object, e As MouseEventArgs) Handles notify.MouseClick
        Me.menustrip.Show()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        Form5.ShowDialog()
    End Sub
    Private Sub test()
        Dim num2 As Single = (SystemInformation.PowerStatus.BatteryLifePercent * 100.0!)
        Dim num As Integer = CInt(Math.Round(CDbl(num2)))
        Dim batteryChargeStatus As Integer = CInt(SystemInformation.PowerStatus.BatteryChargeStatus)
        Dim str As String = Conversions.ToString(CInt(SystemInformation.PowerStatus.PowerLineStatus))
        Dim powerLineStatus As PowerLineStatus = SystemInformation.PowerStatus.PowerLineStatus
        Dim num3 As Single = (SystemInformation.PowerStatus.BatteryLifePercent * 100.0!)
        If (powerLineStatus = PowerLineStatus.Online) Then
            Me.notify.Text = (Conversions.ToString(num3) & "% Available (plugged in,Charging)")
            If ((num = Form1.num) And (batteryChargeStatus >= 1)) Then
                Dim form As New Form3
                If (Not Form1.check And Form1.noti) Then
                    My.Forms.Form3.Opacity = 1
                    Form1.check = True
                    form.Show()
                ElseIf (Form1.check AndAlso (powerLineStatus = powerLineStatus.Offline)) Then
                    Form1.check = False
                End If
            End If
        ElseIf (Form1.check And (powerLineStatus = powerLineStatus.Offline)) Then
            Me.notify.Text = (Conversions.ToString(num3) & "% Remaining")
            My.Forms.Form3.Close()
        Else
            Me.notify.Text = (Conversions.ToString(num3) & "% Remaining")
            My.Forms.Form3.Close()
            Me.Opacity = 0
        End If
    End Sub

    Private Sub Tim_Tick(sender As Object, e As EventArgs) Handles Tim.Tick
        Me.test()
    End Sub
    Public Sub toastnoti()
    End Sub

    Public Shared check As Boolean = False
    Public Shared noti As Boolean = True
    Public Shared num As Integer = 100

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class
