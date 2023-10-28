using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Net;
using KAF.BusinessDataObjects.BusinessDataObjectsPartials;
using System.Drawing;
using System.Drawing.Imaging;

namespace KAF.AppConfiguration.Configuration
{
    public class FileHandler
    {

        /// <summary>
        /// Get FileFrom FTP List By CivilID
        /// </summary>
        /// <method name="GetFileFromFTPListByCivilID" type="List<KAF_ReplyContainerEntity>"></method>
        /// <param name="civilid" type="string"></param>
        /// <param name="ftpFolder" type="string"></param>
        /// <returns></returns>
        public List<KAF_ReplyContainerEntity> GetFileFromFTPListByCivilID(string ftpFolder, string civilid = "")
        {
            string strMsg = string.Empty;
            var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string strmsg = string.Empty;
            string _Password = _apsSettings["pass"] ?? null;
            string _UserName = _apsSettings["user"] ?? null;
            string _ftpURL = _apsSettings["ftpAddress"] ?? null;

            List<KAF_ReplyContainerEntity> objFiles = new List<KAF_ReplyContainerEntity>();
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpURL + ftpFolder);
                request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

                //Enter FTP Server credentials.
                request.Credentials = new NetworkCredential(_UserName, _Password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.EnableSsl = false;

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                List<string> entries = new List<string>();
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    //Read the Response as String and split using New Line character.
                    entries = reader.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries).ToList();
                }
                response.Close();

