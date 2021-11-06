using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace LurtisTest.Common.Utils
{
    public class ReadProperty
    {
        private static readonly ILog _logger = LogManager.GetLogger(typeof(ReadProperty));

        #region Attributes

        public static string DB_CONNECTION = GetProperty("DBConnection");

        //Exceptions
        public static string EXCEPTION_HANDLER = GetProperty("ExceptionHandler");
        public static string EXCEPTION_FIND = GetProperty("ExceptionFind");

        #endregion 

        private static string GetProperty(string name)
        {
            _logger.Debug("IN - GetProperty()");
            var answer = string.Empty;

            try
            {
                using (StreamReader r = new StreamReader("appsettings.json"))
                {
                    string json = r.ReadToEnd();
                    var @object = JObject.Parse(json);

                    answer = (string)@object["Property"][name];
                }
            }
            catch (Exception e)
            {
                _logger.Error(e);
            }

            _logger.Debug("OUT - GetProperty()");

            return answer;
        }
    }
}

