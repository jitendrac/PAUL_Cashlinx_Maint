﻿using System.Net;
using System.Text;

namespace Common.Controllers.Database.Couch.CouchSecurity
{
    class PawnCouchRequest
    {
        private readonly HttpWebRequest request;

        public PawnCouchRequest(string uri)
			: this(uri, null, null)
		{
		}

        public PawnCouchRequest(string uri, Cookie authCookie, string eTag)
		{
		    request = (HttpWebRequest) WebRequest.Create(uri);
            request.Headers.Clear(); //important
            if (!string.IsNullOrEmpty(eTag))
                request.Headers.Add("If-None-Match", eTag);		
            request.Headers.Add("Accept-Charset", "utf-8");
            request.Headers.Add("Accept-Language", "en-us");
			request.Referer = uri;
			request.ContentType = "application/json";
			request.KeepAlive = true;
            if (authCookie != null)
            {
                request.Headers.Add("Cookie", "AuthSession=" + authCookie.Value);
                //Console.WriteLine("Authentication store" + authCookie + " : " + TimeSpan.FromMinutes(9));
            }
            request.Timeout = Timeout.HasValue ? Timeout.Value : 10000;
		}

        public int? Timeout { get; set; }

        public PawnCouchRequest Put()
		{
			request.Method = "PUT";
			return this;
		}

        public PawnCouchRequest Get()
		{
			request.Method = "GET";
			return this;
		}
        public PawnCouchRequest Post()
		{
			request.Method = "POST";
			return this;
		}
        public PawnCouchRequest Delete()
		{
			request.Method = "DELETE";
			return this;
		}
        public PawnCouchRequest Data(string data)
		{
			using (var body = request.GetRequestStream())
			{
				var encodedData = Encoding.UTF8.GetBytes(data);
				body.Write(encodedData, 0, encodedData.Length);
			}
			return this;
		}
        public PawnCouchRequest Data(byte[] attachment)
		{
			using (var body = request.GetRequestStream())
			{
				body.Write(attachment, 0, attachment.Length);
			}
			return this;
		}
		/*public CouchRequest Data(JObject obj)
		{
			return Data(obj.ToString());
		}*/

        public PawnCouchRequest ContentType(string contentType)
		{
			request.ContentType = contentType;
			return this;
		}

        public PawnCouchRequest Form()
		{
			request.ContentType = "application/x-www-form-urlencoded";
			return this;
		}
        public PawnCouchRequest Json()
		{
			request.ContentType = "application/json";
			return this;
		}
        public HttpWebRequest GetRequest()
        {
            return request;
        }
		public HttpWebResponse GetResponse()
		{
			try
			{
				var response = (HttpWebResponse)request.GetResponse();	
					return response;
			}
			catch (WebException webEx)
			{
				var response = (HttpWebResponse)webEx.Response;
				if (response != null)
				{
				    return response;
				}
			}
		    return null;
		}
    }
}
