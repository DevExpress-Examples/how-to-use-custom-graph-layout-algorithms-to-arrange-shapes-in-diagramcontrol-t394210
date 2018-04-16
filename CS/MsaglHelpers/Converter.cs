using MsaglPoint = Microsoft.Msagl.Core.Geometry.Point;
using System.Windows;

namespace MsaglHelpers {
    public static class Converter {
        public static Point MsaglPointToPointConvert(this MsaglPoint msaglPoint) {
            return new Point(msaglPoint.X, msaglPoint.Y);
        }
    }
}