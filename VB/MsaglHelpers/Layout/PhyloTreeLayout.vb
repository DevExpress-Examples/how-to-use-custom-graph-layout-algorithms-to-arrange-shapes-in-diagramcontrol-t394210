Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Layout
Imports DevExpress.Diagram.Core.Routing
Imports Microsoft.Msagl.Core.Layout
Imports Microsoft.Msagl.Core.Routing
Imports Microsoft.Msagl.Prototype.Phylo
Imports System.Collections.Generic

Namespace MsaglHelpers
    Public Class PhyloTreeLayout
        Inherits GraphLayout

        Private Property Tree() As PhyloTree

        Public Sub New(ByVal layoutCalculator As ILayoutCalculator)
            MyBase.New(layoutCalculator)
        End Sub
        Public Overrides Function RelayoutGraphNodesPosition(ByVal graph As Graph(Of IDiagramItem)) As IEnumerable(Of PositionInfo(Of IDiagramItem))
            Tree = MsaglGeometryGraphHelpers.CreatePhyloTrees(graph)
            LayoutCalculator.CalculateLayout(Tree)
            Return MsaglGeometryGraphHelpers.GetGetNodesPositionInfo(Tree)
        End Function
    End Class
End Namespace