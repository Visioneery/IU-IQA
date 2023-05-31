using System.IO;
using OpenCvSharp;
using OpenCvSharp.DnnSuperres;

namespace UpscalingAndQualityAssessmentForm.Upscale
{
    public class Upscaler
    {
        public ScaleEnum Scale { get; set; }
        private string _imagesFolderPath;
        private string _modelsFolderPath;

        public void InitializeModels()
        {
            _modelsFolderPath = 
                Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName,
                    "models");

            _imagesFolderPath =
                Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.FullName,
                    "images");
        }

        public void UpscaleUsingLanczos(string originalImagePath)
        {
            var upscaledImagePath = $"{_imagesFolderPath}\\Upscaled\\{Path.GetFileNameWithoutExtension(originalImagePath)}_{InterpolationFlags.Lanczos4.ToString().TrimEnd('4')}_x{(int)Scale}{Path.GetExtension(originalImagePath)}";

            using var image = new Mat(originalImagePath);

            var newWidth = image.Width * (int)Scale;
            var newHeight = image.Height * (int)Scale;

            var upscaledImage = new Mat();
            Cv2.Resize(image, upscaledImage, new OpenCvSharp.Size(newWidth, newHeight), 0, 0, InterpolationFlags.Lanczos4);

            WriteBasedOnType(upscaledImagePath, upscaledImage, Path.GetExtension(originalImagePath).ToLowerInvariant());

            // Clean up
            image.Dispose();
            upscaledImage.Dispose();
        }

        public void UpscaleUsingBicubic(string originalImagePath)
        {
            var upscaledImagePath = $"{_imagesFolderPath}\\Upscaled\\{Path.GetFileNameWithoutExtension(originalImagePath)}_Bi{InterpolationFlags.Cubic}_x{(int)Scale}{Path.GetExtension(originalImagePath)}";

            using var image = new Mat(originalImagePath);

            var newWidth = image.Width * (int)Scale;
            var newHeight = image.Height * (int)Scale;

            var upscaledImage = new Mat();
            Cv2.Resize(image, upscaledImage, new OpenCvSharp.Size(newWidth, newHeight), 0, 0, InterpolationFlags.Cubic);

            WriteBasedOnType(upscaledImagePath, upscaledImage, Path.GetExtension(originalImagePath).ToLowerInvariant());

            // Clean up
            image.Dispose();
            upscaledImage.Dispose();
        }

        public void UpscaleUsingLapSRN(string originalImagePath) 
        {
            var upscaledImagePath = $"{_imagesFolderPath}\\Upscaled\\{Path.GetFileNameWithoutExtension(originalImagePath)}_{ModelEnum.LapSRN}_x{(int)Scale}{Path.GetExtension(originalImagePath)}";

            var image = new Mat(originalImagePath);
            var upscaledImage = new Mat();

            var _LapSRNDnn = new DnnSuperResImpl(ModelEnum.LapSRN.ToString().ToLowerInvariant(), (int)Scale);
            _LapSRNDnn.ReadModel($"{_modelsFolderPath}\\{ModelEnum.LapSRN}_x{(int)Scale}.pb");

            _LapSRNDnn.Upsample(image, upscaledImage);

            WriteBasedOnType(upscaledImagePath, upscaledImage, Path.GetExtension(originalImagePath).ToLowerInvariant());

            image.Dispose();
            upscaledImage.Dispose();
        }

        public void UpscaleUsingEDSR(string originalImagePath)
        {
            var upscaledImagePath = $"{_imagesFolderPath}\\Upscaled\\{Path.GetFileNameWithoutExtension(originalImagePath)}_{ModelEnum.EDSR}_x{(int)Scale}{Path.GetExtension(originalImagePath)}";

            var image = new Mat(originalImagePath);
            var upscaledImage = new Mat();

            var _EDSRDnn = new DnnSuperResImpl(ModelEnum.EDSR.ToString().ToLowerInvariant(), (int)Scale);
            _EDSRDnn.ReadModel($"{_modelsFolderPath}\\{ModelEnum.EDSR}_x{(int)Scale}.pb");

            _EDSRDnn.Upsample(image, upscaledImage);

            WriteBasedOnType(upscaledImagePath, upscaledImage, Path.GetExtension(originalImagePath).ToLowerInvariant());

            image.Dispose();
            upscaledImage.Dispose();
        }

        public void UpscaleUsingFSRCNN(string originalImagePath)
        {
            var upscaledImagePath = $"{_imagesFolderPath}\\Upscaled\\{Path.GetFileNameWithoutExtension(originalImagePath)}_{ModelEnum.FSRCNN}_x{(int)Scale}{Path.GetExtension(originalImagePath)}";

            var image = new Mat(originalImagePath);
            var upscaledImage = new Mat();


            var _FSRCNNDnn = new DnnSuperResImpl(ModelEnum.FSRCNN.ToString().ToLowerInvariant(), (int)Scale);
            _FSRCNNDnn.ReadModel($"{_modelsFolderPath}\\{ModelEnum.FSRCNN}_x{(int)Scale}.pb");

            _FSRCNNDnn.Upsample(image, upscaledImage);

            WriteBasedOnType(upscaledImagePath, upscaledImage, Path.GetExtension(originalImagePath).ToLowerInvariant());

            image.Dispose();
            upscaledImage.Dispose();
        }

        private void WriteBasedOnType(string upscaledImagePath, Mat upscaledImage,string type)
        {
            switch (type)
            {
                case ".png":
                    Cv2.ImWrite(upscaledImagePath, upscaledImage, new ImageEncodingParam(ImwriteFlags.PngCompression, 9));
                    break;
                case ".jpg":
                    Cv2.ImWrite(upscaledImagePath, upscaledImage, new ImageEncodingParam(ImwriteFlags.JpegQuality, 100));
                    break;
                case ".jpeg":
                    Cv2.ImWrite(upscaledImagePath, upscaledImage, new ImageEncodingParam(ImwriteFlags.JpegQuality, 100));
                    break;
                default:
                    Cv2.ImWrite(upscaledImagePath, upscaledImage, new ImageEncodingParam(ImwriteFlags.JpegQuality, 100));
                    break;
            }
        }
    }
}