                foreach (string entry in entries)
                {
                    KAF_ReplyContainerEntity objFile = new KAF_ReplyContainerEntity();
                    string[] splits = entry.Split(new string[] { " ", }, StringSplitOptions.RemoveEmptyEntries);

                    //Determine whether entry is for File or Directory.
                    bool isFile = splits[0].Substring(0, 1) != "d";
                    bool isDirectory = splits[0].Substring(0, 1) == "d";

                    //If entry is for File, add details to DataTable.
                    if (isFile)
                    {
                        objFile.strValue1 = (decimal.Parse(splits[2]) / 1024).ToString();
                        objFile.strValue2 = string.Join(" ", splits[0], splits[1]);

                        objFile.strValue3 = splits[3];
                        if (civilid != "")
                        {
                            if (objFile.strValue3.Contains(civilid))
                                objFiles.Add(objFile);
                        }
                        else
                        {
                            objFiles.Add(objFile);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return objFiles;
        }
        public static string GetRelativePath(string ftpBasePath, string ftpToPath)
        {

            if (!ftpBasePath.StartsWith("/"))
            {
                throw new Exception("Base path is not absolute");
            }
            else
            {
                ftpBasePath = ftpBasePath.Substring(1);
            }
            if (ftpBasePath.EndsWith("/"))
            {
                ftpBasePath = ftpBasePath.Substring(0, ftpBasePath.Length - 1);
            }

            if (!ftpToPath.StartsWith("/"))
            {
                throw new Exception("Base path is not absolute");
            }
            else
            {
                ftpToPath = ftpToPath.Substring(1);
            }
            if (ftpToPath.EndsWith("/"))
            {
                ftpToPath = ftpToPath.Substring(0, ftpToPath.Length - 1);
            }
            string[] arrBasePath = ftpBasePath.Split("/".ToCharArray());
            string[] arrToPath = ftpToPath.Split("/".ToCharArray());

            int basePathCount = arrBasePath.Count();
            int levelChanged = basePathCount;
            for (int iIndex = 0; iIndex < basePathCount; iIndex++)
            {
                if (arrToPath.Count() > iIndex)
                {
                    if (arrBasePath[iIndex] != arrToPath[iIndex])
                    {
                        levelChanged = iIndex;
                        break;
                    }
                }
            }
            int HowManyBack = basePathCount - levelChanged;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < HowManyBack; i++)
            {
                sb.Append("../");
            }
            for (int i = levelChanged; i < arrToPath.Count(); i++)
            {
                sb.Append(arrToPath[i]);
                sb.Append("/");
            }

            return sb.ToString();
        }


        public bool  MoveFTPFile( string ftpfrompath, string ftptopath, string filename)
        {
            string retval = string.Empty;

            try
            {
                var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
                string _Password = _apsSettings["pass"] ?? null;
                string _UserName = _apsSettings["user"] ?? null;
                string _ftpURL = _apsSettings["ftpAddress"] ?? null;


                FtpWebRequest ftp = (FtpWebRequest)FtpWebRequest.Create(_ftpURL + ftpfrompath+"/"+  filename);
                ftp.Method = WebRequestMethods.Ftp.Rename;
                ftp.Credentials = new NetworkCredential(_UserName, _Password);
                ftp.UsePassive = true;
                ftp.RenameTo = "../"+ ftptopath + "/Upload/" + filename;//   GetRelativePath(ftpfrompath, ftptopath) + filename;

                FtpWebResponse response = (FtpWebResponse)ftp.GetResponse();

                return true;
            }
            catch(Exception es)
            {
                return false;
            }

        }

        public bool CreateFTPDir(string pathToCreate)
        {
            FtpWebRequest reqFTP = null;
            Stream ftpStream = null;

            var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string _Password = _apsSettings["pass"] ?? null;
            string _UserName = _apsSettings["user"] ?? null;
            string _ftpURL = _apsSettings["ftpAddress"] ?? null;

            string currentDir = "";

            try
            {
                currentDir = _ftpURL + pathToCreate;
                reqFTP = (FtpWebRequest)FtpWebRequest.Create(currentDir);
                reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                reqFTP.UseBinary = true;
                reqFTP.Credentials = new NetworkCredential(_UserName, _Password);
                FtpWebResponse response = (FtpWebResponse)reqFTP.GetResponse();
                ftpStream = response.GetResponseStream();
                ftpStream.Close();
                response.Close();
                return true;
            }
            catch (WebException e)
            {
                String status = ((FtpWebResponse)e.Response).StatusDescription;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }
        /// <summary>
        /// Folder Check from FTP by fileupload directory
        /// </summary>
        /// <method name="FolderCheckFTP" type="bool"></method>
        /// <param name="fileUploadDir" type="string"></param>
        /// <returns></returns>
        public void FolderCheckFTP(string fileUploadDir)
        {
            string strMsg = string.Empty;
            var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string strmsg = string.Empty;
            string _Password = _apsSettings["pass"] ?? null;
            string _UserName = _apsSettings["user"] ?? null;
            string _ftpURL = _apsSettings["ftpAddress"] ?? null;

            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpURL + fileUploadDir);
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(_UserName, _Password);
                using (FtpWebResponse res = (FtpWebResponse)request.GetResponse())
                {
                    // Okay. 
                }
            }
            catch (WebException ex)
            {
                if (ex.Response != null)
                {
                    FtpWebResponse response = (FtpWebResponse)ex.Response;
                    if (response.StatusCode == FtpStatusCode.ActionNotTakenFileUnavailable)
                    {
                        KAF.AppConfiguration.Configuration.FileHandler objFTP = new KAF.AppConfiguration.Configuration.FileHandler();
                        string mainfolder = fileUploadDir.Substring(0, 36);
                        string userfolderpath = mainfolder + "/";
                        objFTP.CreateFTPDir(userfolderpath);
                        var otherfolderpath = userfolderpath + "Tasks/";
                        objFTP.CreateFTPDir(otherfolderpath);
                        otherfolderpath = userfolderpath + "Meeting/";
                        objFTP.CreateFTPDir(otherfolderpath);
                        otherfolderpath = userfolderpath + "Correspondance/";
                        objFTP.CreateFTPDir(otherfolderpath);
                        otherfolderpath = userfolderpath + "Upload/";
                        objFTP.CreateFTPDir(otherfolderpath);
                    }
                }
            }
        }
        /// <summary>
        /// Delete File from FTP
        /// </summary>
        /// <param name="fileUploadDir" type="string"></param>
        /// <param name="FileNamePrefix" type="string"></param>
        /// <param name="fileExtension" type="string"></param>
        /// <returns></returns>
        public string DeleteFileFTP(string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            string strMsg = string.Empty;
            var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string strmsg = string.Empty;
            string _Password = _apsSettings["pass"] ?? null;
            string _UserName = _apsSettings["user"] ?? null;
            string _ftpURL = _apsSettings["ftpAddress"] ?? null;

            try
            {
                if (!string.IsNullOrEmpty(_Password) && !string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_ftpURL))
                {
                    if (!fileUploadDir.Contains("/"))
                        fileUploadDir = fileUploadDir + "/";
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpURL + fileUploadDir + FileNamePrefix + fileExtension);
                    request.Method = WebRequestMethods.Ftp.DeleteFile;
                    request.Credentials = new NetworkCredential(_UserName, _Password);
                    request.Proxy = null;
                    request.UseBinary = false;
                    request.UsePassive = true;
                    request.KeepAlive = false;
                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    Stream responseStream = response.GetResponseStream();
                    StreamReader sr = new StreamReader(responseStream);
                    sr.ReadToEnd();
                    string StatusCode = response.StatusDescription;
                    sr.Close();
                    response.Close();
                }
            }
            catch (Exception ex)
            {
                strmsg = ex.Message;

            }
            return strMsg;
        }
        /// <summary>
        /// Upload File to FTP
        /// </summary>
        /// <method name="UploadFileFTP" type="string"></method>
        /// <param name="Myfile" type="byte[]"></param>
        /// <param name="fileUploadDir" type="string"></param>
        /// <param name="FileNamePrefix" type="string"></param>
        /// <param name="fileExtension" type="string"></param>
        /// <returns></returns>
        public string UploadFileFTP(byte[] Myfile, string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            string strMsg = string.Empty;
            var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string strmsg = string.Empty;
            string _Password = _apsSettings["pass"] ?? null;
            string _UserName = _apsSettings["user"] ?? null;
            string _ftpURL = _apsSettings["ftpAddress"] ?? null;

            try
            {
                if (!string.IsNullOrEmpty(_Password) && !string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_ftpURL))
                {
                    FolderCheckFTP(fileUploadDir);
                    if (!fileUploadDir.Contains("/"))
                        fileUploadDir = fileUploadDir + "/";



                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpURL + fileUploadDir + FileNamePrefix + fileExtension);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(_UserName, _Password);
                    Stream ftpstream = request.GetRequestStream();
                    ftpstream.Write(Myfile, 0, Myfile.Length);
                    ftpstream.Close();

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                    strmsg = response.StatusDescription;

                    response.Close();
                }
            }
            catch (Exception ex)
            {
                strmsg = ex.Message;

            }
            return strMsg;
        }

        /// <summary>   Get Memory Stram From File. </summary>
        /// <remarks>   2/7/2017. </remarks>
        /// <method name="GetMemoryStramFromFile" type="byte[]">  GetMemoryStramFromFile. </method>
        /// <exception cref="Exception" >    Thrown when an exception error condition occurs. </exception>
        /// <param name="fileUploadDir" type="string">    . </param>
        /// <param name="FileNamePrefix" type="string">   . </param>
        /// <param name="fileExtension" type="string">    . </param>
        /// <returns>   An array of byte. </returns>

        public byte[] GetMemoryStramFromFile(string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            try
            {
                var webClient = new WebClient();
                byte[] imageBytes = webClient.DownloadData(fileUploadDir + FileNamePrefix + fileExtension);
                return imageBytes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Get Memory Stram From File
        /// </summary>
        /// <method name="GetMemoryStramFromFile" type="byte[]"></method>
        /// <param name="flUploader" type="System.Web.UI.WebControls.FileUpload"></param>
        /// <returns></returns>
        public byte[] GetMemoryStramFromFile(System.Web.UI.WebControls.FileUpload flUploader)
        {
            try
            {
                Stream input = flUploader.PostedFile.InputStream;
                byte[] buffer = new byte[input.Length];
                using (MemoryStream ms = new MemoryStream())
                {
                    int read;
                    while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ms.Write(buffer, 0, read);
                    }
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Upload File
        /// </summary>
        /// <method name="UploadFile" type="string"></method>
        /// <param name="Myfile" type="byte[]"></param>
        /// <param name="fileName" type="string"></param>
        /// <returns></returns>
        public string UploadFile(byte[] Myfile, string fileName)
        {
            string strMsg = string.Empty;
            var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string strmsg = string.Empty;
            string _Password = _apsSettings["_Password"] ?? null;
            string _UserName = _apsSettings["_UserName"] ?? null;
            string _ftpURL = _apsSettings["_ftpURL"] ?? null;

            try
            {
                if (!string.IsNullOrEmpty(_Password) && !string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_ftpURL))
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://" + _ftpURL + @"/" + fileName);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(_UserName, _Password);
                    Stream ftpstream = request.GetRequestStream();
                    ftpstream.Write(Myfile, 0, Myfile.Length);
                    ftpstream.Close();

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                    strmsg = response.StatusDescription;

                    response.Close();
                }
            }
            catch (Exception ex)
            {
                strmsg = ex.Message;

            }
            return strMsg;
        }

        /// <summary>   Reads web string. </summary>
        /// <remarks>   2/7/2017. </remarks>
        /// <method name="ReadWebString">   ReadWebString. </method>
        /// <param name="fileUploadDir">    . </param>
        /// <param name="FileNamePrefix">   . </param>
        /// <param name="fileExtension">    . </param>
        /// <returns>   The web string. </returns>

        public string ReadWebString(string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            string strMsg = string.Empty;
            var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string strmsg = string.Empty;
            string _Password = _apsSettings["pass"] ?? null;
            string _UserName = _apsSettings["user"] ?? null;
            string _ftpURL = _apsSettings["uploadfolder"] ?? null;

            try
            {
                if (!string.IsNullOrEmpty(_Password) && !string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_ftpURL))
                {
                    HttpWebRequest webrequest = (HttpWebRequest)HttpWebRequest.Create(_ftpURL + fileUploadDir + FileNamePrefix + fileExtension);
                    webrequest.Method = "GET";
                    webrequest.ContentLength = 0;

                    WebResponse response = webrequest.GetResponse();

                    using (StreamReader stream = new StreamReader(response.GetResponseStream()))
                    {
                        strMsg = stream.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                strmsg = ex.Message;

            }
            return strMsg;
        }

        /// <summary>   Writes a FTP string. </summary>
        /// <remarks>   2/7/2017. </remarks>
        /// <method name="WriteFTPString">  WriteFTPString. </method>
        /// <param name="fileUploadDir">    . </param>
        /// <param name="FileNamePrefix">   . </param>
        /// <param name="fileExtension">    . </param>
        /// <param name="str">              The string. </param>
        /// <returns>   A string. </returns>

        public string WriteFTPString(string fileUploadDir, string FileNamePrefix, string fileExtension, string str)
        {
            string strMsg = string.Empty;
            var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string strmsg = string.Empty;
            string _Password = _apsSettings["pass"] ?? null;
            string _UserName = _apsSettings["user"] ?? null;
            string _ftpURL = _apsSettings["ftpAddress"] ?? null;

            try
            {
                if (!string.IsNullOrEmpty(_Password) && !string.IsNullOrEmpty(_UserName) && !string.IsNullOrEmpty(_ftpURL))
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(_ftpURL + fileUploadDir + FileNamePrefix + fileExtension);
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(_UserName, _Password);

                    request.ContentLength = str.Length;
                    using (Stream request_stream = request.GetRequestStream())
                    {
                        byte[] bytes = Encoding.UTF8.GetBytes(str);
                        request_stream.Write(bytes, 0, str.Length);
                        request_stream.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                strmsg = ex.Message;

            }
            return strMsg;
        }

        
        /// <summary>
        /// SearchDirectory
        /// </summary>
        /// <method name="SearchDirectory" type="List<string>"></method>
        /// <param name="FileName" type="string"></param>
        /// <param name="DirectoryName" type="string"></param>
        /// <returns></returns>
        public List<string> SearchDirectory(string FileName, string DirectoryName)
        {            //Declare a List of Strings for Returning File Names            
            List<string> strFileNames = new List<string>();
            try
            {
                //Get the Directory Info using Directory Name                
                DirectoryInfo dirInfor = new DirectoryInfo(DirectoryName);
                // Get all files whose names starts with FileName Passed                 
                FileInfo[] filesInfo = dirInfor.GetFiles(FileName + "*", SearchOption.AllDirectories);
                //Loop through all the files found and add to                 
                //List and return them                
                foreach (FileInfo fi in filesInfo)
                {
                    strFileNames.Add(fi.FullName);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return strFileNames;
        }
        /// <summary>
        /// Check File Exists
        /// </summary>
        /// <method name="CheckFileExists" type="bool"></method>
        /// <param name="fileinfo" type="FileInfo"></param>
        /// <param name="dirName" type="string"></param>
        /// <returns></returns>
        public bool CheckFileExists(FileInfo fileinfo, string dirName)
        {
            bool flg = false;
            string UploadFolder;
            UploadFolder = HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + fileinfo.Name;

            if (File.Exists(UploadFolder))
                flg = false;
            else
                flg = true;

            return flg;
        }
        /// <summary>
        /// Delete A File
        /// </summary>
        /// <method name="DeleteAFile" type="bool"></method>
        /// <param name="fileinfo" type="FileInfo"></param>
        /// <param name="dirName" type="string"></param>
        /// <returns></returns>
        public bool DeleteAFile(FileInfo fileinfo, string dirName)
        {
            bool flg = false;
            try
            {
                FileInfo TheFile = new FileInfo(HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + fileinfo.Name);
                if (TheFile.Exists)
                {
                    File.Delete(HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + fileinfo.Name);
                }
                else
                {
                    throw new FileNotFoundException();
                }
                return flg;
            }
            catch (FileNotFoundException ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
            catch (Exception ex1)
            {
                string msg = ex1.Message.ToString();
                return false;
            }
        }
        /// <summary>
        /// Rename A File
        /// </summary>
        /// <method name="RenameAFile" type="bool"></method>
        /// <param name="fileinfo" type="FileInfo"></param>
        /// <param name="dirName" type="string"></param>
        /// <param name="newNameWithExtension" type="string"></param>
        /// <returns></returns>
        public bool RenameAFile(FileInfo fileinfo, string dirName, string newNameWithExtension)
        {
            bool flg = false;
            try
            {
                FileInfo TheFile = new FileInfo(HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + fileinfo.Name);
                if (TheFile.Exists)
                {
                    File.Move(HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + fileinfo.Name, HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + newNameWithExtension);
                }
                else
                {
                    throw new FileNotFoundException();
                }
                return flg;
            }
            catch (FileNotFoundException ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
            catch (Exception ex1)
            {
                string msg = ex1.Message.ToString();
                return false;
            }
        }
        /// <summary>
        /// Move  File To New Directory
        /// </summary>
        /// <method name="MoveAFileToNewDirectory" type="bool"></method>
        /// <param name="fileinfo" type="FileInfo"></param>
        /// <param name="dirName" type="string"></param>
        /// <param name="newDirName" type="string"></param>
        /// <returns></returns>
        public bool MoveAFileToNewDirectory(FileInfo fileinfo, string dirName, string newDirName)
        {
            bool flg = false;
            try
            {
                FileInfo TheFile = new FileInfo(HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + fileinfo.Name);
                if (TheFile.Exists)
                {
                    if (Directory.Exists(HttpRuntime.AppDomainAppPath + "\\" + newDirName))
                    {
                        File.Move(HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + fileinfo.Name, HttpRuntime.AppDomainAppPath + "\\" + newDirName + "\\" + fileinfo.Name);
                        flg = true;
                    }
                    else
                    {
                        flg = false;
                        throw new DirectoryNotFoundException();
                    }
                }
                else
                {
                    flg = false;
                }
                return flg;
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
        }
        /// <summary>
        /// Move All File To NewDirectory
        /// </summary>
        /// <method name="MovellAFileToNewDirectory" type="bool"></method>
        /// <param name="dirName" type="string"></param>
        /// <param name="newDirName" type="string"></param>
        /// <returns></returns>
        public bool MovellAFileToNewDirectory(string dirName, string newDirName)
        {
            FileInfo[] file = null;
            int i = 0;

            bool flg = false;
            try
            {
                if (Directory.Exists(HttpRuntime.AppDomainAppPath + "\\" + dirName))
                {
                    DirectoryInfo dir = new DirectoryInfo(HttpRuntime.AppDomainAppPath + "\\" + dirName);
                    file = dir.GetFiles();
                    if (file.Length > 0)
                    {
                        for (i = 0; i < file.Length; i++)
                        {
                            File.Move(HttpRuntime.AppDomainAppPath + "\\" + dirName + "\\" + file[i].Name, HttpRuntime.AppDomainAppPath + "\\" + newDirName + "\\" + file[i].Name);
                            flg = true;
                        }
                    }
                }
                return flg;
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
        }
        /// <summary>
        /// Delete All Files And Folder In Directory
        /// </summary>
        /// <method name="DeleteAllFilesAndFolderInDirectory" type="bool"></method>
        /// <param name="dirName" type="string"></param>
        /// <returns></returns>
        public bool DeleteAllFilesAndFolderInDirectory(string dirName)
        {
            DirectoryInfo[] Dire = null;
            FileInfo[] file = null;
            int i = 0;

            bool flg = false;
            try
            {
                if (Directory.Exists(HttpRuntime.AppDomainAppPath + "\\" + dirName))
                {
                    DirectoryInfo dir = new DirectoryInfo(HttpRuntime.AppDomainAppPath + "\\" + dirName);
                    Dire = dir.GetDirectories();
                    file = dir.GetFiles();
                    if (Dire.Length > 0)
                    {
                        for (i = 0; i < Dire.Length; i++)
                        {
                            Dire[i].Delete(true);
                        }
                    }
                    if (file.Length > 0)
                    {
                        for (i = 0; i < file.Length; i++)
                        {
                            file[i].Delete();
                        }
                    }
                    flg = true;
                }
                else
                    flg = false;
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
            return flg;
        }
        /// <summary>
        /// Delete All Files In Directory
        /// </summary>
        /// <method name="DeleteAllFilesInDirectory" type="bool"></method>
        /// <param name="dirName" type="string"></param>
        /// <returns></returns>
        public bool DeleteAllFilesInDirectory(string dirName)
        {
            FileInfo[] file = null;
            int i = 0;

            bool flg = false;
            try
            {
                if (Directory.Exists(HttpRuntime.AppDomainAppPath + "\\" + dirName))
                {
                    DirectoryInfo dir = new DirectoryInfo(HttpRuntime.AppDomainAppPath + "\\" + dirName);
                    file = dir.GetFiles();
                    if (file.Length > 0)
                    {
                        for (i = 0; i < file.Length; i++)
                        {
                            file[i].Delete();
                        }
                    }
                    flg = true;
                }
                else
                    flg = false;
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
            return flg;
        }
        /// <summary>
        /// Delete All Files In Directory With Extension Specific Extension
        /// </summary>
        /// <method name="DeleteAllFilesInDirectoryWithExtensionSpecificExtension" type="bool"></method>
        /// <param name="dirName" type="string"></param>
        /// <param name="extensionName" type="string"></param>
        /// <returns></returns>
        public bool DeleteAllFilesInDirectoryWithExtensionSpecificExtension(string dirName, string extensionName)
        {
            FileInfo[] file = null;
            int i = 0;

            bool flg = false;
            try
            {
                // how to get Extension strFileName.Substring(strFileName.LastIndexOf(".") + 1)
                if (Directory.Exists(HttpRuntime.AppDomainAppPath + "\\" + dirName))
                {
                    DirectoryInfo dir = new DirectoryInfo(HttpRuntime.AppDomainAppPath + "\\" + dirName);
                    file = dir.GetFiles();
                    if (file.Length > 0)
                    {
                        for (i = 0; i < file.Length; i++)
                        {
                            if (file[i].Name.ToString().Substring(file[i].Name.LastIndexOf(".") + 1).ToString() == extensionName)
                                file[i].Delete();
                        }
                    }
                    flg = true;
                }
                else
                    flg = false;
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
            return flg;
        }
        /// <summary>
        /// Create A Directory
        /// </summary>
        /// <method name="CreateADirectory" type="bool"></method>
        /// <param name="dirName" type="string"></param>
        /// <returns></returns>
        public bool CreateADirectory(string dirName)
        {
            bool flg = false;
            try
            {
                if (Directory.Exists(HttpRuntime.AppDomainAppPath + "\\" + dirName))
                {
                    Directory.CreateDirectory(HttpRuntime.AppDomainAppPath + "\\" + dirName);
                    flg = true;
                }
                else
                {
                    flg = false;
                }
                return flg;
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
        }
        /// <summary>
        /// Delete A Directory
        /// </summary>
        /// <method name="DeleteADirectory" type="bool"></method>
        /// <param name="dirName" type="string"></param>
        /// <returns></returns>
        public bool DeleteADirectory(string dirName)
        {
            bool flg = false;
            try
            {
                if (Directory.Exists(HttpRuntime.AppDomainAppPath + "\\" + dirName))
                {
                    Directory.Delete(HttpRuntime.AppDomainAppPath + "\\" + dirName);
                    flg = true;
                }
                else
                {
                    flg = false;
                }
                return flg;
            }
            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                return false;
            }
        }
        /// <summary>
        /// Stream File To Browser
        /// </summary>
        /// <method name="StreamFileToBrowser" type="void"></method>
        /// <param name="context" type="System.Web.HttpContext"></param>
        /// <param name="Physicalfullpath" type="string"></param>
        /// <param name="ImgfileData" type="string"></param>
        /// <param name="filetype" type="string"></param>
        /// <param name="fileName" type="string"></param>
        public void StreamFileToBrowser(System.Web.HttpContext context, string Physicalfullpath,
            byte[] ImgfileData, string filetype, string fileName)
        {
            byte[] fileBytes = null;

            if (Physicalfullpath != null)
            {
                fileBytes = System.IO.File.ReadAllBytes(Physicalfullpath);
            }
            else
            {
                fileBytes = ImgfileData;
            }

            context.Response.Clear();
            context.Response.ClearHeaders();
            context.Response.ClearContent();
            context.Response.AppendHeader("content-length", fileBytes.Length.ToString());
            context.Response.ContentType = filetype;
            context.Response.AppendHeader("content-disposition", "attachment; filename=" + fileName);
            context.Response.BinaryWrite(fileBytes);

            // use this instead of response.end to avoid thread aborted exception (known issue):
            // http://support.microsoft.com/kb/312629/EN-US
            context.ApplicationInstance.CompleteRequest();
        }

        /// <summary>   Downloads from FTP. </summary>
        /// <remarks>   2/7/2017. </remarks>
        /// <method name="DownloadFromFTP"> DownloadFromFTP. </method>
        /// <param name="filename">         Filename of the file. </param>
        /// <param name="fileUploadDir">    . </param>

        public void DownloadFromFTP(string filename, string fileUploadDir)
        {

            string ftpAddress = System.Configuration.ConfigurationManager.AppSettings["ftpAddress"].ToString();
            string user = System.Configuration.ConfigurationManager.AppSettings["user"].ToString();
            string pass = System.Configuration.ConfigurationManager.AppSettings["pass"].ToString();

            string crFtp = ftpAddress + "/" + fileUploadDir + filename;

            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create(ftpAddress);
            ftpRequest.Credentials = new NetworkCredential(user, pass);
            //ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;
            //FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            //StreamReader streamReader = new StreamReader(response.GetResponseStream());
            //List<string> directories = new List<string>();

            //string line = streamReader.ReadLine();
            //while (!string.IsNullOrEmpty(line))
            //{
            //    directories.Add(line);
            //    line = streamReader.ReadLine();
            //}
            //streamReader.Close();


            using (WebClient ftpClient = new WebClient())
            {
                ftpClient.Credentials = new System.Net.NetworkCredential(user, pass);

                //    for (int i = 0; i <= directories.Count - 1; i++)
                //    {
                //        if (directories[i].Contains("."))
                //        {

                //            string path = ftpAddress + directories[i].ToString();
                string trnsfrpth = @"D:\\Test\" + fileUploadDir;
                ftpClient.DownloadFile(crFtp, trnsfrpth);
            }
        }

        public void UploadPhoto(HttpPostedFileBase file, string UploadDir)
        {
            string msg = String.Empty;
            try
            {
                //Bitmap b = (Bitmap)Bitmap.FromStream(file.InputStream);
                //using (MemoryStream ms = new MemoryStream())
                //{
                //    b.Save(ms, ImageFormat.Jpeg);  
                //}
                file.SaveAs(UploadDir);
            }
            catch (Exception ex)
            {
                msg = ex.Message;
            }
        }

        public string UploadFileHTTP(byte[] Myfile, string fileUploadDir, string FileNamePrefix, string fileExtension)
        {
            string strMsg = string.Empty;
            //var _apsSettings = System.Configuration.ConfigurationManager.AppSettings;
            string strmsg = string.Empty;

            try
            {
                //FolderCheckFTP(fileUploadDir);
                //if (!fileUploadDir.Contains("/"))
                //    fileUploadDir = fileUploadDir + "/";


                string imageURL = Path.Combine("http://" + fileUploadDir, FileNamePrefix + fileExtension);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(imageURL);
                Stream stream = request.GetRequestStream();
                stream.Write(Myfile, 0, Myfile.Length);
                stream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                strmsg = response.StatusDescription;

                response.Close();
            }
            catch (Exception ex)
            {
                strmsg = ex.Message;

            }
            return strMsg;

        }

    }
}
