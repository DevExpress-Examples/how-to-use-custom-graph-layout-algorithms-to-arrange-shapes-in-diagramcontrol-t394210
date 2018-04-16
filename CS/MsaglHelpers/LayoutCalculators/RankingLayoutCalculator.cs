
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Miscellaneous;
using Microsoft.Msagl.Prototype.Ranking;

namespace MsaglHelpers {
    public class RankingLayoutCalculator : ILayoutCalculator {
        public LayoutAlgorithmSettings LayoutAlgorithmSettings {
            get {
                return new RankingLayoutSettings() {
                    NodeSeparation = 30,
                    EdgeRoutingSettings = { EdgeRoutingMode = EdgeRoutingMode.Rectilinear }
                };
            }
        }
        public void CalculateLayout(GeometryGraph geometryGraph) {
            var geomGraphComponents = GraphConnectedComponents.CreateComponents(geometryGraph.Nodes, geometryGraph.Edges);
            var settings = LayoutAlgorithmSettings as RankingLayoutSettings;
            foreach(var components in geomGraphComponents) {
                var layout = new RankingLayout(settings, components);
                components.Margins = 30;
                layout.Run();
            }
            Microsoft.Msagl.Layout.MDS.MdsGraphLayout.PackGraphs(geomGraphComponents, settings);
            geometryGraph.UpdateBoundingBox();
        }
    }
}
