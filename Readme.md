# How to use custom graph layout algorithms to arrange shapes in DiagramControl


DiagramControl provides two methods that make it easier to use external graph layout algorithms to arrange diagram shapes. The <strong><em>GraphOperations.GetDiagramGraph</em></strong> method reads the diagram currently loaded into DiagramControl and returns the <strong><em>Graph </em></strong>object that contains collections of edges and nodes represented by diagram items. You can use this information to calculate positions for diagram shapes. Then, for every shape, create the <strong><em>PositionInfo</em> </strong>object containing the shape reference and its position. To apply the layout to the loaded diagram, call the <em><strong>DiagramControl.RelayoutDiagramItems</strong></em> method that accepts the collection of PositionInfo objects.<br><br>This example demonstrates how the GetDiagramGraph and RelayoutDiagramItems methods can be used to connect the <a href="https://github.com/Microsoft/automatic-graph-layout">Microsoft Automatic Graph Layout (MSAGL)</a> library to DiagramControl.

<br/>


