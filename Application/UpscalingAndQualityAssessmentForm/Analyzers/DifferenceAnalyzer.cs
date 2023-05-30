using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;
using OpenCvSharp;
using OpenCvSharp.Extensions;
using OpenCvSharp.Quality;
using static System.Net.Mime.MediaTypeNames;

namespace UpscalingAndQualityAssessmentForm.Analyzers
{
    public class DifferenceAnalyzer
    {
        private readonly Form1 _form;

        public DifferenceAnalyzer(Form1 form)
        {
            _form = form;
        }

        public void ComparePixelValuesGreyScale(PictureBox pictureBox1, PictureBox pictureBox2)
        {
            // Get the images from the picture boxes
            var bitmap1 = (Bitmap)pictureBox1.Image;
            var bitmap2 = (Bitmap)pictureBox2.Image;

            // Convert the images to OpenCV format
            var image1 = bitmap1.ToMat();
            var image2 = bitmap2.ToMat();

            // Convert the images to gray-scale
            var grayImage1 = new Mat();
            var grayImage2 = new Mat();
            Cv2.CvtColor(image1, grayImage1, ColorConversionCodes.BGR2GRAY);
            Cv2.CvtColor(image2, grayImage2, ColorConversionCodes.BGR2GRAY);

            // Compare the pixel values of the two images
            var diffImage = new Mat();
            Cv2.Absdiff(grayImage1, grayImage2, diffImage);

            // Count the number of non-zero pixels in the difference image
            var numDifferentPixels = Cv2.CountNonZero(diffImage);

            // Display the number of different pixels

            _form.PixelValuesResultPictureBox1.Text = Cv2.CountNonZero(grayImage1).ToString();
            _form.PixelValuesResultPictureBox2.Text = Cv2.CountNonZero(grayImage2).ToString();

            _form.PixelValueDifferenceResultPictureBox1.Text = numDifferentPixels.ToString();
            _form.PixelValueDifferenceResultPictureBox2.Text = numDifferentPixels.ToString();
        }

        public void ComparePixelValuesColor(PictureBox pictureBox1, PictureBox pictureBox2, string referenceImagePath)
        {
            // Get the images from the picture boxes
            var bitmap1 = (Bitmap)pictureBox1.Image;
            var bitmap2 = (Bitmap)pictureBox2.Image;

            // Convert the images to OpenCV format
            var image1 = bitmap1.ToMat();
            var image2 = bitmap2.ToMat();
            var referenceImage = Cv2.ImRead(referenceImagePath);

            // Split the images into BGR channels
            var channels1 = Cv2.Split(referenceImage);
            var channels2 = Cv2.Split(image1);
            var channels3 = Cv2.Split(image2);

            // Compare the pixel values of the two images for each channel separately
            var numDifferentPixels = new int[3];
            for (var i = 0; i < 3; i++)
            {
                var diffImage = new Mat();
                Cv2.Absdiff(channels1[i], channels2[i], diffImage);
                numDifferentPixels[i] = Cv2.CountNonZero(diffImage);
            }

            var numDifferentPixels2 = new int[3];
            for (var i = 0; i < 3; i++)
            {
                var diffImage = new Mat();
                Cv2.Absdiff(channels1[i], channels3[i], diffImage);
                numDifferentPixels2[i] = Cv2.CountNonZero(diffImage);
            }

            // Display the number of different pixels for each channel
            _form.PixelValuesResultPictureBox1.Text = $@"B:{Cv2.CountNonZero(channels2[0])}, G:{Cv2.CountNonZero(channels2[1])}, R:{Cv2.CountNonZero(channels2[2])}";
            _form.PixelValuesResultPictureBox2.Text = $@"B:{Cv2.CountNonZero(channels3[0])}, G:{Cv2.CountNonZero(channels3[1])}, R:{Cv2.CountNonZero(channels3[2])}";

            // Display the total number of different pixels for all channels combined
            _form.PixelValueDifferenceResultPictureBox1.Text = numDifferentPixels.Sum().ToString();
            _form.PixelValueDifferenceResultPictureBox2.Text = numDifferentPixels2.Sum().ToString();
        }

