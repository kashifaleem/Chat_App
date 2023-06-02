<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChatServer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChatServer))
        Dim Appearance11 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool1 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("File Transfer")
        Dim ButtonTool3 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Settings")
        Dim ButtonTool2 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Hide")
        Dim ButtonTool7 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Close")
        Dim ButtonTool4 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("File Transfer")
        Dim Appearance22 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool5 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Hide")
        Dim Appearance23 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim ButtonTool6 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Close")
        Dim Appearance24 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Dim TextBoxTool2 As Infragistics.Win.UltraWinToolbars.TextBoxTool = New Infragistics.Win.UltraWinToolbars.TextBoxTool("Nick Name")
        Dim TextBoxTool4 As Infragistics.Win.UltraWinToolbars.TextBoxTool = New Infragistics.Win.UltraWinToolbars.TextBoxTool("NickName")
        Dim TextBoxTool3 As Infragistics.Win.UltraWinToolbars.TextBoxTool = New Infragistics.Win.UltraWinToolbars.TextBoxTool("TextBoxTool1")
        Dim ButtonTool8 As Infragistics.Win.UltraWinToolbars.ButtonTool = New Infragistics.Win.UltraWinToolbars.ButtonTool("Settings")
        Dim Appearance12 As Infragistics.Win.Appearance = New Infragistics.Win.Appearance
        Me.txtDisplay = New System.Windows.Forms.TextBox
        Me.txtInput = New System.Windows.Forms.TextBox
        Me.ctHide = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.itmShowHide = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.FrmChatServer_Fill_Panel = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me._FrmChatServer_Toolbars_Dock_Area_Right = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.UltraToolbarsManager1 = New Infragistics.Win.UltraWinToolbars.UltraToolbarsManager(Me.components)
        Me._FrmChatServer_Toolbars_Dock_Area_Left = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me._FrmChatServer_Toolbars_Dock_Area_Top = New Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
        Me.ctHide.SuspendLayout()
        Me.FrmChatServer_Fill_Panel.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDisplay
        '
        Me.txtDisplay.BackColor = System.Drawing.Color.LightSlateGray
        Me.txtDisplay.Location = New System.Drawing.Point(8, 79)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.ReadOnly = True
        Me.txtDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDisplay.Size = New System.Drawing.Size(325, 216)
        Me.txtDisplay.TabIndex = 17
        '
        'txtInput
        '
        Me.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInput.Location = New System.Drawing.Point(8, 53)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.ReadOnly = True
        Me.txtInput.Size = New System.Drawing.Size(325, 20)
        Me.txtInput.TabIndex = 16
        '
        'ctHide
        '
        Me.ctHide.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itmShowHide, Me.ExitToolStripMenuItem})
        Me.ctHide.Name = "ctHide"
        Me.ctHide.Size = New System.Drawing.Size(172, 48)
        '
        'itmShowHide
        '
        Me.itmShowHide.Name = "itmShowHide"
        Me.itmShowHide.Size = New System.Drawing.Size(171, 22)
        Me.itmShowHide.Text = "Hide Ch@t Server"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ctHide
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "Ch@t Server"
        Me.NotifyIcon1.Visible = True
        '
        'FrmChatServer_Fill_Panel
        '
        Me.FrmChatServer_Fill_Panel.BackColor = System.Drawing.Color.Transparent
        Me.FrmChatServer_Fill_Panel.Controls.Add(Me.txtDisplay)
        Me.FrmChatServer_Fill_Panel.Controls.Add(Me.txtInput)
        Me.FrmChatServer_Fill_Panel.Controls.Add(Me.ToolStrip1)
        Me.FrmChatServer_Fill_Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.FrmChatServer_Fill_Panel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FrmChatServer_Fill_Panel.Location = New System.Drawing.Point(4, 51)
        Me.FrmChatServer_Fill_Panel.Name = "FrmChatServer_Fill_Panel"
        Me.FrmChatServer_Fill_Panel.Size = New System.Drawing.Size(342, 313)
        Me.FrmChatServer_Fill_Panel.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ToolStrip1.ContextMenuStrip = Me.ctHide
        Me.ToolStrip1.GripMargin = New System.Windows.Forms.Padding(0)
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(342, 39)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "Tools"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.Ch_tServer.My.Resources.Resources.btnChangePassword_LargeImage
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(64, 36)
        Me.ToolStripButton1.Text = "Hide"
        '
        '_FrmChatServer_Toolbars_Dock_Area_Right
        '
        Me._FrmChatServer_Toolbars_Dock_Area_Right.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmChatServer_Toolbars_Dock_Area_Right.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._FrmChatServer_Toolbars_Dock_Area_Right.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Right
        Me._FrmChatServer_Toolbars_Dock_Area_Right.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me._FrmChatServer_Toolbars_Dock_Area_Right.InitialResizeAreaExtent = 4
        Me._FrmChatServer_Toolbars_Dock_Area_Right.Location = New System.Drawing.Point(346, 51)
        Me._FrmChatServer_Toolbars_Dock_Area_Right.Name = "_FrmChatServer_Toolbars_Dock_Area_Right"
        Me._FrmChatServer_Toolbars_Dock_Area_Right.Size = New System.Drawing.Size(4, 313)
        Me._FrmChatServer_Toolbars_Dock_Area_Right.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'UltraToolbarsManager1
        '
        Me.UltraToolbarsManager1.DesignerFlags = 1
        Me.UltraToolbarsManager1.DockWithinContainer = Me
        Me.UltraToolbarsManager1.DockWithinContainerBaseType = GetType(System.Windows.Forms.Form)
        Me.UltraToolbarsManager1.FormDisplayStyle = Infragistics.Win.UltraWinToolbars.FormDisplayStyle.RoundedFixed
        Appearance11.Image = Global.Ch_tServer.My.Resources.Resources.CloseIt
        Me.UltraToolbarsManager1.MenuSettings.Appearance = Appearance11
        Me.UltraToolbarsManager1.Office2007UICompatibility = False
        ButtonTool1.InstanceProps.Visible = Infragistics.Win.DefaultableBoolean.[False]
        Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaLeft.NonInheritedTools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool1, ButtonTool3, ButtonTool2, ButtonTool7})
        Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaRight.MaxWidth = 1
        Me.UltraToolbarsManager1.Ribbon.ApplicationMenu.ToolAreaRight.MinWidth = 1
        Me.UltraToolbarsManager1.Ribbon.ApplicationMenuButtonImage = Global.Ch_tServer.My.Resources.Resources.btnObjType_LargeImage
        Me.UltraToolbarsManager1.Ribbon.QuickAccessToolbar.Visible = False
        Me.UltraToolbarsManager1.Ribbon.Visible = True
        Me.UltraToolbarsManager1.Style = Infragistics.Win.UltraWinToolbars.ToolbarStyle.WindowsVista
        Appearance22.Image = Global.Ch_tServer.My.Resources.Resources.appMenu_LargeImage
        ButtonTool4.SharedProps.AppearancesSmall.Appearance = Appearance22
        ButtonTool4.SharedProps.Caption = "File Transfer"
        ButtonTool4.SharedProps.DisplayStyle = Infragistics.Win.UltraWinToolbars.ToolDisplayStyle.ImageAndText
        Appearance23.Image = CType(resources.GetObject("Appearance23.Image"), Object)
        ButtonTool5.SharedProps.AppearancesSmall.Appearance = Appearance23
        ButtonTool5.SharedProps.Caption = "Hide"
        Appearance24.Image = Global.Ch_tServer.My.Resources.Resources.CloseIt
        ButtonTool6.SharedProps.AppearancesSmall.Appearance = Appearance24
        ButtonTool6.SharedProps.Caption = "Exit"
        TextBoxTool4.SharedProps.Caption = "NickName"
        TextBoxTool3.SharedProps.Caption = "TextBoxTool1"
        Appearance12.Image = Global.Ch_tServer.My.Resources.Resources.tasks
        ButtonTool8.SharedProps.AppearancesSmall.Appearance = Appearance12
        ButtonTool8.SharedProps.Caption = "Settings"
        Me.UltraToolbarsManager1.Tools.AddRange(New Infragistics.Win.UltraWinToolbars.ToolBase() {ButtonTool4, ButtonTool5, ButtonTool6, TextBoxTool2, TextBoxTool4, TextBoxTool3, ButtonTool8})
        '
        '_FrmChatServer_Toolbars_Dock_Area_Left
        '
        Me._FrmChatServer_Toolbars_Dock_Area_Left.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmChatServer_Toolbars_Dock_Area_Left.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._FrmChatServer_Toolbars_Dock_Area_Left.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Left
        Me._FrmChatServer_Toolbars_Dock_Area_Left.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me._FrmChatServer_Toolbars_Dock_Area_Left.InitialResizeAreaExtent = 4
        Me._FrmChatServer_Toolbars_Dock_Area_Left.Location = New System.Drawing.Point(0, 51)
        Me._FrmChatServer_Toolbars_Dock_Area_Left.Name = "_FrmChatServer_Toolbars_Dock_Area_Left"
        Me._FrmChatServer_Toolbars_Dock_Area_Left.Size = New System.Drawing.Size(4, 313)
        Me._FrmChatServer_Toolbars_Dock_Area_Left.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_FrmChatServer_Toolbars_Dock_Area_Bottom
        '
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Bottom
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.InitialResizeAreaExtent = 4
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.Location = New System.Drawing.Point(0, 364)
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.Name = "_FrmChatServer_Toolbars_Dock_Area_Bottom"
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.Size = New System.Drawing.Size(350, 4)
        Me._FrmChatServer_Toolbars_Dock_Area_Bottom.ToolbarsManager = Me.UltraToolbarsManager1
        '
        '_FrmChatServer_Toolbars_Dock_Area_Top
        '
        Me._FrmChatServer_Toolbars_Dock_Area_Top.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me._FrmChatServer_Toolbars_Dock_Area_Top.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me._FrmChatServer_Toolbars_Dock_Area_Top.DockedPosition = Infragistics.Win.UltraWinToolbars.DockedPosition.Top
        Me._FrmChatServer_Toolbars_Dock_Area_Top.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me._FrmChatServer_Toolbars_Dock_Area_Top.Location = New System.Drawing.Point(0, 0)
        Me._FrmChatServer_Toolbars_Dock_Area_Top.Name = "_FrmChatServer_Toolbars_Dock_Area_Top"
        Me._FrmChatServer_Toolbars_Dock_Area_Top.Size = New System.Drawing.Size(350, 51)
        Me._FrmChatServer_Toolbars_Dock_Area_Top.ToolbarsManager = Me.UltraToolbarsManager1
        '
        'FrmChatServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(350, 368)
        Me.Controls.Add(Me.FrmChatServer_Fill_Panel)
        Me.Controls.Add(Me._FrmChatServer_Toolbars_Dock_Area_Left)
        Me.Controls.Add(Me._FrmChatServer_Toolbars_Dock_Area_Right)
        Me.Controls.Add(Me._FrmChatServer_Toolbars_Dock_Area_Top)
        Me.Controls.Add(Me._FrmChatServer_Toolbars_Dock_Area_Bottom)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmChatServer"
        Me.Text = "Ch@t Server"
        Me.ctHide.ResumeLayout(False)
        Me.FrmChatServer_Fill_Panel.ResumeLayout(False)
        Me.FrmChatServer_Fill_Panel.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.UltraToolbarsManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDisplay As System.Windows.Forms.TextBox
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ctHide As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents itmShowHide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FrmChatServer_Fill_Panel As System.Windows.Forms.Panel
    Friend WithEvents _FrmChatServer_Toolbars_Dock_Area_Right As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents UltraToolbarsManager1 As Infragistics.Win.UltraWinToolbars.UltraToolbarsManager
    Friend WithEvents _FrmChatServer_Toolbars_Dock_Area_Left As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FrmChatServer_Toolbars_Dock_Area_Top As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents _FrmChatServer_Toolbars_Dock_Area_Bottom As Infragistics.Win.UltraWinToolbars.UltraToolbarsDockArea
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton

End Class
