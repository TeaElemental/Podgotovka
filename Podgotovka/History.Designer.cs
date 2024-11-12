namespace Podgotovka
{
    partial class History
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
            historyDV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)historyDV).BeginInit();
            SuspendLayout();
            // 
            // historyDV
            // 
            historyDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            historyDV.Location = new Point(1, 1);
            historyDV.Name = "historyDV";
            historyDV.Size = new Size(797, 437);
            historyDV.TabIndex = 0;
            historyDV.CellContentClick += historyDV_CellContentClick;
            // 
            // History
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(historyDV);
            Name = "History";
            Text = "History";
            Load += History_Load;
            ((System.ComponentModel.ISupportInitialize)historyDV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView historyDV;
    }
}