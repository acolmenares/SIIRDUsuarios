Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class SucursalesDAL

    Public Shared Function Insertar(ByVal Descripcion As String, ByVal Id_Enlace As Int32) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.SucursalesInsertar", isNothingToDBNull(Descripcion), isNothingToDBNull(Id_Enlace))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Descripcion As String, ByVal Id_Enlace As Int32)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.SucursalesActualizar", Id, isNothingToDBNull(Descripcion), isNothingToDBNull(Id_Enlace))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.SucursalesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SucursalesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.SucursalesConsultarPorID", Id)
    End Function

End Class

