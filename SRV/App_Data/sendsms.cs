using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Web;
/// <summary>
/// Summary description for sendsms
/// </summary>
public class sendsms
{
    public sendsms()
    {
        //
        // TODO: Add constructor logic here
        //
    }



    public string sendsmsquick(string destination, string msg)
    {

        string strresult = "";
        WebRequest WebRequest = default(WebRequest);
        WebResponse WebResonse = default(WebResponse);
        string Server = "103.16.101.52";
        string Port = "8080";
        string UserName = "aweb-srvpathlab";
        string Password = "srvlab12";
        int type = 0;
        string Message = msg;
        Message = HttpUtility.UrlEncode(Message);
        int DLR = 1;
        string Source = "SRVLAB";
        string Destination = destination;
        string WebResponseString = "";
        string URL = "http://" + Server + ":" + Port + "/sendsms/bulksms?username=" + UserName + "&password=" + Password + "&type=" + type + "&dlr=" + DLR + "&destination=" + Destination + "&source=" + Source + "&message=" + Message + "";
        WebRequest = HttpWebRequest.Create(URL);
        // http://103.16.101.52:8080/sendsms/bulksms?username=aweb-srvpathlab&password=srvlab12&type=0&dlr=1&destination=9810502506&source=SRVLAB&message=hello
        WebRequest.Timeout = 25000;
        try
        {
            WebResonse = WebRequest.GetResponse();
            StreamReader reader = new StreamReader(WebResonse.GetResponseStream());
            WebResponseString = reader.ReadToEnd();
            WebResonse.Close();
            strresult = WebResponseString;
        }
        catch (Exception ex)
        {
            WebResponseString = "Request Timeout";
            strresult = WebResponseString;
        }
        return strresult;
    }







}