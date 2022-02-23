using System;
using System.Drawing;
using System.Drawing.Imaging;
using Svg;

namespace svgzToPng
{
    class Program
    {
        static void Main(string[] args)
        {
            // get all .svgz files in current directory
            string[] svgzFiles = System.IO.Directory.GetFiles(System.IO.Directory.GetCurrentDirectory(), "*.svgz");

            Program.transformSVGZToPNG(svgzFiles);
        }

        public static void transformSVGZToPNG(string[] paths){
            foreach (string path in paths){
                SvgDocument svgDoc = SvgDocument.Open(path);
                Bitmap bitmap = svgDoc.Draw();
                bitmap.Save(path.Replace(".svgz", ".png"), ImageFormat.Png);
            }
        }
    }
}
