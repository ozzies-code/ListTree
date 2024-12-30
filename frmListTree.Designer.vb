<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListTree
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmListTree))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Jaime Torres", "Toledo"}, 0, System.Drawing.Color.White, System.Drawing.Color.IndianRed, New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Rosario Gomez", "Madrid"}, 0, System.Drawing.Color.White, System.Drawing.Color.IndianRed, New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte)))
        Me.imgMisImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.lstMiListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.tvwLenguajes = New System.Windows.Forms.TreeView()
        Me.btnAgregarNodo = New System.Windows.Forms.Button()
        Me.btnNodoHijo = New System.Windows.Forms.Button()
        Me.btnEliminarNodo = New System.Windows.Forms.Button()
        Me.BtnEliminarNodos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'imgMisImagenes
        '
        Me.imgMisImagenes.ImageStream = CType(resources.GetObject("imgMisImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMisImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imgMisImagenes.Images.SetKeyName(0, "searh.png")
        '
        'lstMiListView
        '
        Me.lstMiListView.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lstMiListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lstMiListView.Font = New System.Drawing.Font("Calibri", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMiListView.ForeColor = System.Drawing.Color.Black
        Me.lstMiListView.FullRowSelect = True
        Me.lstMiListView.HideSelection = False
        Me.lstMiListView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2})
        Me.lstMiListView.Location = New System.Drawing.Point(8, 8)
        Me.lstMiListView.Name = "lstMiListView"
        Me.lstMiListView.Size = New System.Drawing.Size(402, 97)
        Me.lstMiListView.SmallImageList = Me.imgMisImagenes
        Me.lstMiListView.TabIndex = 0
        Me.lstMiListView.UseCompatibleStateImageBehavior = False
        Me.lstMiListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nombres"
        Me.ColumnHeader1.Width = 142
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Ciudad"
        Me.ColumnHeader2.Width = 120
        '
        'btnMostrar
        '
        Me.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnMostrar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMostrar.ForeColor = System.Drawing.Color.Yellow
        Me.btnMostrar.Location = New System.Drawing.Point(8, 111)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(119, 29)
        Me.btnMostrar.TabIndex = 1
        Me.btnMostrar.Text = "&Mostrar Lista"
        Me.btnMostrar.UseVisualStyleBackColor = False
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnQuitar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.Yellow
        Me.btnQuitar.Location = New System.Drawing.Point(133, 112)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(152, 29)
        Me.btnQuitar.TabIndex = 2
        Me.btnQuitar.Text = "&Eliminar Elemento"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnLimpiar.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.Yellow
        Me.btnLimpiar.Location = New System.Drawing.Point(291, 112)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(119, 29)
        Me.btnLimpiar.TabIndex = 3
        Me.btnLimpiar.Text = "&Limpiar Lista"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'tvwLenguajes
        '
        Me.tvwLenguajes.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tvwLenguajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvwLenguajes.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvwLenguajes.ImageIndex = 0
        Me.tvwLenguajes.ImageList = Me.imgMisImagenes
        Me.tvwLenguajes.Location = New System.Drawing.Point(8, 162)
        Me.tvwLenguajes.Name = "tvwLenguajes"
        Me.tvwLenguajes.SelectedImageIndex = 0
        Me.tvwLenguajes.Size = New System.Drawing.Size(402, 97)
        Me.tvwLenguajes.TabIndex = 4
        '
        'btnAgregarNodo
        '
        Me.btnAgregarNodo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnAgregarNodo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarNodo.ForeColor = System.Drawing.Color.Yellow
        Me.btnAgregarNodo.Location = New System.Drawing.Point(8, 265)
        Me.btnAgregarNodo.Name = "btnAgregarNodo"
        Me.btnAgregarNodo.Size = New System.Drawing.Size(83, 68)
        Me.btnAgregarNodo.TabIndex = 5
        Me.btnAgregarNodo.Text = "&Agregar Nodo"
        Me.btnAgregarNodo.UseVisualStyleBackColor = False
        '
        'btnNodoHijo
        '
        Me.btnNodoHijo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnNodoHijo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNodoHijo.ForeColor = System.Drawing.Color.Yellow
        Me.btnNodoHijo.Location = New System.Drawing.Point(115, 265)
        Me.btnNodoHijo.Name = "btnNodoHijo"
        Me.btnNodoHijo.Size = New System.Drawing.Size(83, 68)
        Me.btnNodoHijo.TabIndex = 6
        Me.btnNodoHijo.Text = "&Agregar Hijo"
        Me.btnNodoHijo.UseVisualStyleBackColor = False
        '
        'btnEliminarNodo
        '
        Me.btnEliminarNodo.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnEliminarNodo.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarNodo.ForeColor = System.Drawing.Color.Yellow
        Me.btnEliminarNodo.Location = New System.Drawing.Point(221, 265)
        Me.btnEliminarNodo.Name = "btnEliminarNodo"
        Me.btnEliminarNodo.Size = New System.Drawing.Size(83, 68)
        Me.btnEliminarNodo.TabIndex = 7
        Me.btnEliminarNodo.Text = "&Eliminar Nodo"
        Me.btnEliminarNodo.UseVisualStyleBackColor = False
        '
        'BtnEliminarNodos
        '
        Me.BtnEliminarNodos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnEliminarNodos.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarNodos.ForeColor = System.Drawing.Color.Yellow
        Me.BtnEliminarNodos.Location = New System.Drawing.Point(327, 265)
        Me.BtnEliminarNodos.Name = "BtnEliminarNodos"
        Me.BtnEliminarNodos.Size = New System.Drawing.Size(83, 68)
        Me.BtnEliminarNodos.TabIndex = 8
        Me.BtnEliminarNodos.Text = "&Quitar Nodos"
        Me.BtnEliminarNodos.UseVisualStyleBackColor = False
        '
        'frmListTree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(426, 345)
        Me.Controls.Add(Me.BtnEliminarNodos)
        Me.Controls.Add(Me.btnEliminarNodo)
        Me.Controls.Add(Me.btnNodoHijo)
        Me.Controls.Add(Me.btnAgregarNodo)
        Me.Controls.Add(Me.tvwLenguajes)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.lstMiListView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmListTree"
        Me.Text = "Listas y Arboles"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents imgMisImagenes As ImageList
    Friend WithEvents lstMiListView As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents btnMostrar As Button
    Friend WithEvents btnQuitar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents tvwLenguajes As TreeView
    Friend WithEvents btnAgregarNodo As Button
    Friend WithEvents btnNodoHijo As Button
    Friend WithEvents btnEliminarNodo As Button
    Friend WithEvents BtnEliminarNodos As Button
End Class
