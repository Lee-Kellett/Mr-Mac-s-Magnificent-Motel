<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbSuperior = New System.Windows.Forms.RadioButton()
        Me.rdbStandard = New System.Windows.Forms.RadioButton()
        Me.rdbDelux = New System.Windows.Forms.RadioButton()
        Me.cmbxRoomType = New System.Windows.Forms.ComboBox()
        Me.cbxSuperiorPillows = New System.Windows.Forms.CheckBox()
        Me.cbxFoodBasket = New System.Windows.Forms.CheckBox()
        Me.tbxFirstName = New System.Windows.Forms.TextBox()
        Me.tbxSurName = New System.Windows.Forms.TextBox()
        Me.tbxGuests = New System.Windows.Forms.TextBox()
        Me.tbxNights = New System.Windows.Forms.TextBox()
        Me.lsbDisplay = New System.Windows.Forms.ListBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(201, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mr Mac's Magnificent Motel"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(15, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 112)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer's first name: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Customer's last name: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number of guests: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Number" &
    " of nights: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(295, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Breakfast Selection"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(26, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Customer Details"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(61, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Room Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(243, 226)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(218, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Room extras (Select your options)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(26, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(159, 21)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Room Request cost:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbSuperior)
        Me.GroupBox1.Controls.Add(Me.rdbStandard)
        Me.GroupBox1.Controls.Add(Me.rdbDelux)
        Me.GroupBox1.Location = New System.Drawing.Point(292, 87)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(159, 126)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options"
        '
        'rdbSuperior
        '
        Me.rdbSuperior.AutoSize = True
        Me.rdbSuperior.Location = New System.Drawing.Point(6, 93)
        Me.rdbSuperior.Name = "rdbSuperior"
        Me.rdbSuperior.Size = New System.Drawing.Size(107, 19)
        Me.rdbSuperior.TabIndex = 10
        Me.rdbSuperior.TabStop = True
        Me.rdbSuperior.Text = "Superior $40 pp"
        Me.rdbSuperior.UseVisualStyleBackColor = True
        '
        'rdbStandard
        '
        Me.rdbStandard.AutoSize = True
        Me.rdbStandard.Location = New System.Drawing.Point(6, 22)
        Me.rdbStandard.Name = "rdbStandard"
        Me.rdbStandard.Size = New System.Drawing.Size(110, 19)
        Me.rdbStandard.TabIndex = 8
        Me.rdbStandard.TabStop = True
        Me.rdbStandard.Text = "Standard $20 pp"
        Me.rdbStandard.UseVisualStyleBackColor = True
        '
        'rdbDelux
        '
        Me.rdbDelux.AutoSize = True
        Me.rdbDelux.Location = New System.Drawing.Point(6, 58)
        Me.rdbDelux.Name = "rdbDelux"
        Me.rdbDelux.Size = New System.Drawing.Size(93, 19)
        Me.rdbDelux.TabIndex = 9
        Me.rdbDelux.TabStop = True
        Me.rdbDelux.Text = "Delux $30 pp"
        Me.rdbDelux.UseVisualStyleBackColor = True
        '
        'cmbxRoomType
        '
        Me.cmbxRoomType.FormattingEnabled = True
        Me.cmbxRoomType.Items.AddRange(New Object() {"Single", "Double", "Family", "Penthouse suit"})
        Me.cmbxRoomType.Location = New System.Drawing.Point(35, 252)
        Me.cmbxRoomType.Name = "cmbxRoomType"
        Me.cmbxRoomType.Size = New System.Drawing.Size(132, 23)
        Me.cmbxRoomType.TabIndex = 8
        '
        'cbxSuperiorPillows
        '
        Me.cbxSuperiorPillows.AutoSize = True
        Me.cbxSuperiorPillows.Location = New System.Drawing.Point(243, 256)
        Me.cbxSuperiorPillows.Name = "cbxSuperiorPillows"
        Me.cbxSuperiorPillows.Size = New System.Drawing.Size(152, 19)
        Me.cbxSuperiorPillows.TabIndex = 9
        Me.cbxSuperiorPillows.Text = "Superior pillows Fee $50"
        Me.cbxSuperiorPillows.UseVisualStyleBackColor = True
        '
        'cbxFoodBasket
        '
        Me.cbxFoodBasket.AutoSize = True
        Me.cbxFoodBasket.Location = New System.Drawing.Point(243, 281)
        Me.cbxFoodBasket.Name = "cbxFoodBasket"
        Me.cbxFoodBasket.Size = New System.Drawing.Size(210, 19)
        Me.cbxFoodBasket.TabIndex = 10
        Me.cbxFoodBasket.Text = "Goumet Food Welcome Basket $30"
        Me.cbxFoodBasket.UseVisualStyleBackColor = True
        '
        'tbxFirstName
        '
        Me.tbxFirstName.Location = New System.Drawing.Point(162, 85)
        Me.tbxFirstName.Name = "tbxFirstName"
        Me.tbxFirstName.Size = New System.Drawing.Size(113, 23)
        Me.tbxFirstName.TabIndex = 11
        '
        'tbxSurName
        '
        Me.tbxSurName.Location = New System.Drawing.Point(162, 114)
        Me.tbxSurName.Name = "tbxSurName"
        Me.tbxSurName.Size = New System.Drawing.Size(113, 23)
        Me.tbxSurName.TabIndex = 12
        '
        'tbxGuests
        '
        Me.tbxGuests.Location = New System.Drawing.Point(162, 145)
        Me.tbxGuests.Name = "tbxGuests"
        Me.tbxGuests.Size = New System.Drawing.Size(72, 23)
        Me.tbxGuests.TabIndex = 13
        '
        'tbxNights
        '
        Me.tbxNights.Location = New System.Drawing.Point(162, 179)
        Me.tbxNights.Name = "tbxNights"
        Me.tbxNights.Size = New System.Drawing.Size(72, 23)
        Me.tbxNights.TabIndex = 14
        '
        'lsbDisplay
        '
        Me.lsbDisplay.FormattingEnabled = True
        Me.lsbDisplay.ItemHeight = 15
        Me.lsbDisplay.Location = New System.Drawing.Point(26, 329)
        Me.lsbDisplay.Name = "lsbDisplay"
        Me.lsbDisplay.Size = New System.Drawing.Size(562, 109)
        Me.lsbDisplay.TabIndex = 15
        '
        'btnGo
        '
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnGo.Location = New System.Drawing.Point(531, 109)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(131, 45)
        Me.btnGo.TabIndex = 16
        Me.btnGo.Text = "Calculate Price"
        Me.btnGo.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(531, 168)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(131, 45)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Reset Form (Clear)"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnExit.Location = New System.Drawing.Point(594, 372)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(97, 39)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 450)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.lsbDisplay)
        Me.Controls.Add(Me.tbxNights)
        Me.Controls.Add(Me.tbxGuests)
        Me.Controls.Add(Me.tbxSurName)
        Me.Controls.Add(Me.tbxFirstName)
        Me.Controls.Add(Me.cbxFoodBasket)
        Me.Controls.Add(Me.cbxSuperiorPillows)
        Me.Controls.Add(Me.cmbxRoomType)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbSuperior As RadioButton
    Friend WithEvents rdbStandard As RadioButton
    Friend WithEvents rdbDelux As RadioButton
    Friend WithEvents cmbxRoomType As ComboBox
    Friend WithEvents cbxSuperiorPillows As CheckBox
    Friend WithEvents cbxFoodBasket As CheckBox
    Friend WithEvents tbxFirstName As TextBox
    Friend WithEvents tbxSurName As TextBox
    Friend WithEvents tbxGuests As TextBox
    Friend WithEvents tbxNights As TextBox
    Friend WithEvents lsbDisplay As ListBox
    Friend WithEvents btnGo As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
