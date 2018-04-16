Namespace XtraDiagram.CustomLayoutAlgorithms
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.showMDSLayout_Renamed = New System.Windows.Forms.Button()
            Me.showRankingLayout_Renamed = New System.Windows.Forms.Button()
            Me.showPhyloTreeLayout = New System.Windows.Forms.Button()
            Me.showDisconnectedGraphsLayout = New System.Windows.Forms.Button()
            Me.showSugiamaLayout = New System.Windows.Forms.Button()
            Me.SuspendLayout()
            ' 
            ' showMDSLayout
            ' 
            Me.showMDSLayout_Renamed.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.showMDSLayout_Renamed.Location = New System.Drawing.Point(39, 70)
            Me.showMDSLayout_Renamed.Name = "showMDSLayout"
            Me.showMDSLayout_Renamed.Size = New System.Drawing.Size(150, 23)
            Me.showMDSLayout_Renamed.TabIndex = 1
            Me.showMDSLayout_Renamed.Text = "Show Ranking Layout"
            Me.showMDSLayout_Renamed.UseVisualStyleBackColor = True
            ' 
            ' showRankingLayout
            ' 
            Me.showRankingLayout_Renamed.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.showRankingLayout_Renamed.Location = New System.Drawing.Point(39, 108)
            Me.showRankingLayout_Renamed.Name = "showRankingLayout"
            Me.showRankingLayout_Renamed.Size = New System.Drawing.Size(150, 23)
            Me.showRankingLayout_Renamed.TabIndex = 4
            Me.showRankingLayout_Renamed.Text = "Show Phylo Tree"
            Me.showRankingLayout_Renamed.UseVisualStyleBackColor = True
            ' 
            ' showPhyloTreeLayout
            ' 
            Me.showPhyloTreeLayout.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.showPhyloTreeLayout.Location = New System.Drawing.Point(39, 187)
            Me.showPhyloTreeLayout.Name = "showPhyloTreeLayout"
            Me.showPhyloTreeLayout.Size = New System.Drawing.Size(150, 23)
            Me.showPhyloTreeLayout.TabIndex = 3
            Me.showPhyloTreeLayout.Text = "Show Disconnected Graphs"
            Me.showPhyloTreeLayout.UseVisualStyleBackColor = True
            ' 
            ' showDisconnectedGraphsLayout
            ' 
            Me.showDisconnectedGraphsLayout.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.showDisconnectedGraphsLayout.Location = New System.Drawing.Point(39, 149)
            Me.showDisconnectedGraphsLayout.Name = "showDisconnectedGraphsLayout"
            Me.showDisconnectedGraphsLayout.Size = New System.Drawing.Size(150, 23)
            Me.showDisconnectedGraphsLayout.TabIndex = 2
            Me.showDisconnectedGraphsLayout.Text = "Show MDS Layout"
            Me.showDisconnectedGraphsLayout.UseVisualStyleBackColor = True
            ' 
            ' showSugiamaLayout
            ' 
            Me.showSugiamaLayout.Anchor = (CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.showSugiamaLayout.BackColor = System.Drawing.SystemColors.Control
            Me.showSugiamaLayout.Location = New System.Drawing.Point(39, 31)
            Me.showSugiamaLayout.Name = "showSugiamaLayout"
            Me.showSugiamaLayout.Size = New System.Drawing.Size(150, 23)
            Me.showSugiamaLayout.TabIndex = 0
            Me.showSugiamaLayout.Text = "Show Sugiyama Layout"
            Me.showSugiamaLayout.UseVisualStyleBackColor = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(224, 286)
            Me.Controls.Add(Me.showMDSLayout_Renamed)
            Me.Controls.Add(Me.showRankingLayout_Renamed)
            Me.Controls.Add(Me.showPhyloTreeLayout)
            Me.Controls.Add(Me.showDisconnectedGraphsLayout)
            Me.Controls.Add(Me.showSugiamaLayout)
            Me.Name = "Form1"
            Me.Text = "Form1"
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private WithEvents showSugiamaLayout As System.Windows.Forms.Button

        Private WithEvents showRankingLayout_Renamed As System.Windows.Forms.Button

        Private WithEvents showMDSLayout_Renamed As System.Windows.Forms.Button
        Private WithEvents showDisconnectedGraphsLayout As System.Windows.Forms.Button
        Private WithEvents showPhyloTreeLayout As System.Windows.Forms.Button
    End Class
End Namespace

