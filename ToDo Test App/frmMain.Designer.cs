namespace ToDo_Test_App
{
    partial class FrmMain
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
            this.btnTestSerialize = new System.Windows.Forms.Button();
            this.btnTestDeserialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestSerialize
            // 
            this.btnTestSerialize.Location = new System.Drawing.Point(12, 12);
            this.btnTestSerialize.Name = "btnTestSerialize";
            this.btnTestSerialize.Size = new System.Drawing.Size(96, 23);
            this.btnTestSerialize.TabIndex = 0;
            this.btnTestSerialize.Text = "Test Serialize";
            this.btnTestSerialize.UseVisualStyleBackColor = true;
            this.btnTestSerialize.Click += new System.EventHandler(this.btnTestSerialize_Click);
            // 
            // btnTestDeserialize
            // 
            this.btnTestDeserialize.Location = new System.Drawing.Point(114, 12);
            this.btnTestDeserialize.Name = "btnTestDeserialize";
            this.btnTestDeserialize.Size = new System.Drawing.Size(96, 23);
            this.btnTestDeserialize.TabIndex = 1;
            this.btnTestDeserialize.Text = "Test Deserialize";
            this.btnTestDeserialize.UseVisualStyleBackColor = true;
            this.btnTestDeserialize.Click += new System.EventHandler(this.btnTestDeserialize_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 398);
            this.Controls.Add(this.btnTestDeserialize);
            this.Controls.Add(this.btnTestSerialize);
            this.Name = "frmMain";
            this.Text = "ToDo Test App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestSerialize;
        private System.Windows.Forms.Button btnTestDeserialize;
    }
}

