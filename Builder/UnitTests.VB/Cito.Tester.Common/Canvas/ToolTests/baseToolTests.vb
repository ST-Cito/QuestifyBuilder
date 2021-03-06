﻿
Imports Cito.Tester.Common.Controls.Canvas
Imports System.Windows.Forms

Public Class baseToolTests

    Protected Added As Integer
    Protected Removed As Integer
    Protected Replace As Integer

    Protected Function TrackAndResetCounters() As EventHandler(Of NotifyCollectionChangedEventArgs)
        Added = 0 : Removed = 0 : Replace = 0
        Return Sub(s As Object, e As NotifyCollectionChangedEventArgs)
                   Select Case e.Action
                       Case NotifyCollectionChangedAction.Add
                           Added += 1
                       Case NotifyCollectionChangedAction.Remove
                           Removed += 1
                       Case NotifyCollectionChangedAction.Replace
                           Replace += 1
                       Case Else
                           Throw New Exception()
                   End Select
               End Sub
    End Function

    Protected Sub MoveMouseTo(x As Integer, y As Integer, c As ICanvas)
        c.Tool.MouseMove(c, New MouseEventArgs(MouseButtons.None, 0, x, y, 0))
    End Sub

    Protected Sub MouseClick(x As Integer, y As Integer, c As ICanvas)
        c.Tool.MouseDown(c, New MouseEventArgs(MouseButtons.Left, 0, x, y, 0))
        c.Tool.MouseUp(c, New MouseEventArgs(MouseButtons.Left, 0, x, y, 0))
    End Sub

End Class
