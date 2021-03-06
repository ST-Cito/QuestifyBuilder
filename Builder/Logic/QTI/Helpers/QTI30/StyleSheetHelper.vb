﻿Imports System.IO
Imports Questify.Builder.Logic.QTI.Helpers.QTI_Base
Imports Questify.Builder.Logic.QTI.Xsd.QTI30

Namespace QTI.Helpers.QTI30

    Public Class QTI30StyleSheetHelper
        Inherits StyleSheetHelper

        Public Function GetStylesheetType(file As String, relativePathToResources As String) As StyleSheetType
            Dim f = file

            If Not f.StartsWith("cito_") AndAlso Not Path.GetExtension(f) = ".js" Then
                f = String.Concat("cito_", file)
            End If

            Dim returnValue As New StyleSheetType
            returnValue.href = $"{relativePathToResources.Replace("\", "/")}css/{f}"
            returnValue.type = "text/css"
            Return returnValue
        End Function

    End Class
End Namespace