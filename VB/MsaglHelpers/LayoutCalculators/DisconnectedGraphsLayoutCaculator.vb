Imports Microsoft.Msagl.Core.Layout
Imports Microsoft.Msagl.Layout.Layered
Imports Microsoft.Msagl.Core.Geometry.Curves
Imports Microsoft.Msagl.Core.Routing
Imports System
Namespace MsaglHelpers
    Public Class DisconnectedGraphsLayoutCalculator
        Implements ILayoutCalculator

        Public ReadOnly Property LayoutAlgorithmSettings() As LayoutAlgorithmSettings Implements ILayoutCalculator.LayoutAlgorithmSettings
            Get
                Return New SugiyamaLayoutSettings() With {
                    .Transformation = PlaneTransformation.Rotation(Math.PI), .EdgeRoutingSettings = New EdgeRoutingSettings() With {.EdgeRoutingMode = EdgeRoutingMode.StraightLine}
                }
            End Get
        End Property
        Public Sub CalculateLayout(ByVal geometryGraph As GeometryGraph) Implements ILayoutCalculator.CalculateLayout
            Dim geomGraphComponents = GraphConnectedComponents.CreateComponents(geometryGraph.Nodes, geometryGraph.Edges)
            Dim settings = TryCast(LayoutAlgorithmSettings, SugiyamaLayoutSettings)
            For Each components In geomGraphComponents
                Dim layout = New LayeredLayout(components, settings)
                components.Margins = 100
                layout.Run()
            Next components
            Microsoft.Msagl.Layout.MDS.MdsGraphLayout.PackGraphs(geomGraphComponents, settings)

            geometryGraph.UpdateBoundingBox()
        End Sub
    End Class
End Namespace
