<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me.TodoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.moveup = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.movedown = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TodoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbDataSet = New Simpletodolist.dbDataSet()
        Me.TodoTableAdapter = New Simpletodolist.dbDataSetTableAdapters.todoTableAdapter()
        Me.TableAdapterManager = New Simpletodolist.dbDataSetTableAdapters.TableAdapterManager()
        CType(Me.TodoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TodoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TodoDataGridView
        '
        Me.TodoDataGridView.AllowUserToAddRows = False
        Me.TodoDataGridView.AllowUserToDeleteRows = False
        Me.TodoDataGridView.AllowUserToResizeColumns = False
        Me.TodoDataGridView.AllowUserToResizeRows = False
        Me.TodoDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TodoDataGridView.AutoGenerateColumns = False
        Me.TodoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TodoDataGridView.BackgroundColor = System.Drawing.Color.Khaki
        Me.TodoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TodoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TodoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Column1, Me.moveup, Me.movedown})
        Me.TodoDataGridView.DataSource = Me.TodoBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Desktop
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.TodoDataGridView.DefaultCellStyle = DataGridViewCellStyle1
        Me.TodoDataGridView.GridColor = System.Drawing.SystemColors.ScrollBar
        Me.TodoDataGridView.Location = New System.Drawing.Point(12, 65)
        Me.TodoDataGridView.Name = "TodoDataGridView"
        Me.TodoDataGridView.ReadOnly = True
        Me.TodoDataGridView.RowHeadersVisible = False
        Me.TodoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TodoDataGridView.Size = New System.Drawing.Size(415, 227)
        Me.TodoDataGridView.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(377, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 21)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Dodaj"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 274)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(359, 20)
        Me.TextBox1.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.DataPropertyName = "removeitem"
        Me.Column1.HeaderText = ""
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 50
        '
        'moveup
        '
        Me.moveup.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.moveup.DataPropertyName = "moveup"
        Me.moveup.FillWeight = 100.4869!
        Me.moveup.HeaderText = ""
        Me.moveup.Name = "moveup"
        Me.moveup.ReadOnly = True
        Me.moveup.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.moveup.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.moveup.Width = 50
        '
        'movedown
        '
        Me.movedown.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.movedown.DataPropertyName = "movedown"
        Me.movedown.FillWeight = 102.0408!
        Me.movedown.HeaderText = ""
        Me.movedown.Name = "movedown"
        Me.movedown.ReadOnly = True
        Me.movedown.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.movedown.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.movedown.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "itemorder"
        Me.DataGridViewTextBoxColumn1.HeaderText = "itemorder"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "itemtodo"
        Me.DataGridViewTextBoxColumn2.FillWeight = 97.47229!
        Me.DataGridViewTextBoxColumn2.HeaderText = " "
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TodoBindingSource
        '
        Me.TodoBindingSource.DataMember = "todo"
        Me.TodoBindingSource.DataSource = Me.DbDataSet
        '
        'DbDataSet
        '
        Me.DbDataSet.DataSetName = "dbDataSet"
        Me.DbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TodoTableAdapter
        '
        Me.TodoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.todoTableAdapter = Me.TodoTableAdapter
        Me.TableAdapterManager.UpdateOrder = Simpletodolist.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Simpletodolist.My.Resources.Resources.tlo
        Me.ClientSize = New System.Drawing.Size(439, 304)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TodoDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainWindow"
        Me.Text = "Kajecik"
        CType(Me.TodoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TodoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DbDataSet As Simpletodolist.dbDataSet
    Friend WithEvents TodoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TodoTableAdapter As Simpletodolist.dbDataSetTableAdapters.todoTableAdapter
    Friend WithEvents TableAdapterManager As Simpletodolist.dbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TodoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents moveup As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents movedown As System.Windows.Forms.DataGridViewButtonColumn

End Class
