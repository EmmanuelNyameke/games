<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSortGames
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
        lblHeading = New Label()
        lstSortedGames = New ListBox()
        btnBack = New Button()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 20.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(170, 36)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(205, 33)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Sorted Games"
        ' 
        ' lstSortedGames
        ' 
        lstSortedGames.Font = New Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lstSortedGames.FormattingEnabled = True
        lstSortedGames.ItemHeight = 25
        lstSortedGames.Location = New Point(110, 116)
        lstSortedGames.Name = "lstSortedGames"
        lstSortedGames.Size = New Size(324, 154)
        lstSortedGames.TabIndex = 1
        ' 
        ' btnBack
        ' 
        btnBack.Font = New Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnBack.Location = New Point(235, 329)
        btnBack.Name = "btnBack"
        btnBack.Size = New Size(75, 32)
        btnBack.TabIndex = 2
        btnBack.Text = "Back"
        btnBack.UseVisualStyleBackColor = True
        ' 
        ' frmSortGames
        ' 
        AutoScaleDimensions = New SizeF(7F, 14F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.games
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(545, 420)
        Controls.Add(btnBack)
        Controls.Add(lstSortedGames)
        Controls.Add(lblHeading)
        Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "frmSortGames"
        Text = "Sorted Games"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lstSortedGames As ListBox
    Friend WithEvents btnBack As Button
End Class
