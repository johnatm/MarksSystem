namespace OOP2
{
    partial class AddComponentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.compName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.compID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // compName
            // 
            this.compName.Location = new System.Drawing.Point(90, 45);
            this.compName.Name = "compName";
            this.compName.Size = new System.Drawing.Size(100, 20);
            this.compName.TabIndex = 1;
            this.compName.TextChanged += new System.EventHandler(this.assName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Weight";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(90, 74);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(100, 20);
            this.weight.TabIndex = 3;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(79, 113);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 7;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // compID
            // 
            this.compID.Location = new System.Drawing.Point(90, 17);
            this.compID.Name = "compID";
            this.compID.Size = new System.Drawing.Size(100, 20);
            this.compID.TabIndex = 1;
            this.compID.TextChanged += new System.EventHandler(this.assName_TextChanged);
            // 
            // AddComponentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.compID);
            this.Controls.Add(this.compName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "AddComponentControl";
            this.Size = new System.Drawing.Size(226, 151);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox compName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox compID;
    }
}
