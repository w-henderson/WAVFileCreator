using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WAVFileCreator
{
    class WavlangParser
    {
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
                    else if (commands[0] == "sin")
                    {
                        // format of command: [sin,<frequency Hz>,<duration sec>]
                        if (commands.Length == 3 && float.TryParse(commands[1], out float freqInHz) && float.TryParse(commands[2], out float duration))
                        {
                            string sinOut = "";
                            int sampleRate = Program.form.getSampleRate();
                            for (int sample = 0; sample < duration * sampleRate; sample++)
                            {
                                float sinValue = (float)Math.Sin((Math.PI * 2 * sample * freqInHz) / (float)sampleRate);
                                sinOut += ((int)Math.Round((sinValue + 1) * 127)).ToString("X2"); // currently only supports 8 bit
                            }
                            output += sinOut;
                        }
                        else
                        {
                            throw new Exception("Syntax error in Wavlang: sin function was supplied with invalid parameters.");
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
