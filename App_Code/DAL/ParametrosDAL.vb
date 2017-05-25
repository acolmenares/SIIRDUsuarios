Imports Microsoft.ApplicationBlocks.Data
Imports ingNovar.Utilidades2

Public Class ParametrosDAL

    Public Shared Function CargarTodos() As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ParametrosConsultarTodos")
    End Function

    Public Shared Function CargarPorID(ByVal Id As Int32) As System.Data.DataSet
        Return SqlHelper.ExecuteDataset(strCadenaConexion, "dbo.ParametrosConsultarPorID", Id)
    End Function


End Class

