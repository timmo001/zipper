using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace Zipper
{
    public class Zip
    {
        public static string ZipFiles(string[] filesToZipArray, string zipPath)
        {
            try
            {
                using (ZipArchive archive = ZipFile.Open(zipPath, ZipArchiveMode.Create))
                {
                    foreach (var file in filesToZipArray)
                    {
                        archive.CreateEntryFromFile(file, Path.GetFileName(file));
                    }
                }
                return zipPath;
            }
            catch (Exception)
            {
                return "";
            }
        }

        public static string ZipDirectory(string zipDirectory, string zipPath)
        {
            try
            {
                ZipFile.CreateFromDirectory(zipDirectory, zipPath);
                Thread.Sleep(2000);
                return zipPath;
            }
            catch (Exception)
            {
                return "";
            }
        }

    }
}
