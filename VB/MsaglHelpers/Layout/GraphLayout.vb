Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Layout
Imports DevExpress.Diagram.Core.Routing
Imports Microsoft.Msagl.Core.Layout
Imports Microsoft.Msagl.Core.Routing
Imports System.Collections.Generic

Namespace MsaglHelpers
    Public Class GraphLayout
        Private Property GeometryGraph() As GeometryGraph
        Private ReadOnly Property RoutingMode() As EdgeRoutingMode
            Get
                Return LayoutCalculator.LayoutAlgorithmSettings.EdgeRoutingSettings.EdgeRoutingMode
            End Get
        End Property
        Protected Property LayoutCalculator() As ILayoutCalculator

        Public Sub New(ByVal layoutCalculator As ILayoutCalculator)
            Me.LayoutCalculator = layoutCalculator
        End Sub
        Public Overridable Function RelayoutGraphNodesPosition(ByVal graph As Graph(Of IDiagramItem)) As IEnumerable(Of PositionInfo(Of IDiagramItem))
            GeometryGraph = MsaglGeometryGraphHelpers.CreateGeometryGraph(graph)
            LayoutCalculator.CalculateLayout(GeometryGraph)
            Return MsaglGeometryGraphHelpers.GetGetNodesPositionInfo(GeometryGraph)
        End Function
        Public Function GetDiagramConnectorType() As ConnectorType
            Return RoutingHelper.GetDiagramConnectorType(RoutingMode)
        End Function
    End Class
End Namespace