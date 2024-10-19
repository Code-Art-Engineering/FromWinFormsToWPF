namespace MvvmWinForms
{
    partial class MainForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtInputMessage = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblFeedbackMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(32, 31);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(200, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(32, 91);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(200, 20);
            this.txtAge.TabIndex = 1;
            // 
            // txtInputMessage
            // 
            this.txtInputMessage.Location = new System.Drawing.Point(32, 121);
            this.txtInputMessage.Name = "txtInputMessage";
            this.txtInputMessage.Size = new System.Drawing.Size(200, 20);
            this.txtInputMessage.TabIndex = 2;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(32, 151);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 25);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAge
            // 
            this.lblAge.Location = new System.Drawing.Point(32, 61);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(200, 20);
            this.lblAge.TabIndex = 4;
            this.lblAge.Text = "Age";
            // 
            // lblFeedbackMessage
            // 
            this.lblFeedbackMessage.ForeColor = System.Drawing.Color.Green;
            this.lblFeedbackMessage.Location = new System.Drawing.Point(32, 181);
            this.lblFeedbackMessage.Name = "lblFeedbackMessage";
            this.lblFeedbackMessage.Size = new System.Drawing.Size(200, 40);
            this.lblFeedbackMessage.TabIndex = 5;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(262, 275);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtInputMessage);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lblFeedbackMessage);
            this.Name = "MainForm";
            this.Text = "Person Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtInputMessage;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblFeedbackMessage;

    }
}

