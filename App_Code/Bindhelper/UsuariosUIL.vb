Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class UsuariosUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of UsuariosBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "Nombre_Completo"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of UsuariosBRL)
            Dim Lista As List(Of UsuariosBRL)
            Lista = UsuariosBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Perfil(ByVal control As ListControl, ByVal Id_Perfil As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of UsuariosBRL)
            Dim Lista As List(Of UsuariosBRL)
            Lista = UsuariosBRL.CargarPorId_Perfil(Id_Perfil)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    




        
    End Class
    
End Namespace


