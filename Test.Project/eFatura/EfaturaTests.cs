using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using NUnit.Framework;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace Test.Project.eFatura
{
    [TestFixture]
    public class EfaturaTests
    {
        private readonly string _baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

        [Test]
        public void gib_service_test()
        {
            var xmlPath = _baseDirectory + "/eFatura/Files/xml/1_TEMEL_FATURA.xml";
            var gibService = new EFatura();

            var memStreamIn = new MemoryStream(File.ReadAllBytes(xmlPath));
            var zipFileName = "F47AC10B-58CC-4372-A567-0E02B2C3D479";
            var zipFileStream = CreateToMemoryStream(memStreamIn, zipFileName + ".xml");

            var documentRequest = new documentType()
            {
                binaryData = new base64Binary()
                {
                    contentType = "aplication/zip",
                    Value = zipFileStream.ToArray()
                },
                fileName = zipFileName + ".zip",
                hash = Md5HashFromStream(zipFileStream)
            };

            var result = gibService.sendDocument(documentRequest);
            Console.WriteLine(result.msg);
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                var sb = new StringBuilder();
                foreach (byte hashByte in hashBytes)
                {
                    sb.Append(hashByte.ToString("X2"));
                }
                return sb.ToString();
            }
        }

        /// <summary>
        /// Writes the zip file.
        /// </summary>
        /// <param name="filesToZip">The files to zip.</param>
        /// <param name="path">The destination path.</param>
        /// <param name="compression">The compression level.</param>
        private static void WriteZipFile(List<string> filesToZip, string path, int compression = 5)
        {
            if (compression < 0 || compression > 9)
                throw new ArgumentException("Invalid compression rate.");

            var directoryInfo = new FileInfo(path).Directory;
            if (directoryInfo != null && !Directory.Exists(directoryInfo.ToString()))
                throw new ArgumentException("The Path does not exist.");

            foreach (string c in filesToZip)
                if (!File.Exists(c)) throw new ArgumentException($"The File {c} does not exist!");

            Crc32 crc32 = new Crc32();
            ZipOutputStream stream = new ZipOutputStream(File.Create(path));
            stream.SetLevel(compression);

            foreach (string t in filesToZip)
            {
                ZipEntry entry = new ZipEntry(Path.GetFileName(t));
                entry.DateTime = DateTime.Now;

                using (FileStream fs = File.OpenRead(t))
                {
                    byte[] buffer = new byte[fs.Length];
                    fs.Read(buffer, 0, buffer.Length);
                    entry.Size = fs.Length;
                    fs.Close();
                    crc32.Reset();
                    crc32.Update(buffer);
                    entry.Crc = crc32.Value;
                    stream.PutNextEntry(entry);
                    stream.Write(buffer, 0, buffer.Length);
                }
            }
            stream.Finish();
            stream.Close();
        }

        // Compresses the supplied memory stream, naming it as zipEntryName, into a zip,
        // which is returned as a memory stream or a byte array.
        public MemoryStream CreateToMemoryStream(MemoryStream memStreamIn, string zipEntryName)
        {
            MemoryStream outputMemStream = new MemoryStream();
            ZipOutputStream zipStream = new ZipOutputStream(outputMemStream);

            zipStream.SetLevel(3); //0-9, 9 being the highest level of compression

            var newEntry = new ZipEntry(zipEntryName) { DateTime = DateTime.Now };

            zipStream.PutNextEntry(newEntry);

            StreamUtils.Copy(memStreamIn, zipStream, new byte[4096]);
            zipStream.CloseEntry();

            zipStream.IsStreamOwner = false;    // False stops the Close also Closing the underlying stream.
            zipStream.Close();          // Must finish the ZipOutputStream before using outputMemStream.

            outputMemStream.Position = 0;
            return outputMemStream;
        }

        public static string Md5HashFromStream(Stream stream)
        {
            using (var md5 = MD5.Create())
            {
                return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
            }
        }

    }
}