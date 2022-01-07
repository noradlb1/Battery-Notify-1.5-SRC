Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.Devices
Imports System.IO

Public Class Form5
    Dim sfO = "Software\Microsoft\Windows\CurrentVersion\Run"
    Dim EXE = "Battery Notify"
    Dim LO = New FileInfo(Application.ExecutablePath)
    Dim F = New Computer

    Public Function Startup() As Object
        Dim obj2 As Object
        Dim flagArray As Boolean()
        Dim flagArray2 As Boolean()
        Try
            Dim arguments As Object() = New Object() {Me.sfO, True}
            flagArray = New Boolean() {True, False}
            If flagArray(0) Then
                Me.sfO = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(arguments(0)), GetType(String)))
            End If
            Dim objArray4 As Object() = New Object() {Me.EXE, Operators.ConcatenateObject(Operators.ConcatenateObject(""""c, NewLateBinding.LateGet(Me.LO, Nothing, "FullName", New Object(0 - 1) {}, Nothing, Nothing, Nothing)), """"c)}
            flagArray2 = New Boolean() {True, False}
            NewLateBinding.LateCall(NewLateBinding.LateGet(NewLateBinding.LateGet(NewLateBinding.LateGet(Me.F, Nothing, "Registry", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "CurrentUser", New Object(0 - 1) {}, Nothing, Nothing, Nothing), Nothing, "OpenSubKey", arguments, Nothing, Nothing, flagArray), Nothing, "SetValue", objArray4, Nothing, Nothing, flagArray2, True)
            If flagArray2(0) Then
                Me.EXE = CStr(Conversions.ChangeType(RuntimeHelpers.GetObjectValue(objArray4(0)), GetType(String)))
            End If
        Catch exception1 As Exception
        End Try
        Return obj2
    End Function

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.CheckBox1.Checked = Form1.noti
    End Sub

    Private Sub BlackShadesNetButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlackShadesNetButton1.Click
        Form1.noti = Me.CheckBox1.Checked
        Form1.num = Convert.ToInt32(Me.NumericUpDown1.Value)
        If CheckBox2.Checked = True Then
            Startup()
        End If
        Me.Close()
    End Sub
End Class