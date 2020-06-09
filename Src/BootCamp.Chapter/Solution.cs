using System;

public class Solution
{
    public int MyAtoi(string str)
    {
        int result = 0;
        int sign = 1;

        if (!string.IsNullOrEmpty(str) && str.Length > 0)
        {
            char[] chars = str.ToCharArray();

            double num = 0;

            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == ' ')
                {
                    if (i > 0 && chars[i - 1] >= '0' && chars[i - 1] <= '9')
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (chars[i] == '-' || chars[i] == '+')
                {
                    if (i + 1 < chars.Length && IsDigit(chars[i + 1]) &&
                     !(i - 1 >= 0 && IsDigit(chars[i - 1])))
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (IsDigit(chars[i]))
                {
                    if (num == 0 && i >= 1 && chars[i - 1] == '-')
                    {
                        sign = -1;
                    }

                    num = num * 10 + chars[i] - '0';
                }
                else
                {
                    break;
                }
            }

            if (sign > 0 && num > Int32.MaxValue)
            {
                result = Int32.MaxValue;
            }
            else if (sign < 0 && num < Int32.MinValue)
            {
                result = Int32.MinValue;
            }
            else
            {
                num = sign * num;
                result = (int)num;
            }
        }

        return result;
    }

    public bool IsDigit(char character)
    {
        return character >= '0' && character <= '9';
    }
}