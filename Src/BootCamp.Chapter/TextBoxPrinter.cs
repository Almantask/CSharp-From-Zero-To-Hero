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

            ///<summary>
            ///     TOP
            /// </summary>
            sb.Append(corner);
            sb.Append(sideTop.ToCharArray()[0], objNumOfChars);
            sb.Append(corner + Environment.NewLine);

            for (int i = 0; i < padding; i++)
            {
                sb.Append(sideLeft);
                sb.Append(' ', padding);
                sb.Append(' ', text.Length);
                sb.Append(' ', padding);
                sb.Append(sideLeft + Environment.NewLine);
            }

            ///<summary>
            ///     MIDDLE
            /// </summary>
            sb.Append(sideLeft);
            sb.Append(' ', padding);
            sb.Append(text);
            sb.Append(' ', padding);
            sb.Append(sideLeft + Environment.NewLine);

            for (int i = 0; i < padding; i++)
            {
                sb.Append(sideLeft);
                sb.Append(' ', padding);
                sb.Append(' ', text.Length);
                sb.Append(' ', padding);
                sb.Append(sideLeft + Environment.NewLine);
            }

            ///<summary>
            ///     BOTTOM
            /// </summary>
            sb.Append(corner);
            sb.Append(sideTop.ToCharArray()[0], objNumOfChars);
            sb.Append(corner);

            return sb.ToString();
        }
    }
}
