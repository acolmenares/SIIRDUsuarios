Imports ingNovar.Utilidades2
Imports System.Collections.Generic
Imports System.Data

Partial Public Class ParametrosBrl

    Private _Id As Int32
    Private _Razon_Social As String
    Private _Direccion As String
    Private _Telefono_Principal As String
    Private _Url As String
    Private _Correo As String
    Private _Fax As String
    Private _Observacion_Adicional As String
    Private _Ts_Cargar_POP As Int32
    Private _Ts_Cargue_SOP As Int32
    Private _Ts_Generacion_OC As Int32
    Private _Ts_Registro_OC As Int32
    Private _Ts_Salida_Mercancia As Int32
    Private _Ts_Confirmacion_Cliente As Int32
    Private _Ts_Anular_OC As Int32
    Private _Ts_Finalizar_OC As Int32
    Private _Ts_Finalizar_OP As Int32
    Private _Ubicacion_GP As String
    Private _texto01 As String
    Private _texto02 As String
    Private _texto03 As String
    Private _texto04 As String

    Public Event Creating()
    Public Event Created()

    Public Sub New()
        RaiseEvent Creating()
        'Adicionar código al costructor aquí

        RaiseEvent Created()
    End Sub

    Public Event IDChanging(ByVal Value As Int32)
    Public Event IDChanged()

    Public Property ID() As Int32
        Get
            Return Me._Id
        End Get
        Set(ByVal Value As Int32)
            If _Id <> Value Then
                RaiseEvent IDChanging(Value)
                Me._Id = Value
                RaiseEvent IDChanged()
            End If
        End Set
    End Property

    Public Event Razon_SocialChanging(ByVal Value As String)
    Public Event Razon_SocialChanged()

    Public Property Razon_Social() As String
        Get
            Return Me._Razon_Social
        End Get
        Set(ByVal Value As String)
            If _Razon_Social <> Value Then
                RaiseEvent Razon_SocialChanging(Value)
                Me._Razon_Social = Value
                RaiseEvent Razon_SocialChanged()
            End If
        End Set
    End Property

    Public Event DireccionChanging(ByVal Value As String)
    Public Event DireccionChanged()

    Public Property Direccion() As String
        Get
            Return Me._Direccion
        End Get
        Set(ByVal Value As String)
            If _Direccion <> Value Then
                RaiseEvent DireccionChanging(Value)
                Me._Direccion = Value
                RaiseEvent DireccionChanged()
            End If
        End Set
    End Property

    Public Event Telefono_PrincipalChanging(ByVal Value As String)
    Public Event Telefono_PrincipalChanged()

    Public Property Telefono_Principal() As String
        Get
            Return Me._Telefono_Principal
        End Get
        Set(ByVal Value As String)
            If _Telefono_Principal <> Value Then
                RaiseEvent Telefono_PrincipalChanging(Value)
                Me._Telefono_Principal = Value
                RaiseEvent Telefono_PrincipalChanged()
            End If
        End Set
    End Property

    Public Event UrlChanging(ByVal Value As String)
    Public Event UrlChanged()

    Public Property Url() As String
        Get
            Return Me._Url
        End Get
        Set(ByVal Value As String)
            If _Url <> Value Then
                RaiseEvent UrlChanging(Value)
                Me._Url = Value
                RaiseEvent UrlChanged()
            End If
        End Set
    End Property

    Public Event CorreoChanging(ByVal Value As String)
    Public Event CorreoChanged()

    Public Property Correo() As String
        Get
            Return Me._Correo
        End Get
        Set(ByVal Value As String)
            If _Correo <> Value Then
                RaiseEvent CorreoChanging(Value)
                Me._Correo = Value
                RaiseEvent CorreoChanged()
            End If
        End Set
    End Property

    Public Event FaxChanging(ByVal Value As String)
    Public Event FaxChanged()

    Public Property Fax() As String
        Get
            Return Me._Fax
        End Get
        Set(ByVal Value As String)
            If _Fax <> Value Then
                RaiseEvent FaxChanging(Value)
                Me._Fax = Value
                RaiseEvent FaxChanged()
            End If
        End Set
    End Property

    Public Event Observacion_AdicionalChanging(ByVal Value As String)
    Public Event Observacion_AdicionalChanged()

    Public Property Observacion_Adicional() As String
        Get
            Return Me._Observacion_Adicional
        End Get
        Set(ByVal Value As String)
            If _Observacion_Adicional <> Value Then
                RaiseEvent Observacion_AdicionalChanging(Value)
                Me._Observacion_Adicional = Value
                RaiseEvent Observacion_AdicionalChanged()
            End If
        End Set
    End Property

    Public Event Ts_Cargar_POPChanging(ByVal Value As Int32)
    Public Event Ts_Cargar_POPChanged()

    Public Property Ts_Cargar_POP() As Int32
        Get
            Return Me._Ts_Cargar_POP
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Cargar_POP <> Value Then
                RaiseEvent Ts_Cargar_POPChanging(Value)
                Me._Ts_Cargar_POP = Value
                RaiseEvent Ts_Cargar_POPChanged()
            End If
        End Set
    End Property

    Public Event Ts_Cargue_SOPChanging(ByVal Value As Int32)
    Public Event Ts_Cargue_SOPChanged()

    Public Property Ts_Cargue_SOP() As Int32
        Get
            Return Me._Ts_Cargue_SOP
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Cargue_SOP <> Value Then
                RaiseEvent Ts_Cargue_SOPChanging(Value)
                Me._Ts_Cargue_SOP = Value
                RaiseEvent Ts_Cargue_SOPChanged()
            End If
        End Set
    End Property

    Public Event Ts_Generacion_OCChanging(ByVal Value As Int32)
    Public Event Ts_Generacion_OCChanged()

    Public Property Ts_Generacion_OC() As Int32
        Get
            Return Me._Ts_Generacion_OC
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Generacion_OC <> Value Then
                RaiseEvent Ts_Generacion_OCChanging(Value)
                Me._Ts_Generacion_OC = Value
                RaiseEvent Ts_Generacion_OCChanged()
            End If
        End Set
    End Property

    Public Event Ts_Registro_OCChanging(ByVal Value As Int32)
    Public Event Ts_Registro_OCChanged()

    Public Property Ts_Registro_OC() As Int32
        Get
            Return Me._Ts_Registro_OC
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Registro_OC <> Value Then
                RaiseEvent Ts_Registro_OCChanging(Value)
                Me._Ts_Registro_OC = Value
                RaiseEvent Ts_Registro_OCChanged()
            End If
        End Set
    End Property

    Public Event Ts_Salida_MercanciaChanging(ByVal Value As Int32)
    Public Event Ts_Salida_MercanciaChanged()

    Public Property Ts_Salida_Mercancia() As Int32
        Get
            Return Me._Ts_Salida_Mercancia
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Salida_Mercancia <> Value Then
                RaiseEvent Ts_Salida_MercanciaChanging(Value)
                Me._Ts_Salida_Mercancia = Value
                RaiseEvent Ts_Salida_MercanciaChanged()
            End If
        End Set
    End Property

    Public Event Ts_Confirmacion_ClienteChanging(ByVal Value As Int32)
    Public Event Ts_Confirmacion_ClienteChanged()

    Public Property Ts_Confirmacion_Cliente() As Int32
        Get
            Return Me._Ts_Confirmacion_Cliente
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Confirmacion_Cliente <> Value Then
                RaiseEvent Ts_Confirmacion_ClienteChanging(Value)
                Me._Ts_Confirmacion_Cliente = Value
                RaiseEvent Ts_Confirmacion_ClienteChanged()
            End If
        End Set
    End Property

    Public Event Ts_Anular_OCChanging(ByVal Value As Int32)
    Public Event Ts_Anular_OCChanged()

    Public Property Ts_Anular_OC() As Int32
        Get
            Return Me._Ts_Anular_OC
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Anular_OC <> Value Then
                RaiseEvent Ts_Anular_OCChanging(Value)
                Me._Ts_Anular_OC = Value
                RaiseEvent Ts_Anular_OCChanged()
            End If
        End Set
    End Property

    Public Event Ts_Finalizar_OCChanging(ByVal Value As Int32)
    Public Event Ts_Finalizar_OCChanged()

    Public Property Ts_Finalizar_OC() As Int32
        Get
            Return Me._Ts_Finalizar_OC
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Finalizar_OC <> Value Then
                RaiseEvent Ts_Finalizar_OCChanging(Value)
                Me._Ts_Finalizar_OC = Value
                RaiseEvent Ts_Finalizar_OCChanged()
            End If
        End Set
    End Property

    Public Event Ts_Finalizar_OPChanging(ByVal Value As Int32)
    Public Event Ts_Finalizar_OPChanged()

    Public Property Ts_Finalizar_OP() As Int32
        Get
            Return Me._Ts_Finalizar_OP
        End Get
        Set(ByVal Value As Int32)
            If _Ts_Finalizar_OP <> Value Then
                RaiseEvent Ts_Finalizar_OPChanging(Value)
                Me._Ts_Finalizar_OP = Value
                RaiseEvent Ts_Finalizar_OPChanged()
            End If
        End Set
    End Property

    Public Event Ubicacion_GPChanging(ByVal Value As String)
    Public Event Ubicacion_GPChanged()

    Public Property Ubicacion_GP() As String
        Get
            Return Me._Ubicacion_GP
        End Get
        Set(ByVal Value As String)
            If _Ubicacion_GP <> Value Then
                RaiseEvent Ubicacion_GPChanging(Value)
                Me._Ubicacion_GP = Value
                RaiseEvent Ubicacion_GPChanged()
            End If
        End Set
    End Property

    Public Event Texto01Changing(ByVal Value As String)
    Public Event Texto01Changed()

    Public Property Texto01() As String
        Get
            Return Me._texto01
        End Get
        Set(ByVal Value As String)
            If _texto01 <> Value Then
                RaiseEvent Texto01Changing(Value)
                Me._texto01 = Value
                RaiseEvent Texto01Changed()
            End If
        End Set
    End Property

    Public Event Texto02Changing(ByVal Value As String)
    Public Event Texto02Changed()

    Public Property Texto02() As String
        Get
            Return Me._texto02
        End Get
        Set(ByVal Value As String)
            If _texto02 <> Value Then
                RaiseEvent Texto02Changing(Value)
                Me._texto02 = Value
                RaiseEvent Texto02Changed()
            End If
        End Set
    End Property

    Public Event Texto03Changing(ByVal Value As String)
    Public Event Texto03Changed()

    Public Property Texto03() As String
        Get
            Return Me._texto03
        End Get
        Set(ByVal Value As String)
            If _texto03 <> Value Then
                RaiseEvent Texto03Changing(Value)
                Me._texto03 = Value
                RaiseEvent Texto03Changed()
            End If
        End Set
    End Property

    Public Event Texto04Changing(ByVal Value As String)
    Public Event Texto04Changed()

    Public Property Texto04() As String
        Get
            Return Me._texto04
        End Get
        Set(ByVal Value As String)
            If _texto04 <> Value Then
                RaiseEvent Texto04Changing(Value)
                Me._texto04 = Value
                RaiseEvent Texto04Changed()
            End If
        End Set
    End Property


    Public Event Saving()
    Public Event Saved()

    Public Event Inserting()
    Public Event Inserted()

    Public Event Updating()
    Public Event Updated()

    Public Event Deleting()
    Public Event Deleted()


    Private Shared Function asignarValoresALasPropiedades(ByVal fila As DataRow) As ParametrosBrl

        Dim objParametros As New ParametrosBrl

        With objParametros
            .ID = fila("Id")
            .Razon_Social = isDBNullToNothing(fila("Razon_Social"))
            .Direccion = isDBNullToNothing(fila("Direccion"))
            .Telefono_Principal = isDBNullToNothing(fila("Telefono_Principal"))
            .Url = isDBNullToNothing(fila("Url"))
            .Correo = isDBNullToNothing(fila("Correo"))
            .Fax = isDBNullToNothing(fila("Fax"))
            .Observacion_Adicional = isDBNullToNothing(fila("Observacion_Adicional"))
            .Ts_Cargar_POP = isDBNullToNothing(fila("Ts_Cargar_POP"))
            .Ts_Cargue_SOP = isDBNullToNothing(fila("Ts_Cargue_SOP"))
            .Ts_Generacion_OC = isDBNullToNothing(fila("Ts_Generacion_OC"))
            .Ts_Registro_OC = isDBNullToNothing(fila("Ts_Registro_OC"))
            .Ts_Salida_Mercancia = isDBNullToNothing(fila("Ts_Salida_Mercancia"))
            .Ts_Confirmacion_Cliente = isDBNullToNothing(fila("Ts_Confirmacion_Cliente"))
            .Ts_Anular_OC = isDBNullToNothing(fila("Ts_Anular_OC"))
            .Ts_Finalizar_OC = isDBNullToNothing(fila("Ts_Finalizar_OC"))
            .Ts_Finalizar_OP = isDBNullToNothing(fila("Ts_Finalizar_OP"))
            .Ubicacion_GP = isDBNullToNothing(fila("Ubicacion_GP"))
            .Texto01 = isDBNullToNothing(fila("Texto01"))
            .Texto02 = isDBNullToNothing(fila("Texto02"))
            .Texto03 = isDBNullToNothing(fila("Texto03"))
            .Texto04 = isDBNullToNothing(fila("Texto04"))
        End With

        Return objParametros

    End Function

    Public Shared Event LoadingParametrosList(ByVal LoadType As String)
    Public Shared Event LoadedParametrosList(ByVal target As List(Of ParametrosBrl), ByVal LoadType As String)

    Public Shared Function CargarTodos() As List(Of ParametrosBrl)

        Dim dsDatos As System.Data.DataSet
        Dim lista As New List(Of ParametrosBrl)

        RaiseEvent LoadingParametrosList("CargarTodos")

        dsDatos = ParametrosDAL.CargarTodos()

        For Each fila As DataRow In dsDatos.Tables(0).Rows
            lista.Add(asignarValoresALasPropiedades(fila))
        Next

        RaiseEvent LoadedParametrosList(lista, "CargarTodos")

        Return lista

    End Function

    Public Shared Event LoadingPorId(ByVal id As Int32)
    Public Shared Event LoadedPorId(ByVal target As ParametrosBrl)

    Public Shared Function CargarPorID(ByVal ID As Int32) As ParametrosBrl

        Dim dsDatos As System.Data.DataSet
        Dim objParametros As ParametrosBrl = Nothing
        dsDatos = ParametrosDAL.CargarPorID(ID)
        If dsDatos.Tables(0).Rows.Count <> 0 Then objParametros = asignarValoresALasPropiedades(dsDatos.Tables(0).Rows(0))
        Return objParametros

    End Function

 

End Class


