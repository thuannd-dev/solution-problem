public class Solution
{
    public string IntToRoman(int num)
    {
        // var arrChar = num.ToString().ToCharArray();
        // string result = "";
        // int length = arrChar.Length;
        // for(int i = 0; i < arrChar.Length; i++) {
        //     if(arrChar[i] == '0') {
        //         continue;
        //     }
        //     if(length - i - 1 == 3) {
        //         result += TransferDigit(arrChar[i] + "000");
        //     }
        //     if(length - i - 1 == 2) {
        //         result += TransferDigit(arrChar[i] + "00");
        //     }
        //     if(length - i - 1 == 1) {
        //         result += TransferDigit(arrChar[i] + "0");
        //     }
        //     if(length - i - 1 == 0) {
        //         result += TransferDigit(arrChar[i] + "");
        //     }
        // }
        // return result;

        string[] M = { "", "M", "MM", "MMM" };
        string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
        string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
        string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
        return M[num / 1000] + C[(num % 1000) / 100] + X[(num % 100) / 10] + I[num % 10];
    }

    public string TransferDigit(string s)
    {
        switch (s)
        {
            case "0":
                return "";
            case "1":
                return "I";
            case "2":
                return "II";
            case "3":
                return "III";
            case "4":
                return "IV";
            case "5":
                return "V";
            case "6":
                return "VI";
            case "7":
                return "VII";
            case "8":
                return "VIII";
            case "9":
                return "IX";
            case "10":
                return "X";
            case "20":
                return "XX";
            case "30":
                return "XXX";
            case "40":
                return "XL";
            case "50":
                return "L";
            case "60":
                return "LX";
            case "70":
                return "LXX";
            case "80":
                return "LXXX";
            case "90":
                return "XC";
            case "100":
                return "C";
            case "200":
                return "CC";
            case "300":
                return "CCC";
            case "400":
                return "CD";
            case "500":
                return "D";
            case "600":
                return "DC";
            case "700":
                return "DCC";
            case "800":
                return "DCCC";
            case "900":
                return "CM";
            case "1000":
                return "M";
            case "2000":
                return "MM";
            case "3000":
                return "MMM";
            default:
                return "Stupid";
        }
    }
}