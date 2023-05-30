using System;
using System.Windows.Forms;

namespace UpscalingAndQualityAssessmentForm
{
    public partial class DownscalingForm : Form
    {
        public int ImageCompressionValue { get; set; }

        public int GaussianNoiseValue { get; set; }

        public int GaussianBlurValue { get; set; }

        public double ImageQualitySettingValue { get; set; }

        public DownscalingForm()
        {
            InitializeComponent();
        }

        private void ConfirmDownscalingValues_Click(object sender, EventArgs e)
        {
            // Store the input values in properties
            ImageCompressionValue = int.Parse(ImageCompressionTextBox.Text);
            GaussianNoiseValue = int.Parse(GaussianNoiseTextBox.Text);
            GaussianBlurValue = int.Parse(GaussianBlurTextBox.Text);
            ImageQualitySettingValue = double.Parse(ImageQualitySettingTextBox.Text);
            // Close the dialog
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
