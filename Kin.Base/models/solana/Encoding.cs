using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Kin.Base.models.solana
{

    namespace KinCSharp
    {
        public class ShortVec
        {
            private int MAX_VALUE = ushort.MaxValue;


            public int encodeLen(MemoryStream output, int length)
            {
                if (length > MAX_VALUE)
                {
                    throw new Exception("length exceeds" + MAX_VALUE.ToString());
                }

                int lengthLocal = length;
                byte[] valBuf = new byte[1];
                int written = 0;

                using (BinaryWriter writer = new BinaryWriter(output))
                {
                    while (true)
                    {
                        writer.Write(lengthLocal & 0x7f);
                        lengthLocal >>= 7;

                        if (lengthLocal == 0)
                        {
                            writer.Write(valBuf);
                            written += 1;

                            return written;
                        }

                        valBuf[0] = (byte)(valBuf[0] | 0x80);
                        writer.Write(valBuf);
                        written += 1;
                    }
                }
            }

            public int decodeLen(MemoryStream input)
            {
                int offset = 0;
                byte[] valBuf = new byte[1];
                int value = 0;


                using (BinaryReader reader = new BinaryReader(input))
                {
                    while (true)
                    {
                        valBuf[0] = reader.ReadByte();

                        value = value | (valBuf[0] & 0x7f << (offset * 7));

                        offset++;

                        if ((valBuf[0] & 0x80) == 0)
                        {
                            break;
                        }
                    }

                    if (offset > 3)
                    {
                        throw new Exception("invalid size: $offset (max 3)");
                    }
                    return value;
                }
            }
        }
    }
}
