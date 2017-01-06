namespace Applications.Applications.Accounting.AccountReceivables
{
    partial class CreateReceivableDocs
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
            this.panel1.SuspendLayout();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_GetDoc
            // 
            this.button_GetDoc.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            // 
            // button_ResetCommand
            // 
            this.button_ResetCommand.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ResetCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetCommand.Size = new System.Drawing.Size(102, 46);
            this.button_ResetCommand.UseVisualStyleBackColor = false;
            // 
            // button_ResetLabels
            // 
            this.button_ResetLabels.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_ResetLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetLabels.ForeColor = System.Drawing.Color.Black;
            this.button_ResetLabels.Size = new System.Drawing.Size(96, 46);
            this.button_ResetLabels.UseVisualStyleBackColor = false;
            // 
            // button_Transaction
            // 
            this.button_Transaction.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Transaction.Enabled = true;
            this.button_Transaction.Text = "Create Receivable Doc";
            this.button_Transaction.UseVisualStyleBackColor = false;
            this.button_Transaction.Visible = true;
            this.button_Transaction.Click += new System.EventHandler(this.button_Transaction_Click);
            // 
            // label_SubName
            // 
            this.label_SubName.ForeColor = System.Drawing.Color.Black;
            this.label_SubName.Size = new System.Drawing.Size(222, 28);
            this.label_SubName.Text = "Receivable Documents";
            // 
            // CreateReceivableDocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1101, 677);
            this.Name = "CreateReceivableDocs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
