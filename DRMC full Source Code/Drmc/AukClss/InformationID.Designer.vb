<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformationID
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.FilesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowSelectorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ShowEntryFromToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CommonEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.AukSoftware.My.Resources.Resources.Pan_setting
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(219, 90)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(359, 396)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Working Category"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.AukSoftware.My.Resources.Resources.IcoAukSoft_copy
        Me.PictureBox1.Location = New System.Drawing.Point(640, 469)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(149, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(643, 542)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "AukOrganization"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Please Choose Working Category between " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "them..."
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.AukSoftware.My.Resources.Resource1._NewVista6Noborder
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(275, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 22)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Location = New System.Drawing.Point(176, 82)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(85, 17)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Work In Grid"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.RadioButton2.Location = New System.Drawing.Point(146, 105)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(115, 17)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.Text = "Work In Form View"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilesToolStripMenuItem, Me.WindowsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(792, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilesToolStripMenuItem
        '
        Me.FilesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowSelectorToolStripMenuItem, Me.ShowEntryFromToolStripMenuItem, Me.CommonEntryToolStripMenuItem})
        Me.FilesToolStripMenuItem.Name = "FilesToolStripMenuItem"
        Me.FilesToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FilesToolStripMenuItem.Text = "Files"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'ShowSelectorToolStripMenuItem
        '
        Me.ShowSelectorToolStripMenuItem.Name = "ShowSelectorToolStripMenuItem"
        Me.ShowSelectorToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ShowSelectorToolStripMenuItem.Text = "Show Selector"
        '
        'ShowEntryFromToolStripMenuItem
        '
        Me.ShowEntryFromToolStripMenuItem.Name = "ShowEntryFromToolStripMenuItem"
        Me.ShowEntryFromToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.ShowEntryFromToolStripMenuItem.Text = "Show Entry From"
        '
        'CommonEntryToolStripMenuItem
        '
        Me.CommonEntryToolStripMenuItem.Name = "CommonEntryToolStripMenuItem"
        Me.CommonEntryToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.CommonEntryToolStripMenuItem.Text = "Common Entry"
        '
        'InformationID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AukSoftware.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "InformationID"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InformationID(Students Profile)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FilesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowSelectorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowEntryFromToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommonEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
