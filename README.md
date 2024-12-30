# ListTree

 Este proyecto se basa en el uso de listas y arboles para mostrar diferentes elementos y nodos
 de manera jerarquica y de forma indexada, lo que permite manejarlos a traves de diferentes 
 metodos como agregar, mostrar, elminar o limpiar toda la lista y el arbol de nodos.

 # Actualizacion: 30/12/2024
 # Hora: 13:33

 Se agrego una actualizacion en la rama master para contar con la 
 version actualizada del proyecto.

Detalles Tecnicos del Proyecto:
Lenguaje: Visual Basic.NET
Version del Framawork: 4.7.2

This project is based on the use of lists and trees to display different elements and nodes
in a hierarchical and indexed manner, which allows them to be handled through different
methods such as adding, showing, deleting or clearing the entire list and node tree.

# Update: 12/30/2024
# Time: 1:33 PM

An update was added to the master branch to have the updated
version of the project.

Technical Details of the Project:
Language: Visual Basic.NET
Framework Version: 4.7.2

![imagen](https://github.com/user-attachments/assets/e2c904d8-b20e-4c81-a49f-4fe13a7578bb)

Code of the Project:

    Public Class frmListTree

    Private Sub frmListTree_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'lstMiListView.Items.Add("Miguel Cano")
        'lstMiListView.Items.Add("Manuel Soto", 0)
        'Se agregan elementos de la lista al cargarse el programa
        Dim objElementoLista As ListViewItem
        objElementoLista = lstMiListView.Items.Add("Miguel Huertas", 2)
        objElementoLista.SubItems.Add("Valencia")


    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        If lstMiListView.SelectedItems.Count > 0 Then
            MessageBox.Show(lstMiListView.SelectedItems(0).Text)
            'Muestra los elementos seleccionados de la lista
        End If
    End Sub

    Private Sub btnQuitar_Click(sender As Object, e As EventArgs) Handles btnQuitar.Click
        lstMiListView.Items.Remove(lstMiListView.SelectedItems(0))
        'Elimina elementos de la lista
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        lstMiListView.Items.Clear()
        'limpia la lista
    End Sub

    Private Sub btnAgregarNodo_Click(sender As Object, e As EventArgs) Handles btnAgregarNodo.Click
        tvwLenguajes.Nodes.Add("Jaime")
        tvwLenguajes.Nodes.Add("Visual Basic")
        'Agrega un nodo Padre
    End Sub

    Private Sub btnNodoHijo_Click(sender As Object, e As EventArgs) Handles btnNodoHijo.Click

        Dim objNodo As TreeNode
        objNodo = tvwLenguajes.Nodes.Add("Jaime")
        objNodo.Nodes.Add("Visual Basic")
        'Agrega un nodo hijo
    End Sub

    Private Sub btnEliminarNodo_Click(sender As Object, e As EventArgs) Handles btnEliminarNodo.Click
        tvwLenguajes.Nodes.Remove(tvwLenguajes.SelectedNode)

        'Elimina el nodo seleccionado

        'If Not (tvwLenguajes.SelectedNode Is Nothing) Then
        'tvwLenguajes.Nodes.Remove(tvwLenguajes.SelectedNode)
        'End If
    End Sub

    Private Sub BtnEliminarNodos_Click(sender As Object, e As EventArgs) Handles BtnEliminarNodos.Click
        tvwLenguajes.Nodes.Clear()
        'limpia todos los nodos
    End Sub
End Class
End Class

