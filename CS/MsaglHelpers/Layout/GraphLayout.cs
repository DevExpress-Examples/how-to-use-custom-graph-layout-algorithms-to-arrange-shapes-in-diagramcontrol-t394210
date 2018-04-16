using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Layout;
using DevExpress.Diagram.Core.Routing;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using System.Collections.Generic;

namespace MsaglHelpers {
    public class GraphLayout {
        GeometryGraph GeometryGraph { get; set; }
        EdgeRoutingMode RoutingMode { get { return LayoutCalculator.LayoutAlgorithmSettings.EdgeRoutingSettings.EdgeRoutingMode; } }
        protected ILayoutCalculator LayoutCalculator { get; set; }

        public GraphLayout(ILayoutCalculator layoutCalculator) {
            this.LayoutCalculator = layoutCalculator;
        }
        public virtual IEnumerable<PositionInfo<IDiagramItem>> RelayoutGraphNodesPosition(Graph<IDiagramItem> graph) {
            GeometryGraph = MsaglGeometryGraphHelpers.CreateGeometryGraph(graph);
            LayoutCalculator.CalculateLayout(GeometryGraph);
            return MsaglGeometryGraphHelpers.GetGetNodesPositionInfo(GeometryGraph);
        }
        public ConnectorType GetDiagramConnectorType() {
            return RoutingHelper.GetDiagramConnectorType(RoutingMode);
        }
    }
}