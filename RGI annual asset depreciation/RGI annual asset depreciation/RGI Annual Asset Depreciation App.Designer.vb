<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAssetCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSalvageValue = New System.Windows.Forms.TextBox()
        Me.lstUsefulLife = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDisplayDepreciationSchedules = New System.Windows.Forms.Button()
        Me.lstSumYearDigit = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lstDoubleDecliningBalance = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 131)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Asset cost:"
        '
        'txtAssetCost
        '
        Me.txtAssetCost.Location = New System.Drawing.Point(158, 123)
        Me.txtAssetCost.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtAssetCost.Name = "txtAssetCost"
        Me.txtAssetCost.Size = New System.Drawing.Size(149, 23)
        Me.txtAssetCost.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 178)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Salvage value:"
        '
        'txtSalvageValue
        '
        Me.txtSalvageValue.Location = New System.Drawing.Point(158, 170)
        Me.txtSalvageValue.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txtSalvageValue.Name = "txtSalvageValue"
        Me.txtSalvageValue.Size = New System.Drawing.Size(149, 23)
        Me.txtSalvageValue.TabIndex = 1
        '
        'lstUsefulLife
        '
        Me.lstUsefulLife.FormattingEnabled = True
        Me.lstUsefulLife.ItemHeight = 15
        Me.lstUsefulLife.Location = New System.Drawing.Point(158, 222)
        Me.lstUsefulLife.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstUsefulLife.Name = "lstUsefulLife"
        Me.lstUsefulLife.Size = New System.Drawing.Size(149, 19)
        Me.lstUsefulLife.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(88, 226)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Useful life:"
        '
        'btnDisplayDepreciationSchedules
        '
        Me.btnDisplayDepreciationSchedules.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDisplayDepreciationSchedules.Location = New System.Drawing.Point(108, 282)
        Me.btnDisplayDepreciationSchedules.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btnDisplayDepreciationSchedules.Name = "btnDisplayDepreciationSchedules"
        Me.btnDisplayDepreciationSchedules.Size = New System.Drawing.Size(199, 40)
        Me.btnDisplayDepreciationSchedules.TabIndex = 3
        Me.btnDisplayDepreciationSchedules.Text = "Display Depreciation Schedules"
        Me.btnDisplayDepreciationSchedules.UseVisualStyleBackColor = False
        '
        'lstSumYearDigit
        '
        Me.lstSumYearDigit.FormattingEnabled = True
        Me.lstSumYearDigit.ItemHeight = 15
        Me.lstSumYearDigit.Location = New System.Drawing.Point(614, 123)
        Me.lstSumYearDigit.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstSumYearDigit.Name = "lstSumYearDigit"
        Me.lstSumYearDigit.Size = New System.Drawing.Size(218, 199)
        Me.lstSumYearDigit.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(614, 105)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Sum-of-the years' digit:"
        '
        'lstDoubleDecliningBalance
        '
        Me.lstDoubleDecliningBalance.BackColor = System.Drawing.SystemColors.Window
        Me.lstDoubleDecliningBalance.FormattingEnabled = True
        Me.lstDoubleDecliningBalance.ItemHeight = 15
        Me.lstDoubleDecliningBalance.Location = New System.Drawing.Point(388, 123)
        Me.lstDoubleDecliningBalance.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lstDoubleDecliningBalance.Name = "lstDoubleDecliningBalance"
        Me.lstDoubleDecliningBalance.Size = New System.Drawing.Size(218, 199)
        Me.lstDoubleDecliningBalance.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(388, 105)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Double-declining balance:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Aqua
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(388, 66)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(135, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Depreciation Schedules:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aqua
        Me.ClientSize = New System.Drawing.Size(914, 413)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lstSumYearDigit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lstDoubleDecliningBalance)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnDisplayDepreciationSchedules)
        Me.Controls.Add(Me.lstUsefulLife)
        Me.Controls.Add(Me.txtSalvageValue)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAssetCost)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RGI Asset Annual Depreciation App"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAssetCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSalvageValue As System.Windows.Forms.TextBox
    Friend WithEvents lstUsefulLife As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnDisplayDepreciationSchedules As System.Windows.Forms.Button
    Friend WithEvents lstSumYearDigit As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lstDoubleDecliningBalance As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As Label

End Class
