using Newtonsoft.Json;
using CNXT.Connector.Client.Api;
using CNXT.Connector.Client.Client;
using CNXT.Connector.Client.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Rodenstock.CNXT.Connector.Client.ConsoleApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Configuration configuration = new Configuration();
            configuration.BasePath = "http://connector.develop.cnxt.dtr01.rodenstock.com:8080/api";
            //configuration.BasePath = "http://localhost:8280/api";

            PatientsApi patientsApi = new PatientsApi(configuration);

            // Query the first 25 patients sorted by lastName (ascending)
            PatientsResponse patientsResponse = patientsApi.GetPatients(25, null, new PatientFilter()
            {
                DateOfBirth = DateTime.ParseExact("1982-10-30", "yyyy-MM-dd", CultureInfo.InvariantCulture,
                                     DateTimeStyles.None)
            }, new List<string>() { "lastName" }, new List<string>() { "session" });

            // Query the next 25 patients sorted by lastName (ascending)
            patientsResponse = patientsApi.GetPatients(25, patientsResponse.PageInfo.EndCursor, null, new List<string>() { "lastName" }, new List<string>() { "session" });

            List<PatientResponse> patients = patientsResponse.Patients;

            PatientResponse patient = null;
            foreach (PatientResponse patientResponse in patients)
            {
                // Query patient by id and include session relationship
                patient = patientsApi.GetPatient(patientResponse.Id, new List<string>() { "session" });
                Console.WriteLine("Patient: {0}" + Environment.NewLine, JsonConvert.SerializeObject(patient));
            }

            SessionsApi sessionsApi = new SessionsApi(configuration);

            // Query the first 25 sessions sorted by upatedAt date (descending)
            SessionsResponse sessionsResponse = sessionsApi.GetSessions(25, null, new SessionFilter() { UpdatedAfter = DateTime.Parse("2020-02-17T10:00:00.391984Z"), State = null }, new List<string>() { "-updatedAt" }, new List<string>() { "patient" });

            // Query the next 25 sessions sorted by updatedAt date (descending)
            sessionsResponse = sessionsApi.GetSessions(25, sessionsResponse.PageInfo.EndCursor, new SessionFilter() { UpdatedAfter = DateTime.Parse("2020-02-17T10:00:00.391984Z"), State = null }, new List<string>() { "-updatedAt" }, new List<string>() { "patient" });

            List<SessionResponse> sessions = sessionsResponse.Sessions;

            SessionResponse session = null;
            foreach (SessionResponse sessionResponse in sessions)
            {
                // Query session by id and include patient and b2boptic relationships
                session = sessionsApi.GetSession(sessionResponse.Id, new List<string>() { "patient", "b2boptic" });
                Console.WriteLine("Session: {0}" + Environment.NewLine, JsonConvert.SerializeObject(session));
            }

            string b2bOptic_Sample1 = System.IO.File.ReadAllText("./Data/B2BOptic_Sample1.xml");

            // Import b2boptic XML document as new session
            List<string> sessionIds = sessionsApi.ImportB2BOpticAsNewSession(b2bOptic_Sample1, "OPEN");

            string b2bOptic_Sample2 = System.IO.File.ReadAllText("./Data/B2BOptic_Sample2.xml");

            // Import b2boptic XML document and update it by session for the specified session
            sessionIds = sessionsApi.ImportB2BOptic("691e5c29-3d70-4a3e-a8dd-bea781faba4b", b2bOptic_Sample2, "OPEN");

            Console.ReadLine();
        }
    }
}