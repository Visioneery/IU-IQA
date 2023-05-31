using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Dnn;
using OpenCvSharp.Extensions;
using OpenCvSharp.Features2D;
using OpenCvSharp.Quality;

namespace UpscalingAndQualityAssessmentForm.Analyzers
{
    public class QualityAnalyzer
    {
        private readonly Form1 _form;
        private string _modelsFolderPath;

        public QualityAnalyzer(Form1 form)
        {
            _form = form;
            _modelsFolderPath =
                Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName,
                    "models");
        }

        public void DetermineQualityUsingPSNR()
        {
            var psnrScore1 = _form.PeakSignaltoNoiseRatioResultPictureBox1.Text;
            var psnrValues1 = psnrScore1.Replace("[", "").Replace("]", "").Replace(" ", "").Split(',').ToList();
            psnrValues1.RemoveAt(psnrValues1.Count - 1);
            var psnrValues1Int = psnrValues1.Select(double.Parse).ToList();

            var psnrScore2 = _form.PeakSignaltoNoiseRatioResultPictureBox2.Text;
            var psnrValues2 = psnrScore2.Replace("[", "").Replace("]", "").Replace(" ", "").Split(',').ToList();
            psnrValues2.RemoveAt(psnrValues2.Count - 1);
            var psnrValues2Int = psnrValues2.Select(double.Parse).ToList();

            var psnrResult = new List<double>();

            for (var i = 0; i < 3; i++)
            {
                var result = psnrValues1Int[i] - psnrValues2Int[i];
                psnrResult.Add(result);
            }

            var negativeCount = psnrResult.Count(n => n < 0);
            var positiveCount = psnrResult.Count(n => n > 0);


            //Compare the PSNR scores
            if (negativeCount > positiveCount)
            {
                // distortedImage is of higher quality than refImage
                _form.PeakSignalToNoiseQualityResultPictureBox1.Text = "-";
                _form.PeakSignalToNoiseQualityResultPictureBox2.Text = "+";

            }
            else
            {
                // refImage is of higher quality than distortedImage
                _form.PeakSignalToNoiseQualityResultPictureBox1.Text = "+";
                _form.PeakSignalToNoiseQualityResultPictureBox2.Text = "-";
            }
        }

        public void DetermineQualityUsingSSIM()
        {
            var ssimScore1 = _form.StructuralSimilarityIndexResultPictureBox1.Text;
            var ssimValues1 = ssimScore1.Replace("[", "").Replace("]", "").Replace(" ", "").Split(',').ToList();
            ssimValues1.RemoveAt(ssimValues1.Count - 1);
            var ssimValues1Int = ssimValues1.Select(double.Parse).ToList();

            var ssimScore2 = _form.StructuralSimilarityIndexResultPictureBox2.Text;
            var ssimValues2 = ssimScore2.Replace("[", "").Replace("]", "").Replace(" ", "").Split(',').ToList();
            ssimValues2.RemoveAt(ssimValues2.Count - 1);
            var ssimValues2Int = ssimValues2.Select(double.Parse).ToList();

            var ssimResult = new List<double>();

            for (var i = 0; i < 3; i++)
            {
                var result = ssimValues1Int[i] - ssimValues2Int[i];
                ssimResult.Add(result);
            }

            var negativeCount = ssimResult.Count(n => n < 0);
            var positiveCount = ssimResult.Count(n => n > 0);

            // Compare the SSIM scores
            if (negativeCount > positiveCount) // score taken based on bilinear
            {
                // distortedImage is of higher quality than refImage
                _form.StructuralSimilarityIndexQualityResultPictureBox1.Text = "-";
                _form.StructuralSimilarityIndexQualityResultPictureBox2.Text = "+";
            }
            else
            {
                // refImage is of higher quality than distortedImage
                _form.StructuralSimilarityIndexQualityResultPictureBox1.Text = "+";
                _form.StructuralSimilarityIndexQualityResultPictureBox2.Text = "-";
            }
        }

