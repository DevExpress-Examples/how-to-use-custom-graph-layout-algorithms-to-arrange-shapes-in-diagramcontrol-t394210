using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Layout.Layered;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Routing;
using System;
namespace MsaglHelpers {
    public class DisconnectedGraphsLayoutCalculator : ILayoutCalculator {
        public LayoutAlgorithmSettings LayoutAlgorithmSettings {
            get {
                return new SugiyamaLayoutSettings() {
                    Transformation = PlaneTransformation.Rotation(Math.PI),
                    EdgeRoutingSettings = {
                        EdgeRoutingMode =  EdgeRoutingMode.StraightLine,
                    }
                };
            }
        }
        public void CalculateLayout(GeometryGraph geometryGraph) {
            var geomGraphComponents = GraphConnectedComponents.CreateComponents(geometryGraph.Nodes, geometryGraph.Edges);
            var settings = LayoutAlgorithmSettings as SugiyamaLayoutSettings;
            foreach(var components in geomGraphComponents) {
                var layout = new LayeredLayout(components, settings);
                components.Margins = 100;
                layout.Run();
            }
            Microsoft.Msagl.Layout.MDS.MdsGraphLayout.PackGraphs(geomGraphComponents, settings);

            geometryGraph.UpdateBoundingBox();
        }
    }
}
