<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QueryManager
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
        Dim YearLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QueryManager))
        Dim TermLabel As System.Windows.Forms.Label
        Dim ClassLabel As System.Windows.Forms.Label
        Dim SectionLabel As System.Windows.Forms.Label
        Dim SubjectLabel As System.Windows.Forms.Label
        Dim ShiftLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaveNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OpenAndSavedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ChangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.SectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.ShiftToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox
        Me.TermsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TermsComboX = New System.Windows.Forms.ToolStripComboBox
        Me.SubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SubCombox = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripSplitButton
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.TermSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AuksoftDataSet1 = New AukSoftware.auksoftDataSet1
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SavedTopic = New System.Windows.Forms.ComboBox
        Me.SavedTopicBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox
        Me.ShiftTextBox = New System.Windows.Forms.TextBox
        Me.SubjectTextBox = New System.Windows.Forms.TextBox
        Me.SectionTextBox = New System.Windows.Forms.TextBox
        Me.ClassTextBox = New System.Windows.Forms.TextBox
        Me.TermTextBox = New System.Windows.Forms.TextBox
        Me.YearTextBox = New System.Windows.Forms.TextBox
        Me.SubjectCombo = New System.Windows.Forms.ComboBox
        Me.SubLstFor9_Human = New System.Windows.Forms.ComboBox
        Me.SublstFor9_Science = New System.Windows.Forms.ComboBox
        Me.SavedTopicBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.SavedTopicBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ServiceController1 = New System.ServiceProcess.ServiceController
        Me.Group = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.SubjectsCollectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SavedTopicTableAdapter = New AukSoftware.auksoftDataSet1TableAdapters.SavedTopicTableAdapter
        Me.SubjectsCollectionTableAdapter = New AukSoftware.auksoftDataSet1TableAdapters.SubjectsCollectionTableAdapter
        Me.TermSTableAdapter = New AukSoftware.auksoftDataSet1TableAdapters.TermSTableAdapter
        Me.ClassOptionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClassOptionsTableAdapter = New AukSoftware.auksoftDataSet1TableAdapters.ClassOptionsTableAdapter
        Me.SubjectPositionTableAdapter1 = New AukSoftware.auksoftDataSet1TableAdapters.SubjectPositionTableAdapter
        Me.Acc2SubjectTableAdapter1 = New AukSoftware.auksoftDataSet1TableAdapters.Acc2SubjectTableAdapter
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResultSheetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ResultEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CommentsEntryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MarksDistrubitionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PositionGeneratorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UnProgrammaticResultviewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClassOptionsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SubjectEditorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SubjectsCollectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PrintToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SubjectPositionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        YearLabel = New System.Windows.Forms.Label
        TermLabel = New System.Windows.Forms.Label
        ClassLabel = New System.Windows.Forms.Label
        SectionLabel = New System.Windows.Forms.Label
        SubjectLabel = New System.Windows.Forms.Label
        ShiftLabel = New System.Windows.Forms.Label
        Label1 = New System.Windows.Forms.Label
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TermSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AuksoftDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedTopicBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedTopicBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SavedTopicBindingNavigator.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SubjectsCollectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClassOptionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip2.SuspendLayout()
        CType(Me.SubjectPositionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'YearLabel
        '
        YearLabel.AutoSize = True
        YearLabel.ContextMenuStrip = Me.ContextMenuStrip1
        YearLabel.Location = New System.Drawing.Point(29, 69)
        YearLabel.Name = "YearLabel"
        YearLabel.Size = New System.Drawing.Size(36, 13)
        YearLabel.TabIndex = 0
        YearLabel.Text = "Year:"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.BackgroundImage = Global.AukSoftware.My.Resources.Resources.Crystal1
        Me.ContextMenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ContextMenuStrip1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.SaveNewToolStripMenuItem, Me.OpenAndSavedToolStripMenuItem, Me.ToolStripSeparator3, Me.ChangesToolStripMenuItem, Me.ToolStripSeparator4, Me.ToolStripMenuItem5, Me.ToolStripMenuItem1, Me.ToolStripMenuItem9, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripSeparator5, Me.ToolStripMenuItem6, Me.ToolStripMenuItem7, Me.ToolStripSeparator6})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.OwnerItem = Me.ToolStripButton4
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(335, 270)
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveNewToolStripMenuItem
        '
        Me.SaveNewToolStripMenuItem.Name = "SaveNewToolStripMenuItem"
        Me.SaveNewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.SaveNewToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.SaveNewToolStripMenuItem.Text = "SaveNew"
        '
        'OpenAndSavedToolStripMenuItem
        '
        Me.OpenAndSavedToolStripMenuItem.Name = "OpenAndSavedToolStripMenuItem"
        Me.OpenAndSavedToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.OpenAndSavedToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.OpenAndSavedToolStripMenuItem.Text = "Open And Saved"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(331, 6)
        Me.ToolStripSeparator3.Visible = False
        '
        'ChangesToolStripMenuItem
        '
        Me.ChangesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClassToolStripMenuItem, Me.SectionToolStripMenuItem, Me.ShiftToolStripMenuItem, Me.TermsToolStripMenuItem, Me.SubjectToolStripMenuItem})
        Me.ChangesToolStripMenuItem.Name = "ChangesToolStripMenuItem"
        Me.ChangesToolStripMenuItem.Size = New System.Drawing.Size(334, 22)
        Me.ChangesToolStripMenuItem.Text = "Changes"
        Me.ChangesToolStripMenuItem.Visible = False
        '
        'ClassToolStripMenuItem
        '
        Me.ClassToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1})
        Me.ClassToolStripMenuItem.Name = "ClassToolStripMenuItem"
        Me.ClassToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ClassToolStripMenuItem.Text = "Class"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 14)
        '
        'SectionToolStripMenuItem
        '
        Me.SectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox2})
        Me.SectionToolStripMenuItem.Name = "SectionToolStripMenuItem"
        Me.SectionToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SectionToolStripMenuItem.Text = "Section"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 14)
        '
        'ShiftToolStripMenuItem
        '
        Me.ShiftToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1})
        Me.ShiftToolStripMenuItem.Name = "ShiftToolStripMenuItem"
        Me.ShiftToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.ShiftToolStripMenuItem.Text = "Shift"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Morning", "Day"})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 21)
        '
        'TermsToolStripMenuItem
        '
        Me.TermsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TermsComboX})
        Me.TermsToolStripMenuItem.Name = "TermsToolStripMenuItem"
        Me.TermsToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.TermsToolStripMenuItem.Text = "Terms"
        '
        'TermsComboX
        '
        Me.TermsComboX.Name = "TermsComboX"
        Me.TermsComboX.Size = New System.Drawing.Size(121, 21)
        '
        'SubjectToolStripMenuItem
        '
        Me.SubjectToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubCombox})
        Me.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem"
        Me.SubjectToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.SubjectToolStripMenuItem.Text = "Subject"
        '
        'SubCombox
        '
        Me.SubCombox.Name = "SubCombox"
        Me.SubCombox.Size = New System.Drawing.Size(121, 21)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(331, 6)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(334, 22)
        Me.ToolStripMenuItem5.Text = "MainMenu"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
                    Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(334, 22)
        Me.ToolStripMenuItem1.Text = "ShowQueryManager"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(334, 22)
        Me.ToolStripMenuItem9.Text = "Hide QueryManager"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(334, 22)
        Me.ToolStripMenuItem3.Text = "InformationID(Students Informations)"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(334, 22)
        Me.ToolStripMenuItem4.Text = "TermEditor"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(331, 6)
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(334, 22)
        Me.ToolStripMenuItem6.Text = "ExitFromSoft"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.ShortcutKeyDisplayString = "Alt+F4"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(334, 22)
        Me.ToolStripMenuItem7.Text = "ExitFromQueryManager"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(331, 6)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton4.DropDown = Me.ContextMenuStrip1
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripButton4.Text = "Menu"
        Me.ToolStripButton4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TermLabel
        '
        TermLabel.AutoSize = True
        TermLabel.ContextMenuStrip = Me.ContextMenuStrip1
        TermLabel.Location = New System.Drawing.Point(25, 97)
        TermLabel.Name = "TermLabel"
        TermLabel.Size = New System.Drawing.Size(40, 13)
        TermLabel.TabIndex = 2
        TermLabel.Text = "Term:"
        '
        'ClassLabel
        '
        ClassLabel.AutoSize = True
        ClassLabel.ContextMenuStrip = Me.ContextMenuStrip1
        ClassLabel.Location = New System.Drawing.Point(26, 155)
        ClassLabel.Name = "ClassLabel"
        ClassLabel.Size = New System.Drawing.Size(39, 13)
        ClassLabel.TabIndex = 4
        ClassLabel.Text = "Class:"
        '
        'SectionLabel
        '
        SectionLabel.AutoSize = True
        SectionLabel.ContextMenuStrip = Me.ContextMenuStrip1
        SectionLabel.Location = New System.Drawing.Point(13, 182)
        SectionLabel.Name = "SectionLabel"
        SectionLabel.Size = New System.Drawing.Size(52, 13)
        SectionLabel.TabIndex = 6
        SectionLabel.Text = "Section:"
        '
        'SubjectLabel
        '
        SubjectLabel.AutoSize = True
        SubjectLabel.ContextMenuStrip = Me.ContextMenuStrip1
        SubjectLabel.Location = New System.Drawing.Point(12, 211)
        SubjectLabel.Name = "SubjectLabel"
        SubjectLabel.Size = New System.Drawing.Size(53, 13)
        SubjectLabel.TabIndex = 8
        SubjectLabel.Text = "Subject:"
        '
        'ShiftLabel
        '
        ShiftLabel.AutoSize = True
        ShiftLabel.ContextMenuStrip = Me.ContextMenuStrip1
        ShiftLabel.Location = New System.Drawing.Point(29, 267)
        ShiftLabel.Name = "ShiftLabel"
        ShiftLabel.Size = New System.Drawing.Size(36, 13)
        ShiftLabel.TabIndex = 10
        ShiftLabel.Text = "Shift:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.ContextMenuStrip = Me.ContextMenuStrip1
        Label1.Location = New System.Drawing.Point(537, 16)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(75, 13)
        Label1.TabIndex = 21
        Label1.Text = "SavedTopic:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.ToolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ToolStrip1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.AutoSize = False
        Me.ToolStripLabel1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(760, 22)
        Me.ToolStripLabel1.Text = "Query Manager"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "X"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.BackgroundImage = Global.AukSoftware.My.Resources.Resources.AlienAqua_avedesk
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.GroupBox1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Label1)
        Me.GroupBox1.Controls.Add(Me.SavedTopic)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(ShiftLabel)
        Me.GroupBox1.Controls.Add(Me.ShiftTextBox)
        Me.GroupBox1.Controls.Add(SubjectLabel)
        Me.GroupBox1.Controls.Add(Me.SubjectTextBox)
        Me.GroupBox1.Controls.Add(SectionLabel)
        Me.GroupBox1.Controls.Add(Me.SectionTextBox)
        Me.GroupBox1.Controls.Add(ClassLabel)
        Me.GroupBox1.Controls.Add(Me.ClassTextBox)
        Me.GroupBox1.Controls.Add(TermLabel)
        Me.GroupBox1.Controls.Add(Me.TermTextBox)
        Me.GroupBox1.Controls.Add(YearLabel)
        Me.GroupBox1.Controls.Add(Me.YearTextBox)
        Me.GroupBox1.Controls.Add(Me.SubjectCombo)
        Me.GroupBox1.Controls.Add(Me.SubLstFor9_Human)
        Me.GroupBox1.Controls.Add(Me.SublstFor9_Science)
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(23, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(740, 366)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OpenDatabase / Login / Query Manager"
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(534, 54)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(191, 23)
        Me.Button5.TabIndex = 30
        Me.Button5.TabStop = False
        Me.Button5.Text = "Change Topic"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button6.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(591, 186)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(143, 23)
        Me.Button6.TabIndex = 27
        Me.Button6.TabStop = False
        Me.Button6.Text = "Class Update"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(93, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Junior Section"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.TermSBindingSource
        Me.ComboBox1.DisplayMember = "TermName"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(70, 122)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox1.TabIndex = 4
        '
        'TermSBindingSource
        '
        Me.TermSBindingSource.DataMember = "TermS"
        Me.TermSBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'AuksoftDataSet1
        '
        Me.AuksoftDataSet1.DataSetName = "auksoftDataSet1"
        Me.AuksoftDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.BackgroundImage = CType(resources.GetObject("Button4.BackgroundImage"), System.Drawing.Image)
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(591, 302)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(143, 23)
        Me.Button4.TabIndex = 25
        Me.Button4.TabStop = False
        Me.Button4.Text = "Open"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(591, 273)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(143, 23)
        Me.Button3.TabIndex = 24
        Me.Button3.TabStop = False
        Me.Button3.Text = "Save and Open"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(591, 244)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(143, 23)
        Me.Button2.TabIndex = 23
        Me.Button2.TabStop = False
        Me.Button2.Text = "Save"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(591, 215)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 23)
        Me.Button1.TabIndex = 22
        Me.Button1.TabStop = False
        Me.Button1.Text = "Save New"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SavedTopic
        '
        Me.SavedTopic.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SavedTopic.DataSource = Me.SavedTopicBindingSource
        Me.SavedTopic.DisplayMember = "SavedTopic"
        Me.SavedTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SavedTopic.FormattingEnabled = True
        Me.SavedTopic.Location = New System.Drawing.Point(534, 32)
        Me.SavedTopic.Name = "SavedTopic"
        Me.SavedTopic.Size = New System.Drawing.Size(191, 21)
        Me.SavedTopic.TabIndex = 22
        '
        'SavedTopicBindingSource
        '
        Me.SavedTopicBindingSource.DataMember = "SavedTopic"
        Me.SavedTopicBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Morning", "Day"})
        Me.ComboBox2.Location = New System.Drawing.Point(70, 292)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox2.TabIndex = 18
        '
        'ShiftTextBox
        '
        Me.ShiftTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ShiftTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SavedTopicBindingSource, "Shift", True))
        Me.ShiftTextBox.Location = New System.Drawing.Point(70, 264)
        Me.ShiftTextBox.Name = "ShiftTextBox"
        Me.ShiftTextBox.ReadOnly = True
        Me.ShiftTextBox.Size = New System.Drawing.Size(170, 21)
        Me.ShiftTextBox.TabIndex = 17
        Me.ShiftTextBox.TabStop = False
        Me.ShiftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SubjectTextBox
        '
        Me.SubjectTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SavedTopicBindingSource, "Subject", True))
        Me.SubjectTextBox.Location = New System.Drawing.Point(70, 207)
        Me.SubjectTextBox.Name = "SubjectTextBox"
        Me.SubjectTextBox.ReadOnly = True
        Me.SubjectTextBox.Size = New System.Drawing.Size(170, 21)
        Me.SubjectTextBox.TabIndex = 9
        Me.SubjectTextBox.TabStop = False
        Me.SubjectTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SectionTextBox
        '
        Me.SectionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SectionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SavedTopicBindingSource, "Section", True))
        Me.SectionTextBox.Location = New System.Drawing.Point(70, 179)
        Me.SectionTextBox.Name = "SectionTextBox"
        Me.SectionTextBox.Size = New System.Drawing.Size(170, 21)
        Me.SectionTextBox.TabIndex = 7
        Me.SectionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ClassTextBox
        '
        Me.ClassTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ClassTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SavedTopicBindingSource, "Class", True))
        Me.ClassTextBox.Location = New System.Drawing.Point(70, 151)
        Me.ClassTextBox.Name = "ClassTextBox"
        Me.ClassTextBox.Size = New System.Drawing.Size(170, 21)
        Me.ClassTextBox.TabIndex = 5
        Me.ClassTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TermTextBox
        '
        Me.TermTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TermTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SavedTopicBindingSource, "Term", True))
        Me.TermTextBox.Location = New System.Drawing.Point(70, 94)
        Me.TermTextBox.Name = "TermTextBox"
        Me.TermTextBox.ReadOnly = True
        Me.TermTextBox.Size = New System.Drawing.Size(170, 21)
        Me.TermTextBox.TabIndex = 2
        Me.TermTextBox.TabStop = False
        Me.TermTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'YearTextBox
        '
        Me.YearTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.YearTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.SavedTopicBindingSource, "Year", True))
        Me.YearTextBox.Location = New System.Drawing.Point(70, 66)
        Me.YearTextBox.Name = "YearTextBox"
        Me.YearTextBox.Size = New System.Drawing.Size(170, 21)
        Me.YearTextBox.TabIndex = 1
        Me.YearTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SubjectCombo
        '
        Me.SubjectCombo.FormattingEnabled = True
        Me.SubjectCombo.Location = New System.Drawing.Point(70, 235)
        Me.SubjectCombo.Name = "SubjectCombo"
        Me.SubjectCombo.Size = New System.Drawing.Size(170, 21)
        Me.SubjectCombo.TabIndex = 16
        '
        'SubLstFor9_Human
        '
        Me.SubLstFor9_Human.FormattingEnabled = True
        Me.SubLstFor9_Human.Location = New System.Drawing.Point(70, 235)
        Me.SubLstFor9_Human.Name = "SubLstFor9_Human"
        Me.SubLstFor9_Human.Size = New System.Drawing.Size(170, 21)
        Me.SubLstFor9_Human.TabIndex = 29
        '
        'SublstFor9_Science
        '
        Me.SublstFor9_Science.FormattingEnabled = True
        Me.SublstFor9_Science.Location = New System.Drawing.Point(70, 235)
        Me.SublstFor9_Science.Name = "SublstFor9_Science"
        Me.SublstFor9_Science.Size = New System.Drawing.Size(170, 21)
        Me.SublstFor9_Science.TabIndex = 28
        '
        'SavedTopicBindingNavigator
        '
        Me.SavedTopicBindingNavigator.AddNewItem = Nothing
        Me.SavedTopicBindingNavigator.BackColor = System.Drawing.Color.Silver
        Me.SavedTopicBindingNavigator.BackgroundImage = Global.AukSoftware.My.Resources.Resource2.__1
        Me.SavedTopicBindingNavigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SavedTopicBindingNavigator.BindingSource = Me.SavedTopicBindingSource
        Me.SavedTopicBindingNavigator.ContextMenuStrip = Me.ContextMenuStrip1
        Me.SavedTopicBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SavedTopicBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SavedTopicBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorDeleteItem, Me.SavedTopicBindingNavigatorSaveItem, Me.ToolStripButton6, Me.ToolStripButton3, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripButton5, Me.ToolStripSeparator7})
        Me.SavedTopicBindingNavigator.Location = New System.Drawing.Point(0, 25)
        Me.SavedTopicBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SavedTopicBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SavedTopicBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SavedTopicBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SavedTopicBindingNavigator.Name = "SavedTopicBindingNavigator"
        Me.SavedTopicBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SavedTopicBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.SavedTopicBindingNavigator.Size = New System.Drawing.Size(792, 25)
        Me.SavedTopicBindingNavigator.TabIndex = 4
        Me.SavedTopicBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.BackColor = System.Drawing.Color.Transparent
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(36, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 21)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'SavedTopicBindingNavigatorSaveItem
        '
        Me.SavedTopicBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SavedTopicBindingNavigatorSaveItem.Image = CType(resources.GetObject("SavedTopicBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SavedTopicBindingNavigatorSaveItem.Name = "SavedTopicBindingNavigatorSaveItem"
        Me.SavedTopicBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.SavedTopicBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton6.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton6.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.Size = New System.Drawing.Size(109, 22)
        Me.ToolStripButton6.Text = "RefreshDatabase"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripButton3.Text = "InformationsEntry"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripButton2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ToolStripButton2.Image = Global.AukSoftware.My.Resources.Resource1.RightIco1
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(115, 22)
        Me.ToolStripButton2.Text = "Reject Changes"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(109, 22)
        Me.ToolStripButton5.Text = "Open all user's Topic"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'Group
        '
        Me.Group.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group.BackColor = System.Drawing.Color.Black
        Me.Group.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group.ForeColor = System.Drawing.Color.White
        Me.Group.Location = New System.Drawing.Point(23, 74)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(740, 28)
        Me.Group.TabIndex = 6
        Me.Group.Text = "Junior Section"
        Me.Group.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipTitle = "AukSoftware's"
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "AukSoftQuery Manager"
        Me.NotifyIcon1.Visible = True
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.AukSoftware.My.Resources.Resources.IcoAukSoft_copy
        Me.PictureBox2.Location = New System.Drawing.Point(23, 469)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(158, 85)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'SubjectsCollectionBindingSource
        '
        Me.SubjectsCollectionBindingSource.DataMember = "SubjectsCollection"
        Me.SubjectsCollectionBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'SavedTopicTableAdapter
        '
        Me.SavedTopicTableAdapter.ClearBeforeFill = True
        '
        'SubjectsCollectionTableAdapter
        '
        Me.SubjectsCollectionTableAdapter.ClearBeforeFill = True
        '
        'TermSTableAdapter
        '
        Me.TermSTableAdapter.ClearBeforeFill = True
        '
        'ClassOptionsBindingSource
        '
        Me.ClassOptionsBindingSource.DataMember = "ClassOptions"
        Me.ClassOptionsBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'ClassOptionsTableAdapter
        '
        Me.ClassOptionsTableAdapter.ClearBeforeFill = True
        '
        'SubjectPositionTableAdapter1
        '
        Me.SubjectPositionTableAdapter1.ClearBeforeFill = True
        '
        'Acc2SubjectTableAdapter1
        '
        Me.Acc2SubjectTableAdapter1.ClearBeforeFill = True
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultSheetToolStripMenuItem, Me.ClassOptionsToolStripMenuItem1, Me.SubjectEditorToolStripMenuItem1, Me.SubjectsCollectionToolStripMenuItem, Me.PrintToolStripMenuItem1})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(189, 114)
        '
        'ResultSheetToolStripMenuItem
        '
        Me.ResultSheetToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ResultSheetToolStripMenuItem.BackgroundImage = Global.AukSoftware.My.Resources.Resource2._71
        Me.ResultSheetToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ResultSheetToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultEntryToolStripMenuItem, Me.CommentsEntryToolStripMenuItem, Me.MarksDistrubitionToolStripMenuItem, Me.PositionGeneratorToolStripMenuItem1, Me.UnProgrammaticResultviewToolStripMenuItem})
        Me.ResultSheetToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ResultSheetToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ResultSheetToolStripMenuItem.Image = Global.AukSoftware.My.Resources.VSImages.GoLtrHS
        Me.ResultSheetToolStripMenuItem.Name = "ResultSheetToolStripMenuItem"
        Me.ResultSheetToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.ResultSheetToolStripMenuItem.Text = "Result Sheet ->"
        '
        'ResultEntryToolStripMenuItem
        '
        Me.ResultEntryToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.ResultEntryToolStripMenuItem.BackgroundImage = Global.AukSoftware.My.Resources.Resource2._2
        Me.ResultEntryToolStripMenuItem.Image = Global.AukSoftware.My.Resources.VSImages.compareversionsHS
        Me.ResultEntryToolStripMenuItem.Name = "ResultEntryToolStripMenuItem"
        Me.ResultEntryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ResultEntryToolStripMenuItem.Text = "Result Entry"
        Me.ResultEntryToolStripMenuItem.ToolTipText = "Entry Students Results..."
        '
        'CommentsEntryToolStripMenuItem
        '
        Me.CommentsEntryToolStripMenuItem.BackColor = System.Drawing.Color.Bisque
        Me.CommentsEntryToolStripMenuItem.Image = Global.AukSoftware.My.Resources.VSImages.CommentHS
        Me.CommentsEntryToolStripMenuItem.Name = "CommentsEntryToolStripMenuItem"
        Me.CommentsEntryToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CommentsEntryToolStripMenuItem.Text = "Comments Entry"
        Me.CommentsEntryToolStripMenuItem.ToolTipText = "House master,Medical Officer,Class Teacher,Games Teachers Comments"
        '
        'MarksDistrubitionToolStripMenuItem
        '
        Me.MarksDistrubitionToolStripMenuItem.BackColor = System.Drawing.Color.Silver
        Me.MarksDistrubitionToolStripMenuItem.BackgroundImage = Global.AukSoftware.My.Resources.Resource1.Crystal1
        Me.MarksDistrubitionToolStripMenuItem.Image = Global.AukSoftware.My.Resources.VSImages.ExpirationHS
        Me.MarksDistrubitionToolStripMenuItem.Name = "MarksDistrubitionToolStripMenuItem"
        Me.MarksDistrubitionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MarksDistrubitionToolStripMenuItem.Text = "Marks Distribution"
        Me.MarksDistrubitionToolStripMenuItem.ToolTipText = "(Automatically Distribute Total Marks ,Grading,Comments ,Big Sheet Summary, Extra" & _
            " Summary, Big Sheet print etc...)"
        '
        'PositionGeneratorToolStripMenuItem1
        '
        Me.PositionGeneratorToolStripMenuItem1.BackColor = System.Drawing.Color.Chocolate
        Me.PositionGeneratorToolStripMenuItem1.BackgroundImage = Global.AukSoftware.My.Resources.Resource2._1
        Me.PositionGeneratorToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PositionGeneratorToolStripMenuItem1.Image = Global.AukSoftware.My.Resources.VSImages.LegendHS
        Me.PositionGeneratorToolStripMenuItem1.Name = "PositionGeneratorToolStripMenuItem1"
        Me.PositionGeneratorToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.PositionGeneratorToolStripMenuItem1.Text = "Position Generator"
        Me.PositionGeneratorToolStripMenuItem1.ToolTipText = "At Last Click there to generate Studnets Positions Bases on Total Marks ." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(So Yo" & _
            "u  Need Total Marks First,you can get it from Marks Distrubution)"
        '
        'UnProgrammaticResultviewToolStripMenuItem
        '
        Me.UnProgrammaticResultviewToolStripMenuItem.Image = Global.AukSoftware.My.Resources.VSImages.ArrangeWindowsHS
        Me.UnProgrammaticResultviewToolStripMenuItem.Name = "UnProgrammaticResultviewToolStripMenuItem"
        Me.UnProgrammaticResultviewToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UnProgrammaticResultviewToolStripMenuItem.Text = "UnProgrammatic"
        '
        'ClassOptionsToolStripMenuItem1
        '
        Me.ClassOptionsToolStripMenuItem1.BackgroundImage = Global.AukSoftware.My.Resources.Resource1.Crystal1
        Me.ClassOptionsToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ClassOptionsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ClassOptionsToolStripMenuItem1.Image = Global.AukSoftware.My.Resources.VSImages.CheckGrammarHS
        Me.ClassOptionsToolStripMenuItem1.Name = "ClassOptionsToolStripMenuItem1"
        Me.ClassOptionsToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.ClassOptionsToolStripMenuItem1.Text = "ClassOptions"
        '
        'SubjectEditorToolStripMenuItem1
        '
        Me.SubjectEditorToolStripMenuItem1.Name = "SubjectEditorToolStripMenuItem1"
        Me.SubjectEditorToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.SubjectEditorToolStripMenuItem1.Text = "Subject Editor"
        '
        'SubjectsCollectionToolStripMenuItem
        '
        Me.SubjectsCollectionToolStripMenuItem.Name = "SubjectsCollectionToolStripMenuItem"
        Me.SubjectsCollectionToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SubjectsCollectionToolStripMenuItem.Text = "Subjects Collection"
        '
        'PrintToolStripMenuItem1
        '
        Me.PrintToolStripMenuItem1.BackgroundImage = Global.AukSoftware.My.Resources.Resource2._1
        Me.PrintToolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PrintToolStripMenuItem1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.PrintToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.PrintToolStripMenuItem1.Image = Global.AukSoftware.My.Resources.VSImages.PrintPreviewHS
        Me.PrintToolStripMenuItem1.Name = "PrintToolStripMenuItem1"
        Me.PrintToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PrintToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.PrintToolStripMenuItem1.Text = "Print Reports"
        '
        'SubjectPositionBindingSource
        '
        Me.SubjectPositionBindingSource.DataMember = "SubjectPosition"
        Me.SubjectPositionBindingSource.DataSource = Me.AuksoftDataSet1
        '
        'QueryManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AukSoftware.My.Resources.Resources.Crystal1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(792, 574)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.SavedTopicBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Group)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QueryManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QueryManager"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TermSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AuksoftDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedTopicBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedTopicBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SavedTopicBindingNavigator.ResumeLayout(False)
        Me.SavedTopicBindingNavigator.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SubjectsCollectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClassOptionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip2.ResumeLayout(False)
        CType(Me.SubjectPositionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents AuksoftDataSet1 As AukSoftware.auksoftDataSet1
    Friend WithEvents SavedTopicBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SavedTopicTableAdapter As AukSoftware.auksoftDataSet1TableAdapters.SavedTopicTableAdapter
    Friend WithEvents SavedTopicBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SavedTopicBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents SubjectCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ShiftTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SectionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ClassTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TermTextBox As System.Windows.Forms.TextBox
    Friend WithEvents YearTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents SavedTopic As System.Windows.Forms.ComboBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents SubjectsCollectionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SubjectsCollectionTableAdapter As AukSoftware.auksoftDataSet1TableAdapters.SubjectsCollectionTableAdapter
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents TermSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TermSTableAdapter As AukSoftware.auksoftDataSet1TableAdapters.TermSTableAdapter
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents Group As System.Windows.Forms.Label
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenAndSavedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChangesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents SectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShiftToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripComboBox1 As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TermsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TermsComboX As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents SubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubCombox As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClassOptionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClassOptionsTableAdapter As AukSoftware.auksoftDataSet1TableAdapters.ClassOptionsTableAdapter
    Friend WithEvents SubjectPositionTableAdapter1 As AukSoftware.auksoftDataSet1TableAdapters.SubjectPositionTableAdapter
    Friend WithEvents ToolStripButton6 As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents SublstFor9_Science As System.Windows.Forms.ComboBox
    Friend WithEvents SubLstFor9_Human As System.Windows.Forms.ComboBox
    Friend WithEvents Acc2SubjectTableAdapter1 As AukSoftware.auksoftDataSet1TableAdapters.Acc2SubjectTableAdapter
    Friend WithEvents ContextMenuStrip2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResultSheetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClassOptionsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectEditorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectsCollectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommentsEntryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarksDistrubitionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PositionGeneratorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnProgrammaticResultviewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents SubjectPositionBindingSource As System.Windows.Forms.BindingSource
End Class
