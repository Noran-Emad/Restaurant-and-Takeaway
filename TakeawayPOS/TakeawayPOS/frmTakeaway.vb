Imports System.Data.SqlClient

Public Class frmTakeaway
    Private total As Decimal = 0
    Private mealData As New List(Of MealItem)
    Private LocFlag As Boolean = False

    Private Sub frmTakeaway_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        btnNew_Click()
        LoadCategories()
        SetupGrid()
    End Sub

    Private Sub LoadNewOrder()
        Dim cmd As New SqlCommand("SELECT TOP 1 id FROM Order_Header ORDER BY id DESC", conn)
        Dim orderId = cmd.ExecuteScalar()
        txtOrderID.Text = orderId + 1
        txtOrderID.Enabled = False
        txtStaffName.Text = staffName
        txtStaffName.Enabled = False
        txtDeliveryFee.Enabled = False
        txtDeliveryFee.Text = 0
        txtNotes.Clear()
        txtLocName.Text = "Not Selected"
        txtLocName.Enabled = False

        Dim daCustomer As New SqlDataAdapter("SELECT id, name FROM Customer", conn)
        Dim dsCustomer As New DataSet()
        daCustomer.Fill(dsCustomer, 0)

        Dim dvCustomer As New DataView(dsCustomer.Tables(0))

        With cmbCustomerName
            .DataSource = dvCustomer
            .ValueMember = "id"
            .DisplayMember = "name"
        End With

        Dim daPayment As New SqlDataAdapter("SELECT id, name FROM Payment_Method", conn)
        Dim dsPayment As New DataSet()
        daPayment.Fill(dsPayment, 0)

        Dim dvPayment As New DataView(dsPayment.Tables(0))

        With cmbPayment
            .DataSource = dvPayment
            .ValueMember = "id"
            .DisplayMember = "name"
        End With

        With cmbOrderType
            .Items.Add("delivery")
            .Items.Add("pickup")
            .SelectedIndex = 0
        End With

        total = 0
        LocFlag = True
    End Sub

    Private Sub SetupGrid()
        With grdOrderDetails
            .Columns.Clear()
            .ReadOnly = False
            .Columns.Add("MealName", "اسم الوجبة")
            .Columns.Add("Price", "السعر")
            .Columns.Add("Quantity", "الكمية")
            .Columns.Add("Subtotal", "السعر النهائي")
            .Columns.Add("Notes", "ملاحظات")
            .Columns.Add("MealID", "م")
            .Columns("Price").DefaultCellStyle.Format = "C2" ' Currency format
            .Columns("Subtotal").DefaultCellStyle.Format = "C2"
            .Columns("MealName").ReadOnly = True
            .Columns("MealID").ReadOnly = True
            .Columns("Price").ReadOnly = True
            .Columns("Subtotal").ReadOnly = True
            .AllowUserToAddRows = False
            .BackgroundColor = Color.White
            .RowTemplate.Height = 40
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("MealID").Visible = False

        End With
    End Sub

    ''''' Bar Buttons '''''
    Private Sub btnNew_Click() Handles btnNew.Click
        clearGrd()
        LoadNewOrder()
        btnNew.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        btnNew.Enabled = True
        SaveData()
        showRpt()
    End Sub

    Private Sub btnInfo_Click(sender As System.Object, e As System.EventArgs) Handles btnInfo.Click
        If Panel2.Visible Then
            Panel2.Visible = False
        Else
            Panel2.Visible = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As System.Object, e As System.EventArgs) Handles btnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    ''''' Categories and Items '''''
    Private Sub LoadCategories()

        Dim cmd As New SqlCommand("SELECT id, name FROM Meal_Category", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        flpCategories.Controls.Clear()

        While reader.Read()
            Dim btn As New Button
            With btn
                .Text = reader("name").ToString()
                .AutoSize = True
                .Width = 100
                .Height = 40
                .Tag = reader("name")
                .Font = New Font("Cairo", 11.25, FontStyle.Bold)
                .TextAlign = ContentAlignment.MiddleCenter
            End With

            AddHandler btn.Click, AddressOf CategoryButton_Click
            flpCategories.Controls.Add(btn)
        End While
        reader.Close()
        LoadMeals()

    End Sub

    Private Class MealItem
        Public Property MealID As Integer
        Public Property MealName As String
        Public Property CategoryName As String
        Public Property Price As Decimal
    End Class

    Private Sub LoadMeals()
        mealData.Clear()
        Dim cmd As New SqlCommand("SELECT MealID, MealName, CategoryName, is_active, price " &
                                 "FROM vw_Meal_Details_With_Category WHERE is_active = 1", conn)
        Dim reader As SqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            mealData.Add(New MealItem With {
                .MealID = Convert.ToDecimal(reader("MealID")),
                .MealName = reader("MealName").ToString(),
                .CategoryName = reader("CategoryName").ToString(),
                .Price = Convert.ToDecimal(reader("price"))
            })
        End While
        reader.Close()
    End Sub

    Private Sub CategoryButton_Click(sender As Object, e As EventArgs)
        Dim btn As Button = CType(sender, Button)
        Dim categoryName As String = btn.Tag.ToString()

        flpItems.Controls.Clear()

        ' Filter and display meals for the selected category
        Dim filteredMeals = mealData.Where(Function(m) m.CategoryName = categoryName).ToList()

        For Each meal In filteredMeals
            Dim itemBtn As New Button
            With itemBtn
                .Text = meal.MealName & vbCrLf & meal.Price.ToString()
                .AutoSize = True
                .Width = 100
                .Height = 70
                .Font = New Font("Cairo", 11.25)
                .TextAlign = ContentAlignment.MiddleCenter
                .Tag = meal
            End With

            'grdOrderDetails.Columns("MealID").Visible = False
            AddHandler itemBtn.Click, AddressOf ItemButton_Click
            flpItems.Controls.Add(itemBtn)
        Next
    End Sub

    Private Sub ItemButton_Click(sender As Object, e As EventArgs)
        Dim itemBtn As Button = CType(sender, Button)

        If itemBtn.Tag IsNot Nothing Then
            Dim selectedMeal As MealItem = CType(itemBtn.Tag, MealItem)
            Dim found As Boolean = False

            ' Check if meal already exists in the grid
            For Each row As DataGridViewRow In grdOrderDetails.Rows
                If Not row.IsNewRow Then
                    Dim mealNameCell = row.Cells("MealName").Value
                    If mealNameCell IsNot Nothing AndAlso mealNameCell.ToString() = selectedMeal.MealName Then
                        ' Increase quantity
                        Dim currentQty As Integer = 0
                        Dim cellValue As Object = row.Cells("Quantity").Value
                        If cellValue IsNot Nothing AndAlso Integer.TryParse(cellValue.ToString(), currentQty) Then
                            currentQty += 1
                            row.Cells("Quantity").Value = currentQty
                            ' Update subtotal
                            row.Cells("Subtotal").Value = selectedMeal.Price * currentQty
                            found = True
                        End If
                        Exit For
                    End If
                End If
            Next

            ' Add new row if not already in grid
            If Not found Then
                Dim qty As Integer = 1
                Dim subtotal As Decimal = selectedMeal.Price * qty
                grdOrderDetails.Rows.Add(selectedMeal.MealName, selectedMeal.Price, qty, subtotal, "", selectedMeal.MealID)
            End If
        End If
        UpdateTotalAmount()
    End Sub


    ''''' ONChange Functions '''''
    Private Sub grdOrderDetails_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles grdOrderDetails.CellValueChanged
        If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub

        Dim row = grdOrderDetails.Rows(e.RowIndex)

        If grdOrderDetails.Columns(e.ColumnIndex).Name = "Quantity" Then
            Dim qty As Integer
            Dim cellValue As Object = row.Cells("Quantity").Value

            If cellValue IsNot Nothing AndAlso Integer.TryParse(cellValue.ToString(), qty) Then
                If qty <= 0 Then
                    grdOrderDetails.Rows.RemoveAt(e.RowIndex)
                    btnDecrease.Enabled = False
                    Exit Sub
                ElseIf qty = 1 Then
                    btnDecrease.Enabled = False
                Else
                    btnDecrease.Enabled = True
                End If

                Dim price As Decimal = Convert.ToDecimal(row.Cells("Price").Value)
                row.Cells("Subtotal").Value = price * qty
            Else
                row.Cells("Subtotal").Value = 0
            End If
            UpdateTotalAmount()

        End If
    End Sub

    Private Sub cmbOrderType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbOrderType.SelectedIndexChanged
        If cmbOrderType.SelectedIndex = 1 Then
            txtDeliveryFee.Text = 0
            UpdateTotalAmount()
        End If
    End Sub

    ''''' Utilities Functionss '''''
    Private Sub UpdateTotalAmount()
        total = 0
        For Each row As DataGridViewRow In grdOrderDetails.Rows
            If row.Cells("Subtotal").Value IsNot Nothing Then
                total += Convert.ToDecimal(row.Cells("Subtotal").Value)
            End If
        Next
        If cmbOrderType.SelectedIndex = 0 Then
            total += Convert.ToDecimal(txtDeliveryFee.Text)
        End If
        txtOrderTotal.Text = total.ToString("C2")
        txtOrderTotal.Enabled = False
    End Sub

    Private Sub SaveData()
        Try
            Dim cmdHeader As New SqlCommand("INSERT INTO Order_Header (total_price, customer_id, order_type, notes, payment_id, staff_id) " &
                                     "VALUES ( @total, @customer, @type, @notes, @payment,  @staff)", conn)

            With cmdHeader.Parameters
                .AddWithValue("@staff", staffId)
                .AddWithValue("@type", cmbOrderType.Text)
                .AddWithValue("@total", total)
                .AddWithValue("@customer", cmbCustomerName.SelectedValue)
                .AddWithValue("@payment", cmbPayment.SelectedValue)
                .AddWithValue("@notes", txtNotes.Text)
            End With
            cmdHeader.ExecuteNonQuery()

            For Each row As DataGridViewRow In grdOrderDetails.Rows
                If Not row.IsNewRow Then
                    Dim cmdDetails As New SqlCommand(
                        "INSERT INTO Order_Detail (order_id, meal_id, price, quantity, notes) " &
                        "VALUES (@id, @meal, @price, @quantity, @notes)", conn)

                    cmdDetails.Parameters.AddWithValue("@id", txtOrderID.Text)
                    cmdDetails.Parameters.AddWithValue("@meal", Convert.ToInt32(row.Cells("MealID").Value))
                    cmdDetails.Parameters.AddWithValue("@price", Convert.ToDecimal(row.Cells("price").Value))
                    cmdDetails.Parameters.AddWithValue("@quantity", Convert.ToInt32(row.Cells("quantity").Value))
                    cmdDetails.Parameters.AddWithValue("@notes", row.Cells("notes").Value)
                    'Dim notesValue As Object = row.Cells("notes").Value
                    'If notesValue Is Nothing OrElse String.IsNullOrWhiteSpace(notesValue.ToString()) Then
                    '    cmdDetails.Parameters.AddWithValue("@notes", DBNull.Value)
                    'Else : cmdDetails.Parameters.AddWithValue("@notes", notesValue.ToString())
                    'End If

                    cmdDetails.ExecuteNonQuery()
                End If
            Next
            MessageBox.Show("Order saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnNew_Click()

        Catch ex As SqlException
            MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub clearGrd()
        grdOrderDetails.Rows.Clear()
    End Sub

    ''''' Grid Buttons '''''
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If grdOrderDetails.CurrentRow IsNot Nothing AndAlso Not grdOrderDetails.CurrentRow.IsNewRow Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                grdOrderDetails.Rows.Remove(grdOrderDetails.CurrentRow)
            End If
        Else
            MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub grdOrderDetails_RowsRemoved(sender As System.Object, e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles grdOrderDetails.RowsRemoved
        UpdateTotalAmount()
    End Sub

    Private Sub btnIncrease_Click(sender As Object, e As EventArgs) Handles btnIncrease.Click
        If grdOrderDetails.CurrentCell IsNot Nothing AndAlso
           Not grdOrderDetails.CurrentRow.IsNewRow Then

            Dim cell = grdOrderDetails.CurrentCell
            Dim value As Integer = 0
            Dim cellValue As Object = cell.Value

            ' Check if it's numeric and increase it
            If cellValue IsNot Nothing AndAlso Integer.TryParse(cellValue.ToString(), value) Then
                value += 1
                cell.Value = value

                ' Optional: auto-update subtotal if this is Quantity column
                If grdOrderDetails.Columns(cell.ColumnIndex).Name = "Quantity" Then
                    Dim price As Decimal = Convert.ToDecimal(grdOrderDetails.CurrentRow.Cells("Price").Value)
                    grdOrderDetails.CurrentRow.Cells("Subtotal").Value = price * value
                End If
            End If
        End If
    End Sub

    Private Sub btnDecrease_Click(sender As Object, e As EventArgs) Handles btnDecrease.Click
        If grdOrderDetails.CurrentCell IsNot Nothing AndAlso
           Not grdOrderDetails.CurrentRow.IsNewRow Then

            Dim cell = grdOrderDetails.CurrentCell
            Dim value As Integer = 0
            Dim cellValue As Object = cell.Value

            If cellValue IsNot Nothing AndAlso Integer.TryParse(cellValue.ToString(), value) Then
                value -= 1

                If grdOrderDetails.Columns(cell.ColumnIndex).Name = "Quantity" Then
                    cell.Value = value
                    Dim price As Decimal = Convert.ToDecimal(grdOrderDetails.CurrentRow.Cells("Price").Value)
                    grdOrderDetails.CurrentRow.Cells("Subtotal").Value = price * value

                    ' Disable if value hits 1 (next click would remove row)
                    btnDecrease.Enabled = (value > 1)

                Else
                    If value >= 0 Then
                        cell.Value = value
                    End If
                End If
            End If
        End If
    End Sub

    ''''' Report '''''
    Private Sub showRpt1()
        Try
            ds = New BillDataSet
            da = New SqlDataAdapter("select * from OrderBill", conn)
            da.Fill(ds, 0)
            dv = New DataView(ds.Tables(0))


            Dim cyr1 As New BillRpt
            cyr1.SetDataSource(dv)
            cyr1.SetParameterValue("pOrderID", txtOrderID.Text - 1)
            Dim viewerForm As New frmBillRptViewer()
            viewerForm.CrystalReportViewer1.ReportSource = cyr1
            viewerForm.Show()
        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        End Try
    End Sub

    Private Sub showRpt()
        Try
            ds = New DataSet
            cmd = New SqlCommand("SELECT * FROM vw_All_Order_Details WHERE OrderID = @OrderID", conn)
            cmd.Parameters.AddWithValue("@OrderID", txtOrderID.Text - 1)
            da = New SqlDataAdapter(cmd)
            da.Fill(ds, 0)
            dv = New DataView(ds.Tables(0))


            Dim cyr1 As New BillRpt
            cyr1.SetDataSource(dv)
            Dim viewerForm As New frmBillRptViewer()
            viewerForm.CrystalReportViewer1.ReportSource = cyr1
            viewerForm.Show()

        Catch ex As Exception
            MessageBox.Show("Error loading report: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRpt_Click(sender As System.Object, e As System.EventArgs) Handles btnRpt.Click
        showRpt()
    End Sub

    Private Sub cmbCustomerName_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cmbCustomerName.SelectedIndexChanged
        If LocFlag Then

            Dim query As String = "SELECT name, DeliveryFee from vw_customer_Location WHERE cid = @id"
            Dim cmd1 As New SqlCommand(query, conn)
            cmd1.Parameters.AddWithValue("@Id", cmbCustomerName.SelectedValue)

            Using reader As SqlDataReader = cmd1.ExecuteReader()
                If reader.Read() Then
                    txtLocName.Text = reader("name").ToString()
                    txtDeliveryFee.Text = Convert.ToDecimal(reader("DeliveryFee")).ToString("F2")
                    UpdateTotalAmount()
                Else
                    txtDeliveryFee.Text = "0.00"
                End If
            End Using
        End If
    End Sub

End Class