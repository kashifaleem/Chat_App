<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.Settings_Fill_Panel = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtIP = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNick = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me.btnChange = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFolder = New Infragistics.Win.UltraWinEditors.UltraTextEditor
        Me._Settings_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._Settings_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Settings_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._Settings_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.Settings_Fill_Panel.SuspendLayout()
        CType(Me.txtIP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNick, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFolder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Settings_Fill_Panel
        '
        Me.Settings_Fill_Panel.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Settings_Fill_Panel.Controls.Add(Me.Label3)
        Me.Settings_Fill_Panel.Controls.Add(Me.txtIP)
        Me.Settings_Fill_Panel.Controls.Add(Me.Button2)
        Me.Settings_Fill_Panel.Controls.Add(Me.Button1)
        Me.Settings_Fill_Panel.Controls.Add(Me.Label2)
        Me.Settings_Fill_Panel.Controls.Add(Me.txtNick)
        Me.Settings_Fill_Panel.Controls.Add(Me.btnChange)
        Me.Settings_Fill_Panel.Controls.Add(Me.Label1)
        Me.Settings_Fill_Panel.Controls.Add(Me.txtFolder)
        Me.Settings_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.Settings_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Settings_Fill_Panel.Location = New System.Drawing.Point(4, 31)
        Me.Settings_Fill_Panel.Name = "Settings_Fill_Panel"
        Me.Settings_Fill_Panel.Size = New System.Drawing.Size(284, 173)
        Me.Settings_Fill_Panel.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Server IP:"
        '
        'txtIP
        '
        Me.txtIP.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtIP.Location = New System.Drawing.Point(63, 95)
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(181, 21)
        Me.txtIP.TabIndex = 12
        Me.txtIP.Text = "172.16.0.89"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(152, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(54, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(70, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nick"
        '
        'txtNick
        '
        Me.txtNick.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtNick.Location = New System.Drawing.Point(63, 68)
        Me.txtNick.Name = "txtNick"
        Me.txtNick.Size = New System.Drawing.Size(181, 21)
        Me.txtNick.TabIndex = 8
        Me.txtNick.Text = "Server"
        '
        'btnChange
        '
        Me.btnChange.Location = New System.Drawing.Point(250, 41)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(25, 20)
        Me.btnChange.TabIndex = 7
        Me.btnChange.Text = ".."
        Me.btnChange.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Save recieved files in"
        '
        'txtFolder
        '
        Me.txtFolder.DisplayStyle = Infragistics.Win.EmbeddableElementDisplayStyle.Office2007
        Me.txtFolder.Location = New System.Drawing.Point(11, 41)
        Me.txtFolder.Name = "txtFolder"
        Me.txtFolder.ReadOnly = True
        Me.txtFolder.Size = New System.Drawing.Size(233, 21)
        Me.txtFolder.TabIndex = 5
        Me.txtFolder.Text = "C:\"
        '
        '_Settings_Toolbars_Dock_Area_Left
        '
        Me._Settings_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Settings_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Settings_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._Settings_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Settings_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 4
        Me._Settings_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 31)
        Me._Settings_Toolbars_Dock_Area_Left.Name = "_Settings_Toolbars_Dock_Area_Left"
        Me._Settings_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(4, 173)
        Me._Settings_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.UltraToolbarsManager1.Office2007UICompatibility = False
        Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.Visible = False
        Me.UltraToolbarsManager1.Ribbon.Visible = True
        '
        '_Settings_Toolbars_Dock_Area_Right
        '
        Me._Settings_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Settings_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Settings_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._Settings_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Settings_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 4
        Me._Settings_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(288, 31)
        Me._Settings_Toolbars_Dock_Area_Right.Name = "_Settings_Toolbars_Dock_Area_Right"
        Me._Settings_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(4, 173)
        Me._Settings_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_Settings_Toolbars_Dock_Area_Top
        '
        Me._Settings_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Settings_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Settings_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._Settings_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Settings_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._Settings_Toolbars_Dock_Area_Top.Name = "_Settings_Toolbars_Dock_Area_Top"
        Me._Settings_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(292, 31)
        Me._Settings_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_Settings_Toolbars_Dock_Area_Bottom
        '
        Me._Settings_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._Settings_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._Settings_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._Settings_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Settings_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 4
        Me._Settings_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 204)
        Me._Settings_Toolbars_Dock_Area_Bottom.Name = "_Settings_Toolbars_Dock_Area_Bottom"
        Me._Settings_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(292, 4)
        Me._Settings_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 208)
        Me.Controls.Add(Me.Settings_Fill_Panel)
        Me.Controls.Add(Me._Settings_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._Settings_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._Settings_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._Settings_Toolbars_Dock_Area_Bottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        Me.Settings_Fill_Panel.ResumeLayout(False)
        Me.Settings_Fill_Panel.PerformLayout()
        CType(Me.txtIP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNick, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFolder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents Settings_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNick As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents btnChange As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolder As Infragistics.Win.UltraWinEditors.UltraTextEditor
    Friend WithEvents _Settings_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Settings_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Settings_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _Settings_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIP As Infragistics.Win.UltraWinEditors.UltraTextEditor
End Class
