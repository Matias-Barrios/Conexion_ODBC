Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar(CONNECTION_STRING())
        dgvGrupos.DataSource = Hacer_consulta("SELECT * FROM Grupos")
        dgvDocentes.DataSource = Hacer_consulta("SELECT * FROM Personas WHERE tipo='Profesor'")
    End Sub

    Private Sub cerrar_ventana(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.Closing
        If MessageBox.Show("Seguro que quiere salir?", "Cerrar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Cerrar()
            Console.WriteLine("Cerrado!")
        Else
            e.Cancel = True
        End If
    End Sub

End Class
