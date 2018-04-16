
using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Layout;
using DevExpress.XtraDiagram.Utils;
using DevExpress.XtraEditors;
using MsaglHelpers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace XtraDiagram.CustomLayoutAlgorithms {
    public partial class CustomLayoutForm : XtraForm {
        public CustomLayoutForm() {
            InitializeComponent();
        }
        void LoadSugiyama(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            diagramControl.LoadDocument("Data/SugiyamaLayout.xml");
        }

        void ApplySugiyama(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ApplyLayout(new GraphLayout(new SugiyamaLayoutCalculator()));
        }
        void LoadDisconnectedGraphs(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            diagramControl.LoadDocument("Data/DisconnectedGraphs.xml");
        }

        void ApplyDisconnectedGraphs(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ApplyLayout(new GraphLayout(new DisconnectedGraphsLayoutCalculator()));
        }

        void LoadPhyloTree(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            diagramControl.LoadDocument("Data/PhyloTree.xml");
        }

        void ApplyPhyloTree(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ApplyLayout(new PhyloTreeLayout(new PhyloTreeLayoutCalculator()));
        }
        void LoadRanking(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            diagramControl.LoadDocument("Data/RankingLayout.xml");
        }

        void ApplyRanking(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ApplyLayout(new GraphLayout(new RankingLayoutCalculator()));
        }
        void LoadMDS(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            diagramControl.LoadDocument("Data/MDSLayout.xml");
        }

        void ApplyMDS(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            ApplyLayout(new GraphLayout(new MDSLayoutCalculator()));
        }

        void ApplyLayout(GraphLayout layout) {
            try {
                diagramControl.RelayoutDiagramItems(layout.RelayoutGraphNodesPosition(GraphOperations.GetDiagramGraph(diagramControl)));

                foreach(var connector in diagramControl.Items.OfType<IDiagramConnector>()) {
                    connector.Type = layout.GetDiagramConnectorType();
                    connector.UpdateRoute();
                };
                diagramControl.FitToDrawing();
            } catch(Exception e) {
                XtraMessageBox.Show(string.Format("Error message: '{0}'", e.Message), "Error has been occurred");
            }
        }

    }
}
