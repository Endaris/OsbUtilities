using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using OsbAnalyser.Contracts;

namespace OsbAnalyser.Analysing.Storyboard
{
    public class StoryboardInfoDrawer
    {
        private readonly StoryboardInfo StoryboardInfo;

        private float xMin => (float)ActiveData.Keys.Min();
        private float xMax => (float)ActiveData.Keys.Max();
        //graph should always start at y = 0
        private float yMin => 0; //ActiveData.Values.Min(); 
        private float yMax => ActiveData.Values.Max();

        private Dictionary<int, int> ActiveData;
        private Dictionary<int, int> VisibleData;

        private Font font = new Font("Tahoma", 10);

        public StoryboardInfoDrawer(StoryboardInfo storyboardInfo)
        {
            StoryboardInfo = storyboardInfo;
        }

        public Image DrawSpriteGraph()
        {
            ActiveData = StoryboardInfo.ActiveSpriteData;
            VisibleData = StoryboardInfo.VisibleSpriteData;
            return DrawGraph("Sprites");
        }

        public Image DrawCommandGraph()
        {
            ActiveData = StoryboardInfo.ActiveCommandData;
            VisibleData = StoryboardInfo.VisibleCommandData;
            return DrawGraph("Commands");
        }

        private Image DrawGraph(string yAxisName)
        {
            Bitmap bitmap = new Bitmap(854, 480);
            DrawAxes(bitmap);
            DrawFonts(bitmap, yAxisName);
            DrawData(bitmap, ActiveData, Color.Green);
            DrawData(bitmap, VisibleData, Color.Red);
            return bitmap;
        }

        private void DrawAxes(Bitmap bitmap)
        {
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.Transform = GetMatrix(bitmap);

                using (Pen pen = new Pen(Color.White, 2))
                {
                    gr.DrawLine(pen, xMin, 0, xMax, 0);
                    gr.DrawLine(pen, 0, 0, 0, yMax);

                    //can't get this right somehow
                    //for (float x = xMin; x <= xMax; x += (xMax - xMin) / 6)
                    //{
                    //    gr.DrawLine(pen, x, -yMax / 100, x, yMax / 100);
                    //}
                    //for (float y = 0; y <= yMax; y += yMax / 6)
                    //{
                    //    gr.DrawLine(pen, -(xMax - xMin) / 100, y, (xMax - xMin) / 100, y);
                    //}                  
                }
            }
        }

        private void DrawFonts(Bitmap bitmap, string yAxisName)
        {
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;

                var rect = new RectangleF(-(xMax / 20), (float)(yMax * 0.9), xMax / 10, yMax / 10);
                var verticalFormat = new StringFormat()
                {
                    FormatFlags = StringFormatFlags.DirectionVertical,
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                };

                gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gr.PixelOffsetMode = PixelOffsetMode.HighQuality;

                string time = "time in ms";

                var sizeY = gr.MeasureString(yAxisName, font);
                var sizeX = gr.MeasureString(time, font);

                gr.DrawString(yAxisName, font, Brushes.White, sizeY.Height, sizeY.Width + 3, verticalFormat);
                gr.DrawString("time in ms", font, Brushes.White, bitmap.Width - sizeX.Width - 2, bitmap.Height - sizeX.Height - 2);

                var centeredFormat = new StringFormat()
                {
                    Alignment = StringAlignment.Center,
                    LineAlignment = StringAlignment.Center,
                };

                int i = 0;
                for (float x = xMin; x <= xMax; x += (xMax - xMin) / 6)
                {
                    gr.DrawString(((int)x).ToString(), font, Brushes.White, 
                        bitmap.Width / 10 + i * bitmap.Width / 6, bitmap.Height - bitmap.Height / 14, centeredFormat);
                    i++;
                }
                i = 0;
                for (float y = 0; y <= yMax; y += yMax / 6)
                {
                    gr.DrawString(Math.Round(y,2).ToString(System.Globalization.CultureInfo.InvariantCulture), font, Brushes.White, 
                        bitmap.Width / 16,  (bitmap.Height - bitmap.Height / 10) - i * (bitmap.Height * 0.935f) / 6, centeredFormat);
                    i++;
                }
            }
        }

        private void DrawData(Bitmap bitmap, Dictionary<int, int> data, Color color)
        {
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.Transform = GetMatrix(bitmap);

                using (Pen pen = new Pen(color, 2))
                {
                    List<PointF> points = new List<PointF>();
                    foreach(var pair in data)
                    {
                        points.Add(new PointF((float)pair.Key, pair.Value));
                    }
                    if (points.Count > 0)
                        gr.DrawLines(pen, points.ToArray());
                    points.Clear();
                }
            }
        }

        private Matrix GetMatrix(Bitmap bitmap)
        {
            RectangleF rect = new RectangleF(
                    xMin, 0, (xMax - xMin) * 1.1f, yMax * 1.1f);
            PointF[] pts =
                {
                    new PointF(0, bitmap.Height),
                    new PointF(bitmap.Width, bitmap.Height),
                    new PointF(0, 0),
                };

            var Matrix = new Matrix(rect, pts);
            Matrix.Translate((xMax - xMin) / 10, yMax / 10);

            return Matrix;
        }
    }
}
