<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workshop
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
        Me.components = New System.ComponentModel.Container()
        Me.GrpWorkshop = New System.Windows.Forms.GroupBox()
        Me.ListBoxWorkshops = New System.Windows.Forms.ListBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GrpLocation = New System.Windows.Forms.GroupBox()
        Me.ListBoxLocations = New System.Windows.Forms.ListBox()
        Me.GrpCosts = New System.Windows.Forms.GroupBox()
        Me.ListBoxCosts = New System.Windows.Forms.ListBox()
        Me.LblTotalCost = New System.Windows.Forms.Label()
        Me.RtbTotalCost = New System.Windows.Forms.RichTextBox()
        Me.BtnAddWorkshop = New System.Windows.Forms.Button()
        Me.BtnCalcTotal = New System.Windows.Forms.Button()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.ToolTipWorkshop = New System.Windows.Forms.ToolTip(Me.components)
        Me.GrpWorkshop.SuspendLayout()
        Me.GrpLocation.SuspendLayout()
        Me.GrpCosts.SuspendLayout()
        Me.SuspendLayout()
        '
        'GrpWorkshop
        '
        Me.GrpWorkshop.Controls.Add(Me.ListBoxWorkshops)
        Me.GrpWorkshop.Location = New System.Drawing.Point(12, 51)
        Me.GrpWorkshop.Name = "GrpWorkshop"
        Me.GrpWorkshop.Size = New System.Drawing.Size(200, 142)
        Me.GrpWorkshop.TabIndex = 0
        Me.GrpWorkshop.TabStop = False
        Me.GrpWorkshop.Text = "Pick a Workshop"
        '
        'ListBoxWorkshops
        '
        Me.ListBoxWorkshops.FormattingEnabled = True
        Me.ListBoxWorkshops.ItemHeight = 16
        Me.ListBoxWorkshops.Items.AddRange(New Object() {"Handling Stress", "Time Management ", "Supervision Skills", "Negotiation", "How to Interview "})
        Me.ListBoxWorkshops.Location = New System.Drawing.Point(6, 21)
        Me.ListBoxWorkshops.Name = "ListBoxWorkshops"
        Me.ListBoxWorkshops.Size = New System.Drawing.Size(188, 116)
        Me.ListBoxWorkshops.TabIndex = 1
        Me.ToolTipWorkshop.SetToolTip(Me.ListBoxWorkshops, "Picking a class")
        '
        'GrpLocation
        '
        Me.GrpLocation.Controls.Add(Me.ListBoxLocations)
        Me.GrpLocation.Location = New System.Drawing.Point(266, 51)
        Me.GrpLocation.Name = "GrpLocation"
        Me.GrpLocation.Size = New System.Drawing.Size(200, 142)
        Me.GrpLocation.TabIndex = 1
        Me.GrpLocation.TabStop = False
        Me.GrpLocation.Text = "Pick a Location"
        '
        'ListBoxLocations
        '
        Me.ListBoxLocations.FormattingEnabled = True
        Me.ListBoxLocations.ItemHeight = 16
        Me.ListBoxLocations.Items.AddRange(New Object() {"Austin", "Chicago", "Dallas", "Orlando", "Phoenix", "Raleigh"})
        Me.ListBoxLocations.Location = New System.Drawing.Point(6, 21)
        Me.ListBoxLocations.Name = "ListBoxLocations"
        Me.ListBoxLocations.Size = New System.Drawing.Size(188, 116)
        Me.ListBoxLocations.TabIndex = 2
        Me.ToolTipWorkshop.SetToolTip(Me.ListBoxLocations, "picking a location for class")
        '
        'GrpCosts
        '
        Me.GrpCosts.Controls.Add(Me.ListBoxCosts)
        Me.GrpCosts.Location = New System.Drawing.Point(516, 52)
        Me.GrpCosts.Name = "GrpCosts"
        Me.GrpCosts.Size = New System.Drawing.Size(200, 142)
        Me.GrpCosts.TabIndex = 2
        Me.GrpCosts.TabStop = False
        Me.GrpCosts.Text = "List of Costs"
        '
        'ListBoxCosts
        '
        Me.ListBoxCosts.FormatString = "C2"
        Me.ListBoxCosts.FormattingEnabled = True
        Me.ListBoxCosts.ItemHeight = 16
        Me.ListBoxCosts.Location = New System.Drawing.Point(6, 21)
        Me.ListBoxCosts.Name = "ListBoxCosts"
        Me.ListBoxCosts.Size = New System.Drawing.Size(188, 116)
        Me.ListBoxCosts.TabIndex = 4
        Me.ToolTipWorkshop.SetToolTip(Me.ListBoxCosts, "cost of the class and location")
        '
        'LblTotalCost
        '
        Me.LblTotalCost.AutoSize = True
        Me.LblTotalCost.Location = New System.Drawing.Point(263, 278)
        Me.LblTotalCost.Name = "LblTotalCost"
        Me.LblTotalCost.Size = New System.Drawing.Size(70, 17)
        Me.LblTotalCost.TabIndex = 3
        Me.LblTotalCost.Text = "Total cost"
        '
        'RtbTotalCost
        '
        Me.RtbTotalCost.BackColor = System.Drawing.SystemColors.MenuBar
        Me.RtbTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RtbTotalCost.Location = New System.Drawing.Point(341, 278)
        Me.RtbTotalCost.Name = "RtbTotalCost"
        Me.RtbTotalCost.ReadOnly = True
        Me.RtbTotalCost.Size = New System.Drawing.Size(100, 24)
        Me.RtbTotalCost.TabIndex = 5
        Me.RtbTotalCost.Text = ""
        '
        'BtnAddWorkshop
        '
        Me.BtnAddWorkshop.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnAddWorkshop.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddWorkshop.Location = New System.Drawing.Point(49, 350)
        Me.BtnAddWorkshop.Name = "BtnAddWorkshop"
        Me.BtnAddWorkshop.Size = New System.Drawing.Size(127, 41)
        Me.BtnAddWorkshop.TabIndex = 3
        Me.BtnAddWorkshop.Text = "A&dd Workshop"
        Me.ToolTipWorkshop.SetToolTip(Me.BtnAddWorkshop, "for adding workshop and location")
        Me.BtnAddWorkshop.UseVisualStyleBackColor = False
        '
        'BtnCalcTotal
        '
        Me.BtnCalcTotal.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnCalcTotal.Enabled = False
        Me.BtnCalcTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalcTotal.Location = New System.Drawing.Point(218, 350)
        Me.BtnCalcTotal.Name = "BtnCalcTotal"
        Me.BtnCalcTotal.Size = New System.Drawing.Size(127, 41)
        Me.BtnCalcTotal.TabIndex = 5
        Me.BtnCalcTotal.Text = "C&alculate Total"
        Me.ToolTipWorkshop.SetToolTip(Me.BtnCalcTotal, "Calculate total costs")
        Me.BtnCalcTotal.UseVisualStyleBackColor = False
        '
        'BtnReset
        '
        Me.BtnReset.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReset.Location = New System.Drawing.Point(375, 350)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(127, 41)
        Me.BtnReset.TabIndex = 6
        Me.BtnReset.Text = "R&eset"
        Me.ToolTipWorkshop.SetToolTip(Me.BtnReset, "Reset selections")
        Me.BtnReset.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Location = New System.Drawing.Point(549, 350)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(123, 41)
        Me.BtnExit.TabIndex = 7
        Me.BtnExit.Text = "E&xit "
        Me.ToolTipWorkshop.SetToolTip(Me.BtnExit, "used to exit app")
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Workshop
        '
        Me.AcceptButton = Me.BtnAddWorkshop
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(734, 450)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnReset)
        Me.Controls.Add(Me.BtnCalcTotal)
        Me.Controls.Add(Me.BtnAddWorkshop)
        Me.Controls.Add(Me.RtbTotalCost)
        Me.Controls.Add(Me.LblTotalCost)
        Me.Controls.Add(Me.GrpCosts)
        Me.Controls.Add(Me.GrpLocation)
        Me.Controls.Add(Me.GrpWorkshop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Workshop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Workshop Selector by Malachi Barbato"
        Me.GrpWorkshop.ResumeLayout(False)
        Me.GrpLocation.ResumeLayout(False)
        Me.GrpCosts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GrpWorkshop As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ListBoxWorkshops As ListBox
    Friend WithEvents GrpLocation As GroupBox
    Friend WithEvents ListBoxLocations As ListBox
    Friend WithEvents GrpCosts As GroupBox
    Friend WithEvents ListBoxCosts As ListBox
    Friend WithEvents LblTotalCost As Label
    Friend WithEvents RtbTotalCost As RichTextBox
    Friend WithEvents BtnAddWorkshop As Button
    Friend WithEvents BtnReset As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnCalcTotal As Button
    Friend WithEvents ToolTipWorkshop As ToolTip
End Class
