<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options_settings
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Options_settings))
        Dim Principal_NameLabel As System.Windows.Forms.Label
        Dim Vice_Principal_NameLabel As System.Windows.Forms.Label
        Me.AuksoftDataSet1 = New AukSoftware.AuksoftDataSet1
        Me.CommentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommentsTableAdapter = New AukSoftware.AuksoftDataSet1TableAdapters.CommentsTableAdapter
        Me.CommentsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.CommentsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.Principal_NameTextBox = New System.Windows.Forms.TextBox
        Me.Vice_Principal_NameTextBox = New System.Windows.Forms.TextBox
        Principal_NameLabel = New System.Windows.Forms.Label
        Vice_Principal_NameLabel = New System.Windows.Forms.Label
        CType(Me.AuksoftDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommentsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommentsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'AuksoftDataSet1
        '
        Me.AuksoftDataSet1.DataSetName = "AuksoftDataSet1"
        Me.AuksoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommentsBindingSource
        '
        Me.CommentsBindingSource.DataMember = "Comments"
        Me.CommentsBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'CommentsTableAdapter
        '
        Me.CommentsTableAdapter.ClearBeforeFill = True
        '
        'CommentsBindingNavigator
        '
        Me.CommentsBindingNavigator.AddNewItem = Nothing
        Me.CommentsBindingNavigator.BindingSource = Me.CommentsBindingSource
        Me.CommentsBindingNavigator.CountItem = Nothing
        Me.CommentsBindingNavigator.DeleteItem = Nothing
        Me.CommentsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CommentsBindingNavigatorSaveItem})
        Me.CommentsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CommentsBindingNavigator.MoveFirstItem = Nothing
        Me.CommentsBindingNavigator.MoveLastItem = Nothing
        Me.CommentsBindingNavigator.MoveNextItem = Nothing
        Me.CommentsBindingNavigator.MovePreviousItem = Nothing
        Me.CommentsBindingNavigator.Name = "CommentsBindingNavigator"
        Me.CommentsBindingNavigator.PositionItem = Nothing
        Me.CommentsBindingNavigator.Size = New System.Drawing.Size(482, 25)
        Me.CommentsBindingNavigator.TabIndex = 0
        Me.CommentsBindingNavigator.Text = "BindingNavigator1"
        '
        'CommentsBindingNavigatorSaveItem
        '
        Me.CommentsBindingNavigatorSaveItem.Image = CType(resources.GetObject("CommentsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CommentsBindingNavigatorSaveItem.Name = "CommentsBindingNavigatorSaveItem"
        Me.CommentsBindingNavigatorSaveItem.Size = New System.Drawing.Size(77, 22)
        Me.CommentsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Principal_NameLabel
        '
        Principal_NameLabel.AutoSize = True
        Principal_NameLabel.BackColor = System.Drawing.Color.Transparent
        Principal_NameLabel.Location = New System.Drawing.Point(31, 43)
        Principal_NameLabel.Name = "Principal_NameLabel"
        Principal_NameLabel.Size = New System.Drawing.Size(81, 13)
        Principal_NameLabel.TabIndex = 1
        Principal_NameLabel.Text = "Principal Name:"
        '
        'Principal_NameTextBox
        '
        Me.Principal_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommentsBindingSource, "Principal_Name", True))
        Me.Principal_NameTextBox.Location = New System.Drawing.Point(118, 40)
        Me.Principal_NameTextBox.Name = "Principal_NameTextBox"
        Me.Principal_NameTextBox.Size = New System.Drawing.Size(347, 20)
        Me.Principal_NameTextBox.TabIndex = 2
        '
        'Vice_Principal_NameLabel
        '
        Vice_Principal_NameLabel.AutoSize = True
        Vice_Principal_NameLabel.BackColor = System.Drawing.Color.Transparent
        Vice_Principal_NameLabel.Location = New System.Drawing.Point(7, 69)
        Vice_Principal_NameLabel.Name = "Vice_Principal_NameLabel"
        Vice_Principal_NameLabel.Size = New System.Drawing.Size(105, 13)
        Vice_Principal_NameLabel.TabIndex = 3
        Vice_Principal_NameLabel.Text = "Vice Principal Name:"
        '
        'Vice_Principal_NameTextBox
        '
        Me.Vice_Principal_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CommentsBindingSource, "Vice_Principal_Name", True))
        Me.Vice_Principal_NameTextBox.Location = New System.Drawing.Point(118, 66)
        Me.Vice_Principal_NameTextBox.Name = "Vice_Principal_NameTextBox"
        Me.Vice_Principal_NameTextBox.Size = New System.Drawing.Size(347, 20)
        Me.Vice_Principal_NameTextBox.TabIndex = 4
        '
        'Options_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AukSoftware.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(482, 111)
        Me.Controls.Add(Vice_Principal_NameLabel)
        Me.Controls.Add(Me.Vice_Principal_NameTextBox)
        Me.Controls.Add(Principal_NameLabel)
        Me.Controls.Add(Me.Principal_NameTextBox)
        Me.Controls.Add(Me.CommentsBindingNavigator)
        Me.Name = "Options_settings"
        Me.Text = "Options_settings"
        CType(Me.AuksoftDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommentsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommentsBindingNavigator.ResumeLayout(False)
        Me.CommentsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AuksoftDataSet1 As AukSoftware.AuksoftDataSet1
    Friend WithEvents CommentsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CommentsTableAdapter As AukSoftware.AuksoftDataSet1TableAdapters.CommentsTableAdapter
    Friend WithEvents CommentsBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents CommentsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Principal_NameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Vice_Principal_NameTextBox As System.Windows.Forms.TextBox
End Class
