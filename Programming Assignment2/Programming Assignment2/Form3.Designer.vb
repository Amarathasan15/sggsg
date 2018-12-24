<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim Matric_numberLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Btnupdate = New System.Windows.Forms.Button()
        Me.Btndelete = New System.Windows.Forms.Button()
        Me.Btncancel = New System.Windows.Forms.Button()
        Me.Btncommit = New System.Windows.Forms.Button()
        Me.Buttonaddview = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripComboBox1 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox2 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox3 = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripComboBox4 = New System.Windows.Forms.ToolStripComboBox()
        Me.Student_registration_QueryDataSet = New Programming_Assignment2.Student_registration_QueryDataSet()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentTableAdapter = New Programming_Assignment2.Student_registration_QueryDataSetTableAdapters.StudentTableAdapter()
        Me.TableAdapterManager = New Programming_Assignment2.Student_registration_QueryDataSetTableAdapters.TableAdapterManager()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.Matric_numberTextBox = New System.Windows.Forms.TextBox()
        Me.StudentBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.StudentBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        NameLabel = New System.Windows.Forms.Label()
        Matric_numberLabel = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Student_registration_QueryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StudentBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(78, 105)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(49, 17)
        NameLabel.TabIndex = 20
        NameLabel.Text = "Name:"
        '
        'Matric_numberLabel
        '
        Matric_numberLabel.AutoSize = True
        Matric_numberLabel.Location = New System.Drawing.Point(78, 146)
        Matric_numberLabel.Name = "Matric_numberLabel"
        Matric_numberLabel.Size = New System.Drawing.Size(102, 17)
        Matric_numberLabel.TabIndex = 21
        Matric_numberLabel.Text = "Matric number:"
        '
        'Btnupdate
        '
        Me.Btnupdate.Location = New System.Drawing.Point(581, 146)
        Me.Btnupdate.Name = "Btnupdate"
        Me.Btnupdate.Size = New System.Drawing.Size(112, 56)
        Me.Btnupdate.TabIndex = 0
        Me.Btnupdate.Text = "Update"
        Me.Btnupdate.UseVisualStyleBackColor = True
        '
        'Btndelete
        '
        Me.Btndelete.Location = New System.Drawing.Point(581, 208)
        Me.Btndelete.Name = "Btndelete"
        Me.Btndelete.Size = New System.Drawing.Size(112, 55)
        Me.Btndelete.TabIndex = 1
        Me.Btndelete.Text = "Delete"
        Me.Btndelete.UseVisualStyleBackColor = True
        '
        'Btncancel
        '
        Me.Btncancel.Location = New System.Drawing.Point(578, 328)
        Me.Btncancel.Name = "Btncancel"
        Me.Btncancel.Size = New System.Drawing.Size(115, 57)
        Me.Btncancel.TabIndex = 3
        Me.Btncancel.Text = "Cancel"
        Me.Btncancel.UseVisualStyleBackColor = True
        '
        'Btncommit
        '
        Me.Btncommit.Location = New System.Drawing.Point(581, 269)
        Me.Btncommit.Name = "Btncommit"
        Me.Btncommit.Size = New System.Drawing.Size(112, 53)
        Me.Btncommit.TabIndex = 2
        Me.Btncommit.Text = "Commit"
        Me.Btncommit.UseVisualStyleBackColor = True
        '
        'Buttonaddview
        '
        Me.Buttonaddview.Location = New System.Drawing.Point(581, 85)
        Me.Buttonaddview.Name = "Buttonaddview"
        Me.Buttonaddview.Size = New System.Drawing.Size(115, 55)
        Me.Buttonaddview.TabIndex = 4
        Me.Buttonaddview.Text = "Add new"
        Me.Buttonaddview.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripComboBox1, Me.ToolStripComboBox2, Me.ToolStripComboBox3, Me.ToolStripComboBox4})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 32)
        Me.MenuStrip1.TabIndex = 20
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripComboBox1
        '
        Me.ToolStripComboBox1.Items.AddRange(New Object() {"Save ", "Print", "Back ", "Properties ", "Sign Out ", "Exit "})
        Me.ToolStripComboBox1.Name = "ToolStripComboBox1"
        Me.ToolStripComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ToolStripComboBox1.Text = "File "
        '
        'ToolStripComboBox2
        '
        Me.ToolStripComboBox2.Items.AddRange(New Object() {"Cut", "Copy ", "Paste", "Delete ", "Undo"})
        Me.ToolStripComboBox2.Name = "ToolStripComboBox2"
        Me.ToolStripComboBox2.Size = New System.Drawing.Size(121, 28)
        Me.ToolStripComboBox2.Text = "Edit"
        '
        'ToolStripComboBox3
        '
        Me.ToolStripComboBox3.Items.AddRange(New Object() {"General ", "Language "})
        Me.ToolStripComboBox3.Name = "ToolStripComboBox3"
        Me.ToolStripComboBox3.Size = New System.Drawing.Size(121, 28)
        Me.ToolStripComboBox3.Text = "Settings"
        '
        'ToolStripComboBox4
        '
        Me.ToolStripComboBox4.Items.AddRange(New Object() {"Send Feeback ", "View Help"})
        Me.ToolStripComboBox4.Name = "ToolStripComboBox4"
        Me.ToolStripComboBox4.Size = New System.Drawing.Size(121, 28)
        Me.ToolStripComboBox4.Text = "Help"
        '
        'Student_registration_QueryDataSet
        '
        Me.Student_registration_QueryDataSet.DataSetName = "Student_registration_QueryDataSet"
        Me.Student_registration_QueryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataMember = "Student"
        Me.StudentBindingSource.DataSource = Me.Student_registration_QueryDataSet
        '
        'StudentTableAdapter
        '
        Me.StudentTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CoursesTableAdapter = Nothing
        Me.TableAdapterManager.DepartmentTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.StudentTableAdapter = Me.StudentTableAdapter
        Me.TableAdapterManager.SubjectTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Programming_Assignment2.Student_registration_QueryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(133, 102)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(201, 22)
        Me.NameTextBox.TabIndex = 21
        '
        'Matric_numberTextBox
        '
        Me.Matric_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentBindingSource, "Matric_number", True))
        Me.Matric_numberTextBox.Location = New System.Drawing.Point(186, 146)
        Me.Matric_numberTextBox.Name = "Matric_numberTextBox"
        Me.Matric_numberTextBox.Size = New System.Drawing.Size(148, 22)
        Me.Matric_numberTextBox.TabIndex = 22
        '
        'StudentBindingNavigator
        '
        Me.StudentBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.StudentBindingNavigator.BindingSource = Me.StudentBindingSource
        Me.StudentBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.StudentBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.StudentBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StudentBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.StudentBindingNavigatorSaveItem})
        Me.StudentBindingNavigator.Location = New System.Drawing.Point(0, 32)
        Me.StudentBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.StudentBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.StudentBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.StudentBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.StudentBindingNavigator.Name = "StudentBindingNavigator"
        Me.StudentBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.StudentBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.StudentBindingNavigator.TabIndex = 23
        Me.StudentBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(45, 24)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'StudentBindingNavigatorSaveItem
        '
        Me.StudentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.StudentBindingNavigatorSaveItem.Image = CType(resources.GetObject("StudentBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.StudentBindingNavigatorSaveItem.Name = "StudentBindingNavigatorSaveItem"
        Me.StudentBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.StudentBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StudentBindingNavigator)
        Me.Controls.Add(Matric_numberLabel)
        Me.Controls.Add(Me.Matric_numberTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Buttonaddview)
        Me.Controls.Add(Me.Btncancel)
        Me.Controls.Add(Me.Btncommit)
        Me.Controls.Add(Me.Btndelete)
        Me.Controls.Add(Me.Btnupdate)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Student_registration_QueryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StudentBindingNavigator.ResumeLayout(False)
        Me.StudentBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnupdate As Button
    Friend WithEvents Btndelete As Button
    Friend WithEvents Btncancel As Button
    Friend WithEvents Btncommit As Button
    Friend WithEvents Buttonaddview As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripComboBox1 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox2 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox3 As ToolStripComboBox
    Friend WithEvents ToolStripComboBox4 As ToolStripComboBox
    Friend WithEvents Student_registration_QueryDataSet As Student_registration_QueryDataSet
    Friend WithEvents StudentBindingSource As BindingSource
    Friend WithEvents StudentTableAdapter As Student_registration_QueryDataSetTableAdapters.StudentTableAdapter
    Friend WithEvents TableAdapterManager As Student_registration_QueryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents Matric_numberTextBox As TextBox
    Friend WithEvents StudentBindingNavigator As BindingNavigator
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
    Friend WithEvents StudentBindingNavigatorSaveItem As ToolStripButton
End Class
