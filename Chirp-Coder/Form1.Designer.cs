namespace Chirp_Coder
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Key = new TextBox();
            Input = new TextBox();
            Output = new TextBox();
            SuspendLayout();
            // 
            // Key
            // 
            Key.Location = new Point(688, 12);
            Key.Name = "Key";
            Key.Size = new Size(100, 23);
            Key.TabIndex = 0;
            Key.TextChanged += Key_TextChanged;
            // 
            // Input
            // 
            Input.Location = new Point(12, 12);
            Input.Multiline = true;
            Input.Name = "Input";
            Input.Size = new Size(670, 207);
            Input.TabIndex = 1;
            Input.TextChanged += Input_TextChanged;
            // 
            // Output
            // 
            Output.Location = new Point(12, 225);
            Output.Multiline = true;
            Output.Name = "Output";
            Output.Size = new Size(670, 207);
            Output.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Output);
            Controls.Add(Input);
            Controls.Add(Key);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Key;
        private TextBox Input;
        private TextBox Output;
    }
}
