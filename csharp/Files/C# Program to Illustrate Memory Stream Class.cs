/*
 * C# Program to Illustrate Memory Stream Class
 */
using System;
using System.IO;
using System.Text;
class MemStream
{
    static void Main()
    {
        int count;
        byte[] byteArray;
        char[] charArray;
        UnicodeEncoding uniEncoding = new UnicodeEncoding();
        byte[] firstString = uniEncoding.GetBytes("Invalid file path characters are: ");
        byte[] secondString = uniEncoding.GetBytes(Path.GetInvalidPathChars());
        using(MemoryStream memStream = new MemoryStream(100))
        {
            memStream.Write(firstString, 0, firstString.Length);
            count = 0;
            while(count < secondString.Length)
                {
                    memStream.WriteByte(secondString[count++]);
                }
            Console.WriteLine("Capacity = {0}, Length = {1}, Position = {2}\n",
                              memStream.Capacity.ToString(),
                              memStream.Length.ToString(),
                              memStream.Position.ToString());
            memStream.Seek(0, SeekOrigin.Begin);
            byteArray = new byte[memStream.Length];
            count = memStream.Read(byteArray, 0, 20);
            while (count < memStream.Length)
                {
                    byteArray[count++] = Convert.ToByte(memStream.ReadByte());
                }
            charArray = new char[uniEncoding.GetCharCount(byteArray, 0, count)];
            uniEncoding.GetDecoder().GetChars(byteArray, 0, count, charArray, 0);
            Console.WriteLine(charArray);
            Console.Read();
        }
    }
}

/*
Capacity = 256  Length = 140  Position =140
Invalid File Path Characters are : "<>|