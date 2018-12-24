Public Class Form3
    Private Sub Buttonaddview_Click(sender As Object, e As EventArgs) Handles Buttonaddview.Click
        Btncommit.Enabled = True
        Buttonaddview.Enabled = False
        Btnupdate.Enabled = False
        Btndelete.Enabled = False
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Student_registration_QueryDataSet.Student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.Student_registration_QueryDataSet.Student)

    End Sub
End Class