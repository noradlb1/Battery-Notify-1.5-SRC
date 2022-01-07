Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports System.Runtime.InteropServices
Imports System.Security
Public Class Form3
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_DWMCOLORIZATIONCOLORCHANGED As Integer = 800
        If m.Msg = WM_DWMCOLORIZATIONCOLORCHANGED Then
            Dim l As Boolean = (m.LParam.ToInt32 = 0)
            Dim w As Integer = m.WParam.ToInt32
        End If
        MyBase.WndProc(m)
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Me.Opacity = 1
            Me.charge.Text = ("Charged " & Conversions.ToString(Form1.num) & "%")
            Me.CheckBox1.Checked = Form1.noti
            Me.Visible = True
            Dim x As Integer
            Dim y As Integer
            x = Screen.PrimaryScreen.WorkingArea.Width
            y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height
            Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width
                x = x - 1
                Me.Location = New Point(x, y)
            Loop
               My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.Background)
        Catch ex As Exception

        End Try

    End Sub


    Private Sub BlackShadesNetButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlackShadesNetButton1.Click
        Form1.check = False
        Form1.noti = Me.CheckBox1.Checked
        Me.Close()
    End Sub
End Class

