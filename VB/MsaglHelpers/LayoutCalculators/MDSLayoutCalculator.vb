Imports Microsoft.Msagl.Layout.MDS
Imports Microsoft.Msagl.Miscellaneous
Imports Microsoft.Msagl.Core.Routing
Imports Microsoft.Msagl.Core.Layout

Namespace MsaglHelpers
    Public Class MDSLayoutCalculator
        Implements ILayoutCalculator

        Public ReadOnly Property LayoutAlgorithmSettings() As LayoutAlgorithmSettings Implements ILayoutCalculator.LayoutAlgorithmSettings
            Get
                Return New MdsLayoutSettings() With {
                    .EdgeRoutingSettings = New EdgeRoutingSettings() With {.EdgeRoutingMode = EdgeRoutingMode.StraightLine}
                }
            End Get
        End Property
        Public Sub CalculateLayout(ByVal geometryGraph As GeometryGraph) Implements ILayoutCalculator.CalculateLayout
            LayoutHelpers.CalculateLayout(geometryGraph, LayoutAlgorithmSettings, Nothing)
        End Sub
    End Class
End Namespace
