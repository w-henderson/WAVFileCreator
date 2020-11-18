# WAV Format Documentation: Format Subchunk
The format subchunk contains metadata about the audio file which affects how it is played back. It's the final section of the header and is set out as follows:

| Section Name | Section Size in Bytes | Endianness | Section Description |
| --- | --- | --- | --- |
| Chunk ID | 4 | big | The ID for this chunk. This section will always hold the value `666d7420` which is "fmt " in ASCII hex. |
| Chunk Size | 4 | little | The remaining size in bytes of this subchunk. For almost all files, this will be `01000000` in hex. |
| Audio Format | 2 | little | This identifies how the audio data is formatted. Most WAV files use PCM which is represented by `0100` in hex. |
| Number of Channels | 2 | little | This contains the number of channels. |
| Sample Rate | 4 | little | This contains the sample rate in Hz of the audio. |
| Byte Rate | 4 | little | This is the number of bytes per second of audio, calculated by `sampleRate * channels * (bitsPerSample) / 8`. |
| Block Align | 2 | little | This is the number of bytes per sample, equal to `channels * (bitsPerSample) / 8` or `byteRate / sampleRate`. |
| Bits per Sample | 2 | little | The number of bits per sample. |


### The format subchunk is followed by the [data subchunk](data.md).