﻿Imports Cito.Tester.Common

Public MustInherit Class QTI21ItemReferenceValidator(Of T As QTIItemReferenceBase)
    Inherits EntityValidationBase(Of T)
    Public Sub New()
        MyBase.New()
    End Sub


    Protected Overrides Function ValidateEntityFieldValue(entity As T, fieldName As String, value As Object) As String
        Select Case fieldName
            Case "Identifier"
                Return ValidationHelper.IsValidResourceCode(DirectCast(value, String))

            Case "Title"
                If Not ValidationHelper.IsNotEmpty(value) Then Return My.Resources.TitleIsARequiredField
        End Select

        Return String.Empty
    End Function
End Class
