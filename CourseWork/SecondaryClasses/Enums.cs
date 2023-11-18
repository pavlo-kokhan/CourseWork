using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    public enum VideoFormat { MP4, AVI, MKV, MOV, Undefined, }

    public enum VideoCodec { AVC, HEVC, AVI1, MPEG, Undefined, }

    public enum AudioCodec { MP3, AAC, FLAC, Opus, Undefined, }

    public enum VideoPlayer { VLC, MPC, PotPlayer, Kodi, Undefined, }
}