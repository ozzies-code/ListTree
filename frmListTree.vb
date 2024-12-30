Public Class frmListTree
    Private Sub lstMiListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMiListView.SelectedIndexChanged

    End Sub

    Private Sub frmListTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lstMiListView.Items.Add("Miguel Cano")
        'lstMiListView.Items.Add("Manuel Soto", 0)

        Dim objElementoLista As ListViewItem
        objElementoLista = lstMiListView.Items.Add("Miguel Huertas", 2)
        objElementoLista.SubItems.Add("Valencia")


    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If lstMiListView.SelectedItems.Count > 0 Then
            MessageBox.Show(lstMiListView.SelectedItems(0).Text)
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        lstMiListView.Items.Remove(lstMiListView.SelectedItems(0))
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lstMiListView.Items.Clear()
    End Sub

    Private Sub btnAgregarNodo_Click(sender As Object, e As EventArgs) Handles btnAgregarNodo.Click
        tvwLenguajes.Nodes.Add("Jaime")
        tvwLenguajes.Nodes.Add("Visual Basic")
    End Sub

    Private Sub btnNodoHijo_Click(sender As Object, e As EventArgs) Handles btnNodoHijo.Click

        Dim objNodo As TreeNode
        objNodo = tvwLenguajes.Nodes.Add("Jaime")
        objNodo.Nodes.Add("Visual Basic")
    End Sub

    Private Sub btnEliminarNodo_Click(sender As Object, e As EventArgs) Handles btnEliminarNodo.Click
        tvwLenguajes.Nodes.Remove(tvwLenguajes.SelectedNode)

        'If Not (tvwLenguajes.SelectedNode Is Nothing) Then
        'tvwLenguajes.Nodes.Remove(tvwLenguajes.SelectedNode)
        'End If
    End Sub

    Private Sub BtnEliminarNodos_Click(sender As Object, e As EventArgs) Handles BtnEliminarNodos.Click
        tvwLenguajes.Nodes.Clear()
    End Sub
End Class