<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGames
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        pnlGames = New Panel()
        lblTotalDownloads = New Label()
        btnCompute = New Button()
        lblNumberOfDownloads = New Label()
        lstGames = New ListBox()
        lblTitle = New Label()
        lblHeading = New Label()
        MenuStrip1 = New MenuStrip()
        mnuAction = New ToolStripMenuItem()
        mnuDisplay = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuExit = New ToolStripMenuItem()
        pnlGames.SuspendLayout()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' pnlGames
        ' 
        pnlGames.BackColor = Color.Transparent
        pnlGames.Controls.Add(lblTotalDownloads)
        pnlGames.Controls.Add(btnCompute)
        pnlGames.Controls.Add(lblNumberOfDownloads)
        pnlGames.Controls.Add(lstGames)
        pnlGames.Controls.Add(lblTitle)
        pnlGames.Controls.Add(lblHeading)
        pnlGames.Dock = DockStyle.Right
        pnlGames.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        pnlGames.ForeColor = Color.White
        pnlGames.Location = New Point(406, 24)
        pnlGames.Name = "pnlGames"
        pnlGames.Size = New Size(394, 489)
        pnlGames.TabIndex = 0
        ' 
        ' lblTotalDownloads
        ' 
        lblTotalDownloads.AutoSize = True
        lblTotalDownloads.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalDownloads.Location = New Point(3, 457)
        lblTotalDownloads.Name = "lblTotalDownloads"
        lblTotalDownloads.Size = New Size(73, 23)
        lblTotalDownloads.TabIndex = 5
        lblTotalDownloads.Text = "Label1"
        ' 
        ' btnCompute
        ' 
        btnCompute.BackColor = Color.White
        btnCompute.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCompute.ForeColor = Color.Black
        btnCompute.Location = New Point(98, 402)
        btnCompute.Name = "btnCompute"
        btnCompute.Size = New Size(198, 36)
        btnCompute.TabIndex = 4
        btnCompute.Text = "Total Downloads"
        btnCompute.UseVisualStyleBackColor = False
        ' 
        ' lblNumberOfDownloads
        ' 
        lblNumberOfDownloads.AutoSize = True
        lblNumberOfDownloads.Font = New Font("Tahoma", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblNumberOfDownloads.Location = New Point(3, 365)
        lblNumberOfDownloads.Name = "lblNumberOfDownloads"
        lblNumberOfDownloads.Size = New Size(73, 23)
        lblNumberOfDownloads.TabIndex = 3
        lblNumberOfDownloads.Text = "Label1"
        ' 
        ' lstGames
        ' 
        lstGames.BorderStyle = BorderStyle.None
        lstGames.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstGames.FormattingEnabled = True
        lstGames.ItemHeight = 23
        lstGames.Location = New Point(3, 146)
        lstGames.Name = "lstGames"
        lstGames.Size = New Size(388, 184)
        lstGames.TabIndex = 2
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(98, 95)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(198, 23)
        lblTitle.TabIndex = 1
        lblTitle.Text = "Top 10 Mobile Games:"
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(39, 21)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(317, 29)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Most Popular Games Sold"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Items.AddRange(New ToolStripItem() {mnuAction})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 24)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' mnuAction
        ' 
        mnuAction.DropDownItems.AddRange(New ToolStripItem() {mnuDisplay, mnuClear, mnuExit})
        mnuAction.Name = "mnuAction"
        mnuAction.Size = New Size(54, 20)
        mnuAction.Text = "&Action"
        ' 
        ' mnuDisplay
        ' 
        mnuDisplay.Name = "mnuDisplay"
        mnuDisplay.Size = New Size(188, 22)
        mnuDisplay.Text = "Display Sorted Games"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(188, 22)
        mnuClear.Text = "&Clear"
        ' 
        ' mnuExit
        ' 
        mnuExit.Name = "mnuExit"
        mnuExit.Size = New Size(188, 22)
        mnuExit.Text = "E&xit"
        ' 
        ' frmGames
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.games
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 513)
        Controls.Add(pnlGames)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "frmGames"
        Text = "Most Popular Games Sold"
        pnlGames.ResumeLayout(False)
        pnlGames.PerformLayout()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pnlGames As Panel
    Friend WithEvents lblHeading As Label
    Friend WithEvents lstGames As ListBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnCompute As Button
    Friend WithEvents lblNumberOfDownloads As Label
    Friend WithEvents lblTotalDownloads As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuAction As ToolStripMenuItem
    Friend WithEvents mnuDisplay As ToolStripMenuItem
    Friend WithEvents mnuClear As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem

End Class
