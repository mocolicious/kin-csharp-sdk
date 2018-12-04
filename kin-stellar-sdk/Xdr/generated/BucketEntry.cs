// Automatically generated by xdrgen
// DO NOT EDIT or your changes may be overwritten
using System;

namespace Kin.Stellar.Sdk.xdr
{

    // === xdr source ============================================================

    //  union BucketEntry switch (BucketEntryType type)
    //  {
    //  case LIVEENTRY:
    //      LedgerEntry liveEntry;
    //  
    //  case DEADENTRY:
    //      LedgerKey deadEntry;
    //  };

    //  ===========================================================================
    public class BucketEntry
    {
        public BucketEntry() { }

        public BucketEntryType Discriminant { get; set; } = new BucketEntryType();

        public LedgerEntry LiveEntry { get; set; }
        public LedgerKey DeadEntry { get; set; }
        public static void Encode(XdrDataOutputStream stream, BucketEntry encodedBucketEntry)
        {
            stream.WriteInt((int)encodedBucketEntry.Discriminant.InnerValue);
            switch (encodedBucketEntry.Discriminant.InnerValue)
            {
                case BucketEntryType.BucketEntryTypeEnum.LIVEENTRY:
                    LedgerEntry.Encode(stream, encodedBucketEntry.LiveEntry);
                    break;
                case BucketEntryType.BucketEntryTypeEnum.DEADENTRY:
                    LedgerKey.Encode(stream, encodedBucketEntry.DeadEntry);
                    break;
            }
        }
        public static BucketEntry Decode(XdrDataInputStream stream)
        {
            BucketEntry decodedBucketEntry = new BucketEntry();
            BucketEntryType discriminant = BucketEntryType.Decode(stream);
            decodedBucketEntry.Discriminant = discriminant;
            switch (decodedBucketEntry.Discriminant.InnerValue)
            {
                case BucketEntryType.BucketEntryTypeEnum.LIVEENTRY:
                    decodedBucketEntry.LiveEntry = LedgerEntry.Decode(stream);
                    break;
                case BucketEntryType.BucketEntryTypeEnum.DEADENTRY:
                    decodedBucketEntry.DeadEntry = LedgerKey.Decode(stream);
                    break;
            }
            return decodedBucketEntry;
        }
    }
}
