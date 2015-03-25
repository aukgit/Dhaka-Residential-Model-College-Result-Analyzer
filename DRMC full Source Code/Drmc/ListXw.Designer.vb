<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListXw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListXw))
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.ListBox2 = New System.Windows.Forms.ListBox
        Me.InformationIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuksoftDataSet1 = New AukSoftware.auksoftDataSet1
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.CheckBox2 = New System.Windows.Forms.CheckBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.CheckBox3 = New System.Windows.Forms.CheckBox
        Me.InformationIDTableAdapter = New AukSoftware.auksoftDataSet1TableAdapters.InformationIDTableAdapter
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button6 = New System.Windows.Forms.Button
        Me.ComboBox10 = New System.Windows.Forms.ComboBox
        CType(Me.InformationIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuksoftDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(320, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(185, 381)
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.InformationIDBindingSource
        Me.ListBox2.DisplayMember = "CollegeNo"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(12, 36)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(169, 381)
        Me.ListBox2.TabIndex = 1
        '
        'InformationIDBindingSource
        '
        Me.InformationIDBindingSource.DataMember = "InformationID"
        Me.InformationIDBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'AuksoftDataSet1
        '
        Me.AuksoftDataSet1.DataSetName = "auksoftDataSet1"
        Me.AuksoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(187, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = ">"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Whole Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(317, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "WorkingList"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 94)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 25)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(187, 125)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(127, 25)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Remove"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(187, 156)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(127, 25)
        Me.Button4.TabIndex = 7
        Me.Button4.Text = "Clear"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Location = New System.Drawing.Point(187, 187)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(127, 50)
        Me.CheckBox1.TabIndex = 8
        Me.CheckBox1.Text = "Add to List from main Databaselist when Clickon Item"
        Me.CheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox2.Checked = True
        Me.CheckBox2.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox2.Location = New System.Drawing.Point(187, 243)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(127, 50)
        Me.CheckBox2.TabIndex = 9
        Me.CheckBox2.Text = "Remove from  Workinglist when Click on Item"
        Me.CheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(187, 299)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 57)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Add in the Common add  List (Close this form)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'CheckBox3
        '
        Me.CheckBox3.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox3.Checked = True
        Me.CheckBox3.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox3.Location = New System.Drawing.Point(187, 362)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(127, 36)
        Me.CheckBox3.TabIndex = 11
        Me.CheckBox3.Text = "Adding time Clear Common adds List" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.CheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'InformationIDTableAdapter
        '
        Me.InformationIDTableAdapter.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Class"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 452)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Section"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(59, 449)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(59, 423)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(59, 475)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 482)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Shift"
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(59, 501)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(100, 25)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "Filter"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ComboBox10
        '
        Me.ComboBox10.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox10.FormattingEnabled = True
        Me.ComboBox10.Items.AddRange(New Object() {"Morning", "Day"})
        Me.ComboBox10.Location = New System.Drawing.Point(165, 474)
        Me.ComboBox10.Name = "ComboBox10"
        Me.ComboBox10.Size = New System.Drawing.Size(108, 21)
        Me.ComboBox10.TabIndex = 46
        '
        'ListXw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(512, 535)
        Me.Controls.Add(Me.ComboBox10)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "ListXw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adding With Common Add List"
        CType(Me.InformationIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuksoftDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents AuksoftDataSet1 As AukSoftware.auksoftDataSet1
    Friend WithEvents InformationIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InformationIDTableAdapter As AukSoftware.auksoftDataSet1TableAdapters.InformationIDTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents ComboBox10 As System.Windows.Forms.ComboBox
End Class