        public void ComputeImageMetrics(PictureBox pictureBox1, PictureBox pictureBox2, string referenceImagePath)
        {
            // Get the images from the picture boxes
            var bitmap1 = (Bitmap)pictureBox1.Image;
            var bitmap2 = (Bitmap)pictureBox2.Image;

            // Convert the images to OpenCV format
            var image1 = bitmap1.ToMat();
            var image2 = bitmap2.ToMat();
            var referenceImage = Cv2.ImRead(referenceImagePath);
            Cv2.Resize(referenceImage, referenceImage, new OpenCvSharp.Size(image1.Width, image1.Height));

            // Compute the c (MSE)
            var mseImage1 = QualityMSE.Compute(referenceImage, image1, null);
            var mseImage2 = QualityMSE.Compute(referenceImage, image2, null);

            // Compute the peak signal-to-noise ratio (PSNR)
            var psnrImage1 = QualityPSNR.Compute(referenceImage, image1, null);
            var psnrImage2 = QualityPSNR.Compute(referenceImage, image2, null);

            // Compute the SSIM between the two images
            var ssimImage1 = QualitySSIM.Compute(referenceImage, image1, null);
            var ssimImage2 = QualitySSIM.Compute(referenceImage, image2, null);

            // Display the image metrics
            _form.MeanSquaredErrorResultPictureBox1.Text = mseImage1.ToString();
            _form.MeanSquaredErrorResultPictureBox2.Text = mseImage2.ToString();

            _form.PeakSignaltoNoiseRatioResultPictureBox1.Text = psnrImage1.ToString();
            _form.PeakSignaltoNoiseRatioResultPictureBox2.Text = psnrImage2.ToString();

            _form.StructuralSimilarityIndexResultPictureBox1.Text = ssimImage1.ToString();
            _form.StructuralSimilarityIndexResultPictureBox2.Text = ssimImage2.ToString();
        }

        public Scalar[] ComputeSingleImageMetrics(string upscaledImage, string referenceImagePath)
        {
            var image = Cv2.ImRead(upscaledImage);
            var referenceImage = Cv2.ImRead(referenceImagePath);
            if (upscaledImage.Contains("BSD100"))
            {
                var size = new OpenCvSharp.Size(image.Width, image.Height);
                Cv2.Resize(referenceImage, referenceImage, size);
            }

            if (upscaledImage.Contains("SET14"))
            {
                var size = new OpenCvSharp.Size(image.Width, image.Height);
                Cv2.Resize(referenceImage, referenceImage, size);
            }
            if (upscaledImage.Contains("CUSTOM"))
            {
                var size = new OpenCvSharp.Size(image.Width, image.Height);
                Cv2.Resize(referenceImage, referenceImage, size);
            }

            // Compute the c (MSE)
            var mseImage1 = QualityMSE.Compute(referenceImage, image, null);

            // Compute the peak signal-to-noise ratio (PSNR)
            var psnrImage1 = QualityPSNR.Compute(referenceImage, image, null);

            // Compute the SSIM between the two images
            var ssimImage1 = QualitySSIM.Compute(referenceImage, image, null);

            return new Scalar[] { mseImage1, psnrImage1, ssimImage1 };
        }

        public void KeyMatching(PictureBox pictureBox1, PictureBox pictureBox2, string referenceImagePath)
        {
            // Get the images from the picture boxes
            var bitmap1 = (Bitmap)pictureBox1.Image;
            var bitmap2 = (Bitmap)pictureBox2.Image;

            // Convert the images to OpenCV format
            var image1 = bitmap1.ToMat();
            var image2 = bitmap2.ToMat();
            var referenceImage = Cv2.ImRead(referenceImagePath);

            // Detect the key-points and compute the descriptors
            var detector = ORB.Create(500, 1.2f, 8, 31, 0, 2, ORBScoreType.Fast);
            var descriptors1 = new Mat();
            var descriptors2 = new Mat();
            var descriptors3 = new Mat();

            detector.DetectAndCompute(image1, null, out var keyPoints, descriptors1);
            detector.DetectAndCompute(image2, null, out var keyPoints2, descriptors2);
            detector.DetectAndCompute(image2, null, out var keyPoints3, descriptors3);

            // Match the key-points
            var matcher = new BFMatcher(NormTypes.Hamming, true);
            var matchesImage1 = matcher.Match(descriptors1, descriptors2);
            var matchesImage2 = matcher.Match(descriptors1, descriptors3);

            // Draw the matches
            var matchImg = new Mat();
            var matchImg2 = new Mat();
            Cv2.DrawMatches(referenceImage, keyPoints, image1, keyPoints2, matchesImage1, matchImg);
            Cv2.DrawMatches(referenceImage, keyPoints, image2, keyPoints3, matchesImage2, matchImg2);
            // Show the result
            Cv2.ImShow("Matched key-points", matchImg);
            Cv2.ImShow("Matched key-points", matchImg2);
        }
    }
}
