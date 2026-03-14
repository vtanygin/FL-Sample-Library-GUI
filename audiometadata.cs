using System;
using System.Collections.Generic;
using System.Text;

namespace FL_Sample_Library_GUI
{
    using NAudio.Wave;
    using NAudio.Gui; //this can make a built in audio player
    using NAudio.Extras;
    using TagLib;

    public class AudioMetadata
    {
        public string FilePath { get; set; }
        public TimeSpan Length { get; set; }
        public double PeakVolume { get; set; }
        public string Title { get; set; }
        // add pitch, sample rate, etc.

        public static AudioMetadata Load(string path)
        {
            var meta = new AudioMetadata { FilePath = path };

            using (var reader = new AudioFileReader(path))
            {
                meta.Length = reader.TotalTime;
                meta.PeakVolume = reader.Volume; // or sample the stream for true peak
            }
            var tags = TagLib.File.Create(path);
            meta.Title = tags.Tag.Title;
            return meta;
        }
    }

}
