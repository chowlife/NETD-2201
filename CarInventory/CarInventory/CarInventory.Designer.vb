<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
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
        Me.lbMake = New System.Windows.Forms.Label()
        Me.lbYear = New System.Windows.Forms.Label()
        Me.lbModel = New System.Windows.Forms.Label()
        Me.lbPrice = New System.Windows.Forms.Label()
        Me.lbNew = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lvwResult = New System.Windows.Forms.ListView()
        Me.lbOutput = New System.Windows.Forms.Label()
        Me.CarInventoryToolTips = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmbMake = New System.Windows.Forms.ComboBox()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.tbModel = New System.Windows.Forms.TextBox()
        Me.tbPrice = New System.Windows.Forms.TextBox()
        Me.ColNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColIdentification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColYear = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lbMake
        '
        Me.lbMake.AutoSize = True
        Me.lbMake.Location = New System.Drawing.Point(35, 9)
        Me.lbMake.Name = "lbMake"
        Me.lbMake.Size = New System.Drawing.Size(46, 17)
        Me.lbMake.TabIndex = 3
        Me.lbMake.Text = "&Make:"
        Me.lbMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTips.SetToolTip(Me.lbMake, "Labels for controls")
        '
        'lbYear
        '
        Me.lbYear.AutoSize = True
        Me.lbYear.Location = New System.Drawing.Point(35, 69)
        Me.lbYear.Name = "lbYear"
        Me.lbYear.Size = New System.Drawing.Size(42, 17)
        Me.lbYear.TabIndex = 5
        Me.lbYear.Text = "&Year:"
        Me.lbYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTips.SetToolTip(Me.lbYear, "Labels for controls")
        '
        'lbModel
        '
        Me.lbModel.AutoSize = True
        Me.lbModel.Location = New System.Drawing.Point(35, 38)
        Me.lbModel.Name = "lbModel"
        Me.lbModel.Size = New System.Drawing.Size(50, 17)
        Me.lbModel.TabIndex = 4
        Me.lbModel.Text = "&Model:"
        Me.lbModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTips.SetToolTip(Me.lbModel, "Labels for controls")
        '
        'lbPrice
        '
        Me.lbPrice.AutoSize = True
        Me.lbPrice.Location = New System.Drawing.Point(35, 104)
        Me.lbPrice.Name = "lbPrice"
        Me.lbPrice.Size = New System.Drawing.Size(44, 17)
        Me.lbPrice.TabIndex = 6
        Me.lbPrice.Text = "&Price:"
        Me.lbPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTips.SetToolTip(Me.lbPrice, "Labels for controls")
        '
        'lbNew
        '
        Me.lbNew.AutoSize = True
        Me.lbNew.Location = New System.Drawing.Point(35, 137)
        Me.lbNew.Name = "lbNew"
        Me.lbNew.Size = New System.Drawing.Size(39, 17)
        Me.lbNew.TabIndex = 7
        Me.lbNew.Text = "&New:"
        Me.lbNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTips.SetToolTip(Me.lbNew, "Labels for controls")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(239, 413)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "&Enter"
        Me.CarInventoryToolTips.SetToolTip(Me.btnEnter, "Click or press enter key to Enter")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(320, 413)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.CarInventoryToolTips.SetToolTip(Me.btnReset, "Click or press ESC key to reset")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(401, 413)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "&Exit"
        Me.CarInventoryToolTips.SetToolTip(Me.btnExit, "Click to Exit")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lvwResult
        '
        Me.lvwResult.CheckBoxes = True
        Me.lvwResult.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColNew, Me.ColIdentification, Me.ColMake, Me.ColModel, Me.ColYear, Me.ColPrice})
        Me.lvwResult.FullRowSelect = True
        Me.lvwResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwResult.Location = New System.Drawing.Point(2, 163)
        Me.lvwResult.MultiSelect = False
        Me.lvwResult.Name = "lvwResult"
        Me.lvwResult.Size = New System.Drawing.Size(481, 167)
        Me.lvwResult.TabIndex = 8
        Me.CarInventoryToolTips.SetToolTip(Me.lvwResult, "Shows the result based on your input and selections")
        Me.lvwResult.UseCompatibleStateImageBehavior = False
        Me.lvwResult.View = System.Windows.Forms.View.Details
        '
        'lbOutput
        '
        Me.lbOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbOutput.Location = New System.Drawing.Point(2, 333)
        Me.lbOutput.Name = "lbOutput"
        Me.lbOutput.Size = New System.Drawing.Size(481, 73)
        Me.lbOutput.TabIndex = 9
        Me.lbOutput.Text = "&"
        Me.CarInventoryToolTips.SetToolTip(Me.lbOutput, "Output something")
        '
        'cmbMake
        '
        Me.cmbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMake.FormattingEnabled = True
        Me.cmbMake.Items.AddRange(New Object() {"Toyota", "Holden", "Ford", "Nissan", "Mazda", "Mercedes-Benz", "Volkswagen", "Audi"})
        Me.cmbMake.Location = New System.Drawing.Point(87, 8)
        Me.cmbMake.Name = "cmbMake"
        Me.cmbMake.Size = New System.Drawing.Size(121, 24)
        Me.cmbMake.TabIndex = 10
        Me.CarInventoryToolTips.SetToolTip(Me.cmbMake, "Select your car make")
        '
        'chkNew
        '
        Me.chkNew.AutoSize = True
        Me.chkNew.Location = New System.Drawing.Point(80, 137)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(30, 21)
        Me.chkNew.TabIndex = 14
        Me.chkNew.Text = "&"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CarInventoryToolTips.SetToolTip(Me.chkNew, "Check this if car is new")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018"})
        Me.cmbYear.Location = New System.Drawing.Point(87, 69)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(121, 24)
        Me.cmbYear.TabIndex = 12
        Me.CarInventoryToolTips.SetToolTip(Me.cmbYear, "Select your car year")
        '
        'tbModel
        '
        Me.tbModel.Location = New System.Drawing.Point(87, 38)
        Me.tbModel.Name = "tbModel"
        Me.tbModel.Size = New System.Drawing.Size(121, 22)
        Me.tbModel.TabIndex = 11
        Me.CarInventoryToolTips.SetToolTip(Me.tbModel, "Input your car model")
        '
        'tbPrice
        '
        Me.tbPrice.Location = New System.Drawing.Point(87, 104)
        Me.tbPrice.Name = "tbPrice"
        Me.tbPrice.Size = New System.Drawing.Size(121, 22)
        Me.tbPrice.TabIndex = 13
        Me.CarInventoryToolTips.SetToolTip(Me.tbPrice, "Input car price")
        '
        'ColNew
        '
        Me.ColNew.Text = "New"
        '
        'ColIdentification
        '
        Me.ColIdentification.Text = "ID"
        '
        'ColMake
        '
        Me.ColMake.Text = "Make"
        '
        'ColModel
        '
        Me.ColModel.Text = "Model"
        '
        'ColYear
        '
        Me.ColYear.Text = "Year"
        '
        'ColPrice
        '
        Me.ColPrice.Text = "Price"
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(485, 448)
        Me.Controls.Add(Me.tbPrice)
        Me.Controls.Add(Me.tbModel)
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.cmbMake)
        Me.Controls.Add(Me.lbOutput)
        Me.Controls.Add(Me.lvwResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lbNew)
        Me.Controls.Add(Me.lbPrice)
        Me.Controls.Add(Me.lbModel)
        Me.Controls.Add(Me.lbYear)
        Me.Controls.Add(Me.lbMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbMake As Windows.Forms.Label
    Friend WithEvents lbYear As Windows.Forms.Label
    Friend WithEvents lbModel As Windows.Forms.Label
    Friend WithEvents lbPrice As Windows.Forms.Label
    Friend WithEvents lbNew As Windows.Forms.Label
    Friend WithEvents btnEnter As Windows.Forms.Button
    Friend WithEvents btnReset As Windows.Forms.Button
    Friend WithEvents btnExit As Windows.Forms.Button
    Friend WithEvents lvwResult As Windows.Forms.ListView
    Friend WithEvents lbOutput As Windows.Forms.Label
    Friend WithEvents CarInventoryToolTips As Windows.Forms.ToolTip
    Friend WithEvents cmbMake As Windows.Forms.ComboBox
    Friend WithEvents chkNew As Windows.Forms.CheckBox
    Friend WithEvents cmbYear As Windows.Forms.ComboBox
    Friend WithEvents tbModel As Windows.Forms.TextBox
    Friend WithEvents tbPrice As Windows.Forms.TextBox
    Friend WithEvents ColNew As Windows.Forms.ColumnHeader
    Friend WithEvents ColIdentification As Windows.Forms.ColumnHeader
    Friend WithEvents ColMake As Windows.Forms.ColumnHeader
    Friend WithEvents ColModel As Windows.Forms.ColumnHeader
    Friend WithEvents ColYear As Windows.Forms.ColumnHeader
    Friend WithEvents ColPrice As Windows.Forms.ColumnHeader
End Class
