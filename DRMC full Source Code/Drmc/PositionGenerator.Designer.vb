<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PositionGenerator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PositionGenerator))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.NamedOFForm = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me._3to8TotalMarksBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuksoftDataSet3 = New AukSoftware.auksoftDataSet1
        Me.AuksoftDataSet1 = New AukSoftware.auksoftDataSet1
        Me.Acc2ConvertBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Acc2ConvertTableAdapter = New AukSoftware.auksoftDataSet1TableAdapters.Acc2ConvertTableAdapter
        Me.InformationIDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InformationIDTableAdapter = New AukSoftware.auksoftDataSet1TableAdapters.InformationIDTableAdapter
        Me.AuksoftDataSet2 = New AukSoftware.auksoftDataSet1
        Me.Acc2ConvertBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._3to8TotalMarksTableAdapter = New AukSoftware.auksoftDataSet1TableAdapters._3to8TotalMarksTableAdapter
        Me.Button5 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.ToolStrip1.SuspendLayout()
        CType(Me._3to8TotalMarksBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuksoftDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuksoftDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Acc2ConvertBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.InformationIDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuksoftDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Acc2ConvertBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Black
        Me.ToolStrip1.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NamedOFForm, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(620, 25)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NamedOFForm
        '
        Me.NamedOFForm.AutoSize = False
        Me.NamedOFForm.BackColor = System.Drawing.Color.Transparent
        Me.NamedOFForm.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.NamedOFForm.ForeColor = System.Drawing.Color.White
        Me.NamedOFForm.Name = "NamedOFForm"
        Me.NamedOFForm.Size = New System.Drawing.Size(550, 22)
        Me.NamedOFForm.Text = "Position Generator"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.White
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "X"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(12, 329)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 24)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Generate Position"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(12, 269)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 24)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me._3to8TotalMarksBindingSource
        Me.ListBox1.DisplayMember = "TotalMarks"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(469, 70)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(131, 355)
        Me.ListBox1.TabIndex = 6
        '
        '_3to8TotalMarksBindingSource
        '
        Me._3to8TotalMarksBindingSource.DataMember = "3to8TotalMarks"
        Me._3to8TotalMarksBindingSource.DataSource = Me.AuksoftDataSet3
        '
        'AuksoftDataSet3
        '
        Me.AuksoftDataSet3.DataSetName = "auksoftDataSet1"
        Me.AuksoftDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AuksoftDataSet1
        '
        Me.AuksoftDataSet1.DataSetName = "auksoftDataSet1"
        Me.AuksoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Acc2ConvertBindingSource
        '
        Me.Acc2ConvertBindingSource.DataMember = "Acc2Convert"
        Me.Acc2ConvertBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Transparent
        Me.Button4.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(12, 359)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 24)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Save Generate Position"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(451, 80)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "View"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(268, 46)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(177, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Failed Students Position=0"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Transparent
        Me.Button3.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.Location = New System.Drawing.Point(12, 46)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(117, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "View In Grid"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Black
        Me.ComboBox1.ForeColor = System.Drawing.Color.White
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Third Convert", "Normal"})
        Me.ComboBox1.Location = New System.Drawing.Point(12, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ComboBox1.Size = New System.Drawing.Size(439, 21)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "Select How Generate Position"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.AliceBlue
        Me.Label5.Location = New System.Drawing.Point(21, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Label5"
        '
        'Acc2ConvertTableAdapter
        '
        Me.Acc2ConvertTableAdapter.ClearBeforeFill = True
        '
        'InformationIDBindingSource
        '
        Me.InformationIDBindingSource.DataMember = "InformationID"
        Me.InformationIDBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'InformationIDTableAdapter
        '
        Me.InformationIDTableAdapter.ClearBeforeFill = True
        '
        'AuksoftDataSet2
        '
        Me.AuksoftDataSet2.DataSetName = "auksoftDataSet1"
        Me.AuksoftDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Acc2ConvertBindingSource1
        '
        Me.Acc2ConvertBindingSource1.DataMember = "Acc2Convert"
        Me.Acc2ConvertBindingSource1.DataSource = Me.AuksoftDataSet2
        '
        '_3to8TotalMarksTableAdapter
        '
        Me._3to8TotalMarksTableAdapter.ClearBeforeFill = True
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Transparent
        Me.Button5.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(12, 299)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(184, 24)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Load Again"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(467, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Different Marks"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 245)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(184, 18)
        Me.ProgressBar1.TabIndex = 13
        Me.ProgressBar1.Visible = False
        '
        'PositionGenerator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AukSoftware.My.Resources.Resources.LabelS
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(620, 464)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PositionGenerator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PositionGenerator"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me._3to8TotalMarksBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuksoftDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuksoftDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Acc2ConvertBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.InformationIDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuksoftDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Acc2ConvertBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents NamedOFForm As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AuksoftDataSet1 As AukSoftware.auksoftDataSet1
    Friend WithEvents Acc2ConvertBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Acc2ConvertTableAdapter As AukSoftware.auksoftDataSet1TableAdapters.Acc2ConvertTableAdapter
    Friend WithEvents InformationIDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents InformationIDTableAdapter As AukSoftware.auksoftDataSet1TableAdapters.InformationIDTableAdapter
    Friend WithEvents AuksoftDataSet2 As AukSoftware.auksoftDataSet1
    Friend WithEvents AuksoftDataSet3 As AukSoftware.auksoftDataSet1
    Friend WithEvents Acc2ConvertBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents _3to8TotalMarksBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _3to8TotalMarksTableAdapter As AukSoftware.auksoftDataSet1TableAdapters._3to8TotalMarksTableAdapter
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
