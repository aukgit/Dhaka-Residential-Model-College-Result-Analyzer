<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Logo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logo))
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(0, 0)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(600, 150)
        Me.AxShockwaveFlash1.TabIndex = 0
        '
        'Logo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 150)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Logo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logo"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
End Class
