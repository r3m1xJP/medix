using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MedixCollege.Helpers
{
    public static class Helpers
    {
        public static string GetNumbers(string input)
        {
            return new string(input.Where(c => char.IsDigit(c)).ToArray());
        }

        public static bool HasLetters(string input)
        {
            return Regex.Matches(input, @"[a-zA-Z]").Count > 0;
        }

        public static void SendToNova(string firstName, string lastName, string email, Int64 phoneNumber, int campusId, int programId)
        {
            var allowedCampuses = new List<int>() {
                243,
                242,
                244
            };

            if (!allowedCampuses.Contains(campusId))
            {
                return;
            }

            using (var client = new HttpClient())
            {
                var response = client.PostAsync(
                    String.Format("http://www.westerveltleads.com/submitlead.aspx?first_name={0}&last_name={1}&onlinesource=MedixWebsite&email={2}&phone={3}&CampusID={4}&ProgramID={5}",
                    firstName, lastName, email, phoneNumber, campusId, programId), null).Result;

                if (response.IsSuccessStatusCode)
                {
                    
                }
            }
        }
    }
}
