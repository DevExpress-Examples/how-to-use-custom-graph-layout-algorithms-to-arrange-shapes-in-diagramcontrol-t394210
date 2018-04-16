Imports Microsoft.Msagl
Imports Microsoft.Msagl.Core.Geometry.Curves
Imports Microsoft.Msagl.Layout.Layered
Imports Microsoft.Msagl.Miscellaneous
Imports System
Imports Microsoft.Msagl.Core.Layout
Imports Microsoft.Msagl.Core.Routing

Namespace MsaglHelpers
    Public Class SugiyamaLayoutCalculator
        Implements ILayoutCalculator

        Public ReadOnly Property LayoutAlgorithmSettings() As LayoutAlgorithmSettings Implements ILayoutCalculator.LayoutAlgorithmSettings
            Get
                Return New SugiyamaLayoutSettings() With {
                    .NodeSeparation = 30, .Transformation = PlaneTransformation.Rotation(Math.PI / 2), .EdgeRoutingSettings = New EdgeRoutingSettings() With {.EdgeRoutingMode = EdgeRoutingMode.SugiyamaSplines}
                }
            End Get
        End Property
        Public Sub CalculateLayout(ByVal geometryGraph As GeometryGraph) Implements ILayoutCalculator.CalculateLayout
            LayoutHelpers.CalculateLayout(geometryGraph, LayoutAlgorithmSettings, Nothing)
        End Sub
    End Class
End Namespace
