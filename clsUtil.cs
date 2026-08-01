using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public class clsUtil
    {
        public static string CreateGUID()
        {
            return Guid.NewGuid().ToString(); 
        }
        public static bool CreateFolderIfDoesNotExist(string FolderPath)
        {
            if (!Directory.Exists(FolderPath))
            {
                try
                {
                    Directory.CreateDirectory(FolderPath);
                }
                catch (Exception)
                {
                    return false;
                    throw;
                }
                
            }
            return true;

        }
        public static string ReplaceFileNameWithGUID(string sourceFile)
        { string filename= sourceFile;
            FileInfo fileInfo = new FileInfo(filename);
            string ext= fileInfo.Extension;

            return CreateGUID()+ext;
        }
        public static bool CopyImageToProjectImagesFolder(ref string sourceFile)
        {
            string DeistentFolderPath=@"C:\DVLD-People-Images\";
            if(!CreateFolderIfDoesNotExist(DeistentFolderPath))
            {
                return false;

            }
            string deistenationFile = DeistentFolderPath + ReplaceFileNameWithGUID(sourceFile);
            try
            {
                File.Copy(sourceFile, deistenationFile,true);
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message, "Error");
                return false;
            }
            sourceFile = deistenationFile;
            return true;
        }
    }
}
