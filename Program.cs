using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ModifiedReadonlyFiles
{
    class Program
    {
        public static int count = 0;
        public static List<string> uniqueDirs = new List<string>();
        public static void Main(string[] args)
        {
            DirSearch("C:\\projects\\confluence\\platform-dev-SR-d1\\");
            Console.WriteLine("---Done---count:" + count);
            //System.IO.File.AppendAllLines("C:\\uniquedirs.txt", uniqueDirs);
            Console.Read();
        }

        public static void DirSearch(string sDir)
        {
            DateTime modifiedEnd = new DateTime(2013, 8, 18);
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    if (d.IndexOf("Binother") < 0 && d.IndexOf("Binanother") < 0 && d.IndexOf("\\Debug") < 0)
                    {
                        foreach (string f in Directory.GetFiles(d))
                        {
                            if (isModfiedBefore(f, modifiedEnd) && !isFileExtension(f, "vbp"))
                            {
                                if (!uniqueDirs.Contains(d))
                                {
                                    Console.WriteLine(d);
                                    uniqueDirs.Add(d);
                                    count++;
                                }

                                //FileAttributes attributes = File.GetAttributes(f);

                                //if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
                                //{
                                //    // Make the file RW
                                //    attributes = RemoveAttribute(attributes, FileAttributes.ReadOnly);
                                //    File.SetAttributes(f, attributes);
                                //    Console.WriteLine("The {0} file is no longer RO.", f);
                                //} 

				//string folderPath = f.Substring(sourceFolder.Length);
                                //string DestinationFolderPath = destinationFolder + getWithoutFileName(folderPath);
                                //results.Add("xcopy \"" + f + "\" \"" + DestinationFolderPath + "\" /R /Y");
                            }
                        }
                        DirSearch(d);
                    }
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        private static bool isReadOnly(string file)
        {
            // Create a new FileInfo object.
            FileInfo fInfo = new FileInfo(file);

            // Return the IsReadOnly property value. 
            return fInfo.IsReadOnly;
        }

        private static FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        private static bool isModfiedBefore(string file, DateTime time)
        {
            FileInfo fInfo = new FileInfo(file);
            return fInfo.LastWriteTime < time;
        }

        private static bool isFileExtension(string file, string extension)
        {
            return file.Substring(file.LastIndexOf('.') + 1).ToLower() == extension.ToLower();
        }

        private static bool hasValidFileExtension(string file)
        {
            return true;

        }

	private static string getWithoutFileName(string file)
        {
            return file.Substring(0, file.LastIndexOf('\\') + 1);
        }
    }
}
