namespace Serializer
{
    partial class personsForm
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
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameBox.Location = new System.Drawing.Point(69, 101);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(348, 27);
            this.nameBox.TabIndex = 0;
            // 
            // addressBox
            // 
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressBox.Location = new System.Drawing.Point(69, 175);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(348, 27);
            this.addressBox.TabIndex = 1;
            // 
            // phoneBox
            // 
            this.phoneBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneBox.Location = new System.Drawing.Point(69, 247);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(348, 27);
            this.phoneBox.TabIndex = 2;
            // 
            // previousButton
            // 
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.previousButton.Location = new System.Drawing.Point(39, 314);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(118, 32);
            this.previousButton.TabIndex = 3;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nextButton.Location = new System.Drawing.Point(191, 314);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(118, 32);
            this.nextButton.TabIndex = 4;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveButton.Location = new System.Drawing.Point(339, 314);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(118, 32);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.Location = new System.Drawing.Point(65, 69);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(63, 20);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Name: ";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addressLabel.Location = new System.Drawing.Point(65, 143);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(81, 20);
            this.addressLabel.TabIndex = 7;
            this.addressLabel.Text = "Address: ";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.phoneLabel.Location = new System.Drawing.Point(65, 215);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(66, 20);
            this.phoneLabel.TabIndex = 8;
            this.phoneLabel.Text = "Phone: ";
            // 
            // firstButton
            // 
            this.firstButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.firstButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstButton.Location = new System.Drawing.Point(39, 366);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(190, 32);
            this.firstButton.TabIndex = 9;
            this.firstButton.Text = "Jump to first";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lastButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lastButton.Location = new System.Drawing.Point(267, 366);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(190, 32);
            this.lastButton.TabIndex = 10;
            this.lastButton.Text = "Jump to last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // personsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 421);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.nameBox);
            this.Name = "personsForm";
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "Person Serializer";
            this.Load += new System.EventHandler(this.PersonsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
    }
}

