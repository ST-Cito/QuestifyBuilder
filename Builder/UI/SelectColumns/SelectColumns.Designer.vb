<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SelectColumns
    Inherits System.Windows.Forms.UserControl

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SelectColumns))
        Me.AvailableColumnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OptionsValidatorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SelectedColumnsListBox = New System.Windows.Forms.ListBox()
        Me.SelectedColumnsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SelectColumnButton = New System.Windows.Forms.Button()
        Me.DeSelectColumnButton = New System.Windows.Forms.Button()
        Me.MoveUpButton = New System.Windows.Forms.Button()
        Me.MoveDownButton = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AvailableColumnsListView = New System.Windows.Forms.ListView()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        CType(Me.AvailableColumnsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OptionsValidatorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SelectedColumnsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        Me.AvailableColumnsBindingSource.DataMember = "AvailableColumns"
        Me.AvailableColumnsBindingSource.DataSource = Me.OptionsValidatorBindingSource
        Me.OptionsValidatorBindingSource.DataSource = GetType(SelectColumnsOptionsValidator)
        resources.ApplyResources(Me.SelectedColumnsListBox, "SelectedColumnsListBox")
        Me.SelectedColumnsListBox.DataSource = Me.SelectedColumnsBindingSource
        Me.SelectedColumnsListBox.FormattingEnabled = True
        Me.SelectedColumnsListBox.Name = "SelectedColumnsListBox"
        Me.TableLayoutPanel1.SetRowSpan(Me.SelectedColumnsListBox, 4)
        Me.SelectedColumnsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.SelectedColumnsBindingSource.DataMember = "SelectedColumns"
        Me.SelectedColumnsBindingSource.DataSource = Me.OptionsValidatorBindingSource
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        resources.ApplyResources(Me.SelectColumnButton, "SelectColumnButton")
        Me.SelectColumnButton.Name = "SelectColumnButton"
        Me.SelectColumnButton.UseVisualStyleBackColor = True
        Me.DeSelectColumnButton.BackColor = System.Drawing.SystemColors.Control
        resources.ApplyResources(Me.DeSelectColumnButton, "DeSelectColumnButton")
        Me.DeSelectColumnButton.Name = "DeSelectColumnButton"
        Me.DeSelectColumnButton.UseVisualStyleBackColor = True
        resources.ApplyResources(Me.MoveUpButton, "MoveUpButton")
        Me.MoveUpButton.Name = "MoveUpButton"
        Me.MoveUpButton.UseVisualStyleBackColor = True
        resources.ApplyResources(Me.MoveDownButton, "MoveDownButton")
        Me.MoveDownButton.Name = "MoveDownButton"
        Me.MoveDownButton.UseVisualStyleBackColor = True
        Me.ErrorProvider.ContainerControl = Me
        Me.ErrorProvider.DataSource = Me.OptionsValidatorBindingSource
        resources.ApplyResources(Me.TableLayoutPanel1, "TableLayoutPanel1")
        Me.TableLayoutPanel1.Controls.Add(Me.SelectedColumnsListBox, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DeSelectColumnButton, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MoveDownButton, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.MoveUpButton, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.SelectColumnButton, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AvailableColumnsListView, 0, 1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        resources.ApplyResources(Me.AvailableColumnsListView, "AvailableColumnsListView")
        Me.AvailableColumnsListView.CausesValidation = False
        Me.AvailableColumnsListView.HideSelection = False
        Me.AvailableColumnsListView.Name = "AvailableColumnsListView"
        Me.TableLayoutPanel1.SetRowSpan(Me.AvailableColumnsListView, 4)
        Me.AvailableColumnsListView.UseCompatibleStateImageBehavior = False
        Me.AvailableColumnsListView.View = System.Windows.Forms.View.Details
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "SelectColumns"
        CType(Me.AvailableColumnsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OptionsValidatorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SelectedColumnsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SelectedColumnsListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SelectColumnButton As System.Windows.Forms.Button
    Friend WithEvents DeSelectColumnButton As System.Windows.Forms.Button
    Friend WithEvents MoveUpButton As System.Windows.Forms.Button
    Friend WithEvents MoveDownButton As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Public WithEvents OptionsValidatorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvailableColumnsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SelectedColumnsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AvailableColumnsListView As System.Windows.Forms.ListView

End Class
