using System.Collections.Specialized;
using System.Net;
using System.Text.Json;

List<string> urls = [
    "https://play.rockyrabbit.io/v/1-10-2#tgWebAppData=query_id%3DAAE7UDoaAwAAADtQOhrl_0YU%26user%3D%257B%2522id%2522%253A6882480187%252C%2522first_name%2522%253A%2522Oweisy%2522%252C%2522last_name%2522%253A%2522%2522%252C%2522username%2522%253A%2522Pahloooo%2522%252C%2522language_code%2522%253A%2522en%2522%252C%2522allows_write_to_pm%2522%253Atrue%257D%26auth_date%3D1722625237%26hash%3D2af1eff79addff9e5e0076e5bfef0ff186619816a0dd5ddf5c92ee68951189f4&tgWebAppVersion=7.6&tgWebAppPlatform=weba&tgWebAppThemeParams=%7B%22bg_color%22%3A%22%23ffffff%22%2C%22text_color%22%3A%22%23000000%22%2C%22hint_color%22%3A%22%23707579%22%2C%22link_color%22%3A%22%233390ec%22%2C%22button_color%22%3A%22%233390ec%22%2C%22button_text_color%22%3A%22%23ffffff%22%2C%22secondary_bg_color%22%3A%22%23f4f4f5%22%2C%22header_bg_color%22%3A%22%23ffffff%22%2C%22accent_text_color%22%3A%22%233390ec%22%2C%22section_bg_color%22%3A%22%23ffffff%22%2C%22section_header_text_color%22%3A%22%23707579%22%2C%22subtitle_text_color%22%3A%22%23707579%22%2C%22destructive_text_color%22%3A%22%23e53935%22%7D",
    "https://play.rockyrabbit.io/v/1-10-2#tgWebAppData=query_id%3DAAEfymc9AAAAAB_KZz1W3-99%26user%3D%257B%2522id%2522%253A1030212127%252C%2522first_name%2522%253A%2522Shahram%2522%252C%2522last_name%2522%253A%2522%2522%252C%2522username%2522%253A%2522ShahramDevOps%2522%252C%2522language_code%2522%253A%2522en%2522%252C%2522allows_write_to_pm%2522%253Atrue%257D%26auth_date%3D1722625238%26hash%3Dd05800cb0f4f15c38f0a17b459885f954a0fc0aec190910a4977b541ca857c48&tgWebAppVersion=7.6&tgWebAppPlatform=web&tgWebAppThemeParams=%7B%22bg_color%22%3A%22%23ffffff%22%2C%22button_color%22%3A%22%233390ec%22%2C%22button_text_color%22%3A%22%23ffffff%22%2C%22hint_color%22%3A%22%23707579%22%2C%22link_color%22%3A%22%2300488f%22%2C%22secondary_bg_color%22%3A%22%23f4f4f5%22%2C%22text_color%22%3A%22%23000000%22%2C%22header_bg_color%22%3A%22%23ffffff%22%2C%22accent_text_color%22%3A%22%233390ec%22%2C%22section_bg_color%22%3A%22%23ffffff%22%2C%22section_header_text_color%22%3A%22%233390ec%22%2C%22subtitle_text_color%22%3A%22%23707579%22%2C%22destructive_text_color%22%3A%22%23df3f40%22%7D",
    "https://play.rockyrabbit.io/v/1-10-2#tgWebAppData=query_id%3DAAHf8FtuAgAAAN_wW25v7pCY%26user%3D%257B%2522id%2522%253A6146486495%252C%2522first_name%2522%253A%2522Parand%2522%252C%2522last_name%2522%253A%2522%2522%252C%2522username%2522%253A%2522Parand5560%2522%252C%2522language_code%2522%253A%2522en%2522%252C%2522allows_write_to_pm%2522%253Atrue%257D%26auth_date%3D1722625239%26hash%3D501704cebda12856f9b96a97ed36d54dcbc7444e37616b1e45700255b756583a&tgWebAppVersion=7.6&tgWebAppPlatform=web&tgWebAppThemeParams=%7B%22bg_color%22%3A%22%23ffffff%22%2C%22button_color%22%3A%22%233390ec%22%2C%22button_text_color%22%3A%22%23ffffff%22%2C%22hint_color%22%3A%22%23707579%22%2C%22link_color%22%3A%22%2300488f%22%2C%22secondary_bg_color%22%3A%22%23f4f4f5%22%2C%22text_color%22%3A%22%23000000%22%2C%22header_bg_color%22%3A%22%23ffffff%22%2C%22accent_text_color%22%3A%22%233390ec%22%2C%22section_bg_color%22%3A%22%23ffffff%22%2C%22section_header_text_color%22%3A%22%233390ec%22%2C%22subtitle_text_color%22%3A%22%23707579%22%2C%22destructive_text_color%22%3A%22%23df3f40%22%7D",
    "https://play.rockyrabbit.io/v/1-10-2#tgWebAppData=query_id%3DAAEUWrBhAgAAABRasGHppBhN%26user%3D%257B%2522id%2522%253A5933914644%252C%2522first_name%2522%253A%2522Shahram%2522%252C%2522last_name%2522%253A%2522%2522%252C%2522username%2522%253A%2522ShahramOweisy%2522%252C%2522language_code%2522%253A%2522en%2522%252C%2522allows_write_to_pm%2522%253Atrue%257D%26auth_date%3D1722625241%26hash%3D769554ae57a92c4870ddf7fb1c4f87a5f0d894bcdadfd3c20348ba641011d64a&tgWebAppVersion=7.6&tgWebAppPlatform=web&tgWebAppThemeParams=%7B%22bg_color%22%3A%22%23ffffff%22%2C%22button_color%22%3A%22%233390ec%22%2C%22button_text_color%22%3A%22%23ffffff%22%2C%22hint_color%22%3A%22%23707579%22%2C%22link_color%22%3A%22%2300488f%22%2C%22secondary_bg_color%22%3A%22%23f4f4f5%22%2C%22text_color%22%3A%22%23000000%22%2C%22header_bg_color%22%3A%22%23ffffff%22%2C%22accent_text_color%22%3A%22%233390ec%22%2C%22section_bg_color%22%3A%22%23ffffff%22%2C%22section_header_text_color%22%3A%22%233390ec%22%2C%22subtitle_text_color%22%3A%22%23707579%22%2C%22destructive_text_color%22%3A%22%23df3f40%22%7D",
    "https://play.rockyrabbit.io/v/1-10-2#tgWebAppData=query_id%3DAAGD_zoCAAAAAIP_OgLXxCOo%26user%3D%257B%2522id%2522%253A37420931%252C%2522first_name%2522%253A%2522Jalehmansouri%2522%252C%2522last_name%2522%253A%2522%2522%252C%2522username%2522%253A%2522Jaleh_m89%2522%252C%2522language_code%2522%253A%2522en%2522%252C%2522allows_write_to_pm%2522%253Atrue%257D%26auth_date%3D1722625240%26hash%3D623b599a2827e6ef0b3cf89e1128c98b54cd2283074b14dd774b8cc326bb751e&tgWebAppVersion=7.6&tgWebAppPlatform=weba&tgWebAppThemeParams=%7B%22bg_color%22%3A%22%23ffffff%22%2C%22text_color%22%3A%22%23000000%22%2C%22hint_color%22%3A%22%23707579%22%2C%22link_color%22%3A%22%233390ec%22%2C%22button_color%22%3A%22%233390ec%22%2C%22button_text_color%22%3A%22%23ffffff%22%2C%22secondary_bg_color%22%3A%22%23f4f4f5%22%2C%22header_bg_color%22%3A%22%23ffffff%22%2C%22accent_text_color%22%3A%22%233390ec%22%2C%22section_bg_color%22%3A%22%23ffffff%22%2C%22section_header_text_color%22%3A%22%23707579%22%2C%22subtitle_text_color%22%3A%22%23707579%22%2C%22destructive_text_color%22%3A%22%23e53935%22%7D"
];

