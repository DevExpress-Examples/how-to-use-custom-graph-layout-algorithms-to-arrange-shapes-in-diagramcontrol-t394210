Imports DevExpress.Skins
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace XtraDiagram.CustomLayoutAlgorithms
    Friend NotInheritable Class Program

        Private Sub New()
        End Sub

        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        <STAThread> _
        Shared Sub Main()
            SkinManager.EnableFormSkins()
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New CustomLayoutForm())
        End Sub
    End Class
End Namespace
