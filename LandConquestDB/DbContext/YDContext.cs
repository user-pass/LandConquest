﻿using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using YandexDiskNET;

namespace LandConquestDB
{
    public static class YDContext
    {
        private static YandexDiskRest disk;
        private static string oauth;
        public static void OpenYD()
        {
            Connection();
            Disk();
        }

        private static void Connection()
        {
            oauth =  KSecure.Normal.Decrypt("fO4bi4UutIeOwf4jtC0S0EbdXqb/V4fwoLAkyzdkDFcZNeyFn7COODZF5ivGwnxgc1lefRT3JrNSCREGDl74A6/1B6l7TBgPYAupjE/ZqeSIdGgu274q5aEs59PrbocBktyf9zS1oXoVK3x3nM2zfB/kwwEaGLv34Xb2uN/cK8o=", Path.GetPathRoot(Environment.SystemDirectory));
        }

        private static void Disk()
        {
            disk = new YandexDiskRest(oauth);
        }

        public static YandexDiskRest GetYD()
        {
            return disk;
        }

        public static string ReadResource(string sourceFileName)
        {
            Param param = default(Param);
            param.Path = sourceFileName;
            string result = ReadFile((string)JObject.Parse(CommandDisk(oauth, param)).SelectToken("href"));
            return result;
        }
        
        private static string CommandDisk(string oauth, Param param)
        {
            HttpMethod method = HttpMethod.Get;
            HttpClient httpClient = new HttpClient();
            UrlBuilder urlBuilder = new UrlBuilder(param);
            string requestUri;
            requestUri = "https://cloud-api.yandex.net/v1/disk/resources/download?" + urlBuilder.Path;
            try
            {
                HttpRequestMessage httpRequestMessage = new HttpRequestMessage(method, requestUri);
                httpRequestMessage.Headers.Add("Authorization", "OAuth " + oauth);
                httpRequestMessage.Headers.Add("Accept", "application/json");
                return httpClient.SendAsync(httpRequestMessage).Result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception)
            {
                throw new HttpRequestException();
            }
            finally
            {
                httpClient.Dispose();
            }
        }

        private static string ReadFile(string url)
        {
            HttpClient httpClient = HttpClientFactory.Create();
            try
            {
                HttpResponseMessage httpResponse = httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead).Result;
                using (Stream stream = httpResponse.Content.ReadAsStreamAsync().Result)
                {
                    var memoryStream = new MemoryStream();
                    stream.CopyTo(memoryStream);
                    return Encoding.ASCII.GetString(memoryStream.ToArray());
                }

            }
            catch (Exception) { return null; }
        }
    }
}
