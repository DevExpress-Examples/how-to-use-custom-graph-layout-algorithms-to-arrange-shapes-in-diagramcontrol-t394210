using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Layout.Layered;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Routing;
using System;
using Microsoft.Msagl.Prototype.Phylo;

namespace MsaglHelpers {
    public class PhyloTreeLayoutCalculator : ILayoutCalculator {
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
        public void CalculateLayout(GeometryGraph phyloTree) {
            Microsoft.Msagl.Miscellaneous.LayoutHelpers.CalculateLayout(phyloTree, LayoutAlgorithmSettings, null);
        }
    }
}
