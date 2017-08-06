using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class MembershipType
    {
        public byte Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public static readonly byte Unknown = 0;
        public static readonly byte PayAsYouGo = 1;

        //public enum MembershipTypes
        //{
        //    Unknown = 0, PayAsYouGo = 1, Monthly = 2, Quarterly = 3, Annually = 4
        //}
    }
}