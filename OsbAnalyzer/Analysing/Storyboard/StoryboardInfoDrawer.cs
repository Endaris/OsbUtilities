using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using OsbAnalyzer.Contracts;

namespace OsbAnalyzer.Analysing.Storyboard
{
    public class StoryboardInfoDrawer
    {
        private readonly StoryboardInfo StoryboardInfo;

        private float xMin => (float)ActiveData.Keys.Min();
        private float xMax => (float)ActiveData.Keys.Max();
        private float yMin => ActiveData.Values.Min();
        private float yMax => ActiveData.Values.Max();

        private Dictionary<double, int> ActiveData;
        private Dictionary<double, int> VisibleData;

        public StoryboardInfoDrawer(StoryboardInfo storyboardInfo)
        {
            StoryboardInfo = storyboardInfo;
        }

        public Image DrawSpriteGraph()
        {
            ActiveData = StoryboardInfo.ActiveSpriteData;
            VisibleData = StoryboardInfo.VisibleSpriteData;
            return DrawGraph();
        }

        public Image DrawCommandGraph()
        {
            ActiveData = StoryboardInfo.ActiveCommandData;
            VisibleData = StoryboardInfo.VisibleCommandData;
            return DrawGraph();
        }

        private Image DrawGraph()
        {
            Bitmap bitmap = new Bitmap(854, 480);
            DrawAxes(bitmap);
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

                using (Pen pen = new Pen(Color.Black, 2))
                {
                    gr.DrawLine(pen, xMin, 0, xMax, 0);
                    gr.DrawLine(pen, 0, yMin, 0, yMax);
                    for (int x = (int)xMin; x <= xMax; x += (int)((xMax - xMin) / 6))
                    {
                        gr.DrawLine(pen, x, -0.1f, x, 0.1f);
                    }
                    for (int y = (int)yMin; y <= yMax; y += (int)((yMax - yMin) / 6))
                    {
                        gr.DrawLine(pen, -0.1f, y, 0.1f, y);
                    }
                }
            }
        }

        private void DrawData(Bitmap bitmap, Dictionary<double, int> data, Color color)
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
                    xMin, yMin, xMax - xMin, yMax - yMin);
            PointF[] pts =
                {
                    new PointF(0, bitmap.Height),
                    new PointF(bitmap.Width, bitmap.Height),
                    new PointF(0, 0),
                };

            return new Matrix(rect, pts);
        }
    }
}
