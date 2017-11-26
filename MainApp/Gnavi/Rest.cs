using Newtonsoft.Json;

namespace MainApp.Gnavi
{
    [JsonObject("rest")]
    public class Rest
    {
        [JsonProperty("@attributes")]
        public RestAttributes Attributes { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("update_date")]
        public string UpdateDate { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("name_kana")]
        public string NameKana { get; set; }

        [JsonProperty("latitude")]
        public double? Latitude { get; set; }

        [JsonProperty("longitude")]
        public double? Longitude { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("url_mobile")]
        public string UrlMobile { get; set; }

        [JsonProperty("coupon_url")]
        public CouponUrl CouponUrl { get; set; }

        [JsonProperty("image_url")]
        public ImageUrl ImageUrl { get; set; }

        [JsonProperty("address")]
        public string Address { get; set; }

        [JsonProperty("tel")]
        public string Tel { get; set; }

        [JsonProperty("tel_sub")]
        public string TelSub { get; set; }

        [JsonProperty("fax")]
        public string Fax { get; set; }

        [JsonProperty("opentime")]
        public string Opentime { get; set; }

        [JsonProperty("holiday")]
        public string Holiday { get; set; }

        [JsonProperty("access")]
        public Access Access { get; set; }

        [JsonProperty("parking_lots")]
        public int? ParkingLots { get; set; }

        [JsonProperty("pr")]
        public Pr Pr { get; set; }

        [JsonProperty("code")]
        public Code Code { get; set; }

        [JsonProperty("budget")]
        public int? Budget { get; set; }

        [JsonProperty("party")]
        public int? Party { get; set; }

        [JsonProperty("lunch")]
        public int? Lunch { get; set; }

        [JsonProperty("credit_card")]
        public string CreditCard { get; set; }

        [JsonProperty("e_money")]
        public string Emoney { get; set; }

        [JsonProperty("flags")]
        public Flags Flags { get; set; }
    }

    [JsonObject("@attributes")]
    public class RestAttributes
    {
        [JsonProperty("order")]
        public int Order { get; set; }
    }

    [JsonObject("coupon_url")]
    public class CouponUrl
    {
        [JsonProperty("pc")]
        public string Pc { get; set; }
        [JsonProperty("mobile")]
        public string Mobile { get; set; }
    }

    [JsonObject("image_url")]
    public class ImageUrl
    {
        [JsonProperty("shop_image1")]
        public string Shop1 { get; set; }
        [JsonProperty("shop_image2")]
        public string Shop2 { get; set; }
        [JsonProperty("qrcode")]
        public string Qrcode { get; set; }
    }

    [JsonObject("access")]
    public class Access
    {
        [JsonProperty("line")]
        public string Line { get; set; }
        [JsonProperty("station")]
        public string Station { get; set; }
        [JsonProperty("station_exit")]
        public string Atation_exit { get; set; }
        [JsonProperty("walk")]
        public string Walk { get; set; }
        [JsonProperty("note")]
        public string Note { get; set; }
    }

    [JsonObject("pr")]
    public class Pr
    {
        [JsonProperty("pr_short")]
        public string Short { get; set; }
        [JsonProperty("pr_long")]
        public string Long { get; set; }
    }

    [JsonObject("code")]
    public class Code
    {
        [JsonProperty("areacode")]
        public string Areacode { get; set; }
        [JsonProperty("areaname")]
        public string Areaname { get; set; }
        [JsonProperty("prefcode")]
        public string Prefcode { get; set; }
        [JsonProperty("prefname")]
        public string Prefname { get; set; }
        [JsonProperty("areacode_s")]
        public string AreacodeS { get; set; }
        [JsonProperty("areaname_s")]
        public string AreanameS { get; set; }
        [JsonProperty("category_code_l")]
        public string[] CategoryCodeLs { get; set; }
        [JsonProperty("category_name_l")]
        public string[] CategoryNameLs { get; set; }
        [JsonProperty("category_code_s")]
        public string[] CategoryCodeSs { get; set; }
        [JsonProperty("category_name_s")]
        public string[] CategoryNameSs { get; set; }
    }

    [JsonObject("flags")]
    public class Flags
    {
        [JsonProperty("mobile_site")]
        public int? MobileSite { get; set; }
        [JsonProperty("mobile_coupon")]
        public int? MobileCoupon { get; set; }
        [JsonProperty("pc_coupon")]
        public int? PcCoupon { get; set; }
    }
}
