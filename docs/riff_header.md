# WAV Format Documentation: RIFF Header
The RIFF header is a short header at the start of a WAV file, and tells the audio player the file's size and format. RIFF stands for Resource Interchange File Format, and is a general-purpose file format created by Microsoft which is the base of many other file types. The header is set out as follows:

| Section Name | Section Size in Bytes | Endianness | Section Description |
| --- | --- | --- | --- |
| Chunk ID | 4 | big | The ID for this chunk. This section will always hold the value `52494646` which is "RIFF" in ASCII hex. |
| Chunk Size | 4 | little | The remaining size of the file in bytes. This is 36 bytes for the remaining header information plus the size of the actual audio data in bytes. |
| Format | 4 | big | The format of the file, which always holds the value `57415645` which is "WAVE" in ASCII hex. |

### The RIFF header is followed by the [format subchunk](format.md).