foreach (string url in urls)
{
    var uri = new Uri(url);
    var fragment = uri.Fragment;

    var queryParameters = fragment.TrimStart('#').Split('&');
    var queryDict = new NameValueCollection();
    foreach (var param in queryParameters)
    {
        var parts = param.Split('=');
        if (parts.Length == 2)
        {
            queryDict.Add(parts[0], parts[1]);
        }
    }

    var tgWebAppData = WebUtility.UrlDecode(queryDict["tgWebAppData"]);

    var dataParts = tgWebAppData.Split('&');
    var dataDict = new NameValueCollection();
    foreach (var part in dataParts)
    {
        var keyValue = part.Split('=');
        if (keyValue.Length == 2)
        {
            dataDict.Add(keyValue[0], keyValue[1]);
        }
    }

    // Extract user data from JSON
    var userJson = WebUtility.UrlDecode(dataDict["user"]);
    var user = JsonDocument.Parse(userJson).RootElement;

    var result = $"tma query_id={dataDict["query_id"]}&user=%7B%22id%22%3A{user.GetProperty("id").GetInt64()}%2C%22first_name%22%3A%22{user.GetProperty("first_name").GetString()}%22%2C%22last_name%22%3A%22{user.GetProperty("last_name").GetString()}%22%2C%22username%22%3A%22{user.GetProperty("username").GetString()}%22%2C%22language_code%22%3A%22en%22%2C%22allows_write_to_pm%22%3Atrue%7D&auth_date={dataDict["auth_date"]}&hash={dataDict["hash"]}";
    Console.WriteLine(result);
    Console.WriteLine();
    Console.WriteLine();
}