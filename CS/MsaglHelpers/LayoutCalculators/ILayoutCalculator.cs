using Microsoft.Msagl.Core.Layout;
using Microsoft.Msagl.Core.Routing;

namespace MsaglHelpers {
    public interface ILayoutCalculator {
        LayoutAlgorithmSettings LayoutAlgorithmSettings { get; }
        void CalculateLayout(GeometryGraph geometryGraph);
    }
}
