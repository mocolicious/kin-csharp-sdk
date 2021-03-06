﻿using System;
using Kin.Stellar.Sdk.xdr;

namespace Kin.Stellar.Sdk
{
    public class TimeBounds
    {
        public long MinTime { get; }

        public long MaxTime { get; }

        /// <summary>
        ///     Timebounds constructor.
        /// </summary>
        /// <param name="minTime"> 64bit Unix timestamp</param>
        public TimeBounds(long minTime, long maxTime)
        {
            if (maxTime != 0 && minTime >= maxTime)
            {
                throw new ArgumentException("minTime must be >= maxTime");
            }

            MinTime = minTime;
            MaxTime = maxTime;
        }

        public static TimeBounds FromXdr(xdr.TimeBounds timeBounds)
        {
            if (timeBounds == null)
            {
                return null;
            }

            return new TimeBounds(
                timeBounds.MinTime.InnerValue,
                timeBounds.MaxTime.InnerValue
            );
        }

        public xdr.TimeBounds ToXdr()
        {
            xdr.TimeBounds timeBounds = new xdr.TimeBounds();
            Uint64 minTime = new Uint64();
            Uint64 maxTime = new Uint64();
            minTime.InnerValue = MinTime;
            maxTime.InnerValue = MaxTime;
            timeBounds.MinTime = minTime;
            timeBounds.MaxTime = maxTime;
            return timeBounds;
        }

        public override bool Equals(object o)
        {
            if (this == o)
            {
                return true;
            }

            if (o == null || GetType() != o.GetType())
            {
                return false;
            }

            TimeBounds that = (TimeBounds) o;

            if (MinTime != that.MinTime)
            {
                return false;
            }

            return MaxTime == that.MaxTime;
        }

        public override int GetHashCode()
        {
            return HashCode.Start
                .Hash(MinTime)
                .Hash(MaxTime);
        }
    }
}