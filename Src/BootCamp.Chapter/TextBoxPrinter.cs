using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public static class TextBoxPrinter
    {

        // TODO: Implement.
        //public static string Print(object obj) => "";
        public static string Print(object obj)
        {
            var stringToBeReturned = string.Empty;
            var custAttributeApplied = AttributesGetter.GetClassAttribute<TextableAttribute>(obj.GetType());

            if (custAttributeApplied != null)
            {
                var custPaddingValue = custAttributeApplied.Padding;
                var custSideTop = custAttributeApplied.SideTop;
                var custSideLeft = custAttributeApplied.SideLeft;
                var custCorner = custAttributeApplied.Corner;
                var objString = obj.ToString();
                stringToBeReturned = FormatString(custPaddingValue, custSideTop, custSideLeft, custCorner, objString);
            }
            else
            {
                stringToBeReturned = obj.ToString();
            }
            
            return stringToBeReturned;
        }

        public static string FormatString(int padding, string sideTop, string sideLeft, string corner, string text)
        {
            StringBuilder sb = new StringBuilder();

            int objNumOfChars = text.Length;
            objNumOfChars += padding * 2;

            FormatTop(sideTop, corner, sb, objNumOfChars);

            FormatPadding(padding, sideLeft, text, sb);

            FormatMiddle(padding, sideLeft, text, sb);

            FormatPadding(padding, sideLeft, text, sb);

            FormatBottom(sideTop, corner, sb, objNumOfChars);

            return sb.ToString();
        }

        private static void FormatPadding(int padding, string sideLeft, string text, StringBuilder sb)
        {
            for (int i = 0; i < padding; i++)
            {
                sb.Append(sideLeft);
                sb.Append(' ', padding);
                sb.Append(' ', text.Length);
                sb.Append(' ', padding);
                sb.Append(sideLeft + Environment.NewLine);
            }
        }

        private static void FormatMiddle(int padding, string sideLeft, string text, StringBuilder sb)
        {
            ///<summary>
            ///     MIDDLE
            /// </summary>
            sb.Append(sideLeft);
            sb.Append(' ', padding);
            sb.Append(text);
            sb.Append(' ', padding);
            sb.Append(sideLeft + Environment.NewLine);
        }

        private static void FormatBottom(string sideTop, string corner, StringBuilder sb, int objNumOfChars)
        {
            ///<summary>
            ///     BOTTOM
            /// </summary>
            sb.Append(corner);
            sb.Append(sideTop.ToCharArray()[0], objNumOfChars);
            sb.Append(corner);
        }

        private static void FormatTop(string sideTop, string corner, StringBuilder sb, int objNumOfChars)
        {
            ///<summary>
            ///     TOP
            /// </summary>
            sb.Append(corner);
            sb.Append(sideTop.ToCharArray()[0], objNumOfChars);
            sb.Append(corner + Environment.NewLine);
        }

    }
}
