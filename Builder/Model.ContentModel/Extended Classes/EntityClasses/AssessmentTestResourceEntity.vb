Imports Questify.Builder.Model.ContentModel.Interfaces

Namespace Questify.Builder.Model.ContentModel.EntityClasses
    Partial Public Class AssessmentTestResourceEntity
        Implements IVersionable

        Private _majorVersionLabel As String

        Public Overrides ReadOnly Property ResourceType() As String
            Get
                If Me.IsTemplate Then
                    Return My.Resources.TestTemplate
                Else
                    Return My.Resources.Test
                End If
            End Get
        End Property

        Public Property MajorVersionLabel As String Implements IVersionable.MajorVersionLabel
            Get
                Return _majorVersionLabel
            End Get
            Set(value As String)
                _majorVersionLabel = value
            End Set
        End Property

        Public ReadOnly Property SaveObjectAsBinary As Boolean Implements IVersionable.SaveObjectAsBinary
            Get
                Return True
            End Get
        End Property

        Public Overrides Property Version() As String Implements IVersionable.Version
            Get
                Return MyBase.Version
            End Get
            Set(value As String)
                MyBase.Version = Value
            End Set
        End Property

    End Class
End Namespace