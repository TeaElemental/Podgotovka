namespace Podgotovka
{
    partial class Partners
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            partnersPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // partnersPanel
            // 
            partnersPanel.FlowDirection = FlowDirection.TopDown;
            partnersPanel.Location = new Point(6, 3);
            partnersPanel.Name = "partnersPanel";
            partnersPanel.Size = new Size(776, 426);
            partnersPanel.TabIndex = 0;
            // 
            // Partners
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 441);
            Controls.Add(partnersPanel);
            Name = "Partners";
            Text = "Partners";
            Load += Partners_Load;
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel partnersPanel;
    }
}