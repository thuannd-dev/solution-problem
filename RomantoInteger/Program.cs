public class Solution
{
    public int RomanToInt(string s)
    {
        var arrChar = s.ToString().ToCharArray();
        int result = 0;
        // for(int i = 0; i < arrChar.Length; i++) {
        //     int current = TransferValue(arrChar[i]);
        //     if(i < arrChar.Length - 1) {
        //         int next = TransferValue(arrChar[i + 1]);
        //         if(current < next) {
        //             result += next - current;
        //             i++;
        //             continue;
        //         }
        //     }
        //     result += current;
        // }
        // return result;
        for (int i = 0; i < arrChar.Length; i++)
        {
            int current = TransferValue(arrChar[i]), next;
            if (i < arrChar.Length - 1 && current < (next = TransferValue(arrChar[i + 1])))
            {
                result += next - current;
                i++;
                continue;
            }
            result += current;
        }
        return result;
    }

    public int TransferValue(char c)
    {
        switch (c)
        {
            case 'I':
                return 1;
            case 'V':
                return 5;
            case 'X':
                return 10;
            case 'L':
                return 50;
            case 'C':
                return 100;
            case 'D':
                return 500;
            case 'M':
                return 1000;
            default:
                return 0;
        }
    }
}