Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Permisos_UsuarioUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Permisos_UsuarioBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "ID"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Permisos_UsuarioBRL)
            Dim Lista As List(Of Permisos_UsuarioBRL)
            Lista = Permisos_UsuarioBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Pagina(ByVal control As ListControl, ByVal Id_Pagina As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Permisos_UsuarioBRL)
            Dim Lista As List(Of Permisos_UsuarioBRL)
            Lista = Permisos_UsuarioBRL.CargarPorId_Pagina(Id_Pagina)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Usuario(ByVal control As ListControl, ByVal Id_Usuario As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Permisos_UsuarioBRL)
            Dim Lista As List(Of Permisos_UsuarioBRL)
            Lista = Permisos_UsuarioBRL.CargarPorId_Usuario(Id_Usuario)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    




        
    End Class
    
End Namespace


