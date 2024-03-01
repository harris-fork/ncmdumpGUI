using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ncmdumpGUI
{
    class NeteaseCopyrightData
    {
        [JsonProperty("musicId")]
        public int MusicId { get; set; }

        [JsonProperty("musicName")]
        public string MusicName { get; set; }

        [JsonProperty("artist")]
        public List<List<string>> Artist { get; set; }

        [JsonProperty("albumId")]
        public int AlbumId { get; set; }

        [JsonProperty("album")]
        public string Album { get; set; }

        [JsonProperty("albumPicDocId")]
        public string AlbumPicDocId { get; set; }

        [JsonProperty("albumPic")]
        public string AlbumPic { get; set; }

        [JsonProperty("bitrate")]
        public int Bitrate { get; set; }

        [JsonProperty("mp3DocId")]
        public string Mp3DocId { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        [JsonProperty("mvId")]
        public string MvId { get; set; }

        [JsonProperty("alias")]
        public List<string> Alias { get; set; }

        // missing `transNames` unknow type usually empty

        [JsonProperty("format")]
        public string Format { get; set; }
    }
}
