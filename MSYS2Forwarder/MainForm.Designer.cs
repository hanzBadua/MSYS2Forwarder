
namespace MSYS2Forwarder
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
            this.SelectShellGroupBox = new System.Windows.Forms.GroupBox();
            this.ChooseMinGW32RadioButton = new System.Windows.Forms.RadioButton();
            this.ChooseMinGW64RadioButton = new System.Windows.Forms.RadioButton();
            this.ChooseMSYSRadioButton = new System.Windows.Forms.RadioButton();
            this.LaunchButton = new System.Windows.Forms.Button();
            this.AddContextMenuEntriesButton = new System.Windows.Forms.Button();
            this.RemoveContextMenuEntriesButton = new System.Windows.Forms.Button();
            this.SelectShellGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectShellGroupBox
            // 
            this.SelectShellGroupBox.Controls.Add(this.ChooseMinGW32RadioButton);
            this.SelectShellGroupBox.Controls.Add(this.ChooseMinGW64RadioButton);
            this.SelectShellGroupBox.Controls.Add(this.ChooseMSYSRadioButton);
            this.SelectShellGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.SelectShellGroupBox.Location = new System.Drawing.Point(12, 6);
            this.SelectShellGroupBox.Name = "SelectShellGroupBox";
            this.SelectShellGroupBox.Size = new System.Drawing.Size(485, 85);
            this.SelectShellGroupBox.TabIndex = 0;
            this.SelectShellGroupBox.TabStop = false;
            this.SelectShellGroupBox.Text = "Select MSYS2 Shell";
            // 
            // ChooseMinGW32RadioButton
            // 
            this.ChooseMinGW32RadioButton.AutoSize = true;
            this.ChooseMinGW32RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ChooseMinGW32RadioButton.Location = new System.Drawing.Point(7, 49);
            this.ChooseMinGW32RadioButton.Name = "ChooseMinGW32RadioButton";
            this.ChooseMinGW32RadioButton.Size = new System.Drawing.Size(101, 24);
            this.ChooseMinGW32RadioButton.TabIndex = 2;
            this.ChooseMinGW32RadioButton.Text = "MinGW32";
            this.ChooseMinGW32RadioButton.UseVisualStyleBackColor = true;
            this.ChooseMinGW32RadioButton.CheckedChanged += new System.EventHandler(this.ChooseMinGW32RadioButton_CheckedChanged);
            // 
            // ChooseMinGW64RadioButton
            // 
            this.ChooseMinGW64RadioButton.AutoSize = true;
            this.ChooseMinGW64RadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ChooseMinGW64RadioButton.Location = new System.Drawing.Point(123, 22);
            this.ChooseMinGW64RadioButton.Name = "ChooseMinGW64RadioButton";
            this.ChooseMinGW64RadioButton.Size = new System.Drawing.Size(101, 24);
            this.ChooseMinGW64RadioButton.TabIndex = 1;
            this.ChooseMinGW64RadioButton.Text = "MinGW64";
            this.ChooseMinGW64RadioButton.UseVisualStyleBackColor = true;
            this.ChooseMinGW64RadioButton.CheckedChanged += new System.EventHandler(this.ChooseMinGW64RadioButton_CheckedChanged);
            // 
            // ChooseMSYSRadioButton
            // 
            this.ChooseMSYSRadioButton.AutoSize = true;
            this.ChooseMSYSRadioButton.Checked = true;
            this.ChooseMSYSRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.ChooseMSYSRadioButton.Location = new System.Drawing.Point(7, 22);
            this.ChooseMSYSRadioButton.Name = "ChooseMSYSRadioButton";
            this.ChooseMSYSRadioButton.Size = new System.Drawing.Size(76, 24);
            this.ChooseMSYSRadioButton.TabIndex = 0;
            this.ChooseMSYSRadioButton.TabStop = true;
            this.ChooseMSYSRadioButton.Text = "MSYS";
            this.ChooseMSYSRadioButton.UseVisualStyleBackColor = true;
            this.ChooseMSYSRadioButton.CheckedChanged += new System.EventHandler(this.ChooseMSYSRadioButton_CheckedChanged);
            // 
            // LaunchButton
            // 
            this.LaunchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LaunchButton.Location = new System.Drawing.Point(12, 97);
            this.LaunchButton.Name = "LaunchButton";
            this.LaunchButton.Size = new System.Drawing.Size(160, 52);
            this.LaunchButton.TabIndex = 1;
            this.LaunchButton.Text = "Launch";
            this.LaunchButton.UseVisualStyleBackColor = true;
            this.LaunchButton.Click += new System.EventHandler(this.LaunchButton_Click);
            // 
            // AddContextMenuEntriesButton
            // 
            this.AddContextMenuEntriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
            this.AddContextMenuEntriesButton.Location = new System.Drawing.Point(178, 97);
            this.AddContextMenuEntriesButton.Name = "AddContextMenuEntriesButton";
            this.AddContextMenuEntriesButton.Size = new System.Drawing.Size(164, 52);
            this.AddContextMenuEntriesButton.TabIndex = 2;
            this.AddContextMenuEntriesButton.Text = "Add to Context Menu";
            this.AddContextMenuEntriesButton.UseVisualStyleBackColor = true;
            this.AddContextMenuEntriesButton.Click += new System.EventHandler(this.AddContextMenuEntriesButton_Click);
            // 
            // RemoveContextMenuEntriesButton
            // 
            this.RemoveContextMenuEntriesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RemoveContextMenuEntriesButton.Location = new System.Drawing.Point(348, 97);
            this.RemoveContextMenuEntriesButton.Name = "RemoveContextMenuEntriesButton";
            this.RemoveContextMenuEntriesButton.Size = new System.Drawing.Size(149, 52);
            this.RemoveContextMenuEntriesButton.TabIndex = 3;
            this.RemoveContextMenuEntriesButton.Text = "Remove from Context Menu";
            this.RemoveContextMenuEntriesButton.UseVisualStyleBackColor = true;
            this.RemoveContextMenuEntriesButton.Click += new System.EventHandler(this.RemoveContextMenuEntriesButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.LaunchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 167);
            this.Controls.Add(this.RemoveContextMenuEntriesButton);
            this.Controls.Add(this.AddContextMenuEntriesButton);
            this.Controls.Add(this.LaunchButton);
            this.Controls.Add(this.SelectShellGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "MSYS2 Forwarder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SelectShellGroupBox.ResumeLayout(false);
            this.SelectShellGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SelectShellGroupBox;
        private System.Windows.Forms.RadioButton ChooseMinGW32RadioButton;
        private System.Windows.Forms.RadioButton ChooseMinGW64RadioButton;
        private System.Windows.Forms.RadioButton ChooseMSYSRadioButton;
        private System.Windows.Forms.Button LaunchButton;
        private System.Windows.Forms.Button AddContextMenuEntriesButton;
        private System.Windows.Forms.Button RemoveContextMenuEntriesButton;
    }
}

