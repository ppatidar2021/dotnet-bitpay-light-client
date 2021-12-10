﻿using System;

namespace BitPayLight.Exceptions
{
    public class BillDeliveryException : BitPayException
    {
        private const string BitPayCode = "BITPAY-BILL-Delivery";
        private const string BitPayMessage = "Failed to deliver bill";
        protected string ApiCode;

        public BillDeliveryException() : base(BitPayCode, BitPayMessage)
        {
        }

        public BillDeliveryException(Exception ex, string apiCode = "000000") : base(BitPayCode, BitPayMessage, ex)
        {
            ApiCode = apiCode;
        }

        public String GetApiCode()
        {
            return ApiCode;
        }
    }
}