        public void DetermineQualityUsingMSE()
        {
            var mseScore1 = _form.MeanSquaredErrorResultPictureBox1.Text;
            var mseValues1 = mseScore1.Replace("[", "").Replace("]", "").Replace(" ", "").Split(',').ToList();
            mseValues1.RemoveAt(mseValues1.Count - 1);
            var mseValues1Int = mseValues1.Select(double.Parse).ToList();

            var mseScore2 = _form.MeanSquaredErrorResultPictureBox2.Text;
            var mseValues2 = mseScore2.Replace("[", "").Replace("]", "").Replace(" ", "").Split(',').ToList();
            mseValues2.RemoveAt(mseValues2.Count - 1);
            var mseValues2Int = mseValues2.Select(double.Parse).ToList();

            var mseResult = new List<double>();

            for (var i = 0; i < 3; i++)
            {
                var result = mseValues1Int[i] - mseValues2Int[i];
                mseResult.Add(result);
            }

            var negativeCount = mseResult.Count(n => n < 0);
            var positiveCount = mseResult.Count(n => n > 0);

            // Compare the MSE scores
            if (negativeCount < positiveCount)
            {
                // distortedImage is of higher quality than refImage
                _form.MeanSquaredErrorQualityResultPictureBox1.Text = "-";
                _form.MeanSquaredErrorQualityResultPictureBox2.Text = "+";
            }
            else
            {
                // refImage is of higher quality than distortedImage
                _form.MeanSquaredErrorQualityResultPictureBox1.Text = "+";
                _form.MeanSquaredErrorQualityResultPictureBox2.Text = "_";
            }
        }

        public void DetermineQualityUsingFeatureExtraction(PictureBox pictureBox1, PictureBox pictureBox2)
        {
            // Get the images from the picture boxes
            var bitmap1 = (Bitmap)pictureBox1.Image;
            var bitmap2 = (Bitmap)pictureBox2.Image;

            // Convert the images to OpenCV format
            var image1 = BitmapConverter.ToMat(bitmap1);
            var image2 = BitmapConverter.ToMat(bitmap2);

            // Extract features from reference image
            var refFeatures = ExtractFeatures(image1);

            // Extract features from distorted image
            var distortedFeatures = ExtractFeatures(image2);

            // Resize the features to a fixed size
            var newSize = new OpenCvSharp.Size(128, 128);
            var resizedRefFeatures = new Mat();
            Cv2.Resize(refFeatures, resizedRefFeatures, newSize);
            var resizedDistortedFeatures = new Mat();
            Cv2.Resize(distortedFeatures, resizedDistortedFeatures, newSize);

            // Compute distance between the two feature vectors
            var distance = Cv2.Norm(resizedRefFeatures, resizedDistortedFeatures, NormTypes.L2);

            // Normalize distance by the number of features
            var numFeatures = resizedRefFeatures.Rows * resizedRefFeatures.Cols;
            var normalizedDistance = distance / numFeatures;

            // Compute quality score from the normalized distance
            var qualityScore = Math.Exp(-normalizedDistance);

            // Compare the scores
            if (qualityScore < 0.77) // score taken based on bilinear
            {
                // distortedImage is of higher quality than refImage
                _form.FeatureExtractionQualityResultPictureBox1.Text = "-";
                _form.FeatureExtractionQualityResultPictureBox2.Text = "+";
            }
            else
            {
                // refImage is of higher quality than distortedImage
                _form.FeatureExtractionQualityResultPictureBox1.Text = "+";
                _form.FeatureExtractionQualityResultPictureBox2.Text = "-";
            }
        }

        private Mat ExtractFeatures(Mat image)
        {
            // Resize the image to a fixed size for feature extraction
            OpenCvSharp.Size newSize = new OpenCvSharp.Size(512, 512);
            Mat resizedImage = new Mat();
            Cv2.Resize(image, resizedImage, newSize);

            // Create a SIFT feature detector and extractor
            SIFT sift = SIFT.Create();

            // Detect and compute features in the resized image
            KeyPoint[] keypoints = sift.Detect(resizedImage);
            Mat descriptors = new Mat();
            sift.Compute(resizedImage, ref keypoints, descriptors);

            return descriptors;
        }

