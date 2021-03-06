Imports System.Drawing
Imports Janus.Windows.GridEX
Imports Questify.Builder.PlugIns.DataSource.StaticGroups.Entities
Imports Questify.Builder.UI.Commanding

Public Class MoveDownCommand
    Inherits CommandBase

    Private _config As StaticGroupDataSourceConfig
    Private _ItemInGroupGrid As GridEX

    Public Sub New(config As StaticGroupDataSourceConfig, itemInGroupGrid As GridEX)
        If config Is Nothing Then
            Throw New ArgumentNullException("config")
        End If

        If itemInGroupGrid Is Nothing Then
            Throw New ArgumentNullException("itemInGroupGrid")
        End If

        Me._config = config
        Me._ItemInGroupGrid = itemInGroupGrid
    End Sub

    Public Overrides ReadOnly Property Image As Image
        Get
            Return My.Resources.MoveDownToolStripButton_Image
        End Get
    End Property

    Public Overrides ReadOnly Property Name As String
        Get
            Return "MoveDownCommand"
        End Get
    End Property

    Public Overrides ReadOnly Property NameLocalized As String
        Get
            Return My.Resources.MoveDownCommand_Name
        End Get
    End Property


    Public Overrides Sub Execute(parameter As Object)
        Dim selectedEntry = DirectCast(_ItemInGroupGrid.SelectedItems(0).GetRow().DataRow, StaticGroupEntry)
        Dim currentIndexOfEntry As Integer = _config.GroupDefinition.IndexOf(selectedEntry)

        _config.GroupDefinition.Remove(selectedEntry)
        _config.GroupDefinition.Insert(currentIndexOfEntry + 1, selectedEntry)

        _ItemInGroupGrid.Refetch()
        Dim gridRow As GridEXRow = _ItemInGroupGrid.GetRow(selectedEntry)
        _ItemInGroupGrid.MoveTo(gridRow)
    End Sub

    Protected Overrides Function GetCanExecuteState(parameter As Object) As Boolean
        If _ItemInGroupGrid.SelectedItems.Count > 0 Then
            Dim selectedEntry = DirectCast(_ItemInGroupGrid.SelectedItems(0).GetRow().DataRow, StaticGroupEntry)
            Dim currentIndexOfEntry As Integer = _config.GroupDefinition.IndexOf(selectedEntry)

            Return currentIndexOfEntry <> -1 AndAlso currentIndexOfEntry < _config.GroupDefinition.Count - 1
        Else
            Return False
        End If
    End Function

End Class