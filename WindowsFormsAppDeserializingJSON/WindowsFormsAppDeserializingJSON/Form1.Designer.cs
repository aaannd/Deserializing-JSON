namespace WindowsFormsAppDeserializingJSON
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeserialised = new System.Windows.Forms.Button();
            this.buttonClearDebug = new System.Windows.Forms.Button();
            this.textBoxDebugOutput = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Row JSON (Serialised String)";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInput.Location = new System.Drawing.Point(6, 19);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInput.Size = new System.Drawing.Size(706, 82);
            this.textBoxInput.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxDebugOutput);
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(718, 117);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Debug Output";
            // 
            // buttonDeserialised
            // 
            this.buttonDeserialised.Location = new System.Drawing.Point(13, 146);
            this.buttonDeserialised.Name = "buttonDeserialised";
            this.buttonDeserialised.Size = new System.Drawing.Size(152, 23);
            this.buttonDeserialised.TabIndex = 2;
            this.buttonDeserialised.Text = "Deserialised";
            this.buttonDeserialised.UseVisualStyleBackColor = true;
            this.buttonDeserialised.Click += new System.EventHandler(this.buttonDeserialised_Click);
            // 
            // buttonClearDebug
            // 
            this.buttonClearDebug.Location = new System.Drawing.Point(183, 146);
            this.buttonClearDebug.Name = "buttonClearDebug";
            this.buttonClearDebug.Size = new System.Drawing.Size(152, 23);
            this.buttonClearDebug.TabIndex = 3;
            this.buttonClearDebug.Text = "Clear Debug";
            this.buttonClearDebug.UseVisualStyleBackColor = true;
            this.buttonClearDebug.Click += new System.EventHandler(this.buttonClearDebug_Click);
            // 
            // textBoxDebugOutput
            // 
            this.textBoxDebugOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDebugOutput.Location = new System.Drawing.Point(6, 19);
            this.textBoxDebugOutput.Multiline = true;
            this.textBoxDebugOutput.Name = "textBoxDebugOutput";
            this.textBoxDebugOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDebugOutput.Size = new System.Drawing.Size(706, 82);
            this.textBoxDebugOutput.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 333);
            this.Controls.Add(this.buttonClearDebug);
            this.Controls.Add(this.buttonDeserialised);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonDeserialised;
        private System.Windows.Forms.Button buttonClearDebug;
        private System.Windows.Forms.TextBox textBoxDebugOutput;
    }
}