        public void DetermineQualityUsingBRISQUE(PictureBox pictureBox1, PictureBox pictureBox2)
        {
            // Get the images from the picture boxes
            var bitmap1 = (Bitmap)pictureBox1.Image;
            var bitmap2 = (Bitmap)pictureBox2.Image;

            // Convert the images to OpenCV format
            var image1 = BitmapConverter.ToMat(bitmap1);
            var image2 = BitmapConverter.ToMat(bitmap2);

            var image1InputArray = InputArray.Create(image1);
            var image2InputArray = InputArray.Create(image2);

            

            // Compute the BRISQUE score for each image
            var score1 = QualityBRISQUE.Compute(image1InputArray, $"{_modelsFolderPath}\\brisque_model_live.yml", $"{_modelsFolderPath}\\brisque_range_live.yml");
            var score2 = QualityBRISQUE.Compute(image2InputArray, $"{_modelsFolderPath}\\brisque_model_live.yml", $"{_modelsFolderPath}\\brisque_range_live.yml");

            // Compare the scores to determine which image has better quality
            if (score1.Val0 < score2.Val0)
            {
                _form.BRISQUEQualityResultPictureBox1.Text = "+";
                _form.BRISQUEQualityResultPictureBox2.Text = "-";
            }
            else if (score1.Val0 > score2.Val0)
            {
                _form.BRISQUEQualityResultPictureBox1.Text = "-";
                _form.BRISQUEQualityResultPictureBox2.Text = "+";
            }
            else
            {
                _form.BRISQUEQualityResultPictureBox1.Text = "+";
                _form.BRISQUEQualityResultPictureBox2.Text = "+";
            }
        }

        public Scalar DetermineQualityUsingBRISQUE(string upscaledImage)
        {
            var image = new Mat(upscaledImage);

            var image1InputArray = InputArray.Create(image);

            // Compute the BRISQUE score for each image
            var score1 = QualityBRISQUE.Compute(image1InputArray, $"{_modelsFolderPath}\\brisque_model_live.yml", $"{_modelsFolderPath}\\brisque_range_live.yml");

            return score1;
        }

        public double DetermineQualityUsingVGG(string upscaledImage, string referenceImagePath)
        {
            // Convert the images to OpenCV format
            var image = new Mat(upscaledImage);
            var referenceImage = new Mat(referenceImagePath);

            // Preprocess the images
            var inputBlob1 = CvDnn.BlobFromImage(image, 1.0, size: new OpenCvSharp.Size(224, 224), mean: new Scalar(104, 117, 123), swapRB: true, crop: false);
            var inputBlobReference = CvDnn.BlobFromImage(referenceImage, 1.0, size: new OpenCvSharp.Size(224, 224), mean: new Scalar(104, 117, 123), swapRB: true, crop: false);

            var modelPath = $"{_modelsFolderPath}\\VGG_ILSVRC_16_layers.caffemodel";
            var configPath = $"{_modelsFolderPath}\\VGG_ILSVRC_16_layers_deploy.prototxt";
            var _VggModel = CvDnn.ReadNetFromCaffe(configPath, modelPath);

            // Pass the images through the VGG-16 model to get their feature maps
            _VggModel.SetInput(inputBlob1);
            var features1 = new Mat[3];
            features1[0] = _VggModel.Forward("conv1_2");
            features1[1] = _VggModel.Forward("conv2_2");
            features1[2] = _VggModel.Forward("conv3_3");

            _VggModel.SetInput(inputBlobReference);
            var featuresReference = new Mat[3];
            featuresReference[0] = _VggModel.Forward("conv1_2");
            featuresReference[1] = _VggModel.Forward("conv2_2");
            featuresReference[2] = _VggModel.Forward("conv3_3");

            // Compute the distances between feature maps from different layers
            double image1Distance = 0;
            for (var i = 0; i < features1.Length; i++)
            {
                var distance1 = Cv2.Norm(featuresReference[i], features1[i], NormTypes.L2);
                image1Distance += distance1;
            }

            // Compute the average distance between feature maps from different layers
            var averageDistanceImage1 = image1Distance / features1.Length;

            return averageDistanceImage1;

        }

