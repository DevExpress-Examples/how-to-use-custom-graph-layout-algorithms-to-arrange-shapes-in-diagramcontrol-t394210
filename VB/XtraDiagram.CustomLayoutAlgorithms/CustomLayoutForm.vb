Imports DevExpress.Diagram.Core
Imports DevExpress.Diagram.Core.Layout
Imports DevExpress.XtraDiagram.Utils
Imports DevExpress.XtraEditors
Imports MsaglHelpers
Imports System
Imports System.Linq
Imports System.Windows.Forms

Namespace XtraDiagram.CustomLayoutAlgorithms
    Partial Public Class CustomLayoutForm
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub LoadSugiyama(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem9.ItemClick
            diagramControl.LoadDocument("Data/SugiyamaLayout.xml")
        End Sub

        Private Sub ApplySugiyama(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem10.ItemClick
            ApplyLayout(New GraphLayout(New SugiyamaLayoutCalculator()))
        End Sub
        Private Sub LoadDisconnectedGraphs(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
            diagramControl.LoadDocument("Data/DisconnectedGraphs.xml")
        End Sub

        Private Sub ApplyDisconnectedGraphs(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
            ApplyLayout(New GraphLayout(New DisconnectedGraphsLayoutCalculator()))
        End Sub

        Private Sub LoadPhyloTree(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem3.ItemClick
            diagramControl.LoadDocument("Data/PhyloTree.xml")
        End Sub

        Private Sub ApplyPhyloTree(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem4.ItemClick
            ApplyLayout(New PhyloTreeLayout(New PhyloTreeLayoutCalculator()))
        End Sub
        Private Sub LoadRanking(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem5.ItemClick
            diagramControl.LoadDocument("Data/RankingLayout.xml")
        End Sub

        Private Sub ApplyRanking(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem6.ItemClick
            ApplyLayout(New GraphLayout(New RankingLayoutCalculator()))
        End Sub
        Private Sub LoadMDS(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem7.ItemClick
            diagramControl.LoadDocument("Data/MDSLayout.xml")
        End Sub

        Private Sub ApplyMDS(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem8.ItemClick
            ApplyLayout(New GraphLayout(New MDSLayoutCalculator()))
        End Sub

        Private Sub ApplyLayout(ByVal layout As GraphLayout)
            Try
                diagramControl.RelayoutDiagramItems(layout.RelayoutGraphNodesPosition(GraphOperations.GetDiagramGraph(diagramControl)))

                For Each connector In diagramControl.Items.OfType(Of IDiagramConnector)()
                    connector.Type = layout.GetDiagramConnectorType()
                    connector.UpdateRoute()
                Next connector
                diagramControl.FitToDrawing()
            Catch e As Exception
                XtraMessageBox.Show(String.Format("Error message: '{0}'", e.Message), "Error has been occurred")
            End Try
        End Sub

    End Class
End Namespace
