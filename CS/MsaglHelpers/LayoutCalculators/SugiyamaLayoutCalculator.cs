using Microsoft.Msagl;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Layout.Layered;
using Microsoft.Msagl.Miscellaneous;
using System;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;

namespace MsaglHelpers {
    public class SugiyamaLayoutCalculator : ILayoutCalculator {
        public LayoutAlgorithmSettings LayoutAlgorithmSettings {
            get {
                return new SugiyamaLayoutSettings() {
                    NodeSeparation = 30,
                    Transformation = PlaneTransformation.Rotation(Math.PI / 2),
                    EdgeRoutingSettings = { EdgeRoutingMode = EdgeRoutingMode.SugiyamaSplines }
                };
            }
        }
        public void CalculateLayout(GeometryGraph geometryGraph) {
            LayoutHelpers.CalculateLayout( geometryGraph, LayoutAlgorithmSettings, null);
        }
    }
}