        public void DetermineQualityUsingVGG(PictureBox pictureBox1, PictureBox pictureBox2, string referenceImagePath)
        {
            // Get the images from the picture boxes
            var bitmap1 = (Bitmap)pictureBox1.Image;
            var bitmap2 = (Bitmap)pictureBox2.Image;

            // Convert the images to OpenCV format
            var image1 = BitmapConverter.ToMat(bitmap1);
            var image2 = BitmapConverter.ToMat(bitmap2);
            var referenceImage = Cv2.ImRead(referenceImagePath);

            // Preprocess the images
            var inputBlob1 = CvDnn.BlobFromImage(image1, 1.0, size: new OpenCvSharp.Size(224, 224), mean: new Scalar(104, 117, 123), swapRB: true, crop: false);
            var inputBlob2 = CvDnn.BlobFromImage(image2, 1.0, size: new OpenCvSharp.Size(224, 224), mean: new Scalar(104, 117, 123), swapRB: true, crop: false);
            var inputBlobReference = CvDnn.BlobFromImage(referenceImage, 1.0, size: new OpenCvSharp.Size(224, 224), mean: new Scalar(104, 117, 123), swapRB: true, crop: false);

            var modelPath = $"{_modelsFolderPath}\\VGG_ILSVRC_16_layers.caffemodel";
            var configPath = $"{_modelsFolderPath}\\VGG_ILSVRC_16_layers_deploy.prototxt";
            var _VggModel = CvDnn.ReadNetFromCaffe(configPath, modelPath);

            // Pass the images through the VGG-16 model to get their feature maps
            _VggModel.SetInput(inputBlob1);
            var features1 = new Mat[3];
            features1[0] = _VggModel.Forward("conv3_3");
            features1[1] = _VggModel.Forward("conv4_3");
            features1[2] = _VggModel.Forward("conv5_3");

            _VggModel.SetInput(inputBlob2);
            var features2 = new Mat[3];
            features2[0] = _VggModel.Forward("conv3_3");
            features2[1] = _VggModel.Forward("conv4_3");
            features2[2] = _VggModel.Forward("conv5_3");

            _VggModel.SetInput(inputBlobReference);
            var featuresReference = new Mat[3];
            featuresReference[0] = _VggModel.Forward("conv3_3");
            featuresReference[1] = _VggModel.Forward("conv4_3");
            featuresReference[2] = _VggModel.Forward("conv5_3");

            // Compute the distances between feature maps from different layers
            double image1Distance = 0;
            double image2Distance = 0;
            for (var i = 0; i < features1.Length; i++)
            {
                var distance1 = Cv2.Norm(featuresReference[i], features1[i], NormTypes.L2);
                image1Distance += distance1;
                var distance2 = Cv2.Norm(featuresReference[i], features2[i], NormTypes.L2);
                image2Distance += distance2;
            }

            // Compute the average distance between feature maps from different layers
            var averageDistanceImage1 = image1Distance / features1.Length;
            var averageDistanceImage2 = image2Distance / features2.Length;

            // Compare the distances to determine which image has better quality
            if (averageDistanceImage1 < averageDistanceImage2)
            {
                _form.VGGQualityResultPictureBox1.Text = "+";
                _form.VGGQualityResultPictureBox2.Text = "-";
            }
            else
            {
                _form.VGGQualityResultPictureBox1.Text = "-";
                _form.VGGQualityResultPictureBox2.Text = "+";
            }

            Cv2.WaitKey();
        }

        public void DetermineQualityUsingBIQA(PictureBox pictureBox1, PictureBox pictureBox2)
        {
            // Get the images from the picture boxes
            var bitmap1 = (Bitmap)pictureBox1.Image;
            var bitmap2 = (Bitmap)pictureBox2.Image;

            // Convert the images to OpenCV format
            var image1 = BitmapConverter.ToMat(bitmap1);
            var image2 = BitmapConverter.ToMat(bitmap2);

            // Extract the image features using OpenCV
            var features1 = ExtractFeaturesSobel(image1);
            var features2 = ExtractFeaturesSobel(image2);

            // Compute the BIQA scores for the images
            var score1 = ComputeBIQAScore(features1);
            var score2 = ComputeBIQAScore(features2);

            // Compare the scores to determine which image has better quality
            if (score1 > score2)
            {
                _form.BIQAQualityResultPictureBox1.Text = "+";
                _form.BIQAQualityResultPictureBox2.Text = "-";
            }
            else if (score1 < score2)
            {
                _form.BIQAQualityResultPictureBox1.Text = "-";
                _form.BIQAQualityResultPictureBox2.Text = "+";
            }
            else
            {
                _form.BIQAQualityResultPictureBox1.Text = "+";
                _form.BIQAQualityResultPictureBox2.Text = "+";
            }
        }

        private Mat ExtractFeaturesSobel(Mat image)
        {
            // Extract image features using OpenCV
            // Convert the image to grayscale
            var grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            // Compute image features using OpenCV
            var features = new Mat();
            Cv2.Sobel(grayImage, features, MatType.CV_32F, 1, 1);

            return features;
        }

        private double ComputeBIQAScore(Mat features)
        {
            // Compute the BIQA score for the image features
            var score = 0.0;
            for (var i = 0; i < features.Rows; i++)
            {
                for (var j = 0; j < features.Cols; j++)
                {
                    score += Math.Abs(features.At<float>(i, j));
                }
            }

            return score;
        }
    }
}
