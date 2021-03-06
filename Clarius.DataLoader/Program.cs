﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clarius.DataLoader
{
    class Program
    {
        static void Main(string[] args)
        {
            Load(@"..\..\Data\Clarius-1.csv");
            //Load(@"..\..\Data\Clarius-2.csv");
        }

        public static void Load(string filename)
        {
            using (var fileStream = new FileStream(filename, FileMode.Open))
            {
                using (var streamReader = new StreamReader(fileStream))
                {
                    var line = streamReader.ReadLine();
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        if (!String.IsNullOrEmpty(line))
                        {
                            string[] data = line.Split(',');
                        }
                    }
                }
            }
        }
    }
}

/*
0"EmpNumber",				"                    D00000000145",
1"Description",				"candle\hgouw                                                  ",
2"CommonName",				"GOUW, HERMAN                  ",
3"DateOfBirth",				"6/10/1960 12:00:00 AM",
4"ExtendedEmailAd",			"hgouw@clarius.com.au                                                                                ",
5"Age",						"54 ",
6"DateEmployed",				"9/02/2015 12:00:00 AM",
7"DateTerminated",			"26/06/2015 12:00:00 AM",
8"ReasonForSuspen",			"                                ",
9"ReasonTerminate",			"Resignation                     ",
10"Occupation",				"            SENIOR.NET DEVELOPER",
11"EmpStatus",				"8",
12"Class",					"1",
13"RateOfPay",				"124657.46",
14"NetPay",					"0",
15"PassportNo"				"19601006        "

0"Associate",		"                    D00000000145",
1"HomeAddress",		"37 ROBERT ROAD                  ",
2"HomeAddress2",		"                                ",
3"HomeAddress3",		"CHERRYBROOK                     ",
4"ZipCode",			"                            2126",
5"MobileNo",			"                    ",
6"HomePhone",		"                    ",
7"Email",			"hermangouw@gmail.com            ",
8"BusEmail"			"                                "
*/
