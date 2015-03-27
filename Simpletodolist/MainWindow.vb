Public Class MainWindow

    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DbDataSet.todo' table. You can move, or remove it, as needed.
        Me.TodoTableAdapter.Fill(Me.DbDataSet.todo)

    End Sub

    Private Sub TodoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TodoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DbDataSet)

    End Sub
    ' add item
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' check if text was entered
        If TextBox1.Text.Trim = "" Then
            Exit Sub
        End If
        ' get the order
        Dim ORD As Integer? = Me.TodoTableAdapter.GetMaxOrder
        If ORD Is Nothing Then
            ORD = 0
        End If
        ORD += 1
        'perform insert operation
        Me.TodoTableAdapter.Insert(ORD, TextBox1.Text.Trim)

        'refill the data
        Me.TodoTableAdapter.Fill(Me.DbDataSet.todo)

        'clear the textbox
        TextBox1.Text = ""
        TextBox1.Focus()

    End Sub

    ' this function is used to perform the button actions
    Private Sub TodoDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TodoDataGridView.CellClick
        'make sure that remove column is selected
        If e.ColumnIndex = 2 Then
            If e.RowIndex >= 0 And e.RowIndex <= TodoDataGridView.Rows.Count - 1 Then

                'get the values
                Dim ItemOrders As Integer? = TodoDataGridView.Rows(e.RowIndex).Cells(0).Value
                Dim ItemToDo As String = TodoDataGridView.Rows(e.RowIndex).Cells(1).Value

                'remove form db
                Me.TodoTableAdapter.Delete(ItemOrders, ItemToDo)

                'refill the data
                Me.TodoTableAdapter.Fill(Me.DbDataSet.todo)

            End If
        End If
        'check the up button
        If e.ColumnIndex = 3 Then
            If e.RowIndex >= 0 And e.RowIndex <= TodoDataGridView.Rows.Count - 1 Then

                'get the values
                Dim ItemOrders As Integer? = TodoDataGridView.Rows(e.RowIndex).Cells(0).Value
                Dim ItemToDo As String = TodoDataGridView.Rows(e.RowIndex).Cells(1).Value

                'try getting the privious item
                Dim Prev As String = Me.TodoTableAdapter.GetItemByOrder(ItemOrders - 1) & ""

                If Prev <> "" Then

                    'remove form db
                    Me.TodoTableAdapter.Delete(ItemOrders, ItemToDo)
                    Me.TodoTableAdapter.Delete(ItemOrders - 1, Prev)

                    'insert the items in the correct order
                    Me.TodoTableAdapter.Insert(ItemOrders, Prev)
                    Me.TodoTableAdapter.Insert(ItemOrders - 1, ItemToDo)

                    'refill the data
                    Me.TodoTableAdapter.Fill(Me.DbDataSet.todo)

                End If
                
            End If

        End If

        'check the down button
        If e.ColumnIndex = 4 Then
            If e.RowIndex >= 0 And e.RowIndex <= TodoDataGridView.Rows.Count - 1 Then

                'get the values
                Dim ItemOrders As Integer? = TodoDataGridView.Rows(e.RowIndex).Cells(0).Value
                Dim ItemToDo As String = TodoDataGridView.Rows(e.RowIndex).Cells(1).Value

                'try getting the privious item
                Dim NXT As String = Me.TodoTableAdapter.GetItemByOrder(ItemOrders + 1) & ""

                If NXT <> "" Then

                    'remove form db
                    Me.TodoTableAdapter.Delete(ItemOrders, ItemToDo)
                    Me.TodoTableAdapter.Delete(ItemOrders + 1, NXT)

                    'insert the items in the correct order
                    Me.TodoTableAdapter.Insert(ItemOrders, NXT)
                    Me.TodoTableAdapter.Insert(ItemOrders + 1, ItemToDo)

                    'refill the data
                    Me.TodoTableAdapter.Fill(Me.DbDataSet.todo)

                End If

            End If

        End If



    End Sub

    Private Sub TodoDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TodoDataGridView.CellContentClick

    End Sub
End Class
