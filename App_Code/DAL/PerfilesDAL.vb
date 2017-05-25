Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class PerfilesDAL

    Public Shared Function Insertar(ByVal Descripcion As String, ByVal administrador As Boolean) As Int32
        Return SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.PerfilesInsertar", isNothingToDBNull(Descripcion), isNothingToDBNull(administrador))
    End Function

    Public Shared Sub Actualizar(ByVal Id As Int32, ByVal Descripcion As String, ByVal administrador As Boolean)
        SqlHelper.ExecuteNonQuery(strCadenaConexion, "dbo.PerfilesActualizar", Id, isNothingToDBNull(Descripcion), administrador)
    End Sub

    Public Shared Sub Eliminar(ByVal Id As Int32)
        SqlHelper.ExecuteScalar(strCadenaConexion, "dbo.PerfilesEliminar", Id)
    End Sub

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PerfilesConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.PerfilesConsultarPorID", Id)
    End Function
    

End Class

