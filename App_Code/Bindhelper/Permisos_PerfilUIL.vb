Imports System.Collections.Generic

Namespace BindHelper
    
    Partial Public NotInheritable Class Permisos_PerfilUIL
        
        Private Shared Sub Bind(ByVal control As ListControl, ByVal Lista As List(Of Permisos_PerfilBRL), Optional ByVal firstItem As ListItem = Nothing)
            control.DataSource = Lista
            control.DataValueField = "ID"
            control.DataTextField = "ID"
            control.DataBind
            If Not firstItem Is Nothing  Then
                control.Items.Insert(0, firstItem)
            End If
        End Sub
        
        Public Shared Function BindToListControl(ByVal control As ListControl, Optional ByVal firstItem As ListItem = Nothing) As List(Of Permisos_PerfilBRL)
            Dim Lista As List(Of Permisos_PerfilBRL)
            Lista = Permisos_PerfilBRL.CargarTodos()
            Bind(control, Lista, firstItem)
            Return Lista
        End Function
        
        	Public Shared Function BindToListControlPorId_Pagina(ByVal control As ListControl, ByVal Id_Pagina As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Permisos_PerfilBRL)
            Dim Lista As List(Of Permisos_PerfilBRL)
            Lista = Permisos_PerfilBRL.CargarPorId_Pagina(Id_Pagina)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    


	Public Shared Function BindToListControlPorId_Perfil(ByVal control As ListControl, ByVal Id_Perfil As Int32, Optional ByVal firstItem As ListItem = Nothing) As List(Of Permisos_PerfilBRL)
            Dim Lista As List(Of Permisos_PerfilBRL)
            Lista = Permisos_PerfilBRL.CargarPorId_Perfil(Id_Perfil)
            Bind(control, Lista, firstItem)
            Return Lista
    End Function
    




        
    End Class
    
End Namespace


