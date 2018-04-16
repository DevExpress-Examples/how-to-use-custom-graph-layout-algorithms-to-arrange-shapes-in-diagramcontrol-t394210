using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Routing;
using Microsoft.Msagl.Core.Routing;

namespace MsaglHelpers {
    public static class RoutingHelper {
        public static ConnectorType GetDiagramConnectorType(EdgeRoutingMode routingMode) {
            if(routingMode == EdgeRoutingMode.StraightLine) {
                return ConnectorType.Straight;
            }
            if(routingMode == EdgeRoutingMode.Spline || routingMode == EdgeRoutingMode.SplineBundling || routingMode == EdgeRoutingMode.SugiyamaSplines) {
                return ConnectorType.Curved;
            }
            return ConnectorType.RightAngle;
        }
    }
}