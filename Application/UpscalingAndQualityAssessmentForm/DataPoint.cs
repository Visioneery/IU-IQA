namespace UpscalingAndQualityAssessmentForm
{
    public class DataPoint
    {
        public string File { get; set; }

        public string DataSet { get; set; }

        public int Scale { get; set; } 

        public string Algorithm { get; set; }

        public double MSE { get; set; }

        public double PSNR { get; set; }

        public double SSIM { get; set; }

        public double BRISQUE { get; set; }

        public double VGG { get; set; }

        public double Speed { get; set; }

        public DataPoint(string file, string dataSet, int scale, string algorithm)
        {
            File = file;
            DataSet = dataSet;
            Scale = scale;
            Algorithm = algorithm;
        }
    }
}
