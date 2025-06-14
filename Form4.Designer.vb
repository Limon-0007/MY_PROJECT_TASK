<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim Payroll_idLabel As System.Windows.Forms.Label
        Dim Employee_idLabel As System.Windows.Forms.Label
        Dim SalaryLabel As System.Windows.Forms.Label
        Dim Payment_dateLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Payroll_idTextBox = New System.Windows.Forms.TextBox()
        Me.PayrollBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Access_tables_for_projectDataSet = New MY_PROJECT_TASK.access_tables_for_projectDataSet()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Employee_idTextBox = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SalaryTextBox = New System.Windows.Forms.TextBox()
        Me.Payment_dateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PayrollTableAdapter = New MY_PROJECT_TASK.access_tables_for_projectDataSetTableAdapters.PayrollTableAdapter()
        Me.TableAdapterManager = New MY_PROJECT_TASK.access_tables_for_projectDataSetTableAdapters.TableAdapterManager()
        Me.PayrollBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.PayrollBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PayrollDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Payroll_idLabel = New System.Windows.Forms.Label()
        Employee_idLabel = New System.Windows.Forms.Label()
        SalaryLabel = New System.Windows.Forms.Label()
        Payment_dateLabel = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Access_tables_for_projectDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PayrollBindingNavigator.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PayrollDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Payroll_idLabel
        '
        Payroll_idLabel.AutoSize = True
        Payroll_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Payroll_idLabel.Location = New System.Drawing.Point(16, 253)
        Payroll_idLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Payroll_idLabel.Name = "Payroll_idLabel"
        Payroll_idLabel.Size = New System.Drawing.Size(131, 30)
        Payroll_idLabel.TabIndex = 2
        Payroll_idLabel.Text = "Payroll ID:"
        '
        'Employee_idLabel
        '
        Employee_idLabel.AutoSize = True
        Employee_idLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Employee_idLabel.Location = New System.Drawing.Point(16, 319)
        Employee_idLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Employee_idLabel.Name = "Employee_idLabel"
        Employee_idLabel.Size = New System.Drawing.Size(166, 30)
        Employee_idLabel.TabIndex = 4
        Employee_idLabel.Text = "Employee ID:"
        '
        'SalaryLabel
        '
        SalaryLabel.AutoSize = True
        SalaryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalaryLabel.Location = New System.Drawing.Point(16, 386)
        SalaryLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New System.Drawing.Size(93, 30)
        SalaryLabel.TabIndex = 6
        SalaryLabel.Text = "Salary:"
        '
        'Payment_dateLabel
        '
        Payment_dateLabel.AutoSize = True
        Payment_dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Payment_dateLabel.Location = New System.Drawing.Point(16, 454)
        Payment_dateLabel.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Payment_dateLabel.Name = "Payment_dateLabel"
        Payment_dateLabel.Size = New System.Drawing.Size(177, 30)
        Payment_dateLabel.TabIndex = 8
        Payment_dateLabel.Text = "Payment date:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1404, 85)
        Me.Panel1.TabIndex = 0
        '
        'LinkLabel1
        '
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(15, 30)
        Me.LinkLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(120, 32)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Home"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(981, 30)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(396, 35)
        Me.DateTimePicker1.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(343, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(541, 63)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Payroll Management"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.Button7)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button6)
        Me.Panel2.Controls.Add(Payroll_idLabel)
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.Payroll_idTextBox)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Employee_idLabel)
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Employee_idTextBox)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(SalaryLabel)
        Me.Panel2.Controls.Add(Me.SalaryTextBox)
        Me.Panel2.Controls.Add(Payment_dateLabel)
        Me.Panel2.Controls.Add(Me.Payment_dateDateTimePicker)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 85)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(652, 726)
        Me.Panel2.TabIndex = 1
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.Black
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(234, 619)
        Me.Button7.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(204, 68)
        Me.Button7.TabIndex = 6
        Me.Button7.Text = "Previous"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MY_PROJECT_TASK.My.Resources.Resources.download_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(189, 11)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(307, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Navy
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(448, 619)
        Me.Button6.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(170, 68)
        Me.Button6.TabIndex = 5
        Me.Button6.Text = "Next"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.SaddleBrown
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(37, 618)
        Me.Button5.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(181, 68)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Refresh"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Payroll_idTextBox
        '
        Me.Payroll_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "payroll_id", True))
        Me.Payroll_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payroll_idTextBox.Location = New System.Drawing.Point(208, 253)
        Me.Payroll_idTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Payroll_idTextBox.Multiline = True
        Me.Payroll_idTextBox.Name = "Payroll_idTextBox"
        Me.Payroll_idTextBox.Size = New System.Drawing.Size(416, 52)
        Me.Payroll_idTextBox.TabIndex = 3
        '
        'PayrollBindingSource
        '
        Me.PayrollBindingSource.DataMember = "Payroll"
        Me.PayrollBindingSource.DataSource = Me.Access_tables_for_projectDataSet
        '
        'Access_tables_for_projectDataSet
        '
        Me.Access_tables_for_projectDataSet.DataSetName = "access_tables_for_projectDataSet"
        Me.Access_tables_for_projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Red
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(448, 539)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(170, 68)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Delete"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Green
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(234, 539)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(204, 68)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Save"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Employee_idTextBox
        '
        Me.Employee_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "employee_id", True))
        Me.Employee_idTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Employee_idTextBox.Location = New System.Drawing.Point(208, 319)
        Me.Employee_idTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Employee_idTextBox.Multiline = True
        Me.Employee_idTextBox.Name = "Employee_idTextBox"
        Me.Employee_idTextBox.Size = New System.Drawing.Size(416, 52)
        Me.Employee_idTextBox.TabIndex = 5
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Teal
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(36, 539)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 68)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "New"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'SalaryTextBox
        '
        Me.SalaryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PayrollBindingSource, "salary", True))
        Me.SalaryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalaryTextBox.Location = New System.Drawing.Point(208, 386)
        Me.SalaryTextBox.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.SalaryTextBox.Multiline = True
        Me.SalaryTextBox.Name = "SalaryTextBox"
        Me.SalaryTextBox.Size = New System.Drawing.Size(416, 52)
        Me.SalaryTextBox.TabIndex = 7
        '
        'Payment_dateDateTimePicker
        '
        Me.Payment_dateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PayrollBindingSource, "payment_date", True))
        Me.Payment_dateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payment_dateDateTimePicker.Location = New System.Drawing.Point(208, 452)
        Me.Payment_dateDateTimePicker.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Payment_dateDateTimePicker.Name = "Payment_dateDateTimePicker"
        Me.Payment_dateDateTimePicker.Size = New System.Drawing.Size(416, 51)
        Me.Payment_dateDateTimePicker.TabIndex = 9
        '
        'PayrollTableAdapter
        '
        Me.PayrollTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AttendanceTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.Emp_LoginTableAdapter = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.PayrollTableAdapter = Me.PayrollTableAdapter
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MY_PROJECT_TASK.access_tables_for_projectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PayrollBindingNavigator
        '
        Me.PayrollBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PayrollBindingNavigator.BindingSource = Me.PayrollBindingSource
        Me.PayrollBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PayrollBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PayrollBindingNavigator.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.PayrollBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PayrollBindingNavigatorSaveItem})
        Me.PayrollBindingNavigator.Location = New System.Drawing.Point(683, 85)
        Me.PayrollBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PayrollBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PayrollBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PayrollBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PayrollBindingNavigator.Name = "PayrollBindingNavigator"
        Me.PayrollBindingNavigator.Padding = New System.Windows.Forms.Padding(0, 0, 4, 0)
        Me.PayrollBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PayrollBindingNavigator.Size = New System.Drawing.Size(788, 46)
        Me.PayrollBindingNavigator.TabIndex = 2
        Me.PayrollBindingNavigator.Text = "BindingNavigator1"
        Me.PayrollBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(46, 40)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(70, 40)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(46, 40)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(46, 40)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(46, 40)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 46)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(96, 39)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 46)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(46, 40)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(46, 40)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 46)
        '
        'PayrollBindingNavigatorSaveItem
        '
        Me.PayrollBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PayrollBindingNavigatorSaveItem.Image = CType(resources.GetObject("PayrollBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PayrollBindingNavigatorSaveItem.Name = "PayrollBindingNavigatorSaveItem"
        Me.PayrollBindingNavigatorSaveItem.Size = New System.Drawing.Size(46, 40)
        Me.PayrollBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Navy
        Me.Panel3.Controls.Add(Me.IconPictureBox1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.ComboBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(652, 85)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(752, 66)
        Me.Panel3.TabIndex = 3
        '
        'PayrollDataGridView
        '
        Me.PayrollDataGridView.AutoGenerateColumns = False
        Me.PayrollDataGridView.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PayrollDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.PayrollDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PayrollDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PayrollDataGridView.DataSource = Me.PayrollBindingSource
        Me.PayrollDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PayrollDataGridView.Location = New System.Drawing.Point(652, 151)
        Me.PayrollDataGridView.Margin = New System.Windows.Forms.Padding(5, 6, 5, 6)
        Me.PayrollDataGridView.Name = "PayrollDataGridView"
        Me.PayrollDataGridView.RowHeadersWidth = 62
        Me.PayrollDataGridView.Size = New System.Drawing.Size(752, 660)
        Me.PayrollDataGridView.TabIndex = 4
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "payroll_id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Payroll_ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 158
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "employee_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Employee_ID"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 189
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "salary"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Salary"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 119
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "payment_date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Payment_Date"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 202
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.Navy
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.Gold
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HandPointRight
        Me.IconPictureBox1.IconColor = System.Drawing.Color.Gold
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 34
        Me.IconPictureBox1.Location = New System.Drawing.Point(325, 14)
        Me.IconPictureBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(64, 34)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.IconPictureBox1.TabIndex = 9
        Me.IconPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(389, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select:"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"CSE", "Chemistry", "Psycology", "History", "EEE"})
        Me.ComboBox1.Location = New System.Drawing.Point(485, 12)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 37)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "Department"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1404, 811)
        Me.Controls.Add(Me.PayrollDataGridView)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PayrollBindingNavigator)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payroll Management"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Access_tables_for_projectDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PayrollBindingNavigator.ResumeLayout(False)
        Me.PayrollBindingNavigator.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PayrollDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Access_tables_for_projectDataSet As access_tables_for_projectDataSet
    Friend WithEvents PayrollBindingSource As BindingSource
    Friend WithEvents PayrollTableAdapter As access_tables_for_projectDataSetTableAdapters.PayrollTableAdapter
    Friend WithEvents TableAdapterManager As access_tables_for_projectDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PayrollBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PayrollBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Payroll_idTextBox As TextBox
    Friend WithEvents Employee_idTextBox As TextBox
    Friend WithEvents SalaryTextBox As TextBox
    Friend WithEvents Payment_dateDateTimePicker As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PayrollDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBox1 As ComboBox
End Class
