using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;

using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Processing;
using SixLabors.ImageSharp.Drawing.Processing;
using System.Diagnostics;

namespace FaceDetect
{
    class Program
    {
        private static string msg = "Please provide the API Key as the first command-line parameter, followed by the filenam of the image to be used";
        static void Main(string[] args)
        {
            // Command line arguments
            // get this from the Keys and Endpoint in the Resource Management Left Pane
            var apiKey = !string.IsNullOrWhiteSpace(args[0]) ? args[0] : throw new ArgumentException(msg, args[0]);
            var filename = File.Exists(args[1]) ? args[1] : throw new FileNotFoundException(msg, args[1]);
            // this is the resource name for the Cognitive Services Face app
            var resourceName = args[2];

            // Call HTTP API
            var target = new Uri($"https://{resourceName}.cognitiveservices.azure.com/face/v1.0/detect");
            var httpPost = CreateHttpRequest(target, "POST", "application/octet-stream", apiKey);


            // Load image
            using (var fs = File.OpenRead(filename))
            {
                fs.CopyTo(httpPost.GetRequestStream());

            }


            // Submit the image to the HTTP endpoint

            string data = GetResponse(httpPost);

            // Inspect JSON
            var rectangles = GetRectangles(data);

            // Draw rectangles on the image copy

            var img = Image.Load(filename);
            var count = 0;
            foreach (var rectangle in GetRectangles(data))
            {
                img.Mutate(a => a.DrawPolygon(Color.HotPink, 20, rectangle));
                count++;
            }
            Console.WriteLine($"Number of faces detected: {count}");
            var outputfilename = $"{Environment.CurrentDirectory}\\{Path.GetFileNameWithoutExtension(filename)}-2{Path.GetExtension(filename)}";
            SaveImage(img, outputfilename);
            OpenWithDefaultApp(outputfilename);
        }

        private static void OpenWithDefaultApp(string filename)
        {
            var si = new ProcessStartInfo()
            {
                FileName = "explorer.exe",
                Arguments = filename,
                WindowStyle = ProcessWindowStyle.Hidden
            };
            Process.Start(si);
        }

        private static void SaveImage(Image image, string outputfilename)
        {
            using (var fs = File.Create(outputfilename))
                image.SaveAsJpeg(fs);
        }

        private static System.Collections.Generic.IEnumerable<PointF[]> GetRectangles(string data)
        {
            var faces = JArray.Parse(data);
            foreach (var face in faces)
            {
                var id = (string)face["faceId"];
                var top = (int)face["faceRectangle"]["top"];
                var left = (int)face["faceRectangle"]["left"];
                var width = (int)face["faceRectangle"]["width"];
                var height = (int)face["faceRectangle"]["height"];

                var rectangle = new PointF[]
                {
                    new PointF(left, top),
                    new PointF(left + width, top),
                    new PointF(left + width, top + height),
                    new PointF(left, top + height)
                };

                yield return rectangle;
            }
        }

        private static string GetResponse(HttpWebRequest httpPost)
        {
            using (var response = httpPost.GetResponse())
            using (var sr = new StreamReader(response.GetResponseStream()))
            {
                return sr.ReadToEnd();
            }
        }

        private static HttpWebRequest CreateHttpRequest(Uri target, string method, string contentType, string apiKey)
        {
            var request = WebRequest.CreateHttp(target);
            request.Method = method;
            request.ContentType = contentType;
            request.Headers.Add($"Ocp-Apim-Subscription-Key: {apiKey}");
            return request;
        }
    }
}
