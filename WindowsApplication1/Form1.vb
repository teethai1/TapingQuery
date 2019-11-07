Public Class Form1


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MAPTPDataTableAdapter.FillBy(DBxDataSet.MAPTPData)
        lbcount.Text = DBxDataSet.MAPTPData.Rows.Count
    End Sub

   
End Class
