<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128585457/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T394210)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [GraphLayout.cs](./CS/MsaglHelpers/Layout/GraphLayout.cs) (VB: [GraphLayout.vb](./VB/MsaglHelpers/Layout/GraphLayout.vb))
* [PhyloTreeLayout.cs](./CS/MsaglHelpers/Layout/PhyloTreeLayout.cs) (VB: [PhyloTreeLayout.vb](./VB/MsaglHelpers/Layout/PhyloTreeLayout.vb))
* [SugiyamaLayoutCalculator.cs](./CS/MsaglHelpers/LayoutCalculators/SugiyamaLayoutCalculator.cs) (VB: [SugiyamaLayoutCalculator.vb](./VB/MsaglHelpers/LayoutCalculators/SugiyamaLayoutCalculator.vb))
* [CustomLayoutForm.cs](./CS/XtraDiagram.CustomLayoutAlgorithms/CustomLayoutForm.cs) (VB: [CustomLayoutForm.vb](./VB/XtraDiagram.CustomLayoutAlgorithms/CustomLayoutForm.vb))
<!-- default file list end -->
# How to use custom graph layout algorithms to arrange shapes in DiagramControl


DiagramControl provides two methods that make it easier to use external graph layout algorithms to arrange diagram shapes. The <strong><em>GraphOperations.GetDiagramGraph</em></strong> method reads the diagram currently loaded into DiagramControl and returns the <strong><em>Graph </em></strong>object that contains collections of edges and nodes represented by diagram items. You can use this information to calculate positions for diagram shapes. Then, for every shape, create the <strong><em>PositionInfo</em> </strong>object containing the shape reference and its position. To apply the layout to the loaded diagram, call the <em><strong>DiagramControl.RelayoutDiagramItems</strong></em> method that accepts the collection of PositionInfo objects.<br><br>This example demonstrates how the GetDiagramGraph and RelayoutDiagramItems methods can be used to connect the <a href="https://github.com/Microsoft/automatic-graph-layout">Microsoft Automatic Graph Layout (MSAGL)</a> library to DiagramControl.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-custom-graph-layout-algorithms-to-arrange-shapes-in-diagramcontrol-t394210&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-use-custom-graph-layout-algorithms-to-arrange-shapes-in-diagramcontrol-t394210&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
