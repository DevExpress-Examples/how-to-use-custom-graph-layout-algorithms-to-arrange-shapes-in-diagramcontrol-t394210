Imports MsaglPoint = Microsoft.Msagl.Core.Geometry.Point
Imports System.Windows

Namespace MsaglHelpers
    Public Module Converter
        <System.Runtime.CompilerServices.Extension> _
        Public Function MsaglPointToPointConvert(ByVal msaglPoint As MsaglPoint) As Point
            Return New Point(msaglPoint.X, msaglPoint.Y)
        End Function
    End Module
End Namespace