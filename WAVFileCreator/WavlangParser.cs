using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAVFileCreator
{
    class WavlangParser
    {
        readonly Dictionary<string, double> notes = new Dictionary<string, double>() { { "C0", 16.35 }, { "C#0", 17.32 }, { "DB0", 17.32 }, { "D0", 18.35 }, { "D#0", 19.45 }, { "EB0", 19.45 }, { "E0", 20.6 }, { "F0", 21.83 }, { "F#0", 23.12 }, { "GB0", 23.12 }, { "G0", 24.5 }, { "G#0", 25.96 }, { "AB0", 25.96 }, { "A0", 27.5 }, { "A#0", 29.14 }, { "BB0", 29.14 }, { "B0", 30.87 }, { "C1", 32.7 }, { "C#1", 34.65 }, { "DB1", 34.65 }, { "D1", 36.71 }, { "D#1", 38.89 }, { "EB1", 38.89 }, { "E1", 41.2 }, { "F1", 43.65 }, { "F#1", 46.25 }, { "GB1", 46.25 }, { "G1", 49 }, { "G#1", 51.91 }, { "AB1", 51.91 }, { "A1", 55 }, { "A#1", 58.27 }, { "BB1", 58.27 }, { "B1", 61.74 }, { "C2", 65.41 }, { "C#2", 69.3 }, { "DB2", 69.3 }, { "D2", 73.42 }, { "D#2", 77.78 }, { "EB2", 77.78 }, { "E2", 82.41 }, { "F2", 87.31 }, { "F#2", 92.5 }, { "GB2", 92.5 }, { "G2", 98 }, { "G#2", 103.83 }, { "AB2", 103.83 }, { "A2", 110 }, { "A#2", 116.54 }, { "BB2", 116.54 }, { "B2", 123.47 }, { "C3", 130.81 }, { "C#3", 138.59 }, { "DB3", 138.59 }, { "D3", 146.83 }, { "D#3", 155.56 }, { "EB3", 155.56 }, { "E3", 164.81 }, { "F3", 174.61 }, { "F#3", 185 }, { "GB3", 185 }, { "G3", 196 }, { "G#3", 207.65 }, { "AB3", 207.65 }, { "A3", 220 }, { "A#3", 233.08 }, { "BB3", 233.08 }, { "B3", 246.94 }, { "C4", 261.63 }, { "C#4", 277.18 }, { "DB4", 277.18 }, { "D4", 293.66 }, { "D#4", 311.13 }, { "EB4", 311.13 }, { "E4", 329.63 }, { "F4", 349.23 }, { "F#4", 369.99 }, { "GB4", 369.99 }, { "G4", 392 }, { "G#4", 415.3 }, { "AB4", 415.3 }, { "A4", 440 }, { "A#4", 466.16 }, { "BB4", 466.16 }, { "B4", 493.88 }, { "C5", 523.25 }, { "C#5", 554.37 }, { "DB5", 554.37 }, { "D5", 587.33 }, { "D#5", 622.25 }, { "EB5", 622.25 }, { "E5", 659.26 }, { "F5", 698.46 }, { "F#5", 739.99 }, { "GB5", 739.99 }, { "G5", 783.99 }, { "G#5", 830.61 }, { "AB5", 830.61 }, { "A5", 880 }, { "A#5", 932.33 }, { "BB5", 932.33 }, { "B5", 987.77 }, { "C6", 1046.5 }, { "C#6", 1108.73 }, { "DB6", 1108.73 }, { "D6", 1174.66 }, { "D#6", 1244.51 }, { "EB6", 1244.51 }, { "E6", 1318.51 }, { "F6", 1396.91 }, { "F#6", 1479.98 }, { "GB6", 1479.98 }, { "G6", 1567.98 }, { "G#6", 1661.22 }, { "AB6", 1661.22 }, { "A6", 1760 }, { "A#6", 1864.66 }, { "BB6", 1864.66 }, { "B6", 1975.53 }, { "C7", 2093 }, { "C#7", 2217.46 }, { "DB7", 2217.46 }, { "D7", 2349.32 }, { "D#7", 2489.02 }, { "EB7", 2489.02 }, { "E7", 2637.02 }, { "F7", 2793.83 }, { "F#7", 2959.96 }, { "GB7", 2959.96 }, { "G7", 3135.96 }, { "G#7", 3322.44 }, { "AB7", 3322.44 }, { "A7", 3520 }, { "A#7", 3729.31 }, { "BB7", 3729.31 }, { "B7", 3951.07 }, { "C8", 4186.01 }, { "C#8", 4434.92 }, { "DB8", 4434.92 }, { "D8", 4698.64 }, { "D#8", 4978.03 }, { "EB8", 4978.03 } };

        public string ParseWavlang(string wavlang)
        {
            string[] split = wavlang.Split('[', ']');
            string output = "";
            for (int i = 0; i < split.Length; i++)
            {
                if (i % 2 == 0)
                {
                    output += split[i];
                } else
                {
                    string wavlangSyntax = split[i].Replace(" ","");
                    string[] commands = wavlangSyntax.Split(',');
                    if (commands[0] == "mul")
                    {
                        // format of command: [mul,<hexToRepeat>,<count>]
                        int mulTimes;
                        if (commands.Length == 3 && int.TryParse(commands[2], out mulTimes))
                        {
                            output += string.Concat(Enumerable.Repeat(commands[1], mulTimes));
                        }
                        else
                        {
                            throw new Exception("Syntax error in Wavlang: mul function was supplied with invalid parameters.");
                        }
                    }
                    else if (commands[0] == "sin" || commands[0] == "sqr")
                    {
                        if (notes.ContainsKey(commands[1].ToUpper()))
                        {
                            commands[1] = notes[commands[1].ToUpper()].ToString();
                        }
                        // format of command: [sin,<frequency Hz or note>,<duration sec>]
                        if (commands.Length == 3 && float.TryParse(commands[1], out float freqInHz) && float.TryParse(commands[2], out float duration))
                        {
                            string sinOut = "";
                            int sampleRate = Program.form.getSampleRate();
                            int bitsPerSample = Program.form.getBitsPerSample();
                            int channels = Program.form.getChannels();
                            for (int sample = 0; sample < duration * sampleRate; sample++)
                            {
                                float sinValue = (float)Math.Sin((Math.PI * 2 * sample * freqInHz) / (float)sampleRate);
                                for (int ii = 0; ii < channels; ii++)
                                {
                                    if (bitsPerSample == 8)
                                    {
                                        if (commands[0] == "sin")
                                        {
                                            sinOut += ((int)Math.Round((sinValue + 1) * 127)).ToString("X2");
                                        } else
                                        {
                                            if (sinValue > 0)
                                            {
                                                sinOut += "ff";
                                            } else
                                            {
                                                sinOut += "00";
                                            }
                                        }
                                    } else if (bitsPerSample == 16)
                                    {
                                        if (commands[0] == "sin")
                                        {
                                            sinOut += MainForm.ReverseEndianness(((short)Math.Round(sinValue * 32767)).ToString("X4"));
                                        } else
                                        {
                                            if (sinValue > 0)
                                            {
                                                sinOut += "ff7f";
                                            } else
                                            {
                                                sinOut += "0180";
                                            }
                                        }
                                    } else
                                    {
                                        throw new Exception("Unknown bits per sample, please choose 8 or 16.");
                                    }
                                }
                            }
                            output += sinOut;
                        }
                        else
                        {
                            throw new Exception("Syntax error in Wavlang: "+commands[0]+" function was supplied with invalid parameters.");
                        }
                    }
                    else
                    {
                        throw new Exception("Syntax error in Wavlang: unknown function " + commands[0] + ".");
                    }
                }
            }
            return output;
        }
    }
}
