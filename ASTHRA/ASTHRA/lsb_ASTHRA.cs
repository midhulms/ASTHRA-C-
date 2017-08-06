using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Steganography
{
    public class lsb_ASTHRA
    {
        enum Status
        {
            hide,
            fillingzeros
        };

        public static Bitmap HideText(string text, Bitmap image)
        {
            Status s = Status.hide;

            int charIndex = 0;
            int charValue = 0;
            long colorUnitIndex = 0;

            int zeros = 0;

            int R = 0, G = 0, B = 0;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++) 
                {
                    Color pixel = image.GetPixel(j, i);

                    pixel = Color.FromArgb(pixel.R - pixel.R % 2,
                        pixel.G - pixel.G % 2, pixel.B - pixel.B % 2);

                    R = pixel.R; G = pixel.G; B = pixel.B;

                    for (int n = 0; n < 3; n++)
                    {
                        if (colorUnitIndex % 8 == 0)
                        {
                            if (zeros == 8)
                            {
                                if ((colorUnitIndex - 1) % 3 < 2)
                                {
                                    image.SetPixel(j, i, Color.FromArgb(R, G, B));
                                }

                                return image;
                            }

                            if (charIndex >= text.Length)
                            {
                                s = Status.fillingzeros;
                            }
                            else
                            {
                                charValue = text[charIndex++];
                            }
                        }

                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    if (s == Status.hide)
                                    {
                                        R += charValue % 2;

                                        charValue /= 2;
                                    }
                                } break;
                            case 1:
                                {
                                    if (s == Status.hide)
                                    {
                                        G += charValue % 2;

                                        charValue /= 2;
                                    }
                                } break;
                            case 2:
                                {
                                    if (s == Status.hide)
                                    {
                                        B += charValue % 2;

                                        charValue /= 2;
                                    }

                                    image.SetPixel(j, i, Color.FromArgb(R, G, B));
                                } break;
                        }

                        colorUnitIndex++;

                        if (s == Status.fillingzeros)
                        {
                            zeros++;
                        }
                    }
                }
            }

            return image;
        }

        public static string extractText(Bitmap image)
        {
            int colorUnitIndex = 0;
            int charValue = 0;

            string extractedText = String.Empty;

            for (int i = 0; i < image.Height; i++)
            {
                for (int j = 0; j < image.Width; j++)
                {
                    Color pixel = image.GetPixel(j, i);

                    for (int n = 0; n < 3; n++)
                    {
                        switch (colorUnitIndex % 3)
                        {
                            case 0:
                                {
                                    charValue = charValue * 2 + pixel.R % 2;
                                } break;
                            case 1:
                                {
                                    charValue = charValue * 2 + pixel.G % 2;
                                } break;
                            case 2:
                                {
                                    charValue = charValue * 2 + pixel.B % 2;
                                } break;
                        }

                        colorUnitIndex++;

                        if (colorUnitIndex % 8 == 0)
                        {
                            charValue = reverseBits(charValue);

                            if (charValue == 0)
                            {
                                return extractedText;
                            }

                            char c = (char)charValue;

                            extractedText += c.ToString();
                        }
                    }
                }
            }

            return extractedText;
        }

        public static int reverseBits(int n)
        {
            int result = 0;

            for (int i = 0; i < 8; i++)
            {
                result = result * 2 + n % 2;

                n /= 2;
            }

            return result;
        }
    }
}
