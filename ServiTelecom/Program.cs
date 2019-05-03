using System;

/***
 * Copyright 2019 Vincent Roy

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
 */


/***
 * The application is just a test for c# and .net learning, the goal will be to work with as many functionality and algorithm as possible.
 * This isn't a professional software nor it is the goal, it will surely be messy as hell, but i will try to clean it after working with each functionality.
 * 
 * The App will help manage a hypotetic telecom company service.
 * 
 * THE APP IS MADE COMPLETELY IN CONSOLE.
 * The UI will be I/O in console.
 * 
 * First: the information will be localy store in a text file like: XML, JSON, Text -> the operator will have choices when selecting the Save or Export option.
 * Second: The information will be linked to a relational database(MySQL) and with a NOSQL DB(I will use MongoDB here)
 * 
 * The base fuctionality would be:
    -Registering the client info in a database
    -Bill the client each minute(To see the process in action).
    -Print bill info in a PDF File
    -Make a payment(no real payment processing here)
    -Make a correction on bill
    -Count is place auto in Collection if the ammount reach a certain limit.
    -See a list of the promotion.
    -Total ammount left
    -See the service aquired
    -See the service that can be aquired
    -See the state of the service
    -Create a new service
    -deactivate service
    -Some sorting algorithm used.
 */

namespace ServiTelecom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
