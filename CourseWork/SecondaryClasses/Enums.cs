
namespace Enums
{
    // Усі перелічувані типи, які використовує клас VideoFile
    public enum VideoFormat { MP4, AVI, MKV, MOV, Undefined, }

    public enum VideoCodec { AVC, HEVC, AVI1, MPEG, Undefined, }

    public enum AudioCodec { MP3, AAC, FLAC, Opus, Undefined, }

    public enum VideoPlayer { VLC, MPC, PotPlayer, Kodi, Undefined, }
}