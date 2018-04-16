namespace XtraDiagram.CustomLayoutAlgorithms {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.showMDSLayout = new System.Windows.Forms.Button();
            this.showRankingLayout = new System.Windows.Forms.Button();
            this.showPhyloTreeLayout = new System.Windows.Forms.Button();
            this.showDisconnectedGraphsLayout = new System.Windows.Forms.Button();
            this.showSugiamaLayout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showMDSLayout
            // 
            this.showMDSLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showMDSLayout.Location = new System.Drawing.Point(39, 70);
            this.showMDSLayout.Name = "showMDSLayout";
            this.showMDSLayout.Size = new System.Drawing.Size(150, 23);
            this.showMDSLayout.TabIndex = 1;
            this.showMDSLayout.Text = "Show Ranking Layout";
            this.showMDSLayout.UseVisualStyleBackColor = true;
            this.showMDSLayout.Click += new System.EventHandler(this.ShowRankingLayout);
            // 
            // showRankingLayout
            // 
            this.showRankingLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showRankingLayout.Location = new System.Drawing.Point(39, 108);
            this.showRankingLayout.Name = "showRankingLayout";
            this.showRankingLayout.Size = new System.Drawing.Size(150, 23);
            this.showRankingLayout.TabIndex = 4;
            this.showRankingLayout.Text = "Show Phylo Tree";
            this.showRankingLayout.UseVisualStyleBackColor = true;
            this.showRankingLayout.Click += new System.EventHandler(this.ShowPhyloTree);
            // 
            // showPhyloTreeLayout
            // 
            this.showPhyloTreeLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showPhyloTreeLayout.Location = new System.Drawing.Point(39, 187);
            this.showPhyloTreeLayout.Name = "showPhyloTreeLayout";
            this.showPhyloTreeLayout.Size = new System.Drawing.Size(150, 23);
            this.showPhyloTreeLayout.TabIndex = 3;
            this.showPhyloTreeLayout.Text = "Show Disconnected Graphs";
            this.showPhyloTreeLayout.UseVisualStyleBackColor = true;
            this.showPhyloTreeLayout.Click += new System.EventHandler(this.ShowDisconnectedGraphs);
            // 
            // showDisconnectedGraphsLayout
            // 
            this.showDisconnectedGraphsLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showDisconnectedGraphsLayout.Location = new System.Drawing.Point(39, 149);
            this.showDisconnectedGraphsLayout.Name = "showDisconnectedGraphsLayout";
            this.showDisconnectedGraphsLayout.Size = new System.Drawing.Size(150, 23);
            this.showDisconnectedGraphsLayout.TabIndex = 2;
            this.showDisconnectedGraphsLayout.Text = "Show MDS Layout";
            this.showDisconnectedGraphsLayout.UseVisualStyleBackColor = true;
            this.showDisconnectedGraphsLayout.Click += new System.EventHandler(this.ShowMDSLayout);
            // 
            // showSugiamaLayout
            // 
            this.showSugiamaLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.showSugiamaLayout.BackColor = System.Drawing.SystemColors.Control;
            this.showSugiamaLayout.Location = new System.Drawing.Point(39, 31);
            this.showSugiamaLayout.Name = "showSugiamaLayout";
            this.showSugiamaLayout.Size = new System.Drawing.Size(150, 23);
            this.showSugiamaLayout.TabIndex = 0;
            this.showSugiamaLayout.Text = "Show Sugiyama Layout";
            this.showSugiamaLayout.UseVisualStyleBackColor = false;
            this.showSugiamaLayout.Click += new System.EventHandler(this.ShowSugiyamaLayout);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 286);
            this.Controls.Add(this.showMDSLayout);
            this.Controls.Add(this.showRankingLayout);
            this.Controls.Add(this.showPhyloTreeLayout);
            this.Controls.Add(this.showDisconnectedGraphsLayout);
            this.Controls.Add(this.showSugiamaLayout);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showSugiamaLayout;
        private System.Windows.Forms.Button showRankingLayout;
        private System.Windows.Forms.Button showMDSLayout;
        private System.Windows.Forms.Button showDisconnectedGraphsLayout;
        private System.Windows.Forms.Button showPhyloTreeLayout;
    }
}

