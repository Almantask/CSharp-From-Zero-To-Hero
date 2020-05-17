using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class TextBoxPrinter
    {
        // TODO: Implement.
        public static string Print(object obj) => "";
    }

    // Default .... [Textable(0, '-', '|', '+']
    //string message, 
    public static string MakePadding(int padding = 0, char horizontal = '-', char vertical = '|', char corner = '+')
    {
        //[TextTable(padding, sideTop, sideLeft, corner]

        string[] splitmessage = message.Split(Environment.NewLine);
        int height = splitmessage.Length + (padding * 2) + 1;
        int width = 0;

        foreach (string line in splitmessage) // checking which word is the longest to know how wide the padding should be.
        {
            if (line.Length > width)
            {
                width = line.Length;
            }
        }
        width += (padding * 2) + 1;
        return MakeTabel();

        string MakeTabel()
        {
            StringBuilder final = new StringBuilder();
            for (int iHeight = 0; iHeight <= height; iHeight++)
            {
                for (int kWidth = 0; kWidth <= width; kWidth++)
                {

                    if (IsThisCorner(iHeight, kWidth))
                    {
                        final.Append(corner);
                    }
                    else if (IsThisHorizontal(iHeight, kWidth))
                    {
                        final.Append(horizontal);
                    }
                    else if (IsThisVertical(iHeight, kWidth))
                    {
                        final.Append(vertical);
                    }
                    else if (IsThisText(iHeight, kWidth))
                    {
                        final.Append(WhatLetterToBePlaced(iHeight, kWidth));
                    }
                    else if (IsThisWhiteSpace(iHeight, kWidth))
                    {
                        final.Append(" ");
                    }
                }
                final.Append(Environment.NewLine);
            }

            return final.ToString();
        }

        bool IsThisCorner(int iHeight, int kWidth)
        {
            // corners = 0 + 0 =====  0 + width === height + 0 === height + width
            if ((iHeight == 0 && kWidth == 0) || (iHeight == 0 && kWidth == width) ||
                (iHeight == height && kWidth == 0) || (iHeight == height && kWidth == width))
            {
                return true;
            }

            return false;
        }
        bool IsThisHorizontal(int iHeight, int kWidth)
        {
            // horizontal = height 0 !& width 0 !& width maxwidth || height max !& width 0 !& width maxwidth
            if ((iHeight == 0 && !(kWidth == 0 || kWidth == width)) ||
                (iHeight == height && !(kWidth == 0 || kWidth == width)))
            {
                return true;
            }
            return false;
        }
        bool IsThisVertical(int iHeight, int kWidth)
        {
            // vertical oposite of horizontal
            if ((kWidth == 0 && !(iHeight == 0 || iHeight == height)) ||
                (kWidth == width && !(iHeight == 0 || iHeight == height)))
            {
                return true;
            }
            return false;
        }
        bool IsThisWhiteSpace(int iHeight, int kWidth)
        {
            if (kWidth != 0 && kWidth != width && iHeight != 0 && iHeight != height)
            {
                return true;
            }
            return false;
        }
        bool IsThisText(int iHeight, int kWidth)
        {
            int numberOfTextLines = splitmessage.Length;
            int heightOfFirstTextLine = 1 + padding;
            int textRow = iHeight - heightOfFirstTextLine;

            if ((iHeight >= heightOfFirstTextLine && iHeight < heightOfFirstTextLine + numberOfTextLines) &&
                (kWidth >= heightOfFirstTextLine && kWidth < heightOfFirstTextLine + splitmessage[textRow].Length))
            {
                return true;
            }
            return false;
        }
        string WhatLetterToBePlaced(int iHeight, int kWidth)
        {
            int heightOfFirstTextLine = 1 + padding;
            int textRow = iHeight - heightOfFirstTextLine;
            int letternumber = kWidth - heightOfFirstTextLine;

            return splitmessage[textRow][letternumber].ToString();
        }
    }
}
