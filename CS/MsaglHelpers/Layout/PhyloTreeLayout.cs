using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Layout;
using DevExpress.Diagram.Core.Routing;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;
using Microsoft.Msagl.Prototype.Phylo;
using System.Collections.Generic;

namespace MsaglHelpers {
    public class PhyloTreeLayout : GraphLayout {
        PhyloTree Tree { get; set; }

        public PhyloTreeLayout(ILayoutCalculator layoutCalculator) : base(layoutCalculator) { }
        public override IEnumerable<PositionInfo<IDiagramItem>> RelayoutGraphNodesPosition(Graph<IDiagramItem> graph) {
            Tree = MsaglGeometryGraphHelpers.CreatePhyloTrees(graph);
            LayoutCalculator.CalculateLayout(Tree);
            return MsaglGeometryGraphHelpers.GetGetNodesPositionInfo(Tree);
        }
    }
}