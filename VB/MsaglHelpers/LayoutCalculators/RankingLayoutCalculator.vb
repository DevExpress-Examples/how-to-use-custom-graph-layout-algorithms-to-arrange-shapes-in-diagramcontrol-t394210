Imports Microsoft.Msagl.Core.Layout
Imports Microsoft.Msagl.Core.Routing
Imports Microsoft.Msagl.Miscellaneous
Imports Microsoft.Msagl.Prototype.Ranking

Namespace MsaglHelpers
    Public Class RankingLayoutCalculator
        Implements ILayoutCalculator

        Public ReadOnly Property LayoutAlgorithmSettings() As LayoutAlgorithmSettings Implements ILayoutCalculator.LayoutAlgorithmSettings
            Get
                Return New RankingLayoutSettings() With {
                    .NodeSeparation = 30, .EdgeRoutingSettings = New EdgeRoutingSettings() With {.EdgeRoutingMode = EdgeRoutingMode.Rectilinear}
                }
            End Get
        End Property
        Public Sub CalculateLayout(ByVal geometryGraph As GeometryGraph) Implements ILayoutCalculator.CalculateLayout
            Dim geomGraphComponents = GraphConnectedComponents.CreateComponents(geometryGraph.Nodes, geometryGraph.Edges)
            Dim settings = TryCast(LayoutAlgorithmSettings, RankingLayoutSettings)
            For Each components In geomGraphComponents
                Dim layout = New RankingLayout(settings, components)
                components.Margins = 30
                layout.Run()
            Next components
            Microsoft.Msagl.Layout.MDS.MdsGraphLayout.PackGraphs(geomGraphComponents, settings)
            geometryGraph.UpdateBoundingBox()
        End Sub
    End Class
End Namespace
