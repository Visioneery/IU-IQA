using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using OpenCvSharp;
using UpscalingAndQualityAssessmentForm.Analyzers;
using UpscalingAndQualityAssessmentForm.Upscale;
using LicenseContext = OfficeOpenXml.LicenseContext;

namespace UpscalingAndQualityAssessmentForm
{
    public partial class Form1 : Form
    {
        private readonly DifferenceAnalyzer _differenceAnalyzer;

        private readonly QualityAnalyzer _qualityAnalyzer;

        private readonly Upscaler _upscaler;
        private readonly DownScaler _downScaler;

        private string _lowQualityImagePath;
        private string _referenceImagePath;
        private string _imageFormat;

        public Form1()
        {
            _differenceAnalyzer = new DifferenceAnalyzer(this);
            _qualityAnalyzer = new QualityAnalyzer(this);
            _upscaler = new Upscaler();
            _downScaler = new DownScaler();
            InitializeComponent();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
                "This demonstrates a use of upscaling algorithms, analyses pictures and and determines image quality",
                "Test Form",
                MessageBoxButtons.OK);
        }

        private void DisplayInPictureBox1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog
            var openFileDialog = new OpenFileDialog();

            // Set the filter to only allow image files
            openFileDialog.Filter = @"Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            // Show the dialog and wait for the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the PictureBox control to display the selected image
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Tag = openFileDialog.FileName;
            }
        }

        private void DisplayInPictureBox2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog
            var openFileDialog = new OpenFileDialog();

            // Set the filter to only allow image files
            openFileDialog.Filter = @"Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            // Show the dialog and wait for the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Set the PictureBox control to display the selected image
                pictureBox2.Image = Image.FromFile(openFileDialog.FileName);
                pictureBox2.Tag = openFileDialog.FileName;
            }
        }

        private void SelectLowQualityImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog
            var openFileDialog = new OpenFileDialog();

            // Set the filter to only allow image files
            openFileDialog.Filter = @"Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            // Show the dialog and wait for the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _lowQualityImagePath = openFileDialog.FileName;
            }
        }

        private void SelectReferenceImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Create a new instance of the OpenFileDialog
            var openFileDialog = new OpenFileDialog();

            // Set the filter to only allow image files
            openFileDialog.Filter = @"Image Files (*.mat;*.jpg;*.jpeg,*.png)|*.MAT;*.JPG;*.JPEG;*.PNG";

            // Show the dialog and wait for the user to select a file
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _referenceImagePath = openFileDialog.FileName;
            }
        }

        private void ScaleX2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upscaler.Scale = ScaleEnum.Scale2;
            _upscaler.InitializeModels();
            _qualityAnalyzer.InitializeModels();
        }

        private void ScaleX4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upscaler.Scale = ScaleEnum.Scale4;
            _upscaler.InitializeModels();
            _qualityAnalyzer.InitializeModels();
        }

        private void downScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var inputDialog = new DownscalingForm();
            if (inputDialog.ShowDialog() == DialogResult.OK)
            {
                //string[] files = Directory.GetFiles(@"C:\Users\User\Desktop\Upscaling\images\Reference", "*CUSTOM*");

                //foreach (var file in files)
                //{
                var openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = @"Image Files (*.mat;*.jpg;*.jpeg,*.png)|*.MAT;*.JPG;*.JPEG;*.PNG";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _lowQualityImagePath = _downScaler.DownScale(openFileDialog.FileName, (int)_upscaler.Scale, inputDialog);
                }

                //}
            }

        }

        private void UpscaleUsingLanczosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upscaler.UpscaleUsingLanczos(_lowQualityImagePath);
        }

        private void UpscaleUsingBicubicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upscaler.UpscaleUsingBicubic(_lowQualityImagePath);
        }

        private void UpscaleUsingLapSRNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upscaler.UpscaleUsingLapSRN(_lowQualityImagePath);
        }

        private void UpscaleUsingEDSRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upscaler.UpscaleUsingEDSR(_lowQualityImagePath);
        }

        private void UpscaleUsingFSRCNNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _upscaler.UpscaleUsingFSRCNN(_lowQualityImagePath);
        }

        private void ComparePixelValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _differenceAnalyzer.ComparePixelValuesColor(pictureBox1, pictureBox2, _referenceImagePath);
        }

        private void ComputeImageMetricsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _differenceAnalyzer.ComputeImageMetrics(pictureBox1, pictureBox2, _referenceImagePath);
        }

        private void KeyMatchingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _differenceAnalyzer.KeyMatching(pictureBox1, pictureBox2, _referenceImagePath);
        }

        private void DetermineUsingPSNRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _qualityAnalyzer.DetermineQualityUsingPSNR();
        }

        private void DetermineUsingSSIMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _qualityAnalyzer.DetermineQualityUsingSSIM();
        }

        private void DetermineUsingMSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _qualityAnalyzer.DetermineQualityUsingMSE();
        }

        private void DetermineUsingFeatureExtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _qualityAnalyzer.DetermineQualityUsingFeatureExtraction(pictureBox1, pictureBox2);
        }

        private void DetermineUsingBRISQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _qualityAnalyzer.DetermineQualityUsingBRISQUE(pictureBox1, pictureBox2);
        }

        private void DetermineUsingBIQAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _qualityAnalyzer.DetermineQualityUsingBIQA(pictureBox1, pictureBox2);
        }

        private void DetermineUsingVGGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _qualityAnalyzer.DetermineQualityUsingVGG(pictureBox1, pictureBox2, _referenceImagePath);
        }

        private void ConvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Get all files in the directory
            var imagesFolderPath =
                Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName,
                    "images");
            string[] files = Directory.GetFiles($"{imagesFolderPath}\\convert");

            foreach (var file in files)
            {
                // Read the image file
                var image = Cv2.ImRead(file);

                var extension = Path.GetExtension(file);
                var newExtension = extension.Contains("png") ? ".jpg" : ".png";
                var flag = extension.Contains("png") ? new ImageEncodingParam(ImwriteFlags.JpegQuality, 100) : new ImageEncodingParam(ImwriteFlags.PngCompression, 3);

                var outputFilePath = Path.Combine(Path.GetDirectoryName(file),
                    Path.GetFileNameWithoutExtension(file) + newExtension);

                Cv2.ImWrite(outputFilePath, image, flag);

            }
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainFolderPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName;

            string[] lowQualityFiles = Directory.GetFiles($"{mainFolderPath}\\images\\Downscaled", $"*x{(int)_upscaler.Scale}.{_imageFormat}"); // extension change , select scale
            var stopwatch = new Stopwatch();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // For EPPlus 5.0 and later
            var dataPoints = new List<DataPoint>();

            var algorithms = new List<AlgorithmsEnum> { AlgorithmsEnum.BiCubic, AlgorithmsEnum.Lanczos, AlgorithmsEnum.LapSRN, AlgorithmsEnum.EDSR, AlgorithmsEnum.FSRCNN };

            var dataSets = new List<DataSets>();
            if (_imageFormat.Contains("jpg"))
            {
                dataSets = new List<DataSets> { DataSets.SET5, DataSets.SET14, DataSets.BSD100 };
            }else if (_imageFormat.Contains("png"))
            {
                dataSets = new List<DataSets> { DataSets.URBAN100, DataSets.DIV2K, DataSets.CUSTOM };
            }
            
           

            foreach (var file in lowQualityFiles)
            {
                foreach (var algorithm in algorithms)
                {
                    var dataPoint = new DataPoint(file, Path.GetFileName(file.Split('_')[0]), (int)_upscaler.Scale, algorithm.ToString());

                    dataPoints.Add(dataPoint);
                }
            }

            foreach (string file in lowQualityFiles)
            {
                stopwatch.Start();
                _upscaler.UpscaleUsingBicubic(file);
                stopwatch.Stop();
                dataPoints.FirstOrDefault(x => x.File.Contains(file) && x.DataSet.Contains(Path.GetFileName(file.Split('_')[0])) && x.Algorithm.Contains("BiCubic")).Speed = stopwatch.Elapsed.TotalSeconds;

                stopwatch.Restart();
                _upscaler.UpscaleUsingLanczos(file);
                stopwatch.Stop();
                dataPoints.FirstOrDefault(x => x.File.Contains(file) && x.DataSet.Contains(Path.GetFileName(file.Split('_')[0])) && x.Algorithm.Contains("Lanczos")).Speed = stopwatch.Elapsed.TotalSeconds;

                stopwatch.Restart();
                _upscaler.UpscaleUsingLapSRN(file);
                stopwatch.Stop();
                dataPoints.FirstOrDefault(x => x.File.Contains(file) && x.DataSet.Contains(Path.GetFileName(file.Split('_')[0])) && x.Algorithm.Contains("LapSRN")).Speed = stopwatch.Elapsed.TotalSeconds;

                stopwatch.Restart();
                _upscaler.UpscaleUsingEDSR(file);
                stopwatch.Stop();
                dataPoints.FirstOrDefault(x => x.File.Contains(file) && x.DataSet.Contains(Path.GetFileName(file.Split('_')[0])) && x.Algorithm.Contains("EDSR")).Speed = stopwatch.Elapsed.TotalSeconds;

                stopwatch.Restart();
                _upscaler.UpscaleUsingFSRCNN(file);
                stopwatch.Stop();
                dataPoints.FirstOrDefault(x => x.File.Contains(file) && x.DataSet.Contains(Path.GetFileName(file.Split('_')[0])) && x.Algorithm.Contains("FSRCNN")).Speed = stopwatch.Elapsed.TotalSeconds;
            }

            var upscaledFiles = Directory.GetFiles($"{mainFolderPath}\\images\\Upscaled", $"*x{(int)_upscaler.Scale}.{_imageFormat}*").ToList(); // file extension

            using var package = new ExcelPackage(new FileInfo($"{mainFolderPath}\\documentation\\Test.xlsx"));

            var worksheet = package.Workbook.Worksheets.First(x => x.Name.Contains($"{_imageFormat}_x{(int)_upscaler.Scale}")); // file extension

            foreach (string file in upscaledFiles)
            {
                string[] parts = Path.GetFileNameWithoutExtension(file).Split('x');
                string[] referenceFile;

                if (file.Contains("URBAN"))
                {
                    referenceFile = Directory.GetFiles($"{mainFolderPath}\\images\\Reference",
                        $"*{parts[0]}x{parts[1]}*");
                }
                else
                {
                    referenceFile = Directory.GetFiles($"{mainFolderPath}\\images\\Reference", $"*{parts[0]}*");
                }

                var metrics = _differenceAnalyzer.ComputeSingleImageMetrics(file, referenceFile[0]);
                var brisqueScore = _qualityAnalyzer.DetermineQualityUsingBRISQUE(file);
                var vggScore = _qualityAnalyzer.DetermineQualityUsingVGG(file, referenceFile[0]);

                var nameParts = file.Split('_');
                var dataPoint = dataPoints.FirstOrDefault(x =>
                    x.File.Contains(parts[0]) && x.DataSet.Contains(Path.GetFileName(nameParts[0])) && x.Algorithm.Contains(nameParts[2]));

                dataPoint.MSE = metrics[0].ToDouble();
                dataPoint.PSNR = metrics[1].ToDouble();
                dataPoint.SSIM = metrics[2].ToDouble();
                dataPoint.BRISQUE = brisqueScore.ToDouble();
                dataPoint.VGG = vggScore;
            }

            var defaultNumber = 2;

            foreach (var dataSet in dataSets)
            {
                foreach (var algorithm in algorithms)
                {
                    worksheet.Cells["A" + defaultNumber].Value = dataSet;
                    worksheet.Cells["B" + defaultNumber].Value = $"x{_upscaler.Scale}";
                    worksheet.Cells["C" + defaultNumber].Value = algorithm;

                    double resultMSE = 0;
                    double resultPSNR = 0;
                    double resultSSIM = 0;
                    double resultBRISQUE = 0;
                    double resultVGG = 0;
                    double resultSpeed = 0;

                    foreach (var dataPoint in dataPoints.Where(x =>
                                 x.DataSet.Contains(dataSet.ToString()) && x.Algorithm.Contains(algorithm.ToString())))
                    {

                        resultMSE = resultMSE + dataPoint.MSE;
                        resultPSNR = resultPSNR + dataPoint.PSNR;
                        resultSSIM = resultSSIM + dataPoint.SSIM;
                        resultBRISQUE = resultBRISQUE + dataPoint.BRISQUE;
                        resultVGG = resultVGG + dataPoint.VGG;
                        resultSpeed = resultSpeed + dataPoint.Speed;
                    }

                    worksheet.Cells["D" + defaultNumber].Value = Math.Round(resultMSE / upscaledFiles.Count, 4);
                    worksheet.Cells["E" + defaultNumber].Value = Math.Round(resultPSNR / upscaledFiles.Count, 4);
                    worksheet.Cells["F" + defaultNumber].Value = Math.Round(resultSSIM / upscaledFiles.Count, 4);
                    worksheet.Cells["G" + defaultNumber].Value = Math.Round(resultBRISQUE / upscaledFiles.Count, 4);
                    worksheet.Cells["H" + defaultNumber].Value = Math.Round(resultVGG / upscaledFiles.Count, 4);
                    worksheet.Cells["I" + defaultNumber].Value = Math.Round(resultSpeed / upscaledFiles.Count, 4);

                    defaultNumber += 1;
                    package.Save();
                }
            }
        }

        private void selectPNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _imageFormat = "png";
        }

        private void selectJPGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _imageFormat = "jpg";
        }
    }
}
