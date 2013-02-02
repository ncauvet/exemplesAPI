<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.UcdRadioButton = New System.Windows.Forms.RadioButton()
        Me.DCIRadioButton = New System.Windows.Forms.RadioButton()
        Me.PackRadioButton = New System.Windows.Forms.RadioButton()
        Me.ProductRadioButton = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.IAM = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Drug = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HiddenLine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 20)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.UcdRadioButton)
        Me.GroupBox1.Controls.Add(Me.DCIRadioButton)
        Me.GroupBox1.Controls.Add(Me.PackRadioButton)
        Me.GroupBox1.Controls.Add(Me.ProductRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 47)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'UcdRadioButton
        '
        Me.UcdRadioButton.AutoSize = True
        Me.UcdRadioButton.Location = New System.Drawing.Point(340, 20)
        Me.UcdRadioButton.Name = "UcdRadioButton"
        Me.UcdRadioButton.Size = New System.Drawing.Size(48, 17)
        Me.UcdRadioButton.TabIndex = 3
        Me.UcdRadioButton.Text = "UCD"
        Me.UcdRadioButton.UseVisualStyleBackColor = True
        '
        'DCIRadioButton
        '
        Me.DCIRadioButton.AutoSize = True
        Me.DCIRadioButton.Location = New System.Drawing.Point(227, 20)
        Me.DCIRadioButton.Name = "DCIRadioButton"
        Me.DCIRadioButton.Size = New System.Drawing.Size(43, 17)
        Me.DCIRadioButton.TabIndex = 2
        Me.DCIRadioButton.Text = "DCI"
        Me.DCIRadioButton.UseVisualStyleBackColor = True
        '
        'PackRadioButton
        '
        Me.PackRadioButton.AutoSize = True
        Me.PackRadioButton.Location = New System.Drawing.Point(114, 20)
        Me.PackRadioButton.Name = "PackRadioButton"
        Me.PackRadioButton.Size = New System.Drawing.Size(89, 17)
        Me.PackRadioButton.TabIndex = 1
        Me.PackRadioButton.Text = "Présentations"
        Me.PackRadioButton.UseVisualStyleBackColor = True
        '
        'ProductRadioButton
        '
        Me.ProductRadioButton.AutoSize = True
        Me.ProductRadioButton.Checked = True
        Me.ProductRadioButton.Location = New System.Drawing.Point(17, 20)
        Me.ProductRadioButton.Name = "ProductRadioButton"
        Me.ProductRadioButton.Size = New System.Drawing.Size(82, 17)
        Me.ProductRadioButton.TabIndex = 0
        Me.ProductRadioButton.TabStop = True
        Me.ProductRadioButton.Text = "Spécialitées"
        Me.ProductRadioButton.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(430, 91)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Patient :"
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(511, 91)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(812, 501)
        Me.WebBrowser1.TabIndex = 7
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(712, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 8
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IAM, Me.Drug, Me.HiddenLine})
        Me.DataGridView2.Location = New System.Drawing.Point(12, 166)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(447, 200)
        Me.DataGridView2.TabIndex = 9
        '
        'ListBox1
        '
        Me.ListBox1.DisplayMember = "name"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 91)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(412, 69)
        Me.ListBox1.TabIndex = 10
        Me.ListBox1.ValueMember = "name"
        '
        'IAM
        '
        Me.IAM.HeaderText = "IAM"
        Me.IAM.Name = "IAM"
        Me.IAM.ReadOnly = True
        '
        'Drug
        '
        Me.Drug.HeaderText = "Drug"
        Me.Drug.Name = "Drug"
        Me.Drug.ReadOnly = True
        Me.Drug.Width = 300
        '
        'HiddenLine
        '
        Me.HiddenLine.HeaderText = "HiddenLine"
        Me.HiddenLine.Name = "HiddenLine"
        Me.HiddenLine.ReadOnly = True
        Me.HiddenLine.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 604)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UcdRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents DCIRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents PackRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ProductRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents IAM As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Drug As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HiddenLine As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
