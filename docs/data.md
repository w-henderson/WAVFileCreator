# WAV Format Documentation: Data Subchunk
The data subchunk is the final subchunk of the file, containing the raw audio data as well as a small header.

| Section Name | Section Size in Bytes | Endianness | Section Description |
| --- | --- | --- | --- |
| Chunk ID | 4 | big | The ID for this chunk. This section will always hold the value `64617461` which is "data" in ASCII hex. |
| Chunk Size | 4 | little | The number of bytes in the following audio data. |
| Data | * | little | The actual audio data. If there's two channels, the data alternates between a sample for left and a sample for right. 8-bit samples are unsigned integers and 16-bit samples are 2's complement signed integers.