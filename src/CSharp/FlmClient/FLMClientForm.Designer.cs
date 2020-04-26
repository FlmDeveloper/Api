namespace FlmApiClient
{
    partial class ClientApiForm
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
            this.cboApiCall = new System.Windows.Forms.ComboBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.lblApiCall = new System.Windows.Forms.Label();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.cmdGetResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboApiCall
            // 
            this.cboApiCall.DisplayMember = "DisplayText";
            this.cboApiCall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboApiCall.FormattingEnabled = true;
            this.cboApiCall.Location = new System.Drawing.Point(238, 27);
            this.cboApiCall.Name = "cboApiCall";
            this.cboApiCall.Size = new System.Drawing.Size(226, 21);
            this.cboApiCall.TabIndex = 0;
            this.cboApiCall.ValueMember = "Id";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(6, 28);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(226, 20);
            this.txtApiKey.TabIndex = 1;
            this.txtApiKey.Text = "You\'re Api Key Here";
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(6, 12);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(43, 13);
            this.lblApiKey.TabIndex = 2;
            this.lblApiKey.Text = "Api Key";
            // 
            // lblApiCall
            // 
            this.lblApiCall.AutoSize = true;
            this.lblApiCall.Location = new System.Drawing.Point(237, 12);
            this.lblApiCall.Name = "lblApiCall";
            this.lblApiCall.Size = new System.Drawing.Size(42, 13);
            this.lblApiCall.TabIndex = 3;
            this.lblApiCall.Text = "Api Call";
            // 
            // txtResults
            // 
            this.txtResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResults.Location = new System.Drawing.Point(6, 55);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResults.Size = new System.Drawing.Size(558, 414);
            this.txtResults.TabIndex = 4;
            // 
            // cmdGetResults
            // 
            this.cmdGetResults.Location = new System.Drawing.Point(470, 28);
            this.cmdGetResults.Name = "cmdGetResults";
            this.cmdGetResults.Size = new System.Drawing.Size(94, 21);
            this.cmdGetResults.TabIndex = 5;
            this.cmdGetResults.Text = "Get Results";
            this.cmdGetResults.UseVisualStyleBackColor = true;
            this.cmdGetResults.Click += new System.EventHandler(this.cmdGetResults_Click);
            // 
            // ClientApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 472);
            this.Controls.Add(this.cmdGetResults);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.lblApiCall);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.txtApiKey);
            this.Controls.Add(this.cboApiCall);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(446, 490);
            this.Name = "ClientApiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLM Api Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboApiCall;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.Label lblApiCall;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button cmdGetResults;
    }
}

