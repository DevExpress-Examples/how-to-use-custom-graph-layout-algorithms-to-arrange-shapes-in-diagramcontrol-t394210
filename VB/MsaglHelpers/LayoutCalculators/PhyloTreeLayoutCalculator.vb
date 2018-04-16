Imports Microsoft.Msagl.Core.Layout
Imports Microsoft.Msagl.Layout.Layered
Imports Microsoft.Msagl.Core.Geometry.Curves
Imports Microsoft.Msagl.Core.Routing
Imports System
Imports Microsoft.Msagl.Prototype.Phylo

Namespace MsaglHelpers
    Public Class PhyloTreeLayoutCalculator
        Implements ILayoutCalculator

        Public ReadOnly Property LayoutAlgorithmSettings() As LayoutAlgorithmSettings Implements ILayoutCalculator.LayoutAlgorithmSettings
            Get
                Return New SugiyamaLayoutSettings() With {
                    .Transformation = PlaneTransformation.Rotation(Math.PI), .EdgeRoutingSettings = New EdgeRoutingSettings() With {.EdgeRoutingMode = EdgeRoutingMode.StraightLine}
                }
            End Get
        End Property
        Public Sub CalculateLayout(ByVal phyloTree As GeometryGraph) Implements ILayoutCalculator.CalculateLayout
            Microsoft.Msagl.Miscellaneous.LayoutHelpers.CalculateLayout(phyloTree, LayoutAlgorithmSettings, Nothing)
        End Sub
    End Class
End Namespace
