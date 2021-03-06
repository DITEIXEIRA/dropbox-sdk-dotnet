// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.TeamLog
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The sessions management session length policy object</para>
    /// </summary>
    public class SessionsManagementSessionLengthPolicy
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<SessionsManagementSessionLengthPolicy> Encoder = new SessionsManagementSessionLengthPolicyEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<SessionsManagementSessionLengthPolicy> Decoder = new SessionsManagementSessionLengthPolicyDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see
        /// cref="SessionsManagementSessionLengthPolicy" /> class.</para>
        /// </summary>
        public SessionsManagementSessionLengthPolicy()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Day1</para>
        /// </summary>
        public bool IsDay1
        {
            get
            {
                return this is Day1;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Day1, or <c>null</c>.</para>
        /// </summary>
        public Day1 AsDay1
        {
            get
            {
                return this as Day1;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Day7</para>
        /// </summary>
        public bool IsDay7
        {
            get
            {
                return this is Day7;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Day7, or <c>null</c>.</para>
        /// </summary>
        public Day7 AsDay7
        {
            get
            {
                return this as Day7;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Day14</para>
        /// </summary>
        public bool IsDay14
        {
            get
            {
                return this is Day14;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Day14, or <c>null</c>.</para>
        /// </summary>
        public Day14 AsDay14
        {
            get
            {
                return this as Day14;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Month1</para>
        /// </summary>
        public bool IsMonth1
        {
            get
            {
                return this is Month1;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Month1, or <c>null</c>.</para>
        /// </summary>
        public Month1 AsMonth1
        {
            get
            {
                return this as Month1;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Month3</para>
        /// </summary>
        public bool IsMonth3
        {
            get
            {
                return this is Month3;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Month3, or <c>null</c>.</para>
        /// </summary>
        public Month3 AsMonth3
        {
            get
            {
                return this as Month3;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Month6</para>
        /// </summary>
        public bool IsMonth6
        {
            get
            {
                return this is Month6;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Month6, or <c>null</c>.</para>
        /// </summary>
        public Month6 AsMonth6
        {
            get
            {
                return this as Month6;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Year1</para>
        /// </summary>
        public bool IsYear1
        {
            get
            {
                return this is Year1;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Year1, or <c>null</c>.</para>
        /// </summary>
        public Year1 AsYear1
        {
            get
            {
                return this as Year1;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="SessionsManagementSessionLengthPolicy" />.</para>
        /// </summary>
        private class SessionsManagementSessionLengthPolicyEncoder : enc.StructEncoder<SessionsManagementSessionLengthPolicy>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(SessionsManagementSessionLengthPolicy value, enc.IJsonWriter writer)
            {
                if (value is Day1)
                {
                    WriteProperty(".tag", "day_1", writer, enc.StringEncoder.Instance);
                    Day1.Encoder.EncodeFields((Day1)value, writer);
                    return;
                }
                if (value is Day7)
                {
                    WriteProperty(".tag", "day_7", writer, enc.StringEncoder.Instance);
                    Day7.Encoder.EncodeFields((Day7)value, writer);
                    return;
                }
                if (value is Day14)
                {
                    WriteProperty(".tag", "day_14", writer, enc.StringEncoder.Instance);
                    Day14.Encoder.EncodeFields((Day14)value, writer);
                    return;
                }
                if (value is Month1)
                {
                    WriteProperty(".tag", "month_1", writer, enc.StringEncoder.Instance);
                    Month1.Encoder.EncodeFields((Month1)value, writer);
                    return;
                }
                if (value is Month3)
                {
                    WriteProperty(".tag", "month_3", writer, enc.StringEncoder.Instance);
                    Month3.Encoder.EncodeFields((Month3)value, writer);
                    return;
                }
                if (value is Month6)
                {
                    WriteProperty(".tag", "month_6", writer, enc.StringEncoder.Instance);
                    Month6.Encoder.EncodeFields((Month6)value, writer);
                    return;
                }
                if (value is Year1)
                {
                    WriteProperty(".tag", "year_1", writer, enc.StringEncoder.Instance);
                    Year1.Encoder.EncodeFields((Year1)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="SessionsManagementSessionLengthPolicy" />.</para>
        /// </summary>
        private class SessionsManagementSessionLengthPolicyDecoder : enc.UnionDecoder<SessionsManagementSessionLengthPolicy>
        {
            /// <summary>
            /// <para>Create a new instance of type <see
            /// cref="SessionsManagementSessionLengthPolicy" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override SessionsManagementSessionLengthPolicy Create()
            {
                return new SessionsManagementSessionLengthPolicy();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override SessionsManagementSessionLengthPolicy Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "day_1":
                        return Day1.Decoder.DecodeFields(reader);
                    case "day_7":
                        return Day7.Decoder.DecodeFields(reader);
                    case "day_14":
                        return Day14.Decoder.DecodeFields(reader);
                    case "month_1":
                        return Month1.Decoder.DecodeFields(reader);
                    case "month_3":
                        return Month3.Decoder.DecodeFields(reader);
                    case "month_6":
                        return Month6.Decoder.DecodeFields(reader);
                    case "year_1":
                        return Year1.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>The day 1 object</para>
        /// </summary>
        public sealed class Day1 : SessionsManagementSessionLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Day1> Encoder = new Day1Encoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Day1> Decoder = new Day1Decoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Day1" /> class.</para>
            /// </summary>
            private Day1()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Day1</para>
            /// </summary>
            public static readonly Day1 Instance = new Day1();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Day1" />.</para>
            /// </summary>
            private class Day1Encoder : enc.StructEncoder<Day1>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Day1 value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Day1" />.</para>
            /// </summary>
            private class Day1Decoder : enc.StructDecoder<Day1>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Day1" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Day1 Create()
                {
                    return Day1.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The day 7 object</para>
        /// </summary>
        public sealed class Day7 : SessionsManagementSessionLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Day7> Encoder = new Day7Encoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Day7> Decoder = new Day7Decoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Day7" /> class.</para>
            /// </summary>
            private Day7()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Day7</para>
            /// </summary>
            public static readonly Day7 Instance = new Day7();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Day7" />.</para>
            /// </summary>
            private class Day7Encoder : enc.StructEncoder<Day7>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Day7 value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Day7" />.</para>
            /// </summary>
            private class Day7Decoder : enc.StructDecoder<Day7>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Day7" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Day7 Create()
                {
                    return Day7.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The day 14 object</para>
        /// </summary>
        public sealed class Day14 : SessionsManagementSessionLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Day14> Encoder = new Day14Encoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Day14> Decoder = new Day14Decoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Day14" /> class.</para>
            /// </summary>
            private Day14()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Day14</para>
            /// </summary>
            public static readonly Day14 Instance = new Day14();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Day14" />.</para>
            /// </summary>
            private class Day14Encoder : enc.StructEncoder<Day14>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Day14 value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Day14" />.</para>
            /// </summary>
            private class Day14Decoder : enc.StructDecoder<Day14>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Day14" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Day14 Create()
                {
                    return Day14.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The month 1 object</para>
        /// </summary>
        public sealed class Month1 : SessionsManagementSessionLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Month1> Encoder = new Month1Encoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Month1> Decoder = new Month1Decoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Month1" /> class.</para>
            /// </summary>
            private Month1()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Month1</para>
            /// </summary>
            public static readonly Month1 Instance = new Month1();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Month1" />.</para>
            /// </summary>
            private class Month1Encoder : enc.StructEncoder<Month1>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Month1 value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Month1" />.</para>
            /// </summary>
            private class Month1Decoder : enc.StructDecoder<Month1>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Month1" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Month1 Create()
                {
                    return Month1.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The month 3 object</para>
        /// </summary>
        public sealed class Month3 : SessionsManagementSessionLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Month3> Encoder = new Month3Encoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Month3> Decoder = new Month3Decoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Month3" /> class.</para>
            /// </summary>
            private Month3()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Month3</para>
            /// </summary>
            public static readonly Month3 Instance = new Month3();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Month3" />.</para>
            /// </summary>
            private class Month3Encoder : enc.StructEncoder<Month3>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Month3 value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Month3" />.</para>
            /// </summary>
            private class Month3Decoder : enc.StructDecoder<Month3>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Month3" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Month3 Create()
                {
                    return Month3.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The month 6 object</para>
        /// </summary>
        public sealed class Month6 : SessionsManagementSessionLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Month6> Encoder = new Month6Encoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Month6> Decoder = new Month6Decoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Month6" /> class.</para>
            /// </summary>
            private Month6()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Month6</para>
            /// </summary>
            public static readonly Month6 Instance = new Month6();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Month6" />.</para>
            /// </summary>
            private class Month6Encoder : enc.StructEncoder<Month6>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Month6 value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Month6" />.</para>
            /// </summary>
            private class Month6Decoder : enc.StructDecoder<Month6>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Month6" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Month6 Create()
                {
                    return Month6.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The year 1 object</para>
        /// </summary>
        public sealed class Year1 : SessionsManagementSessionLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Year1> Encoder = new Year1Encoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Year1> Decoder = new Year1Decoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Year1" /> class.</para>
            /// </summary>
            private Year1()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Year1</para>
            /// </summary>
            public static readonly Year1 Instance = new Year1();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Year1" />.</para>
            /// </summary>
            private class Year1Encoder : enc.StructEncoder<Year1>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Year1 value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Year1" />.</para>
            /// </summary>
            private class Year1Decoder : enc.StructDecoder<Year1>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Year1" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Year1 Create()
                {
                    return Year1.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : SessionsManagementSessionLengthPolicy
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
