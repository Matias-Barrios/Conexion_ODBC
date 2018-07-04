Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conectar(CONNECTION_STRING())
        dgv_personalizado.Cargar_datos(Hacer_consulta("Select * FROM Personas"))

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
