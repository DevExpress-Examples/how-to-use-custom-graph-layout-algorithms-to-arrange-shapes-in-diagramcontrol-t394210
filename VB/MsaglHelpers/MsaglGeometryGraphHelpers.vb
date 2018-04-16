Imports System.Linq
Imports DevExpress.Diagram.Core
Imports System.Collections.Generic
Imports DevExpress.Diagram.Core.Layout
Imports Microsoft.Msagl.Core.Layout
Imports Microsoft.Msagl.Prototype.Phylo
Imports Microsoft.Msagl.Core.Geometry.Curves
Imports Microsoft.Msagl.Core.Geometry

Namespace MsaglHelpers
    Public NotInheritable Class MsaglGeometryGraphHelpers

        Private Sub New()
        End Sub

        Public Shared Function GetGetNodesPositionInfo(ByVal geometryGraph As GeometryGraph) As IEnumerable(Of PositionInfo(Of IDiagramItem))
            Return geometryGraph.Nodes.Select(Function(node) New PositionInfo(Of IDiagramItem)(DirectCast(node.UserData, IDiagramItem), Converter.MsaglPointToPointConvert(node.BoundingBox.LeftTop)))
        End Function
        Public Shared Function CreatePhyloTrees(ByVal graph As Graph(Of IDiagramItem)) As PhyloTree
            Dim phyloTree As New PhyloTree()
            For Each node In graph.Nodes
                AddNode(phyloTree, node)
            Next node
            For Each edge In graph.Edges
                AddPhyloTreeEdge(phyloTree, edge.From, edge.To, edge.Weight)
            Next edge
            Return phyloTree
        End Function
        Public Shared Function CreateGeometryGraph(ByVal graph As Graph(Of IDiagramItem)) As GeometryGraph
            Dim geomGraph As New GeometryGraph()
            For Each node In graph.Nodes
                AddNode(geomGraph, node)
            Next node
            For Each edge In graph.Edges
                AddEdge(geomGraph, edge.From, edge.To, edge.Weight)
            Next edge
            Return geomGraph
        End Function
        Public Shared Function AddNode(ByVal geometryGraph As GeometryGraph, ByVal item As IDiagramItem) As Node
            Dim msaglNode As Node = geometryGraph.FindNodeByUserData(item)
            If msaglNode Is Nothing Then
                msaglNode = New Node(CreateCurve(item), item)
                geometryGraph.Nodes.Add(msaglNode)
            End If
            Return msaglNode
        End Function
        Public Shared Sub AddEdge(ByVal geometryGraph As GeometryGraph, ByVal parentNodeSource As IDiagramItem, ByVal childNodeSource As IDiagramItem, ByVal weight As Double)
            geometryGraph.Edges.Add(New Edge(AddNode(geometryGraph, parentNodeSource), AddNode(geometryGraph, childNodeSource)) With {.Weight = CInt((weight))})
        End Sub
        Public Shared Sub AddPhyloTreeEdge(ByVal phyloTree As PhyloTree, ByVal parentNodeSource As IDiagramItem, ByVal childNodeSource As IDiagramItem, Optional ByVal weight As Double = 1)
            phyloTree.Edges.Add(New PhyloEdge(AddNode(phyloTree, parentNodeSource), AddNode(phyloTree, childNodeSource)) With {.Weight = CInt((weight))})
        End Sub
        Public Shared Function CreateCurve(ByVal item As IDiagramItem) As ICurve
            Return CurveFactory.CreateRectangle(item.ActualSize.Width, item.ActualSize.Height, New Point())
        End Function
    End Class
End Namespace
