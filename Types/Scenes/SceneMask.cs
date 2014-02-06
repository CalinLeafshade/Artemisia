using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Imaging;
using System.IO;

namespace Types.Scenes
{
    class SceneMask
    {

        Bitmap mask;

        public SceneMask(int width, int height)
        {
            mask = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Indexed);
                
        }

        public byte GetValue(int x,int y)
        {
            var data = mask.LockBits(new Rectangle(Point.Empty, mask.Size), System.Drawing.Imaging.ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Indexed);
            byte index = Marshal.ReadByte(data.Scan0 + (y * data.Stride) + x);
            mask.UnlockBits(data);
            return index;
        }

        public void SetValue(int x, int y, byte index)
        {
            var data = mask.LockBits(new Rectangle(Point.Empty, mask.Size), System.Drawing.Imaging.ImageLockMode.WriteOnly, System.Drawing.Imaging.PixelFormat.Indexed);
            Marshal.WriteByte(data.Scan0 + (y * data.Stride) + x, index);
            mask.UnlockBits(data);
        }

        void Fill(int x, int y, byte index)
        {
            BitmapData data = mask.LockBits(
                new Rectangle(Point.Empty, mask.Size),
                ImageLockMode.ReadWrite, PixelFormat.Indexed);
            byte[] bits = new byte[data.Stride * data.Height];
            Marshal.Copy(data.Scan0, bits, 0, bits.Length);

            LinkedList<Point> check = new LinkedList<Point>();
            byte floodTo = index;
            byte floodFrom = bits[x + y * data.Stride];
            bits[x + y * data.Stride] = floodTo;

            if (floodFrom != floodTo)
            {
                check.AddLast(new Point(x, y));
                while (check.Count > 0)
                {
                    Point cur = check.First.Value;
                    check.RemoveFirst();

                    foreach (Point off in new Point[] {
                        new Point(0, -1), new Point(0, 1), 
                        new Point(-1, 0), new Point(1, 0)})
                    {
                        Point next = new Point(cur.X + off.X, cur.Y + off.Y);
                        if (next.X >= 0 && next.Y >= 0 &&
                            next.X < data.Width &&
                            next.Y < data.Height)
                        {
                            if (bits[next.X + next.Y * data.Stride] == floodFrom)
                            {
                                check.AddLast(next);
                                bits[next.X + next.Y * data.Stride] = floodTo;
                            }
                        }
                    }
                }
            }

            Marshal.Copy(bits, 0, data.Scan0, bits.Length);
            mask.UnlockBits(data);
        }
    }
}
