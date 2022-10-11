using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP1
{
    public class WavFileWriter
    {
        public void WriteFile(String filename, uint sampleRate, double[] data)
        {
            ushort channelsNumber = 1; // 1 for mono, 2 for stereo
            ushort bitsPerSample = 8; // in bits

            FileStream f = new FileStream(filename, FileMode.Create);
            BinaryWriter wr = new BinaryWriter(f);

            wr.Write(Encoding.ASCII.GetBytes("RIFF"));
            wr.Write(BitConverter.GetBytes(36 + data.Length)); // file length with header
            wr.Write(Encoding.ASCII.GetBytes("WAVEfmt "));
            if (BitConverter.IsLittleEndian)
            {
                wr.Write(BitConverter.GetBytes((uint) 16)); // length of format data
                wr.Write(BitConverter.GetBytes((ushort) 1)); // format type
                wr.Write(BitConverter.GetBytes(channelsNumber)); // number of channels
                wr.Write(BitConverter.GetBytes(sampleRate)); // sample rate
                wr.Write(BitConverter.GetBytes(sampleRate * bitsPerSample * channelsNumber / 8));
                wr.Write(BitConverter.GetBytes((ushort) (bitsPerSample * channelsNumber / 8)));
                wr.Write(BitConverter.GetBytes(bitsPerSample));
            }
            else
            {
                wr.Write(GetBytesLittleEndian((uint)16)); // length of format data
                wr.Write(GetBytesLittleEndian((ushort)1)); // format type
                wr.Write(GetBytesLittleEndian(channelsNumber)); // number of channels
                wr.Write(GetBytesLittleEndian(sampleRate)); // sample rate
                wr.Write(GetBytesLittleEndian(sampleRate * bitsPerSample * channelsNumber / 8));
                wr.Write(GetBytesLittleEndian((ushort)(bitsPerSample * channelsNumber / 8)));
                wr.Write(GetBytesLittleEndian(bitsPerSample));
            }
            wr.Write(Encoding.ASCII.GetBytes("data"));
            if (BitConverter.IsLittleEndian)
            {
                wr.Write(BitConverter.GetBytes((uint)data.Length));
                wr.Write(GetBytes(data));
            }
            else
            {
                wr.Write(GetBytesLittleEndian((uint)data.Length));
                Array.Reverse(data);
                wr.Write(GetBytes(data));
            }

            wr.Close();
        }

        private byte[] GetBytesLittleEndian(ushort number)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            Array.Reverse(bytes);
            return bytes;
        }

        private byte[] GetBytesLittleEndian(uint number)
        {
            byte[] bytes = BitConverter.GetBytes(number);
            Array.Reverse(bytes);
            return bytes;
        }

        private byte[] GetBytes(double[] doubles)
        {
            return doubles.SelectMany(value => BitConverter.GetBytes((uint) value)).ToArray();
        }
    }
}
