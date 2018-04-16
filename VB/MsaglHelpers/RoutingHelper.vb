Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Routing
Imports Microsoft.Msagl.Core.Routing

Namespace MsaglHelpers
    Public NotInheritable Class RoutingHelper

        Private Sub New()
        End Sub

        Public Shared Function GetDiagramConnectorType(ByVal routingMode As EdgeRoutingMode) As ConnectorType
            If routingMode = EdgeRoutingMode.StraightLine Then
                Return ConnectorType.Straight
            End If
            If routingMode = EdgeRoutingMode.Spline OrElse routingMode = EdgeRoutingMode.SplineBundling OrElse routingMode = EdgeRoutingMode.SugiyamaSplines Then
                Return ConnectorType.Curved
            End If
            Return ConnectorType.RightAngle
        End Function
    End Class
End Namespace