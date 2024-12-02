namespace RSA_AJC
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
            Alice = new TextBox();
            Bob = new TextBox();
            Encrypt = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // Alice
            // 
            Alice.Location = new Point(29, 131);
            Alice.Multiline = true;
            Alice.Name = "Alice";
            Alice.PlaceholderText = "Alice Says:";
            Alice.Size = new Size(315, 173);
            Alice.TabIndex = 0;
            Alice.TextChanged += textBox1_TextChanged;
            // 
            // Bob
            // 
            Bob.Location = new Point(436, 131);
            Bob.Multiline = true;
            Bob.Name = "Bob";
            Bob.PlaceholderText = "Bob Hears:";
            Bob.ReadOnly = true;
            Bob.Size = new Size(295, 173);
            Bob.TabIndex = 1;
            Bob.TextChanged += textBox1_TextChanged_1;
            // 
            // Encrypt
            // 
            Encrypt.Location = new Point(29, 91);
            Encrypt.Name = "Encrypt";
            Encrypt.Size = new Size(112, 34);
            Encrypt.TabIndex = 2;
            Encrypt.Text = "Encrypt";
            Encrypt.UseVisualStyleBackColor = true;
            Encrypt.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(524, 67);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Encrypt);
            Controls.Add(Bob);
            Controls.Add(Alice);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Alice;
        private TextBox Bob;
        private Button Encrypt;
        private Button button1;
    }
}
