using MsaglHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XtraDiagram.CustomLayoutAlgorithms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        void ShowSugiyamaLayout(object sender, EventArgs e) {
            ShowCustomLayoutForm(new GraphLayout(new SugiyamaLayoutCalculator()), "Data/SugiyamaLayout.xml");
        }
        void ShowRankingLayout(object sender, EventArgs e) {
            ShowCustomLayoutForm(new GraphLayout(new RankingLayoutCalculator()), "Data/RankingLayout.xml");
        }
        void ShowMDSLayout(object sender, EventArgs e) {
            ShowCustomLayoutForm(new GraphLayout(new MDSLayoutCalculator()), "Data/MDSLayout.xml");
        }
        void ShowDisconnectedGraphs(object sender, EventArgs e) {
            ShowCustomLayoutForm(new GraphLayout(new DisconnectedGraphsLayoutCaculator()), "Data/DisconnectedGraphs.xml");
        }
        void ShowPhyloTree(object sender, EventArgs e) {
            ShowCustomLayoutForm(new PhyloTreeLayout(new DisconnectedGraphsLayoutCaculator()), "Data/PhyloTree.xml");
        }
        void ShowCustomLayoutForm(GraphLayout layout, string sourceGraphPath) {
            CustomLayoutForm form = new CustomLayoutForm(layout, sourceGraphPath);
            form.ShowDialog();
        }
    }
}
