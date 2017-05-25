Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class PaginasDAL

    Public Shared Function Insertar(ByVal Descripcion As String, ByVal Url As String) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.PaginasInsertar", isNothingToDBNull(Descripcion), isNothingToDBNull(Url))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Descripcion As String, ByVal Url As String)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.PaginasActualizar", Id, isNothingToDBNull(Descripcion), isNothingToDBNull(Url))
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.PaginasEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PaginasConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PaginasConsultarPorID", Id)
    End Function
    

End Class

