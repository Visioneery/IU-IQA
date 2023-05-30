using OpenCvSharp;
using System.IO;
using Size = OpenCvSharp.Size;

namespace UpscalingAndQualityAssessmentForm.Upscale
{
    public class DownScaler
    {
        public string DownScale(string referenceImagePath, int scale, DownscalingForm downscalingForm)
        {
            // Load the original image
            var originalImage = Cv2.ImRead(referenceImagePath);


            //Apply image compression
            byte[] compressedImageData;
            var parametersJpg = new[] { (int)ImwriteFlags.JpegQuality, downscalingForm.ImageCompressionValue }; // 99
            var parametersPng = new[] { (int)ImwriteFlags.PngCompression, downscalingForm.ImageCompressionValue }; // 1


            using (var ms = new MemoryStream())
            {
                //Cv2.ImEncode(Path.GetExtension(referenceImagePath), originalImage, out compressedImageData);

                // write me a switch

                switch (Path.GetExtension(referenceImagePath).ToLowerInvariant())
                {
                    case ".png":
                        Cv2.ImEncode(Path.GetExtension(referenceImagePath), originalImage, out compressedImageData, parametersPng);
                        break;
                    case ".jpg":
                        Cv2.ImEncode(Path.GetExtension(referenceImagePath), originalImage, out compressedImageData, parametersJpg);
                        break;
                    case ".jpeg":
                        Cv2.ImEncode(Path.GetExtension(referenceImagePath), originalImage, out compressedImageData, parametersJpg);
                        break;
                    default:
                        Cv2.ImEncode(Path.GetExtension(referenceImagePath), originalImage, out compressedImageData, parametersJpg);
                        break;
                }
            }
            var compressedImage = Cv2.ImDecode(compressedImageData, ImreadModes.Color);
            //Cv2.ImWrite($"C:\\Users\\User\\Desktop\\Upscaling\\images\\Downscaled\\compressed_x{scale}{Path.GetFileName(referenceImagePath)}", compressedImage);

            // quantization or dithering

            // Add Gaussian noise
            var noise = new Mat(compressedImage.Size(), compressedImage.Type());
            Cv2.Randn(noise, Scalar.All(0), Scalar.All(downscalingForm.GaussianNoiseValue)); // 20
            var noisyImageWithNoise = compressedImage + noise;
            //Cv2.ImWrite($"C:\\Users\\User\\Desktop\\Upscaling\\images\\Downscaled\\noisy_x{scale}{Path.GetFileName(referenceImagePath)}", noisyImageWithNoise);

            // Add Gaussian blur
            var blurredImage = new Mat();
            Cv2.GaussianBlur(noisyImageWithNoise, blurredImage, new Size(downscalingForm.GaussianBlurValue, downscalingForm.GaussianBlurValue), 0); // higher size make more blurry 7x7
            //Cv2.ImWrite($"C:\\Users\\User\\Desktop\\Upscaling\\images\\Downscaled\\blurry_x{scale}{Path.GetFileName(referenceImagePath)}", blurredImage);

            // Lower the image quality settings
            var lowQualityImage = new Mat();
            Cv2.Normalize(blurredImage, lowQualityImage, 0, 255, NormTypes.MinMax);
            Cv2.ConvertScaleAbs(lowQualityImage, lowQualityImage, downscalingForm.ImageQualitySettingValue); // lower alpha makes image darker 0.95
            //Cv2.ImWrite($"C:\\Users\\User\\Desktop\\Upscaling\\images\\Downscaled\\lower_quality_x{scale}{Path.GetFileName(referenceImagePath)}", lowQualityImage);

            var imagesFolderPath =
                Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName,
                    "images");
            var lowQualityImagePath = $"{imagesFolderPath}\\Downscaled\\{Path.GetFileNameWithoutExtension(referenceImagePath)}x{scale}{Path.GetExtension(referenceImagePath)}";
            // Save the degraded image

            //Resize the image to lower resolution
            var resizedImage = new Mat();
            Cv2.Resize(lowQualityImage, resizedImage, new Size(originalImage.Cols / scale, originalImage.Rows / scale), interpolation: InterpolationFlags.Area);


            Cv2.ImWrite(lowQualityImagePath, resizedImage);

            return lowQualityImagePath;
        }
    }
}
