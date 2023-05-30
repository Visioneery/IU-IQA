namespace UpscalingAndQualityAssessmentForm
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
            MenuStrip = new System.Windows.Forms.MenuStrip();
            ActionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SelectLowQualityImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SelectReferenceImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DisplayInPictureBox1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DisplayInPictureBox2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SelectShadersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SetScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ScaleX2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ScaleX4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            downScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UpscaleUsingLanczosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UpscaleUsingBicubicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UpscaleUsingFSRCNNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UpscaleUsingLapSRNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            UpscaleUsingEDSRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ConvertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectPNGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            selectJPGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DifferenceAnalyserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ComparePixelValuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ComputeImageMetricsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            KeyMatchingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            QualityAnalyserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DetermineUsingPSNRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DetermineUsingSSIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DetermineUsingMSEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DetermineUsingBRISQUEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DetermineUsingVGGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DetermineUsingBIQAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DetermineUsingFeatureExtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            PixelValuesPictureBox1 = new System.Windows.Forms.Label();
            PixelValuesPictureBox2 = new System.Windows.Forms.Label();
            PixelValuesResultPictureBox1 = new System.Windows.Forms.Label();
            PixelValuesResultPictureBox2 = new System.Windows.Forms.Label();
            PixelValueDifferencePictureBox1 = new System.Windows.Forms.Label();
            PixelValueDifferenceResultPictureBox1 = new System.Windows.Forms.Label();
            PixelValueDifferencePictureBox2 = new System.Windows.Forms.Label();
            PixelValueDifferenceResultPictureBox2 = new System.Windows.Forms.Label();
            MeanSquaredErrorPictureBox1 = new System.Windows.Forms.Label();
            MeanSquaredErrorResultPictureBox1 = new System.Windows.Forms.Label();
            MeanSquaredErrorPictureBox2 = new System.Windows.Forms.Label();
            MeanSquaredErrorResultPictureBox2 = new System.Windows.Forms.Label();
            PeakSignaltoNoiseRatioPictureBox1 = new System.Windows.Forms.Label();
            PeakSignaltoNoiseRatioResultPictureBox1 = new System.Windows.Forms.Label();
            PeakSignaltoNoiseRatioPictureBox2 = new System.Windows.Forms.Label();
            PeakSignaltoNoiseRatioResultPictureBox2 = new System.Windows.Forms.Label();
            StructuralSimilarityIndexPictureBox1 = new System.Windows.Forms.Label();
            StructuralSimilarityIndexResultPictureBox1 = new System.Windows.Forms.Label();
            StructuralSimilarityIndexPictureBox2 = new System.Windows.Forms.Label();
            StructuralSimilarityIndexResultPictureBox2 = new System.Windows.Forms.Label();
            Label1 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            PeakSignalToNoiseQualityPictureBox1 = new System.Windows.Forms.Label();
            PeakSignalToNoiseQualityResultPictureBox1 = new System.Windows.Forms.Label();
            PeakSignalToNoisePictureBox2 = new System.Windows.Forms.Label();
            PeakSignalToNoiseQualityResultPictureBox2 = new System.Windows.Forms.Label();
            StructuralSimilarityQualityPictureBox1 = new System.Windows.Forms.Label();
            StructuralSimilarityIndexQualityResultPictureBox1 = new System.Windows.Forms.Label();
            StructuralSimilarityQualityPictureBox2 = new System.Windows.Forms.Label();
            StructuralSimilarityIndexQualityResultPictureBox2 = new System.Windows.Forms.Label();
            MeanSquaredErrorQualityPictureBox1 = new System.Windows.Forms.Label();
            MeanSquaredErrorQualityResultPictureBox1 = new System.Windows.Forms.Label();
            MeanSquaredErrorQualityPictureBox2 = new System.Windows.Forms.Label();
            MeanSquaredErrorQualityResultPictureBox2 = new System.Windows.Forms.Label();
            FeatureExtractionQualityPictureBox1 = new System.Windows.Forms.Label();
            FeatureExtractionQualityResultPictureBox1 = new System.Windows.Forms.Label();
            FeatureExtractionQualityPictureBox2 = new System.Windows.Forms.Label();
            FeatureExtractionQualityResultPictureBox2 = new System.Windows.Forms.Label();
            BRISQUEQualityPictureBox1 = new System.Windows.Forms.Label();
            BRISQUEQualityResultPictureBox1 = new System.Windows.Forms.Label();
            BRISQUEQualityPictureBox2 = new System.Windows.Forms.Label();
            BRISQUEQualityResultPictureBox2 = new System.Windows.Forms.Label();
            BIQAQualityPictureBox1 = new System.Windows.Forms.Label();
            BIQAQualityResultPictureBox1 = new System.Windows.Forms.Label();
            BIQAQualityPictureBox2 = new System.Windows.Forms.Label();
            BIQAQualityResultPictureBox2 = new System.Windows.Forms.Label();
            VGGQualityPictureBox1 = new System.Windows.Forms.Label();
            VGGQualityResultPictureBox1 = new System.Windows.Forms.Label();
            VGGQualityPictureBox2 = new System.Windows.Forms.Label();
            VGGQualityResultPictureBox2 = new System.Windows.Forms.Label();
            MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // MenuStrip
            // 
            MenuStrip.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ActionsToolStripMenuItem, HelpToolStripMenuItem, DifferenceAnalyserToolStripMenuItem, QualityAnalyserToolStripMenuItem });
            MenuStrip.Location = new System.Drawing.Point(0, 0);
            MenuStrip.Name = "MenuStrip";
            MenuStrip.Size = new System.Drawing.Size(1776, 24);
            MenuStrip.TabIndex = 1;
            MenuStrip.Text = "MenuStrip";
            // 
            // ActionsToolStripMenuItem
            // 
            ActionsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            ActionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SelectToolStripMenuItem, DisplayToolStripMenuItem, SelectShadersToolStripMenuItem, ConvertToolStripMenuItem, testToolStripMenuItem });
            ActionsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            ActionsToolStripMenuItem.Name = "ActionsToolStripMenuItem";
            ActionsToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            ActionsToolStripMenuItem.Text = "File";
            // 
            // SelectToolStripMenuItem
            // 
            SelectToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            SelectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SelectLowQualityImageToolStripMenuItem, SelectReferenceImageToolStripMenuItem });
            SelectToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            SelectToolStripMenuItem.Name = "SelectToolStripMenuItem";
            SelectToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            SelectToolStripMenuItem.Text = "Select";
            // 
            // SelectLowQualityImageToolStripMenuItem
            // 
            SelectLowQualityImageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            SelectLowQualityImageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            SelectLowQualityImageToolStripMenuItem.Name = "SelectLowQualityImageToolStripMenuItem";
            SelectLowQualityImageToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            SelectLowQualityImageToolStripMenuItem.Text = "Select low quality image";
            SelectLowQualityImageToolStripMenuItem.Click += SelectLowQualityImageToolStripMenuItem_Click;
            // 
            // SelectReferenceImageToolStripMenuItem
            // 
            SelectReferenceImageToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            SelectReferenceImageToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            SelectReferenceImageToolStripMenuItem.Name = "SelectReferenceImageToolStripMenuItem";
            SelectReferenceImageToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            SelectReferenceImageToolStripMenuItem.Text = "Select reference image";
            SelectReferenceImageToolStripMenuItem.Click += SelectReferenceImageToolStripMenuItem_Click;
            // 
            // DisplayToolStripMenuItem
            // 
            DisplayToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { DisplayInPictureBox1ToolStripMenuItem, DisplayInPictureBox2ToolStripMenuItem });
            DisplayToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DisplayToolStripMenuItem.Name = "DisplayToolStripMenuItem";
            DisplayToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            DisplayToolStripMenuItem.Text = "Display";
            // 
            // DisplayInPictureBox1ToolStripMenuItem
            // 
            DisplayInPictureBox1ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DisplayInPictureBox1ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DisplayInPictureBox1ToolStripMenuItem.Name = "DisplayInPictureBox1ToolStripMenuItem";
            DisplayInPictureBox1ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            DisplayInPictureBox1ToolStripMenuItem.Text = "Display in picturebox 1";
            DisplayInPictureBox1ToolStripMenuItem.Click += DisplayInPictureBox1ToolStripMenuItem_Click;
            // 
            // DisplayInPictureBox2ToolStripMenuItem
            // 
            DisplayInPictureBox2ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DisplayInPictureBox2ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DisplayInPictureBox2ToolStripMenuItem.Name = "DisplayInPictureBox2ToolStripMenuItem";
            DisplayInPictureBox2ToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            DisplayInPictureBox2ToolStripMenuItem.Text = "Display in picturebox 2";
            DisplayInPictureBox2ToolStripMenuItem.Click += DisplayInPictureBox2ToolStripMenuItem_Click;
            // 
            // SelectShadersToolStripMenuItem
            // 
            SelectShadersToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            SelectShadersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { SetScaleToolStripMenuItem, downScaleToolStripMenuItem, UpscaleUsingLanczosToolStripMenuItem, UpscaleUsingBicubicToolStripMenuItem, UpscaleUsingFSRCNNToolStripMenuItem, UpscaleUsingLapSRNToolStripMenuItem, UpscaleUsingEDSRToolStripMenuItem });
            SelectShadersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            SelectShadersToolStripMenuItem.Name = "SelectShadersToolStripMenuItem";
            SelectShadersToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            SelectShadersToolStripMenuItem.Text = "Select scale and algorithm";
            // 
            // SetScaleToolStripMenuItem
            // 
            SetScaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            SetScaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ScaleX2ToolStripMenuItem, ScaleX4ToolStripMenuItem });
            SetScaleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            SetScaleToolStripMenuItem.Name = "SetScaleToolStripMenuItem";
            SetScaleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            SetScaleToolStripMenuItem.Text = "Set ScaleEnum";
            // 
            // ScaleX2ToolStripMenuItem
            // 
            ScaleX2ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            ScaleX2ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            ScaleX2ToolStripMenuItem.Name = "ScaleX2ToolStripMenuItem";
            ScaleX2ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            ScaleX2ToolStripMenuItem.Text = "x2";
            ScaleX2ToolStripMenuItem.Click += ScaleX2ToolStripMenuItem_Click;
            // 
            // ScaleX4ToolStripMenuItem
            // 
            ScaleX4ToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            ScaleX4ToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            ScaleX4ToolStripMenuItem.Name = "ScaleX4ToolStripMenuItem";
            ScaleX4ToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            ScaleX4ToolStripMenuItem.Text = "x4";
            ScaleX4ToolStripMenuItem.Click += ScaleX4ToolStripMenuItem_Click;
            // 
            // downScaleToolStripMenuItem
            // 
            downScaleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            downScaleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            downScaleToolStripMenuItem.Name = "downScaleToolStripMenuItem";
            downScaleToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            downScaleToolStripMenuItem.Text = "DownScale";
            downScaleToolStripMenuItem.Click += downScaleToolStripMenuItem_Click;
            // 
            // UpscaleUsingLanczosToolStripMenuItem
            // 
            UpscaleUsingLanczosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            UpscaleUsingLanczosToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            UpscaleUsingLanczosToolStripMenuItem.Name = "UpscaleUsingLanczosToolStripMenuItem";
            UpscaleUsingLanczosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            UpscaleUsingLanczosToolStripMenuItem.Text = "Upscale using Lanczos";
            UpscaleUsingLanczosToolStripMenuItem.Click += UpscaleUsingLanczosToolStripMenuItem_Click;
            // 
            // UpscaleUsingBicubicToolStripMenuItem
            // 
            UpscaleUsingBicubicToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            UpscaleUsingBicubicToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            UpscaleUsingBicubicToolStripMenuItem.Name = "UpscaleUsingBicubicToolStripMenuItem";
            UpscaleUsingBicubicToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            UpscaleUsingBicubicToolStripMenuItem.Text = "Upscale using Bicubic";
            UpscaleUsingBicubicToolStripMenuItem.Click += UpscaleUsingBicubicToolStripMenuItem_Click;
            // 
            // UpscaleUsingFSRCNNToolStripMenuItem
            // 
            UpscaleUsingFSRCNNToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            UpscaleUsingFSRCNNToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            UpscaleUsingFSRCNNToolStripMenuItem.Name = "UpscaleUsingFSRCNNToolStripMenuItem";
            UpscaleUsingFSRCNNToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            UpscaleUsingFSRCNNToolStripMenuItem.Text = "Upscale using FSRCNN";
            UpscaleUsingFSRCNNToolStripMenuItem.Click += UpscaleUsingFSRCNNToolStripMenuItem_Click;
            // 
            // UpscaleUsingLapSRNToolStripMenuItem
            // 
            UpscaleUsingLapSRNToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            UpscaleUsingLapSRNToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            UpscaleUsingLapSRNToolStripMenuItem.Name = "UpscaleUsingLapSRNToolStripMenuItem";
            UpscaleUsingLapSRNToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            UpscaleUsingLapSRNToolStripMenuItem.Text = "Upscale using LapSRN";
            UpscaleUsingLapSRNToolStripMenuItem.Click += UpscaleUsingLapSRNToolStripMenuItem_Click;
            // 
            // UpscaleUsingEDSRToolStripMenuItem
            // 
            UpscaleUsingEDSRToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            UpscaleUsingEDSRToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            UpscaleUsingEDSRToolStripMenuItem.Name = "UpscaleUsingEDSRToolStripMenuItem";
            UpscaleUsingEDSRToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            UpscaleUsingEDSRToolStripMenuItem.Text = "Upscale using EDSR";
            UpscaleUsingEDSRToolStripMenuItem.Click += UpscaleUsingEDSRToolStripMenuItem_Click;
            // 
            // ConvertToolStripMenuItem
            // 
            ConvertToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            ConvertToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            ConvertToolStripMenuItem.Name = "ConvertToolStripMenuItem";
            ConvertToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            ConvertToolStripMenuItem.Text = "ConvertTo";
            ConvertToolStripMenuItem.Click += ConvertToolStripMenuItem_Click;
            // 
            // testToolStripMenuItem
            // 
            testToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { selectPNGToolStripMenuItem, selectJPGToolStripMenuItem });
            testToolStripMenuItem.Name = "testToolStripMenuItem";
            testToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            testToolStripMenuItem.Text = "Test";
            testToolStripMenuItem.Click += testToolStripMenuItem_Click;
            // 
            // selectPNGToolStripMenuItem
            // 
            selectPNGToolStripMenuItem.Name = "selectPNGToolStripMenuItem";
            selectPNGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            selectPNGToolStripMenuItem.Text = "Select PNG";
            selectPNGToolStripMenuItem.Click += selectPNGToolStripMenuItem_Click;
            // 
            // selectJPGToolStripMenuItem
            // 
            selectJPGToolStripMenuItem.Name = "selectJPGToolStripMenuItem";
            selectJPGToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            selectJPGToolStripMenuItem.Text = "Select JPG";
            selectJPGToolStripMenuItem.Click += selectJPGToolStripMenuItem_Click;
            // 
            // HelpToolStripMenuItem
            // 
            HelpToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ToolStripSeparator, AboutToolStripMenuItem });
            HelpToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            HelpToolStripMenuItem.Text = "&Help";
            // 
            // ToolStripSeparator
            // 
            ToolStripSeparator.Name = "ToolStripSeparator";
            ToolStripSeparator.Size = new System.Drawing.Size(113, 6);
            // 
            // AboutToolStripMenuItem
            // 
            AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            AboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            AboutToolStripMenuItem.Text = "&About...";
            AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
            // 
            // DifferenceAnalyserToolStripMenuItem
            // 
            DifferenceAnalyserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DifferenceAnalyserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ComparePixelValuesToolStripMenuItem, ComputeImageMetricsToolStripMenuItem, KeyMatchingToolStripMenuItem });
            DifferenceAnalyserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DifferenceAnalyserToolStripMenuItem.Name = "DifferenceAnalyserToolStripMenuItem";
            DifferenceAnalyserToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            DifferenceAnalyserToolStripMenuItem.Text = "Difference Analyser";
            // 
            // ComparePixelValuesToolStripMenuItem
            // 
            ComparePixelValuesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            ComparePixelValuesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            ComparePixelValuesToolStripMenuItem.Name = "ComparePixelValuesToolStripMenuItem";
            ComparePixelValuesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            ComparePixelValuesToolStripMenuItem.Text = "Compare Pixel Values";
            ComparePixelValuesToolStripMenuItem.Click += ComparePixelValuesToolStripMenuItem_Click;
            // 
            // ComputeImageMetricsToolStripMenuItem
            // 
            ComputeImageMetricsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            ComputeImageMetricsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            ComputeImageMetricsToolStripMenuItem.Name = "ComputeImageMetricsToolStripMenuItem";
            ComputeImageMetricsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            ComputeImageMetricsToolStripMenuItem.Text = "Compute Image Metrics";
            ComputeImageMetricsToolStripMenuItem.Click += ComputeImageMetricsToolStripMenuItem_Click;
            // 
            // KeyMatchingToolStripMenuItem
            // 
            KeyMatchingToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            KeyMatchingToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            KeyMatchingToolStripMenuItem.Name = "KeyMatchingToolStripMenuItem";
            KeyMatchingToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            KeyMatchingToolStripMenuItem.Text = "Key Matching";
            KeyMatchingToolStripMenuItem.Click += KeyMatchingToolStripMenuItem_Click;
            // 
            // QualityAnalyserToolStripMenuItem
            // 
            QualityAnalyserToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            QualityAnalyserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { DetermineUsingPSNRToolStripMenuItem, DetermineUsingSSIMToolStripMenuItem, DetermineUsingMSEToolStripMenuItem, DetermineUsingBRISQUEToolStripMenuItem, DetermineUsingVGGToolStripMenuItem, DetermineUsingBIQAToolStripMenuItem, DetermineUsingFeatureExtractionToolStripMenuItem });
            QualityAnalyserToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            QualityAnalyserToolStripMenuItem.Name = "QualityAnalyserToolStripMenuItem";
            QualityAnalyserToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            QualityAnalyserToolStripMenuItem.Text = "Quality Analyser";
            // 
            // DetermineUsingPSNRToolStripMenuItem
            // 
            DetermineUsingPSNRToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DetermineUsingPSNRToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DetermineUsingPSNRToolStripMenuItem.Name = "DetermineUsingPSNRToolStripMenuItem";
            DetermineUsingPSNRToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            DetermineUsingPSNRToolStripMenuItem.Text = "Determine Using PSNR";
            DetermineUsingPSNRToolStripMenuItem.Click += DetermineUsingPSNRToolStripMenuItem_Click;
            // 
            // DetermineUsingSSIMToolStripMenuItem
            // 
            DetermineUsingSSIMToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DetermineUsingSSIMToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DetermineUsingSSIMToolStripMenuItem.Name = "DetermineUsingSSIMToolStripMenuItem";
            DetermineUsingSSIMToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            DetermineUsingSSIMToolStripMenuItem.Text = "Determine Using SSIM";
            DetermineUsingSSIMToolStripMenuItem.Click += DetermineUsingSSIMToolStripMenuItem_Click;
            // 
            // DetermineUsingMSEToolStripMenuItem
            // 
            DetermineUsingMSEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DetermineUsingMSEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DetermineUsingMSEToolStripMenuItem.Name = "DetermineUsingMSEToolStripMenuItem";
            DetermineUsingMSEToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            DetermineUsingMSEToolStripMenuItem.Text = "Determine Using MSE";
            DetermineUsingMSEToolStripMenuItem.Click += DetermineUsingMSEToolStripMenuItem_Click;
            // 
            // DetermineUsingBRISQUEToolStripMenuItem
            // 
            DetermineUsingBRISQUEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DetermineUsingBRISQUEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DetermineUsingBRISQUEToolStripMenuItem.Name = "DetermineUsingBRISQUEToolStripMenuItem";
            DetermineUsingBRISQUEToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            DetermineUsingBRISQUEToolStripMenuItem.Text = "Determine Using BRISQUE";
            DetermineUsingBRISQUEToolStripMenuItem.Click += DetermineUsingBRISQUEToolStripMenuItem_Click;
            // 
            // DetermineUsingVGGToolStripMenuItem
            // 
            DetermineUsingVGGToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DetermineUsingVGGToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DetermineUsingVGGToolStripMenuItem.Name = "DetermineUsingVGGToolStripMenuItem";
            DetermineUsingVGGToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            DetermineUsingVGGToolStripMenuItem.Text = "Determine Using VGG";
            DetermineUsingVGGToolStripMenuItem.Click += DetermineUsingVGGToolStripMenuItem_Click;
            // 
            // DetermineUsingBIQAToolStripMenuItem
            // 
            DetermineUsingBIQAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DetermineUsingBIQAToolStripMenuItem.Enabled = false;
            DetermineUsingBIQAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DetermineUsingBIQAToolStripMenuItem.Name = "DetermineUsingBIQAToolStripMenuItem";
            DetermineUsingBIQAToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            DetermineUsingBIQAToolStripMenuItem.Text = "Determine Using BIQA";
            DetermineUsingBIQAToolStripMenuItem.Click += DetermineUsingBIQAToolStripMenuItem_Click;
            // 
            // DetermineUsingFeatureExtractionToolStripMenuItem
            // 
            DetermineUsingFeatureExtractionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(41, 44, 52);
            DetermineUsingFeatureExtractionToolStripMenuItem.Enabled = false;
            DetermineUsingFeatureExtractionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            DetermineUsingFeatureExtractionToolStripMenuItem.Name = "DetermineUsingFeatureExtractionToolStripMenuItem";
            DetermineUsingFeatureExtractionToolStripMenuItem.Size = new System.Drawing.Size(260, 22);
            DetermineUsingFeatureExtractionToolStripMenuItem.Text = "Determine Using Feature Extraction";
            DetermineUsingFeatureExtractionToolStripMenuItem.Click += DetermineUsingFeatureExtractionToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new System.Drawing.Point(5, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(864, 486);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new System.Drawing.Point(875, 27);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(864, 486);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // PixelValuesPictureBox1
            // 
            PixelValuesPictureBox1.AutoSize = true;
            PixelValuesPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PixelValuesPictureBox1.Location = new System.Drawing.Point(5, 530);
            PixelValuesPictureBox1.Name = "PixelValuesPictureBox1";
            PixelValuesPictureBox1.Size = new System.Drawing.Size(138, 15);
            PixelValuesPictureBox1.TabIndex = 5;
            PixelValuesPictureBox1.Text = "Amount of pixel values : ";
            // 
            // PixelValuesPictureBox2
            // 
            PixelValuesPictureBox2.AutoSize = true;
            PixelValuesPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PixelValuesPictureBox2.Location = new System.Drawing.Point(875, 530);
            PixelValuesPictureBox2.Name = "PixelValuesPictureBox2";
            PixelValuesPictureBox2.Size = new System.Drawing.Size(138, 15);
            PixelValuesPictureBox2.TabIndex = 6;
            PixelValuesPictureBox2.Text = "Amount of pixel values : ";
            // 
            // PixelValuesResultPictureBox1
            // 
            PixelValuesResultPictureBox1.AutoSize = true;
            PixelValuesResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PixelValuesResultPictureBox1.Location = new System.Drawing.Point(268, 530);
            PixelValuesResultPictureBox1.Name = "PixelValuesResultPictureBox1";
            PixelValuesResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            PixelValuesResultPictureBox1.TabIndex = 7;
            PixelValuesResultPictureBox1.Text = "Result...";
            // 
            // PixelValuesResultPictureBox2
            // 
            PixelValuesResultPictureBox2.AutoSize = true;
            PixelValuesResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PixelValuesResultPictureBox2.Location = new System.Drawing.Point(1138, 530);
            PixelValuesResultPictureBox2.Name = "PixelValuesResultPictureBox2";
            PixelValuesResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            PixelValuesResultPictureBox2.TabIndex = 8;
            PixelValuesResultPictureBox2.Text = "Result...";
            // 
            // PixelValueDifferencePictureBox1
            // 
            PixelValueDifferencePictureBox1.AutoSize = true;
            PixelValueDifferencePictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PixelValueDifferencePictureBox1.Location = new System.Drawing.Point(5, 550);
            PixelValueDifferencePictureBox1.Name = "PixelValueDifferencePictureBox1";
            PixelValueDifferencePictureBox1.Size = new System.Drawing.Size(250, 15);
            PixelValueDifferencePictureBox1.TabIndex = 9;
            PixelValueDifferencePictureBox1.Text = "Pixel value difference between picture boxes : ";
            // 
            // PixelValueDifferenceResultPictureBox1
            // 
            PixelValueDifferenceResultPictureBox1.AutoSize = true;
            PixelValueDifferenceResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PixelValueDifferenceResultPictureBox1.Location = new System.Drawing.Point(268, 550);
            PixelValueDifferenceResultPictureBox1.Name = "PixelValueDifferenceResultPictureBox1";
            PixelValueDifferenceResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            PixelValueDifferenceResultPictureBox1.TabIndex = 10;
            PixelValueDifferenceResultPictureBox1.Text = "Result...";
            // 
            // PixelValueDifferencePictureBox2
            // 
            PixelValueDifferencePictureBox2.AutoSize = true;
            PixelValueDifferencePictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PixelValueDifferencePictureBox2.Location = new System.Drawing.Point(875, 550);
            PixelValueDifferencePictureBox2.Name = "PixelValueDifferencePictureBox2";
            PixelValueDifferencePictureBox2.Size = new System.Drawing.Size(250, 15);
            PixelValueDifferencePictureBox2.TabIndex = 11;
            PixelValueDifferencePictureBox2.Text = "Pixel value difference between picture boxes : ";
            // 
            // PixelValueDifferenceResultPictureBox2
            // 
            PixelValueDifferenceResultPictureBox2.AutoSize = true;
            PixelValueDifferenceResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PixelValueDifferenceResultPictureBox2.Location = new System.Drawing.Point(1138, 550);
            PixelValueDifferenceResultPictureBox2.Name = "PixelValueDifferenceResultPictureBox2";
            PixelValueDifferenceResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            PixelValueDifferenceResultPictureBox2.TabIndex = 12;
            PixelValueDifferenceResultPictureBox2.Text = "Result...";
            // 
            // MeanSquaredErrorPictureBox1
            // 
            MeanSquaredErrorPictureBox1.AutoSize = true;
            MeanSquaredErrorPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MeanSquaredErrorPictureBox1.Location = new System.Drawing.Point(5, 570);
            MeanSquaredErrorPictureBox1.Name = "MeanSquaredErrorPictureBox1";
            MeanSquaredErrorPictureBox1.Size = new System.Drawing.Size(120, 15);
            MeanSquaredErrorPictureBox1.TabIndex = 13;
            MeanSquaredErrorPictureBox1.Text = "Mean Squared Error : ";
            // 
            // MeanSquaredErrorResultPictureBox1
            // 
            MeanSquaredErrorResultPictureBox1.AutoSize = true;
            MeanSquaredErrorResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MeanSquaredErrorResultPictureBox1.Location = new System.Drawing.Point(268, 570);
            MeanSquaredErrorResultPictureBox1.Name = "MeanSquaredErrorResultPictureBox1";
            MeanSquaredErrorResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            MeanSquaredErrorResultPictureBox1.TabIndex = 14;
            MeanSquaredErrorResultPictureBox1.Text = "Result...";
            // 
            // MeanSquaredErrorPictureBox2
            // 
            MeanSquaredErrorPictureBox2.AutoSize = true;
            MeanSquaredErrorPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MeanSquaredErrorPictureBox2.Location = new System.Drawing.Point(875, 570);
            MeanSquaredErrorPictureBox2.Name = "MeanSquaredErrorPictureBox2";
            MeanSquaredErrorPictureBox2.Size = new System.Drawing.Size(120, 15);
            MeanSquaredErrorPictureBox2.TabIndex = 15;
            MeanSquaredErrorPictureBox2.Text = "Mean Squared Error : ";
            // 
            // MeanSquaredErrorResultPictureBox2
            // 
            MeanSquaredErrorResultPictureBox2.AutoSize = true;
            MeanSquaredErrorResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MeanSquaredErrorResultPictureBox2.Location = new System.Drawing.Point(1138, 570);
            MeanSquaredErrorResultPictureBox2.Name = "MeanSquaredErrorResultPictureBox2";
            MeanSquaredErrorResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            MeanSquaredErrorResultPictureBox2.TabIndex = 16;
            MeanSquaredErrorResultPictureBox2.Text = "Result...";
            // 
            // PeakSignaltoNoiseRatioPictureBox1
            // 
            PeakSignaltoNoiseRatioPictureBox1.AutoSize = true;
            PeakSignaltoNoiseRatioPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PeakSignaltoNoiseRatioPictureBox1.Location = new System.Drawing.Point(5, 590);
            PeakSignaltoNoiseRatioPictureBox1.Name = "PeakSignaltoNoiseRatioPictureBox1";
            PeakSignaltoNoiseRatioPictureBox1.Size = new System.Drawing.Size(157, 15);
            PeakSignaltoNoiseRatioPictureBox1.TabIndex = 17;
            PeakSignaltoNoiseRatioPictureBox1.Text = "Peak Signal-to-Noise Ratio : ";
            // 
            // PeakSignaltoNoiseRatioResultPictureBox1
            // 
            PeakSignaltoNoiseRatioResultPictureBox1.AutoSize = true;
            PeakSignaltoNoiseRatioResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PeakSignaltoNoiseRatioResultPictureBox1.Location = new System.Drawing.Point(268, 590);
            PeakSignaltoNoiseRatioResultPictureBox1.Name = "PeakSignaltoNoiseRatioResultPictureBox1";
            PeakSignaltoNoiseRatioResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            PeakSignaltoNoiseRatioResultPictureBox1.TabIndex = 18;
            PeakSignaltoNoiseRatioResultPictureBox1.Text = "Result...";
            // 
            // PeakSignaltoNoiseRatioPictureBox2
            // 
            PeakSignaltoNoiseRatioPictureBox2.AutoSize = true;
            PeakSignaltoNoiseRatioPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PeakSignaltoNoiseRatioPictureBox2.Location = new System.Drawing.Point(875, 590);
            PeakSignaltoNoiseRatioPictureBox2.Name = "PeakSignaltoNoiseRatioPictureBox2";
            PeakSignaltoNoiseRatioPictureBox2.Size = new System.Drawing.Size(157, 15);
            PeakSignaltoNoiseRatioPictureBox2.TabIndex = 19;
            PeakSignaltoNoiseRatioPictureBox2.Text = "Peak Signal-to-Noise Ratio : ";
            // 
            // PeakSignaltoNoiseRatioResultPictureBox2
            // 
            PeakSignaltoNoiseRatioResultPictureBox2.AutoSize = true;
            PeakSignaltoNoiseRatioResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PeakSignaltoNoiseRatioResultPictureBox2.Location = new System.Drawing.Point(1138, 590);
            PeakSignaltoNoiseRatioResultPictureBox2.Name = "PeakSignaltoNoiseRatioResultPictureBox2";
            PeakSignaltoNoiseRatioResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            PeakSignaltoNoiseRatioResultPictureBox2.TabIndex = 20;
            PeakSignaltoNoiseRatioResultPictureBox2.Text = "Result...";
            // 
            // StructuralSimilarityIndexPictureBox1
            // 
            StructuralSimilarityIndexPictureBox1.AutoSize = true;
            StructuralSimilarityIndexPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            StructuralSimilarityIndexPictureBox1.Location = new System.Drawing.Point(5, 610);
            StructuralSimilarityIndexPictureBox1.Name = "StructuralSimilarityIndexPictureBox1";
            StructuralSimilarityIndexPictureBox1.Size = new System.Drawing.Size(151, 15);
            StructuralSimilarityIndexPictureBox1.TabIndex = 21;
            StructuralSimilarityIndexPictureBox1.Text = "Structural Similarity Index : ";
            // 
            // StructuralSimilarityIndexResultPictureBox1
            // 
            StructuralSimilarityIndexResultPictureBox1.AutoSize = true;
            StructuralSimilarityIndexResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            StructuralSimilarityIndexResultPictureBox1.Location = new System.Drawing.Point(268, 610);
            StructuralSimilarityIndexResultPictureBox1.Name = "StructuralSimilarityIndexResultPictureBox1";
            StructuralSimilarityIndexResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            StructuralSimilarityIndexResultPictureBox1.TabIndex = 22;
            StructuralSimilarityIndexResultPictureBox1.Text = "Result...";
            // 
            // StructuralSimilarityIndexPictureBox2
            // 
            StructuralSimilarityIndexPictureBox2.AutoSize = true;
            StructuralSimilarityIndexPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            StructuralSimilarityIndexPictureBox2.Location = new System.Drawing.Point(875, 610);
            StructuralSimilarityIndexPictureBox2.Name = "StructuralSimilarityIndexPictureBox2";
            StructuralSimilarityIndexPictureBox2.Size = new System.Drawing.Size(151, 15);
            StructuralSimilarityIndexPictureBox2.TabIndex = 23;
            StructuralSimilarityIndexPictureBox2.Text = "Structural Similarity Index : ";
            // 
            // StructuralSimilarityIndexResultPictureBox2
            // 
            StructuralSimilarityIndexResultPictureBox2.AutoSize = true;
            StructuralSimilarityIndexResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            StructuralSimilarityIndexResultPictureBox2.Location = new System.Drawing.Point(1138, 610);
            StructuralSimilarityIndexResultPictureBox2.Name = "StructuralSimilarityIndexResultPictureBox2";
            StructuralSimilarityIndexResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            StructuralSimilarityIndexResultPictureBox2.TabIndex = 24;
            StructuralSimilarityIndexResultPictureBox2.Text = "Result...";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            Label1.Location = new System.Drawing.Point(695, 650);
            Label1.Name = "Label1";
            Label1.Size = new System.Drawing.Size(362, 15);
            Label1.TabIndex = 33;
            Label1.Text = "Determine image quality using various quality analysing algorithms";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            Label2.Location = new System.Drawing.Point(5, 690);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(132, 15);
            Label2.TabIndex = 34;
            Label2.Text = "Full reference method : ";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            Label3.Location = new System.Drawing.Point(5, 790);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(159, 15);
            Label3.TabIndex = 35;
            Label3.Text = "Reduced reference method : ";
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            Label4.Location = new System.Drawing.Point(5, 850);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(132, 15);
            Label4.TabIndex = 36;
            Label4.Text = "No Reference method : ";
            // 
            // PeakSignalToNoiseQualityPictureBox1
            // 
            PeakSignalToNoiseQualityPictureBox1.AutoSize = true;
            PeakSignalToNoiseQualityPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PeakSignalToNoiseQualityPictureBox1.Location = new System.Drawing.Point(5, 710);
            PeakSignalToNoiseQualityPictureBox1.Name = "PeakSignalToNoiseQualityPictureBox1";
            PeakSignalToNoiseQualityPictureBox1.Size = new System.Drawing.Size(127, 15);
            PeakSignalToNoiseQualityPictureBox1.TabIndex = 37;
            PeakSignalToNoiseQualityPictureBox1.Text = "Peak Signal-to-Noise : ";
            // 
            // PeakSignalToNoiseQualityResultPictureBox1
            // 
            PeakSignalToNoiseQualityResultPictureBox1.AutoSize = true;
            PeakSignalToNoiseQualityResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PeakSignalToNoiseQualityResultPictureBox1.Location = new System.Drawing.Point(268, 710);
            PeakSignalToNoiseQualityResultPictureBox1.Name = "PeakSignalToNoiseQualityResultPictureBox1";
            PeakSignalToNoiseQualityResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            PeakSignalToNoiseQualityResultPictureBox1.TabIndex = 38;
            PeakSignalToNoiseQualityResultPictureBox1.Text = "Result...";
            // 
            // PeakSignalToNoisePictureBox2
            // 
            PeakSignalToNoisePictureBox2.AutoSize = true;
            PeakSignalToNoisePictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PeakSignalToNoisePictureBox2.Location = new System.Drawing.Point(875, 710);
            PeakSignalToNoisePictureBox2.Name = "PeakSignalToNoisePictureBox2";
            PeakSignalToNoisePictureBox2.Size = new System.Drawing.Size(127, 15);
            PeakSignalToNoisePictureBox2.TabIndex = 39;
            PeakSignalToNoisePictureBox2.Text = "Peak Signal-to-Noise : ";
            // 
            // PeakSignalToNoiseQualityResultPictureBox2
            // 
            PeakSignalToNoiseQualityResultPictureBox2.AutoSize = true;
            PeakSignalToNoiseQualityResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            PeakSignalToNoiseQualityResultPictureBox2.Location = new System.Drawing.Point(1138, 710);
            PeakSignalToNoiseQualityResultPictureBox2.Name = "PeakSignalToNoiseQualityResultPictureBox2";
            PeakSignalToNoiseQualityResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            PeakSignalToNoiseQualityResultPictureBox2.TabIndex = 40;
            PeakSignalToNoiseQualityResultPictureBox2.Text = "Result...";
            // 
            // StructuralSimilarityQualityPictureBox1
            // 
            StructuralSimilarityQualityPictureBox1.AutoSize = true;
            StructuralSimilarityQualityPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            StructuralSimilarityQualityPictureBox1.Location = new System.Drawing.Point(5, 730);
            StructuralSimilarityQualityPictureBox1.Name = "StructuralSimilarityQualityPictureBox1";
            StructuralSimilarityQualityPictureBox1.Size = new System.Drawing.Size(151, 15);
            StructuralSimilarityQualityPictureBox1.TabIndex = 41;
            StructuralSimilarityQualityPictureBox1.Text = "Structural Similarity Index : ";
            // 
            // StructuralSimilarityIndexQualityResultPictureBox1
            // 
            StructuralSimilarityIndexQualityResultPictureBox1.AutoSize = true;
            StructuralSimilarityIndexQualityResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            StructuralSimilarityIndexQualityResultPictureBox1.Location = new System.Drawing.Point(268, 730);
            StructuralSimilarityIndexQualityResultPictureBox1.Name = "StructuralSimilarityIndexQualityResultPictureBox1";
            StructuralSimilarityIndexQualityResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            StructuralSimilarityIndexQualityResultPictureBox1.TabIndex = 42;
            StructuralSimilarityIndexQualityResultPictureBox1.Text = "Result...";
            // 
            // StructuralSimilarityQualityPictureBox2
            // 
            StructuralSimilarityQualityPictureBox2.AutoSize = true;
            StructuralSimilarityQualityPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            StructuralSimilarityQualityPictureBox2.Location = new System.Drawing.Point(875, 730);
            StructuralSimilarityQualityPictureBox2.Name = "StructuralSimilarityQualityPictureBox2";
            StructuralSimilarityQualityPictureBox2.Size = new System.Drawing.Size(151, 15);
            StructuralSimilarityQualityPictureBox2.TabIndex = 43;
            StructuralSimilarityQualityPictureBox2.Text = "Structural Similarity Index : ";
            // 
            // StructuralSimilarityIndexQualityResultPictureBox2
            // 
            StructuralSimilarityIndexQualityResultPictureBox2.AutoSize = true;
            StructuralSimilarityIndexQualityResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            StructuralSimilarityIndexQualityResultPictureBox2.Location = new System.Drawing.Point(1138, 730);
            StructuralSimilarityIndexQualityResultPictureBox2.Name = "StructuralSimilarityIndexQualityResultPictureBox2";
            StructuralSimilarityIndexQualityResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            StructuralSimilarityIndexQualityResultPictureBox2.TabIndex = 44;
            StructuralSimilarityIndexQualityResultPictureBox2.Text = "Result...";
            // 
            // MeanSquaredErrorQualityPictureBox1
            // 
            MeanSquaredErrorQualityPictureBox1.AutoSize = true;
            MeanSquaredErrorQualityPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MeanSquaredErrorQualityPictureBox1.Location = new System.Drawing.Point(5, 750);
            MeanSquaredErrorQualityPictureBox1.Name = "MeanSquaredErrorQualityPictureBox1";
            MeanSquaredErrorQualityPictureBox1.Size = new System.Drawing.Size(133, 15);
            MeanSquaredErrorQualityPictureBox1.TabIndex = 45;
            MeanSquaredErrorQualityPictureBox1.Text = "Mean Squared Quality : ";
            // 
            // MeanSquaredErrorQualityResultPictureBox1
            // 
            MeanSquaredErrorQualityResultPictureBox1.AutoSize = true;
            MeanSquaredErrorQualityResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MeanSquaredErrorQualityResultPictureBox1.Location = new System.Drawing.Point(268, 750);
            MeanSquaredErrorQualityResultPictureBox1.Name = "MeanSquaredErrorQualityResultPictureBox1";
            MeanSquaredErrorQualityResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            MeanSquaredErrorQualityResultPictureBox1.TabIndex = 46;
            MeanSquaredErrorQualityResultPictureBox1.Text = "Result...";
            // 
            // MeanSquaredErrorQualityPictureBox2
            // 
            MeanSquaredErrorQualityPictureBox2.AutoSize = true;
            MeanSquaredErrorQualityPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MeanSquaredErrorQualityPictureBox2.Location = new System.Drawing.Point(875, 750);
            MeanSquaredErrorQualityPictureBox2.Name = "MeanSquaredErrorQualityPictureBox2";
            MeanSquaredErrorQualityPictureBox2.Size = new System.Drawing.Size(120, 15);
            MeanSquaredErrorQualityPictureBox2.TabIndex = 47;
            MeanSquaredErrorQualityPictureBox2.Text = "Mean Squared Error : ";
            // 
            // MeanSquaredErrorQualityResultPictureBox2
            // 
            MeanSquaredErrorQualityResultPictureBox2.AutoSize = true;
            MeanSquaredErrorQualityResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            MeanSquaredErrorQualityResultPictureBox2.Location = new System.Drawing.Point(1138, 750);
            MeanSquaredErrorQualityResultPictureBox2.Name = "MeanSquaredErrorQualityResultPictureBox2";
            MeanSquaredErrorQualityResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            MeanSquaredErrorQualityResultPictureBox2.TabIndex = 48;
            MeanSquaredErrorQualityResultPictureBox2.Text = "Result...";
            // 
            // FeatureExtractionQualityPictureBox1
            // 
            FeatureExtractionQualityPictureBox1.AutoSize = true;
            FeatureExtractionQualityPictureBox1.Enabled = false;
            FeatureExtractionQualityPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            FeatureExtractionQualityPictureBox1.Location = new System.Drawing.Point(5, 980);
            FeatureExtractionQualityPictureBox1.Name = "FeatureExtractionQualityPictureBox1";
            FeatureExtractionQualityPictureBox1.Size = new System.Drawing.Size(111, 15);
            FeatureExtractionQualityPictureBox1.TabIndex = 49;
            FeatureExtractionQualityPictureBox1.Text = "Feature Extraction : ";
            FeatureExtractionQualityPictureBox1.Visible = false;
            // 
            // FeatureExtractionQualityResultPictureBox1
            // 
            FeatureExtractionQualityResultPictureBox1.AutoSize = true;
            FeatureExtractionQualityResultPictureBox1.Enabled = false;
            FeatureExtractionQualityResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            FeatureExtractionQualityResultPictureBox1.Location = new System.Drawing.Point(268, 980);
            FeatureExtractionQualityResultPictureBox1.Name = "FeatureExtractionQualityResultPictureBox1";
            FeatureExtractionQualityResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            FeatureExtractionQualityResultPictureBox1.TabIndex = 50;
            FeatureExtractionQualityResultPictureBox1.Text = "Result...";
            FeatureExtractionQualityResultPictureBox1.Visible = false;
            // 
            // FeatureExtractionQualityPictureBox2
            // 
            FeatureExtractionQualityPictureBox2.AutoSize = true;
            FeatureExtractionQualityPictureBox2.Enabled = false;
            FeatureExtractionQualityPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            FeatureExtractionQualityPictureBox2.Location = new System.Drawing.Point(875, 980);
            FeatureExtractionQualityPictureBox2.Name = "FeatureExtractionQualityPictureBox2";
            FeatureExtractionQualityPictureBox2.Size = new System.Drawing.Size(111, 15);
            FeatureExtractionQualityPictureBox2.TabIndex = 51;
            FeatureExtractionQualityPictureBox2.Text = "Feature Extraction : ";
            FeatureExtractionQualityPictureBox2.Visible = false;
            // 
            // FeatureExtractionQualityResultPictureBox2
            // 
            FeatureExtractionQualityResultPictureBox2.AutoSize = true;
            FeatureExtractionQualityResultPictureBox2.Enabled = false;
            FeatureExtractionQualityResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            FeatureExtractionQualityResultPictureBox2.Location = new System.Drawing.Point(1138, 980);
            FeatureExtractionQualityResultPictureBox2.Name = "FeatureExtractionQualityResultPictureBox2";
            FeatureExtractionQualityResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            FeatureExtractionQualityResultPictureBox2.TabIndex = 52;
            FeatureExtractionQualityResultPictureBox2.Text = "Result...";
            FeatureExtractionQualityResultPictureBox2.Visible = false;
            // 
            // BRISQUEQualityPictureBox1
            // 
            BRISQUEQualityPictureBox1.AutoSize = true;
            BRISQUEQualityPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            BRISQUEQualityPictureBox1.Location = new System.Drawing.Point(5, 870);
            BRISQUEQualityPictureBox1.Name = "BRISQUEQualityPictureBox1";
            BRISQUEQualityPictureBox1.Size = new System.Drawing.Size(210, 15);
            BRISQUEQualityPictureBox1.TabIndex = 53;
            BRISQUEQualityPictureBox1.Text = "Blind Image Spatial Quality Evaluator : ";
            // 
            // BRISQUEQualityResultPictureBox1
            // 
            BRISQUEQualityResultPictureBox1.AutoSize = true;
            BRISQUEQualityResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            BRISQUEQualityResultPictureBox1.Location = new System.Drawing.Point(268, 870);
            BRISQUEQualityResultPictureBox1.Name = "BRISQUEQualityResultPictureBox1";
            BRISQUEQualityResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            BRISQUEQualityResultPictureBox1.TabIndex = 54;
            BRISQUEQualityResultPictureBox1.Text = "Result...";
            // 
            // BRISQUEQualityPictureBox2
            // 
            BRISQUEQualityPictureBox2.AutoSize = true;
            BRISQUEQualityPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            BRISQUEQualityPictureBox2.Location = new System.Drawing.Point(875, 870);
            BRISQUEQualityPictureBox2.Name = "BRISQUEQualityPictureBox2";
            BRISQUEQualityPictureBox2.Size = new System.Drawing.Size(210, 15);
            BRISQUEQualityPictureBox2.TabIndex = 55;
            BRISQUEQualityPictureBox2.Text = "Blind Image Spatial Quality Evaluator : ";
            // 
            // BRISQUEQualityResultPictureBox2
            // 
            BRISQUEQualityResultPictureBox2.AutoSize = true;
            BRISQUEQualityResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            BRISQUEQualityResultPictureBox2.Location = new System.Drawing.Point(1138, 870);
            BRISQUEQualityResultPictureBox2.Name = "BRISQUEQualityResultPictureBox2";
            BRISQUEQualityResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            BRISQUEQualityResultPictureBox2.TabIndex = 56;
            BRISQUEQualityResultPictureBox2.Text = "Result...";
            // 
            // BIQAQualityPictureBox1
            // 
            BIQAQualityPictureBox1.AutoSize = true;
            BIQAQualityPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            BIQAQualityPictureBox1.Location = new System.Drawing.Point(5, 890);
            BIQAQualityPictureBox1.Name = "BIQAQualityPictureBox1";
            BIQAQualityPictureBox1.Size = new System.Drawing.Size(185, 15);
            BIQAQualityPictureBox1.TabIndex = 57;
            BIQAQualityPictureBox1.Text = "Blind Image Quality Assessment : ";
            // 
            // BIQAQualityResultPictureBox1
            // 
            BIQAQualityResultPictureBox1.AutoSize = true;
            BIQAQualityResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            BIQAQualityResultPictureBox1.Location = new System.Drawing.Point(268, 890);
            BIQAQualityResultPictureBox1.Name = "BIQAQualityResultPictureBox1";
            BIQAQualityResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            BIQAQualityResultPictureBox1.TabIndex = 58;
            BIQAQualityResultPictureBox1.Text = "Result...";
            // 
            // BIQAQualityPictureBox2
            // 
            BIQAQualityPictureBox2.AutoSize = true;
            BIQAQualityPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            BIQAQualityPictureBox2.Location = new System.Drawing.Point(875, 890);
            BIQAQualityPictureBox2.Name = "BIQAQualityPictureBox2";
            BIQAQualityPictureBox2.Size = new System.Drawing.Size(185, 15);
            BIQAQualityPictureBox2.TabIndex = 59;
            BIQAQualityPictureBox2.Text = "Blind Image Quality Assessment : ";
            // 
            // BIQAQualityResultPictureBox2
            // 
            BIQAQualityResultPictureBox2.AutoSize = true;
            BIQAQualityResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            BIQAQualityResultPictureBox2.Location = new System.Drawing.Point(1138, 890);
            BIQAQualityResultPictureBox2.Name = "BIQAQualityResultPictureBox2";
            BIQAQualityResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            BIQAQualityResultPictureBox2.TabIndex = 60;
            BIQAQualityResultPictureBox2.Text = "Result...";
            // 
            // VGGQualityPictureBox1
            // 
            VGGQualityPictureBox1.AutoSize = true;
            VGGQualityPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            VGGQualityPictureBox1.Location = new System.Drawing.Point(5, 810);
            VGGQualityPictureBox1.Name = "VGGQualityPictureBox1";
            VGGQualityPictureBox1.Size = new System.Drawing.Size(138, 15);
            VGGQualityPictureBox1.TabIndex = 61;
            VGGQualityPictureBox1.Text = "Visual Geometry Group : ";
            // 
            // VGGQualityResultPictureBox1
            // 
            VGGQualityResultPictureBox1.AutoSize = true;
            VGGQualityResultPictureBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            VGGQualityResultPictureBox1.Location = new System.Drawing.Point(268, 810);
            VGGQualityResultPictureBox1.Name = "VGGQualityResultPictureBox1";
            VGGQualityResultPictureBox1.Size = new System.Drawing.Size(48, 15);
            VGGQualityResultPictureBox1.TabIndex = 62;
            VGGQualityResultPictureBox1.Text = "Result...";
            // 
            // VGGQualityPictureBox2
            // 
            VGGQualityPictureBox2.AutoSize = true;
            VGGQualityPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            VGGQualityPictureBox2.Location = new System.Drawing.Point(875, 810);
            VGGQualityPictureBox2.Name = "VGGQualityPictureBox2";
            VGGQualityPictureBox2.Size = new System.Drawing.Size(138, 15);
            VGGQualityPictureBox2.TabIndex = 63;
            VGGQualityPictureBox2.Text = "Visual Geometry Group : ";
            // 
            // VGGQualityResultPictureBox2
            // 
            VGGQualityResultPictureBox2.AutoSize = true;
            VGGQualityResultPictureBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            VGGQualityResultPictureBox2.Location = new System.Drawing.Point(1138, 810);
            VGGQualityResultPictureBox2.Name = "VGGQualityResultPictureBox2";
            VGGQualityResultPictureBox2.Size = new System.Drawing.Size(48, 15);
            VGGQualityResultPictureBox2.TabIndex = 64;
            VGGQualityResultPictureBox2.Text = "Result...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.Color.FromArgb(41, 44, 51);
            ClientSize = new System.Drawing.Size(1793, 936);
            Controls.Add(VGGQualityResultPictureBox2);
            Controls.Add(VGGQualityPictureBox2);
            Controls.Add(VGGQualityResultPictureBox1);
            Controls.Add(VGGQualityPictureBox1);
            Controls.Add(BIQAQualityResultPictureBox2);
            Controls.Add(BIQAQualityPictureBox2);
            Controls.Add(BIQAQualityResultPictureBox1);
            Controls.Add(BIQAQualityPictureBox1);
            Controls.Add(BRISQUEQualityResultPictureBox2);
            Controls.Add(BRISQUEQualityPictureBox2);
            Controls.Add(BRISQUEQualityResultPictureBox1);
            Controls.Add(BRISQUEQualityPictureBox1);
            Controls.Add(FeatureExtractionQualityResultPictureBox2);
            Controls.Add(FeatureExtractionQualityPictureBox2);
            Controls.Add(FeatureExtractionQualityResultPictureBox1);
            Controls.Add(FeatureExtractionQualityPictureBox1);
            Controls.Add(MeanSquaredErrorQualityResultPictureBox2);
            Controls.Add(MeanSquaredErrorQualityPictureBox2);
            Controls.Add(MeanSquaredErrorQualityResultPictureBox1);
            Controls.Add(MeanSquaredErrorQualityPictureBox1);
            Controls.Add(StructuralSimilarityIndexQualityResultPictureBox2);
            Controls.Add(StructuralSimilarityQualityPictureBox2);
            Controls.Add(StructuralSimilarityIndexQualityResultPictureBox1);
            Controls.Add(StructuralSimilarityQualityPictureBox1);
            Controls.Add(PeakSignalToNoiseQualityResultPictureBox2);
            Controls.Add(PeakSignalToNoisePictureBox2);
            Controls.Add(PeakSignalToNoiseQualityResultPictureBox1);
            Controls.Add(PeakSignalToNoiseQualityPictureBox1);
            Controls.Add(Label4);
            Controls.Add(Label3);
            Controls.Add(Label2);
            Controls.Add(Label1);
            Controls.Add(StructuralSimilarityIndexResultPictureBox2);
            Controls.Add(StructuralSimilarityIndexPictureBox2);
            Controls.Add(StructuralSimilarityIndexResultPictureBox1);
            Controls.Add(StructuralSimilarityIndexPictureBox1);
            Controls.Add(PeakSignaltoNoiseRatioResultPictureBox2);
            Controls.Add(PeakSignaltoNoiseRatioPictureBox2);
            Controls.Add(PeakSignaltoNoiseRatioResultPictureBox1);
            Controls.Add(PeakSignaltoNoiseRatioPictureBox1);
            Controls.Add(MeanSquaredErrorResultPictureBox2);
            Controls.Add(MeanSquaredErrorPictureBox2);
            Controls.Add(MeanSquaredErrorResultPictureBox1);
            Controls.Add(MeanSquaredErrorPictureBox1);
            Controls.Add(PixelValueDifferenceResultPictureBox2);
            Controls.Add(PixelValueDifferencePictureBox2);
            Controls.Add(PixelValueDifferenceResultPictureBox1);
            Controls.Add(PixelValueDifferencePictureBox1);
            Controls.Add(PixelValuesResultPictureBox2);
            Controls.Add(PixelValuesResultPictureBox1);
            Controls.Add(PixelValuesPictureBox2);
            Controls.Add(PixelValuesPictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(MenuStrip);
            ForeColor = System.Drawing.Color.White;
            Name = "Form1";
            Text = "Image upscaling and quality assessment application";
            MenuStrip.ResumeLayout(false);
            MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem ActionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DifferenceAnalyserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem computeImageMetricsToolStripMenuItem;
        public System.Windows.Forms.Label PixelValuesPictureBox1;
        public System.Windows.Forms.Label PixelValuesPictureBox2;
        public System.Windows.Forms.Label PixelValuesResultPictureBox1;
        public System.Windows.Forms.Label PixelValuesResultPictureBox2;
        public System.Windows.Forms.Label PixelValueDifferencePictureBox1;
        public System.Windows.Forms.Label PixelValueDifferenceResultPictureBox1;
        public System.Windows.Forms.Label PixelValueDifferencePictureBox2;
        public System.Windows.Forms.Label PixelValueDifferenceResultPictureBox2;
        public System.Windows.Forms.Label MeanSquaredErrorPictureBox1;
        public System.Windows.Forms.Label MeanSquaredErrorResultPictureBox1;
        public System.Windows.Forms.Label MeanSquaredErrorPictureBox2;
        public System.Windows.Forms.Label MeanSquaredErrorResultPictureBox2;
        public System.Windows.Forms.Label PeakSignaltoNoiseRatioPictureBox1;
        public System.Windows.Forms.Label PeakSignaltoNoiseRatioResultPictureBox1;
        public System.Windows.Forms.Label PeakSignaltoNoiseRatioPictureBox2;
        public System.Windows.Forms.Label PeakSignaltoNoiseRatioResultPictureBox2;
        public System.Windows.Forms.Label StructuralSimilarityIndexPictureBox1;
        public System.Windows.Forms.Label StructuralSimilarityIndexResultPictureBox1;
        public System.Windows.Forms.Label StructuralSimilarityIndexPictureBox2;
        public System.Windows.Forms.Label StructuralSimilarityIndexResultPictureBox2;
        private System.Windows.Forms.ToolStripMenuItem keyMatchingToolStripMenuItems;
        private System.Windows.Forms.ToolStripMenuItem ComparePixelValuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ComputeImageMetricsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeyMatchingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QualityAnalyserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetermineUsingPSNRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetermineUsingSSIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetermineUsingMSEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetermineUsingFeatureExtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetermineUsingBRISQUEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetermineUsingBIQAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DetermineUsingVGGToolStripMenuItem;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Label PeakSignalToNoiseQualityPictureBox1;
        public System.Windows.Forms.Label PeakSignalToNoiseQualityResultPictureBox1;
        public System.Windows.Forms.Label PeakSignalToNoisePictureBox2;
        public System.Windows.Forms.Label PeakSignalToNoiseQualityResultPictureBox2;
        public System.Windows.Forms.Label StructuralSimilarityQualityPictureBox1;
        public System.Windows.Forms.Label StructuralSimilarityIndexQualityResultPictureBox1;
        public System.Windows.Forms.Label StructuralSimilarityQualityPictureBox2;
        public System.Windows.Forms.Label StructuralSimilarityIndexQualityResultPictureBox2;
        public System.Windows.Forms.Label MeanSquaredErrorQualityPictureBox1;
        public System.Windows.Forms.Label MeanSquaredErrorQualityResultPictureBox1;
        public System.Windows.Forms.Label MeanSquaredErrorQualityPictureBox2;
        public System.Windows.Forms.Label MeanSquaredErrorQualityResultPictureBox2;
        public System.Windows.Forms.Label FeatureExtractionQualityPictureBox1;
        public System.Windows.Forms.Label FeatureExtractionQualityResultPictureBox1;
        public System.Windows.Forms.Label FeatureExtractionQualityPictureBox2;
        public System.Windows.Forms.Label FeatureExtractionQualityResultPictureBox2;
        public System.Windows.Forms.Label BRISQUEQualityPictureBox1;
        public System.Windows.Forms.Label BRISQUEQualityResultPictureBox1;
        public System.Windows.Forms.Label BRISQUEQualityPictureBox2;
        public System.Windows.Forms.Label BRISQUEQualityResultPictureBox2;
        public System.Windows.Forms.Label BIQAQualityPictureBox1;
        public System.Windows.Forms.Label BIQAQualityResultPictureBox1;
        public System.Windows.Forms.Label BIQAQualityPictureBox2;
        public System.Windows.Forms.Label BIQAQualityResultPictureBox2;
        public System.Windows.Forms.Label VGGQualityPictureBox1;
        public System.Windows.Forms.Label VGGQualityResultPictureBox1;
        public System.Windows.Forms.Label VGGQualityPictureBox2;
        public System.Windows.Forms.Label VGGQualityResultPictureBox2;
        private System.Windows.Forms.ToolStripMenuItem SelectShadersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayInPictureBox1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DisplayInPictureBox2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpscaleUsingFSRCNNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SetScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScaleX2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScaleX4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpscaleUsingLanczosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpscaleUsingBicubicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpscaleUsingLapSRNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpscaleUsingEDSRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectLowQualityImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectReferenceImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem downScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ConvertToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectPNGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectJPGToolStripMenuItem;
    }
}

