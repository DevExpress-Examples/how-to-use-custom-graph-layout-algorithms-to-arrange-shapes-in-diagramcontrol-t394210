Imports Microsoft.Msagl.Core.Layout
Imports Microsoft.Msagl.Core.Routing

Namespace MsaglHelpers
    Public Interface ILayoutCalculator
        ReadOnly Property LayoutAlgorithmSettings() As LayoutAlgorithmSettings
        Sub CalculateLayout(ByVal geometryGraph As GeometryGraph)
    End Interface
End Namespace
