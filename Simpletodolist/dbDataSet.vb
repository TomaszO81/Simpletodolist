Partial Class dbDataSet
    Partial Class todoDataTable

        Private Sub todoDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.movedownColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

End Class
