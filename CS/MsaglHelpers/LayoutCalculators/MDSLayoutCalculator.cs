using Microsoft.Msagl.Layout.MDS;
using Microsoft.Msagl.Miscellaneous;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Core.Layout;

namespace MsaglHelpers {
    public class MDSLayoutCalculator : ILayoutCalculator {
        public LayoutAlgorithmSettings LayoutAlgorithmSettings {
            get {
                return new MdsLayoutSettings() {
                    EdgeRoutingSettings = {
                        EdgeRoutingMode = EdgeRoutingMode.StraightLine
                    }
                };
            }
        }
        public void CalculateLayout(GeometryGraph geometryGraph) {
            LayoutHelpers.CalculateLayout(geometryGraph, LayoutAlgorithmSettings, null);
        }
    }
}
