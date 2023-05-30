namespace UpscalingAndQualityAssessmentForm
{
    partial class DownscalingForm
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
            GaussianNoiseLabel = new System.Windows.Forms.Label();
            GaussianBlurLabel = new System.Windows.Forms.Label();
            ImageQualitySettingLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ImageCompressionTextBox = new System.Windows.Forms.TextBox();
            GaussianNoiseTextBox = new System.Windows.Forms.TextBox();
            GaussianBlurTextBox = new System.Windows.Forms.TextBox();
            ImageQualitySettingTextBox = new System.Windows.Forms.TextBox();
            ConfirmDownscalingValues = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // GaussianNoiseLabel
            // 
            GaussianNoiseLabel.AutoSize = true;
            GaussianNoiseLabel.Location = new System.Drawing.Point(12, 40);
            GaussianNoiseLabel.Name = "GaussianNoiseLabel";
            GaussianNoiseLabel.Size = new System.Drawing.Size(113, 15);
            GaussianNoiseLabel.TabIndex = 0;
            GaussianNoiseLabel.Text = "Add Gaussian noise:";
            // 
            // GaussianBlurLabel
            // 
            GaussianBlurLabel.AutoSize = true;
            GaussianBlurLabel.Location = new System.Drawing.Point(12, 70);
            GaussianBlurLabel.Name = "GaussianBlurLabel";
            GaussianBlurLabel.Size = new System.Drawing.Size(106, 15);
            GaussianBlurLabel.TabIndex = 1;
            GaussianBlurLabel.Text = "Add Gaussian blur:";
            // 
            // ImageQualitySettingLabel
            // 
            ImageQualitySettingLabel.AutoSize = true;
            ImageQualitySettingLabel.Location = new System.Drawing.Point(12, 100);
            ImageQualitySettingLabel.Name = "ImageQualitySettingLabel";
            ImageQualitySettingLabel.Size = new System.Drawing.Size(149, 15);
            ImageQualitySettingLabel.TabIndex = 2;
            ImageQualitySettingLabel.Text = "Add Image Quality Setting:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 10);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(139, 15);
            label1.TabIndex = 3;
            label1.Text = "Add Image compression:";
            // 
            // ImageCompressionTextBox
            // 
            ImageCompressionTextBox.Location = new System.Drawing.Point(197, 7);
            ImageCompressionTextBox.Name = "ImageCompressionTextBox";
            ImageCompressionTextBox.Size = new System.Drawing.Size(116, 23);
            ImageCompressionTextBox.TabIndex = 4;
            ImageCompressionTextBox.Text = "99";
            // 
            // GaussianNoiseTextBox
            // 
            GaussianNoiseTextBox.Location = new System.Drawing.Point(197, 37);
            GaussianNoiseTextBox.Name = "GaussianNoiseTextBox";
            GaussianNoiseTextBox.Size = new System.Drawing.Size(116, 23);
            GaussianNoiseTextBox.TabIndex = 5;
            GaussianNoiseTextBox.Text = "20";
            // 
            // GaussianBlurTextBox
            // 
            GaussianBlurTextBox.Location = new System.Drawing.Point(197, 67);
            GaussianBlurTextBox.Name = "GaussianBlurTextBox";
            GaussianBlurTextBox.Size = new System.Drawing.Size(116, 23);
            GaussianBlurTextBox.TabIndex = 6;
            GaussianBlurTextBox.Text = "7";
            // 
            // ImageQualitySettingTextBox
            // 
            ImageQualitySettingTextBox.Location = new System.Drawing.Point(197, 97);
            ImageQualitySettingTextBox.Name = "ImageQualitySettingTextBox";
            ImageQualitySettingTextBox.Size = new System.Drawing.Size(116, 23);
            ImageQualitySettingTextBox.TabIndex = 7;
            ImageQualitySettingTextBox.Text = "0.95";
            // 
            // ConfirmDownscalingValues
            // 
            ConfirmDownscalingValues.Location = new System.Drawing.Point(207, 140);
            ConfirmDownscalingValues.Name = "ConfirmDownscalingValues";
            ConfirmDownscalingValues.Size = new System.Drawing.Size(106, 23);
            ConfirmDownscalingValues.TabIndex = 8;
            ConfirmDownscalingValues.Text = "Confirm Values";
            ConfirmDownscalingValues.UseVisualStyleBackColor = true;
            ConfirmDownscalingValues.Click += ConfirmDownscalingValues_Click;
            // 
            // DownscalingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(338, 184);
            Controls.Add(ConfirmDownscalingValues);
            Controls.Add(ImageQualitySettingTextBox);
            Controls.Add(GaussianBlurTextBox);
            Controls.Add(GaussianNoiseTextBox);
            Controls.Add(ImageCompressionTextBox);
            Controls.Add(label1);
            Controls.Add(ImageQualitySettingLabel);
            Controls.Add(GaussianBlurLabel);
            Controls.Add(GaussianNoiseLabel);
            Name = "DownscalingForm";
            Text = "DownscalingForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label GaussianNoiseLabel;
        private System.Windows.Forms.Label GaussianBlurLabel;
        private System.Windows.Forms.Label ImageQualitySettingLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImageCompressionTextBox;
        private System.Windows.Forms.TextBox GaussianNoiseTextBox;
        private System.Windows.Forms.TextBox GaussianBlurTextBox;
        private System.Windows.Forms.TextBox ImageQualitySettingTextBox;
        private System.Windows.Forms.Button ConfirmDownscalingValues;
    }
}
