using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ncmdumpGUI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            string ncmFolderPath = @"G:\CloudMusic\VipSongsDownload";
            string mp3FolderPath = @"G:\CloudMusicVipSongsPlain";

            DirectoryInfo ncmDirctoryInfo = new DirectoryInfo(ncmFolderPath);

            foreach (FileInfo fileInfo in ncmDirctoryInfo.GetFiles("*.ncm"))
            {
                //try
                //{
                    NeteaseCrypto neteaseFile = new NeteaseCrypto(fileInfo);
                    neteaseFile.Dump(mp3FolderPath);
                //}
                //catch (TagLib.CorruptFileException ex) //Ignore "MPEG audio header not found.", the error means the audio header does not contain artist, song, etc.. details and their absence should never prevent audio stream loading.
                //{
                //    continue;
                //}
                //catch (Exception ex) // Unknown error, to give user a tips and continue processing.
                //{
                //    continue;
                //}
            }


        }
    }
}
