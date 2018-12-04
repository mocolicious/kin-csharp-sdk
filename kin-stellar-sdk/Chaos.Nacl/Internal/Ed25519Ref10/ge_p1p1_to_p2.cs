﻿namespace Kin.Stellar.Sdk.chaos.nacl.Internal.Ed25519Ref10
{
    internal static partial class GroupOperations
    {
        /*
        r = p
        */
        public static void ge_p1p1_to_p2(out GroupElementP2 r, ref GroupElementP1P1 p)
        {
            Kin.Stellar.Sdk.chaos.nacl.Internal.Ed25519Ref10.FieldOperations.fe_mul(out r.X, ref p.X, ref p.T);
            Kin.Stellar.Sdk.chaos.nacl.Internal.Ed25519Ref10.FieldOperations.fe_mul(out r.Y, ref p.Y, ref p.Z);
            Kin.Stellar.Sdk.chaos.nacl.Internal.Ed25519Ref10.FieldOperations.fe_mul(out r.Z, ref p.Z, ref p.T);
        }
    }
}