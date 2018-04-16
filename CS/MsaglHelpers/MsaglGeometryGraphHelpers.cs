using System.Linq;
using DevExpress.Diagram.Core;
using System.Collections.Generic;
using DevExpress.Diagram.Core.Layout;
using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Prototype.Phylo;
using Microsoft.Msagl.Core.Geometry.Curves;
using Microsoft.Msagl.Core.Geometry;

namespace MsaglHelpers {
    public static class MsaglGeometryGraphHelpers {
        public static IEnumerable<PositionInfo<IDiagramItem>> GetGetNodesPositionInfo(GeometryGraph geometryGraph) {
            return geometryGraph.Nodes.Select(node => new PositionInfo<IDiagramItem>((IDiagramItem)node.UserData, Converter.MsaglPointToPointConvert(node.BoundingBox.LeftTop)));
        }
        public static PhyloTree CreatePhyloTrees(Graph<IDiagramItem> graph) {
            PhyloTree phyloTree = new PhyloTree();
            foreach(var node in graph.Nodes) {
                AddNode(phyloTree, node);
            }
            foreach(var edge in graph.Edges) {
                AddPhyloTreeEdge(phyloTree, edge.From, edge.To, edge.Weight);
            }
            return phyloTree;
        }
        public static GeometryGraph CreateGeometryGraph(Graph<IDiagramItem> graph) {
            GeometryGraph geomGraph = new GeometryGraph();
            foreach(var node in graph.Nodes) {
                AddNode(geomGraph, node);
            }
            foreach(var edge in graph.Edges) {
                AddEdge(geomGraph, edge.From, edge.To, edge.Weight);
            }
            return geomGraph;
        }
        public static Node AddNode(GeometryGraph geometryGraph, IDiagramItem item) {
            Node msaglNode = geometryGraph.FindNodeByUserData(item);
            if(msaglNode == null) {
                msaglNode = new Node(CreateCurve(item), item);
                geometryGraph.Nodes.Add(msaglNode);
            }
            return msaglNode;
        }
        public static void AddEdge(GeometryGraph geometryGraph, IDiagramItem parentNodeSource, IDiagramItem childNodeSource, double weight) {
            geometryGraph.Edges.Add(new Edge(AddNode(geometryGraph, parentNodeSource), AddNode(geometryGraph, childNodeSource)) { Weight = (int)weight });
        }
        public static void AddPhyloTreeEdge(PhyloTree phyloTree, IDiagramItem parentNodeSource, IDiagramItem childNodeSource, double weight = 1) {
            phyloTree.Edges.Add(new PhyloEdge(AddNode(phyloTree, parentNodeSource), AddNode(phyloTree, childNodeSource)) { Weight = (int)weight });
        }
        public static ICurve CreateCurve(IDiagramItem item) {
            return CurveFactory.CreateRectangle(item.ActualSize.Width, item.ActualSize.Height, new Point());
        }
    }
}
