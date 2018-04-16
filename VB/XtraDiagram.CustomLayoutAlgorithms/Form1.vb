Imports MsaglHelpers
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace XtraDiagram.CustomLayoutAlgorithms
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub ShowSugiyamaLayout(ByVal sender As Object, ByVal e As EventArgs) Handles showSugiamaLayout.Click
            ShowCustomLayoutForm(New GraphLayout(New SugiyamaLayoutCalculator()), "Data/SugiyamaLayout.xml")
        End Sub
        Private Sub ShowRankingLayout(ByVal sender As Object, ByVal e As EventArgs) Handles showMDSLayout.Click
            ShowCustomLayoutForm(New GraphLayout(New RankingLayoutCalculator()), "Data/RankingLayout.xml")
        End Sub
        Private Sub ShowMDSLayout(ByVal sender As Object, ByVal e As EventArgs) Handles showDisconnectedGraphsLayout.Click
            ShowCustomLayoutForm(New GraphLayout(New MDSLayoutCalculator()), "Data/MDSLayout.xml")
        End Sub
        Private Sub ShowDisconnectedGraphs(ByVal sender As Object, ByVal e As EventArgs) Handles showPhyloTreeLayout.Click
            ShowCustomLayoutForm(New GraphLayout(New DisconnectedGraphsLayoutCaculator()), "Data/DisconnectedGraphs.xml")
        End Sub
        Private Sub ShowPhyloTree(ByVal sender As Object, ByVal e As EventArgs) Handles showRankingLayout.Click
            ShowCustomLayoutForm(New PhyloTreeLayout(New DisconnectedGraphsLayoutCaculator()), "Data/PhyloTree.xml")
        End Sub
        Private Sub ShowCustomLayoutForm(ByVal layout As GraphLayout, ByVal sourceGraphPath As String)
            Dim form As New CustomLayoutForm(layout, sourceGraphPath)
            form.ShowDialog()
        End Sub
    End Class
End Namespace
