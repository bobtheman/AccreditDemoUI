using System;
using System.Text;

namespace AccreditDemoAPI.Helpers
{
    public static class ImageConvert
    {
        public static byte[] ImageToByte(string inputString)
        {
            byte[] imageArray = Encoding.Unicode.GetBytes(inputString);
            return imageArray;
        }
        public static string stringToImage(string inputString)
        {
            byte[] imageArray = Encoding.Unicode.GetBytes(inputString);
            string base64ImageRepresentation = Convert.ToBase64String(imageArray);
            return base64ImageRepresentation;
        }
    }
}